/*
 * Controller:PatientController with it's Methods
*/
using HIS.APP.Data;
using HIS.APP.Helper;
using HIS.APP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection;

namespace HIS.APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        #region  API method

        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly string SIPBaseURL;
        private readonly string CouchDBBaseURL;
        private readonly string WebHook;
        /// <summary>
        /// PatientController Constructor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="iConfig"></param>
        public PatientController(ApplicationDbContext dbContext, IConfiguration iConfig)
        {
            _dbContext = dbContext;
            _configuration = iConfig;
            SIPBaseURL = _configuration.GetSection("URL").GetSection("SIP").Value;
            CouchDBBaseURL = _configuration.GetSection("URL").GetSection("CouchDB").Value;
            WebHook = _configuration.GetSection("URL").GetSection("WebHook").Value;
        }
        /// <summary>
        /// GetPatientDemographics API will first retrieve all updated information, but afterwards it will only return records that have changed.
        /// It will also set the ITSSID in the specified format and post the patient's age to the sip plus database.
        /// </summary>
        /// <returns></returns>
        [Route("PatientDetails")]
        [HttpGet]
        public async Task<ActionResult> GetPatientDemographics()
        {
            var patientIdList = PatientHelper.GetSIPpatients(CouchDBBaseURL);
            List<PatientDemographics> patientDemographicsDetailsList = new();

            foreach (var patient in patientIdList.Results)
            {
                if (!patient.Id.Contains('/'))
                {
                    PatientHelper.SetPatientDemographics(SIPBaseURL, patient.Id, out RestResponse response, out PatientDemographics patientDemographicsDetails);
                    PatientHelper.SetPatientProperties(response, patientDemographicsDetails, patient.Id, SIPBaseURL);
                    patientDemographicsDetailsList.Add(patientDemographicsDetails);

                    if (patientDemographicsDetails.PatientFirstName != null ||
                        patientDemographicsDetails.PatientLastName != null &&
                        patientDemographicsDetails.RecordNumber != null)
                    {
                        _dbContext.Patientdemographics.Add(patientDemographicsDetails);
                        AuditTable auditTable = new();
                        AuditBlob auditblob = new();

                        PatientHelper.SetAuditTable(patientDemographicsDetails, auditTable);
                        PatientHelper.SetAuditblobTable(patientDemographicsDetails, auditblob);
                        PatientHelper.PostDataToWebHook(WebHook, response.Content);

                        auditTable.IsWebHookSend = true;
                        _dbContext.Audittables.Add(auditTable);
                        _dbContext.Auditblobs.Add(auditblob);
                    }
                    _dbContext.SaveChanges();
                }
            }

            // Refresh patient ID list after processing
            patientIdList = PatientHelper.GetSIPpatients(CouchDBBaseURL);
            return Ok(patientDemographicsDetailsList);
        }

        /// <summary>
        /// Get PatientDemographics By Date
        /// </summary>
        /// <param name="stringDate"></param>
        /// <returns></returns>
        [Route("PatientDetailsByDate")]
        [HttpGet]
        public async Task<ActionResult> GetPatientDemographicsByDate(string stringDate)
        {
            var date = DateTime.ParseExact(stringDate.Replace('.', ':'), "ddMMyyyy HH:mm", CultureInfo.InvariantCulture);
            List<PatientDemographics> patientDemographicsDetailsList = new();

            var patientList = await _dbContext.Patientdemographics
                                               .Where(x => x.ITSSID != null)
                                               .ToListAsync();

            foreach (var patient in patientList)
            {
                var auditRecord = await _dbContext.Audittables
                                                  .FirstOrDefaultAsync(x => x.PatientIdentifier == patient.ITSSID);

                if (auditRecord != null &&
                    DateTime.ParseExact(auditRecord.ReceivedDateTime.Replace('.', ':'), "ddMMyyyy HH:mm", CultureInfo.InvariantCulture) >= date)
                {
                    patientDemographicsDetailsList.Add(patient);
                }
            }

            return Ok(patientDemographicsDetailsList);
        }


        /// <summary>
        /// Get Service Request
        /// </summary>
        /// <returns></returns>
        [Route("ServiceRequest")]
        [HttpGet]
        public async Task<ActionResult> GetServiceRequest()
        {
            var serviceResponse = PatientHelper.GetResult();
            var serviceRequest = JsonConvert.DeserializeObject<ServiceRequests>(serviceResponse);

            PatientHelper.SetServiceRequest(serviceResponse, serviceRequest);
            _dbContext.ServiceRequests.Add(serviceRequest);
            await _dbContext.SaveChangesAsync();

            return Ok(serviceRequest);
        }

        /// <summary>
        /// LabResults Get Request
        /// </summary>
        /// <returns></returns>
        [Route("LabResults")]
        [HttpGet]
        public async Task<ActionResult> GetLabResults()
        {
            var labResponse = PatientHelper.GetResult();
            var observations = JsonConvert.DeserializeObject<Observations>(labResponse);

            PatientHelper.SetObservationsfields(labResponse, observations);
            _dbContext.ObservationLabResults.Add(observations);
            await _dbContext.SaveChangesAsync();

            return Ok(observations);
        }

        /// <summary>
        /// PostPatientDetails Read the data from the ServiceRequest LabResults.json file and post it to SIP Plus for the most recent pregnancy.
        /// </summary>
        /// <returns></returns>
        [Route("PostPatientDetails")]
        [HttpPost]
        public async Task<ActionResult> PostPatientDetails()
        {
            var labResponse = PatientHelper.GetResult();
            var results = JsonConvert.DeserializeObject<ServiceRequest_LabResults>(labResponse);

            var patientInfo = new DemographicsInformation();
            var propertyInfos = typeof(DemographicsInformation).GetProperties();

            PatientHelper.SetPatientClass(SIPBaseURL, results.Pid, out var response, out var patientClass);

            var patientResultList = results.Results
                .Select(result => Converter.AssignValue(patientInfo, result.ResultCode, result.ResultValue))
                .Where(tempResultString => !string.IsNullOrWhiteSpace(tempResultString))
                .ToList();

            var pregnancyCode = PatientHelper.GetLatestPregnancy(patientClass.Pregnancies);
            var url = $"{SIPBaseURL}/record/{results.Pid.Replace('#', '/')}";
            var sipBody = $"{{\"pregnancies\":{{ \"{pregnancyCode}\" : {{ {string.Join(',', patientResultList)} }} }} }}";

            PatientHelper.SetPatientDemographics(SIPBaseURL, results.Pid, out response, out var patientDemographicsDetails);

            _dbContext.Patientdemographics.Add(patientDemographicsDetails);

            var auditTable = new AuditTable();
            PatientHelper.SetAuditTable(patientDemographicsDetails, auditTable);
            _dbContext.Audittables.Add(auditTable);

            await _dbContext.SaveChangesAsync();

            var client = new RestClient(url);
            var postRequest = new RestRequest
            {
                Method = Method.Post
            };

            postRequest.AddHeader("Content-Type", "application/json");
            postRequest.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
            postRequest.AddParameter("application/json", sipBody, ParameterType.RequestBody);

            response = client.Execute(postRequest);

            return Ok(response);
        }




        #endregion
    }
}

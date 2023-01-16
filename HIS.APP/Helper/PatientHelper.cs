using Azure;
using HIS.APP.Models;
using Newtonsoft.Json;
using RestSharp;

namespace HIS.APP.Helper
{
    public static class PatientHelper
    {
        public static string LastSeq { get; set; }
        public static DateTime dt { get; set; }

        public static string GetResult()
        {
            //string labResponse = File.ReadAllText("LabResults.json");
            string labResponse = File.ReadAllText("ResultConfigurations.json");
            return labResponse;
        }

        public static string GetLatestPregnancy(Pregnancies pregnancies)
        {
            if (pregnancies._8 is not null)
            {
                return "8";
            }
            else if (pregnancies._7 is not null)
            {
                return "7";
            }
            else if (pregnancies._6 is not null)
            {
                return "6";
            }
            else if (pregnancies._5 is not null)
            {
                return "5";
            }
            else if (pregnancies._4 is not null)
            {
                return "4";
            }
            else if (pregnancies._3 is not null)
            {
                return "3";
            }
            else if (pregnancies._2 is not null)
            {
                return "2";
            }

            return "1";
        }
        public static void SetPatientDemographics(string baseUrl, string patientId, out RestResponse response, out PatientDemographics patientDemographicsDetails)
        {
            try
            {
                var url = string.Format("{0}/record/{1}", baseUrl, patientId.Replace('#', '/'));
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
                request.Method = Method.Get;
                response = client.Execute(request);
                patientDemographicsDetails = JsonConvert.DeserializeObject<PatientDemographics>(response.Content);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        public static void PostDataToWebHook(string url, string body)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddBody(body);
                request.Method = Method.Post;
                client.Execute(request);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void SetPatientClass(string baseUrl, string patientId, out RestResponse response, out PatientClass patientClass)
        {
            try
            {
                var url = string.Format("{0}/record/{1}", baseUrl, patientId.Replace('#', '/'));
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
                request.Method = Method.Get;
                response = client.Execute(request);
                patientClass = JsonConvert.DeserializeObject<PatientClass>(response.Content);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        /// <summary>
        /// SetPatientProperties Method Assign Patient Class properties to PatientDemographics properties
        /// </summary>
        /// <param name="response"></param>
        /// <param name="patientDemographicsDetails"></param>
        public static async Task SetPatientProperties(RestResponse response, PatientDemographics patientDemographicsDetails, string patientId, string baseUrl)
        {
            try
            {
                PatientClass patientClass = JsonConvert.DeserializeObject<PatientClass>(response.Content);

                if (patientClass.Pregnancies is not null && patientClass.Pregnancies._1 is not null)
                {
                    patientDemographicsDetails.Address = patientClass.Pregnancies._1.Address;
                    patientDemographicsDetails.Phone = patientClass.Pregnancies._1.Phone;
                    patientDemographicsDetails.Nationality = patientClass.Pregnancies._1.Nationality;
                    patientDemographicsDetails.CountryOfResidence = patientClass.Pregnancies._1.CountryofResidence;
                }
                if (patientClass.Pregnancies is not null && patientClass.Pregnancies._2 is not null)
                {
                    patientDemographicsDetails.Address = patientClass.Pregnancies._2.Address;
                    patientDemographicsDetails.Phone = patientClass.Pregnancies._2.Phone;
                    patientDemographicsDetails.Nationality = patientClass.Pregnancies._2.Nationality;
                    patientDemographicsDetails.CountryOfResidence = patientClass.Pregnancies._2.CountryofResidence;
                }
                if (patientClass.Pregnancies is not null && patientClass.Pregnancies._3 is not null)
                {
                    patientDemographicsDetails.Address = patientClass.Pregnancies._3.Address;
                    patientDemographicsDetails.Phone = patientClass.Pregnancies._3.Phone;
                    patientDemographicsDetails.Nationality = patientClass.Pregnancies._3.Nationality;
                    patientDemographicsDetails.CountryOfResidence = patientClass.Pregnancies._3.CountryofResidence;
                }
                if (patientClass.Pregnancies is not null && patientClass.Pregnancies._4 is not null)
                {
                    patientDemographicsDetails.Address = patientClass.Pregnancies._4.Address;
                    patientDemographicsDetails.Phone = patientClass.Pregnancies._4.Phone;
                    patientDemographicsDetails.Nationality = patientClass.Pregnancies._4.Nationality;
                    patientDemographicsDetails.CountryOfResidence = patientClass.Pregnancies._4.CountryofResidence;
                }

                if (patientClass.Pregnancies is not null && patientClass.Pregnancies._5 is not null)
                {
                    patientDemographicsDetails.Address = patientClass.Pregnancies._5.Address;
                    patientDemographicsDetails.Phone = patientClass.Pregnancies._5.Phone;
                    patientDemographicsDetails.Nationality = patientClass.Pregnancies._5.Nationality;
                    patientDemographicsDetails.CountryOfResidence = patientClass.Pregnancies._5.CountryofResidence;
                }

                if (patientClass.Pregnancies is not null && patientClass.Pregnancies._6 is not null)
                {
                    patientDemographicsDetails.Address = patientClass.Pregnancies._6.Address;
                    patientDemographicsDetails.Phone = patientClass.Pregnancies._6.Phone;
                    patientDemographicsDetails.Nationality = patientClass.Pregnancies._6.Nationality;
                    patientDemographicsDetails.CountryOfResidence = patientClass.Pregnancies._6.CountryofResidence;
                }
                if (patientClass.Pregnancies is not null && patientClass.Pregnancies._7 is not null)
                {
                    patientDemographicsDetails.Address = patientClass.Pregnancies._7.Address;
                    patientDemographicsDetails.Phone = patientClass.Pregnancies._7.Phone;
                    patientDemographicsDetails.Nationality = patientClass.Pregnancies._7.Nationality;
                    patientDemographicsDetails.CountryOfResidence = patientClass.Pregnancies._7.CountryofResidence;
                }
                if (patientClass.Pregnancies is not null && patientClass.Pregnancies._8 is not null)
                {
                    patientDemographicsDetails.Address = patientClass.Pregnancies._8.Address;
                    patientDemographicsDetails.Phone = patientClass.Pregnancies._8.Phone;
                    patientDemographicsDetails.Nationality = patientClass.Pregnancies._8.Nationality;
                    patientDemographicsDetails.CountryOfResidence = patientClass.Pregnancies._8.CountryofResidence;
                }

                patientDemographicsDetails.RecordNumber = patientClass.Record is not null ? patientClass.Record : String.Empty;

                if (patientDemographicsDetails.DateofBirth is not null)
                {
                    dt = Convert.ToDateTime(patientDemographicsDetails.DateofBirth);
                    int CurrentYear = DateTime.Now.Year;
                    int year = dt.Year;
                    int age = CurrentYear - year;
                    patientDemographicsDetails.Age = age;
                    await PostAge(age, patientId, baseUrl);
                }
                else
                {
                    patientDemographicsDetails.DateofBirth = DateTime.MinValue.ToString("yyyyMMdd");
                }

                if (string.IsNullOrWhiteSpace(patientClass.ITSSId) || patientClass.ITSSId.Any(x => !Char.IsNumber(x)) || patientClass.ITSSId.Length < 14)
                {
                    Random randomNo = new();
                    string num = randomNo.Next(100000, 999999).ToString();
                    string dtstring = dt.ToString("yyyyMMdd");
                    patientDemographicsDetails.ITSSID = dtstring + num;
                    await PostItssId(patientDemographicsDetails.ITSSID, patientId, baseUrl);
                }
                else
                {
                    patientDemographicsDetails.ITSSID = patientClass.ITSSId;
                }
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        private static async Task<PatientClass> GetPatientById(string patientId, string baseUrl)
        {
            try
            {
                var url = string.Format("{0}/record/{1}", baseUrl, patientId.Replace('#', '/'));

                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
                request.Method = Method.Get;
                RestResponse response = client.Execute(request);
                PatientClass patient = JsonConvert.DeserializeObject<PatientClass>(response.Content);
                return patient;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        private static async Task PostItssId(string id, string patientId, string baseUrl)
        {
            try
            {
                var url = string.Format("{0}/record/{1}", baseUrl, patientId.Replace('#', '/'));

                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
                request.Method = Method.Post;
                string body = string.Format("{{\"1249\" : \"{0}\" }}", id);
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);

            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        private static async Task PostAge(int age, string patientId, string baseUrl)
        {
            try
            {
                var ageResult = new List<string>();
                var patient = await GetPatientById(patientId, baseUrl);

                if (patient.Pregnancies is not null && patient.Pregnancies._1 is not null)
                {
                    ageResult.Add(string.Format("\"1\": {{ \"0009\": {0} }}", age));
                }

                if (patient.Pregnancies is not null && patient.Pregnancies._2 is not null)
                {
                    ageResult.Add(string.Format("\"2\": {{ \"0009\": {0} }}", age));
                }

                if (patient.Pregnancies is not null && patient.Pregnancies._3 is not null)
                {
                    ageResult.Add(string.Format("\"3\": {{ \"0009\": {0} }}", age));
                }

                if (patient.Pregnancies is not null && patient.Pregnancies._4 is not null)
                {
                    ageResult.Add(string.Format("\"4\": {{ \"0009\": {0} }}", age));
                }
                if (patient.Pregnancies is not null && patient.Pregnancies._5 is not null)
                {
                    ageResult.Add(string.Format("\"5\": {{ \"0009\": {0} }}", age));
                }
                if (patient.Pregnancies is not null && patient.Pregnancies._6 is not null)
                {
                    ageResult.Add(string.Format("\"6\": {{ \"0009\": {0} }}", age));
                }

                var url = string.Format("{0}/record/{1}", baseUrl, patientId.Replace('#', '/'));
                var client = new RestClient(url);
                var request = new RestRequest();
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
                request.Method = Method.Post;
                string body = string.Format("{{ \"pregnancies\":{{ {0} }} }}", String.Join(',', ageResult));
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public static void SetServiceRequest(string ServiceRsponse, ServiceRequests serviceRequest)
        {
            ServiceRequest_LabResults serviceLabRequest = JsonConvert.DeserializeObject<ServiceRequest_LabResults>(ServiceRsponse);
            serviceRequest.ServiceRequestIdentifier = serviceLabRequest.Order.EntityIdentifier;
            serviceRequest.PatientRecordNumber = serviceLabRequest.Pid.Replace('#', '/');
            serviceRequest.ServiceRequestIdentifierType = serviceLabRequest.Order.EntityIdentifierType;
            serviceRequest.ServiceRequestAuthoredonDatefield = serviceLabRequest.Order.AuthoredOn;
            serviceRequest.RequesterPractitionerIdentifier = serviceLabRequest.Order.PractitionerIdentifier;
            serviceRequest.RequesterPractitionerFirstName = serviceLabRequest.Order.PractitionerName;
            serviceRequest.RequesterPractitionerLastName = String.Empty;
        }

        public static void SetObservationsfields(string LabRsponse, Observations observations)
        {
            ServiceRequest_LabResults serviceLabRequest = JsonConvert.DeserializeObject<ServiceRequest_LabResults>(LabRsponse);
            foreach (var item in serviceLabRequest.Results)
            {
                observations.ObservationCode = item.ResultCode;
                observations.ObservationText = item.ResultText;
                observations.ObservationValue = item.ResultValue.ToString();
                observations.ObservationReferenceRange = item.ResultRange;
                observations.ObservationStatus = item.ResultStatus;
                observations.ObservationEffectiveDatetime = item.ResultDatetime;
                observations.PatientRecordNumber = serviceLabRequest.Pid.Replace('#', '/');
                observations.ObservationPerformer = serviceLabRequest.Order.PractitionerName;
            }
        }
        public static void SetAuditTable(PatientDemographics patientDemographicsDetails, AuditTable auditTable)
        {
            if (string.IsNullOrWhiteSpace(patientDemographicsDetails.ITSSID) || patientDemographicsDetails.ITSSID.Any(x => !Char.IsNumber(x)) || patientDemographicsDetails.ITSSID.Length < 14)
            {
                Random randomNo = new();
                string num = randomNo.Next(100000, 999999).ToString();
                string dtstring = dt.ToString("yyyyMMdd");
                patientDemographicsDetails.ITSSID = dtstring + num;
                auditTable.PatientIdentifier = patientDemographicsDetails.ITSSID;
               
            }
            else
            {
                auditTable.PatientIdentifier = patientDemographicsDetails.ITSSID;
            }
            auditTable.MessageSendingSystem = "SIP Plus";
            auditTable.ReceivedDateTime = DateTime.Now.ToString("ddMMyyyy HH:mm");
            auditTable.MessageTextLinktoUnstructuredStorage = "Patient updated";
            auditTable.MessageGUID = Guid.NewGuid();
        }
        public static void SetAuditblobTable(PatientDemographics patientDemographicsDetails, AuditBlob auditblob)
        {
            auditblob.PatientId = patientDemographicsDetails.ITSSID;
            string body = JsonConvert.SerializeObject(patientDemographicsDetails, Formatting.Indented);
            auditblob.MessageTextOrRawData = body;
            auditblob.MessageGUID = Guid.NewGuid();
        }
        public static SIPPatient GetSIPpatients(string baseUrl)
        {
            string url = string.Format("{0}/sip-plus/_changes{1}", baseUrl, string.Format("{0}", string.IsNullOrWhiteSpace(LastSeq) ? "" : string.Format("?since={0}", LastSeq)));
            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Basic c2lwOnNpcDIwMjEhIQ==");
            request.Method = Method.Get;
            var response = client.Execute(request);

            var sipPatient = JsonConvert.DeserializeObject<SIPPatient>(response.Content);

            if (sipPatient is not null && sipPatient.LastSeq is not null)
            {
                LastSeq = sipPatient.LastSeq;
            }
            return sipPatient;
        }
    }
}

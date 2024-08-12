using HIS.APP.Data;
using HIS.APP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace HIS.APP.Controllers
{
    public class HISController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public HISController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// PatientDemographics ActionMethod
        /// </summary>
        public IActionResult PatientDemographics()
        {
            var patientDemographics = _dbContext.Patientdemographics.ToList();
            return View(patientDemographics);
        }



        /// <summary>
        /// ServiceRequest
        /// </summary>
        /// <returns></returns>
        public IActionResult ServiceRequest()
        {
            var serviceRequest = (from service in _dbContext.ServiceRequests select service).ToList();
            return View(serviceRequest);
        }
        public IActionResult AuditTables()
        {
            var auditTable = _dbContext.Audittables.ToList();
            return View(auditTable);
        }


        public IActionResult AuditBlob()
        {
            var auditBlob = _dbContext.Auditblobs.ToList();
            return View(auditBlob);
        }


        /// <summary>
        /// LabResult
        /// </summary>
        /// <returns></returns>
        public IActionResult LabResult()
        {
            try
            {
                var labresult = _dbContext.ObservationLabResults.ToList();
                return View(labresult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving lab results.");
                return RedirectToAction("Error", "Home"); // Redirect to an error view
            }
        }

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>

        public IActionResult Index()
        {
            return View();
        }
    }
}

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
            var patientDemographics= (from patient in _dbContext.Patientdemographics select patient).ToList();
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
            var audittable = (from audit in _dbContext.Audittables select audit).ToList();
            return View(audittable);
        }
        public IActionResult AuditBlob()
        {
            var auditBlob = (from auditb in _dbContext.Auditblobs select auditb).ToList();
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

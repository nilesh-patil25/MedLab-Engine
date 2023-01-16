/*
 Date:28-11-2022
 */
namespace HIS.APP.Models
{
    /// <summary>
    /// SERVICEREQUESTS TABLE
    /// </summary>

    #region Module
    public class ServiceRequests
    {
        public int ID { get; set; }
        public string PatientRecordNumber { get; set; }
        public string ServiceRequestIdentifier { get; set; }
        public string ServiceRequestIdentifierType { get; set; }
        public string ServiceRequestAuthoredonDatefield{ get; set; }
        public string RequesterPractitionerIdentifier { get; set; }
        public string RequesterPractitionerFirstName { get; set; }
        public string RequesterPractitionerLastName { get; set; }

    }
}
#endregion

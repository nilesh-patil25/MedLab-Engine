/*
 Date:28-11-2022
 */

namespace HIS.APP.Models
{
    #region Module
    public class AuditTable
    {
        public int ID { get; set; }
        public string PatientIdentifier { get; set; }
        public Guid MessageGUID { get; set; }
        public string MessageSendingSystem { get; set; }
        public string ReceivedDateTime { get; set; }
        public string MessageTextLinktoUnstructuredStorage { get; set; }
        public bool IsWebHookSend { get; set; } = false;
    }
#endregion
}
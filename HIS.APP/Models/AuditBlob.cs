/*
 Date:28-11-2022
 */
namespace HIS.APP.Models
{
    /// <summary>
    /// AUDITBLOB TABLE
    /// </summary>

    #region Module

    public class AuditBlob
    {
        public int ID { get; set; }
        public string PatientId { get; set; }
        public Guid MessageGUID { get; set; }
        public string MessageTextOrRawData { get; set; }
    }
}
#endregion
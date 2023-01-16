/*
 Date:28-11-2022
 */

namespace HIS.APP.Models
{
    /// <summary>
    ///    OBSERVATION TABLE     
    /// </summary>
    /// 
    #region Module
    public class Observations
    {
        public int ID { get; set; }
        public string PatientRecordNumber { get; set; }
        public string ObservationCode { get; set; }
        public string ObservationText { get; set; }
        public string ObservationValue { get; set; }
        public string ObservationReferenceRange { get; set; }
        public string ObservationStatus { get; set; }
        public string ObservationEffectiveDatetime { get; set; }
        public string ObservationPerformer { get; set; }
    }
}
#endregion
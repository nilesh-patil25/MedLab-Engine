/*
 Date:29/11/2022
Class:PatientDemographics
 */

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HIS.APP.Models
{
    #region Model
    /// <summary>
    /// PatientDemographics Model
    /// </summary>
    public class PatientDemographics
    {
        public int Id { get; set; }
        [JsonProperty("1254")]
        public string? ITSSID { get; set; }
        [JsonProperty("1018")]
        public string? CountryId { get; set; }
        [JsonProperty("1019")]
        public string? IdType { get; set; }
        [JsonProperty("0001")]
        public string? PatientFirstName { get; set; }
        [JsonProperty("0002")]
        public string? PatientLastName { get; set; }
        [JsonProperty("0003")]
        public string? Address { get; set; }
        [JsonProperty("0005")]
        public string? Phone { get; set; }
        public string Gender { get; set; } = "Female";

        [JsonProperty("0006")]
        public string? DateofBirth { get; set; }
        [JsonProperty("0007")]
        public string? Nationality { get; set; }
        [JsonProperty("0008")]
        public string? CountryOfResidence { get; set; }
        [JsonProperty("0009")]
        public int? Age { get; set; }
        [JsonProperty("0011")]
        public int? Ethnicity { get; set; }
        [JsonProperty("0012")]
        public int? Literacy { get; set; }
        [JsonProperty("0013")]
        public int? Education { get; set; }
        [JsonProperty("0014")]
        public int? YearsInHighestLevel { get; set; }
        [JsonProperty("0015")]
        public int? CivilStatus { get; set; }
        [JsonProperty("0016")]
        public int? LivesAlone { get; set; }
        [JsonProperty("0019")]
        public string RecordNumber { get; set; }
    }
    #endregion
}

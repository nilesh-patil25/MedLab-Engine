using Newtonsoft.Json;

namespace HIS.APP.Models
{
    public class ServiceRequest_LabResults
    {
        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }
    public class Order
    {
        [JsonProperty("entity_identifier")]
        public string EntityIdentifier { get; set; }

        [JsonProperty("entity_identifier_type")]
        public string EntityIdentifierType { get; set; }

        [JsonProperty("practitioner_identifier")]
        public string PractitionerIdentifier { get; set; }

        [JsonProperty("practitioner_name")]
        public string PractitionerName { get; set; }

        [JsonProperty("authored_on")]
        public string AuthoredOn { get; set; }  
    }

    public class Result
    {
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        [JsonProperty("result_text")]
        public string ResultText { get; set; }

        [JsonProperty("result_value")]
        public object ResultValue { get; set; }

        [JsonProperty("result_range")]
        public string ResultRange { get; set; }

        [JsonProperty("result_status")]
        public string ResultStatus { get; set; }

        [JsonProperty("result_datetime")]
        public string ResultDatetime { get; set; }
    }

}

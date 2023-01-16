using Newtonsoft.Json;

namespace HIS.APP.Models
{

    public class SIPPatient
    {
        [JsonProperty("results")]
        public SIPResult[] Results { get; set; }

        [JsonProperty("last_seq")]
        public string LastSeq { get; set; }

        [JsonProperty("pending")]
        public long Pending { get; set; }
    }

    public class SIPResult
    {
        [JsonProperty("seq")]
        public string Seq { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changes")]
        public Change[] Changes { get; set; }
    }

    public class Change
    {
        [JsonProperty("rev")]
        public string Rev { get; set; }
    }
}

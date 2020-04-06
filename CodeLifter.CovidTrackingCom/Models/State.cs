using System;
using CodeLifter.CovidTrackingCom.Models.Enums;
using Newtonsoft.Json;

namespace CodeLifter.CovidTrackingCom.Models
{
    public class State
    {
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateCode StateCode { get; set; }

        [JsonProperty("positive", NullValueHandling = NullValueHandling.Ignore)]
        public long? Positive { get; set; }

        [JsonProperty("negative", NullValueHandling = NullValueHandling.Ignore)]
        public long? Negative { get; set; }

        [JsonProperty("pending")]
        public long? Pending { get; set; }

        [JsonProperty("hospitalizedCurrently")]
        public long? HospitalizedCurrently { get; set; }

        [JsonProperty("hospitalizedCumulative")]
        public long? HospitalizedCumulative { get; set; }

        [JsonProperty("inIcuCurrently")]
        public long? InIcuCurrently { get; set; }

        [JsonProperty("inIcuCumulative")]
        public long? InIcuCumulative { get; set; }

        [JsonProperty("onVentilatorCurrently")]
        public long? OnVentilatorCurrently { get; set; }

        [JsonProperty("onVentilatorCumulative")]
        public long? OnVentilatorCumulative { get; set; }

        [JsonProperty("recovered")]
        public long? Recovered { get; set; }

        [JsonProperty("death", NullValueHandling = NullValueHandling.Ignore)]
        public long? Death { get; set; }

        [JsonProperty("hospitalized")]
        public long? Hospitalized { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        [JsonProperty("totalTestResults", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTestResults { get; set; }

        [JsonProperty("posNeg", NullValueHandling = NullValueHandling.Ignore)]
        public long? PosNeg { get; set; }

        [JsonProperty("fips", NullValueHandling = NullValueHandling.Ignore)]
        public string Fips { get; set; }

        [JsonProperty("dateChecked", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateChecked { get; set; }

        [JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
        public string Hash { get; set; }
    }
}

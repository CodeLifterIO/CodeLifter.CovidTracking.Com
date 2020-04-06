using System;
using Newtonsoft.Json;

namespace CodeLifter.CovidTrackingCom.Models
{
    public partial class Country
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public long? Date { get; set; }

        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public long? States { get; set; }

        [JsonProperty("positive", NullValueHandling = NullValueHandling.Ignore)]
        public long? Positive { get; set; }

        [JsonProperty("negative", NullValueHandling = NullValueHandling.Ignore)]
        public long? Negative { get; set; }

        [JsonProperty("pending", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pending { get; set; }

        [JsonProperty("hospitalizedCurrently", NullValueHandling = NullValueHandling.Ignore)]
        public long? HospitalizedCurrently { get; set; }

        [JsonProperty("hospitalizedCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public long? HospitalizedCumulative { get; set; }

        [JsonProperty("inIcuCurrently", NullValueHandling = NullValueHandling.Ignore)]
        public long? InIcuCurrently { get; set; }

        [JsonProperty("inIcuCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public long? InIcuCumulative { get; set; }

        [JsonProperty("onVentilatorCurrently", NullValueHandling = NullValueHandling.Ignore)]
        public long? OnVentilatorCurrently { get; set; }

        [JsonProperty("onVentilatorCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public long? OnVentilatorCumulative { get; set; }

        [JsonProperty("recovered", NullValueHandling = NullValueHandling.Ignore)]
        public long? Recovered { get; set; }

        [JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
        public string Hash { get; set; }

        [JsonProperty("dateChecked", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateChecked { get; set; }

        [JsonProperty("death", NullValueHandling = NullValueHandling.Ignore)]
        public long? Death { get; set; }

        [JsonProperty("totalTestResults", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTestResults { get; set; }

        [JsonProperty("deathIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeathIncrease { get; set; }

        [JsonProperty("hospitalizedIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public long? HospitalizedIncrease { get; set; }

        [JsonProperty("negativeIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public long? NegativeIncrease { get; set; }

        [JsonProperty("positiveIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public long? PositiveIncrease { get; set; }

        [JsonProperty("totalTestResultsIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTestResultsIncrease { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace CodeLifter.CovidTrackingCom.Models
{
    public class DailyStateInfo : State
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public long? Date { get; set; }

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

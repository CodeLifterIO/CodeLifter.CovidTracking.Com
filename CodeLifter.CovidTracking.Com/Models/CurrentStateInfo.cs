using System;
using CodeLifter.CovidTracking.Com.Models.Enums;
using Newtonsoft.Json;
namespace CodeLifter.CovidTracking.Com.Models
{
    public class CurrentStateInfo : State
    {
        [JsonProperty("positiveScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? PositiveScore { get; set; }

        [JsonProperty("negativeScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? NegativeScore { get; set; }

        [JsonProperty("negativeRegularScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? NegativeRegularScore { get; set; }

        [JsonProperty("commercialScore", NullValueHandling = NullValueHandling.Ignore)]
        public long? CommercialScore { get; set; }

        [JsonProperty("grade", NullValueHandling = NullValueHandling.Ignore)]
        public Grade? Grade { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; set; }

        [JsonProperty("lastUpdateEt", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateEST { get; set; }

        [JsonProperty("checkTimeEt", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckTimeEST { get; set; }

        [JsonProperty("dateModified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateModified { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }
    }
}

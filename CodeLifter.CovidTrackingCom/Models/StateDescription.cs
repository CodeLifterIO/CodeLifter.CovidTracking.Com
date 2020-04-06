using System;
using Newtonsoft.Json;
using CodeLifter.CovidTrackingCom.Models.Enums;

namespace CodeLifter.CovidTrackingCom.Models
{
    public class StateDescription
    {
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("covid19SiteOld", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Covid19SiteOld { get; set; }

        [JsonProperty("covid19Site", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Covid19Site { get; set; }

        [JsonProperty("covid19SiteSecondary")]
        public Uri Covid19SiteSecondary { get; set; }

        [JsonProperty("twitter", NullValueHandling = NullValueHandling.Ignore)]
        public string Twitter { get; set; }

        [JsonProperty("pui", NullValueHandling = NullValueHandling.Ignore)]
        public string Pui { get; set; }

        [JsonProperty("pum", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pum { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}

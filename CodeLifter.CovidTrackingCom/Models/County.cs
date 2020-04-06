using System;
using CodeLifter.CovidTrackingCom.Models.Enums;
using Newtonsoft.Json;

namespace CodeLifter.CovidTrackingCom.Models
{
    public class County
    {
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateCode? StateCode { get; set; }

        [JsonProperty("county", NullValueHandling = NullValueHandling.Ignore)]
        public string CountyName { get; set; }

        [JsonProperty("covid19Site", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Covid19Site { get; set; }

        [JsonProperty("dataSite")]
        public object DataSite { get; set; }

        [JsonProperty("mainSite")]
        public Uri MainSite { get; set; }

        [JsonProperty("twitter")]
        public object Twitter { get; set; }

        [JsonProperty("pui", NullValueHandling = NullValueHandling.Ignore)]
        public string Pui { get; set; }
    }
}

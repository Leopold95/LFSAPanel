using Newtonsoft.Json;
using System.Collections.Generic;

namespace LFSAPanel.Models.AllServersDetailsList
{
    public class AllServersDetailsList
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}

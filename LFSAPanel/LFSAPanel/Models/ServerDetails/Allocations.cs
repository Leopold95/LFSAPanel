using Newtonsoft.Json;
using System.Collections.Generic;

namespace LFSAPanel.Models.ServerDetails
{
    public class Allocations
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }
}

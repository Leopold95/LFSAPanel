using Newtonsoft.Json;
using System.Collections.Generic;

namespace LFSAPanel.Models.ServerNetwork
{
    public class Network
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }
}

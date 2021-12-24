using Newtonsoft.Json;

namespace LFSAPanel.Models.ServerNetwork
{
    public class Datum
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }
}

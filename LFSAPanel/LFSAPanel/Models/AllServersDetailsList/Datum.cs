using Newtonsoft.Json;

namespace LFSAPanel.Models.AllServersDetailsList
{
    public class Datum
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }
}

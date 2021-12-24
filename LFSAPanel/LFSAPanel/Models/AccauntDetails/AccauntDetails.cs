using Newtonsoft.Json;

namespace LFSAPanel.Models.AccauntDetails
{
    public class AccauntDetails
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }
}

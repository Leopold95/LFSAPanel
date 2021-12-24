using Newtonsoft.Json;

namespace LFSAPanel.Models.ServerDetails
{
    public class ServerDetails
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}

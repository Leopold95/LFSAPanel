using Newtonsoft.Json;

namespace LFSAPanel.Models.ServerNetwork
{
    public class Attributes
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("ip_alias")]
        public object IpAlias { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
    }
}

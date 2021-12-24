using Newtonsoft.Json;

namespace LFSAPanel.Models.AllServersDetailsList
{
    public class SftpDetails
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }
    }
}

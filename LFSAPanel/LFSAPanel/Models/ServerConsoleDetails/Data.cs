using Newtonsoft.Json;

namespace LFSAPanel.Models.ServerConsoleDetails
{
    public class Data
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("socket")]
        public string Socket { get; set; }
    }
}

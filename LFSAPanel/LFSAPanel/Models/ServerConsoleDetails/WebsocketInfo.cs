using Newtonsoft.Json;

namespace LFSAPanel.Models.ServerConsoleDetails
{
    public class WebsocketInfo
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}

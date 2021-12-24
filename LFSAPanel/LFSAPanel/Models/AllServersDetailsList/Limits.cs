using Newtonsoft.Json;

namespace LFSAPanel.Models.AllServersDetailsList
{
    public class Limits
    {
        [JsonProperty("memory")]
        public int Memory { get; set; }

        [JsonProperty("swap")]
        public int Swap { get; set; }

        [JsonProperty("disk")]
        public int Disk { get; set; }

        [JsonProperty("io")]
        public int Io { get; set; }

        [JsonProperty("cpu")]
        public int Cpu { get; set; }
    }
}

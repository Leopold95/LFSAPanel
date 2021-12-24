using Newtonsoft.Json;

namespace LFSAPanel.Models.AllServersDetailsList
{
    public class FeatureLimits
    {
        [JsonProperty("databases")]
        public int Databases { get; set; }

        [JsonProperty("allocations")]
        public int Allocations { get; set; }

        [JsonProperty("backups")]
        public int Backups { get; set; }
    }
}

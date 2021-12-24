using Newtonsoft.Json;

namespace LFSAPanel.Models.ServerDetails
{
    public class Relationships
    {
        [JsonProperty("allocations")]
        public Allocations Allocations { get; set; }
    }
}

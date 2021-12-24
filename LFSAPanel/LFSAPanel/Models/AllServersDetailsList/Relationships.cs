using Newtonsoft.Json;

namespace LFSAPanel.Models.AllServersDetailsList
{
    public class Relationships
    {
        [JsonProperty("allocations")]
        public Allocations Allocations { get; set; }
    }
}

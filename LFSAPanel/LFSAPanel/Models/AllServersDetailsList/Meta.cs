using Newtonsoft.Json;

namespace LFSAPanel.Models.AllServersDetailsList
{
    public class Meta
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}

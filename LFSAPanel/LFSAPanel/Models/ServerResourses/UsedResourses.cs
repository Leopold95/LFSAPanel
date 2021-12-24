using Newtonsoft.Json;

namespace LFSAPanel.Models.Resourses
{
    public class UsedResourses
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }
}

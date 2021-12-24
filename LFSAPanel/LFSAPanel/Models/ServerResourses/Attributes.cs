using Newtonsoft.Json;

namespace LFSAPanel.Models.Resourses
{
    public class Attributes
    {
        [JsonProperty("current_state")]
        public string CurrentState { get; set; }

        [JsonProperty("is_suspended")]
        public bool IsSuspended { get; set; }

        [JsonProperty("resources")]
        public Resources Resources { get; set; }
    }
}

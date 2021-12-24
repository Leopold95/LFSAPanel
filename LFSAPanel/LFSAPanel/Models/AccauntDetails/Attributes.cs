using Newtonsoft.Json;

namespace LFSAPanel.Models.AccauntDetails
{
    public class Attributes
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}

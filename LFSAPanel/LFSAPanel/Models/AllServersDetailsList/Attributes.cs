using Newtonsoft.Json;

namespace LFSAPanel.Models.AllServersDetailsList
{
    public class Attributes
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("ip_alias")]
        public object IpAlias { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("server_owner")]
        public bool ServerOwner { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("sftp_details")]
        public SftpDetails SftpDetails { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limits")]
        public Limits Limits { get; set; }

        [JsonProperty("feature_limits")]
        public FeatureLimits FeatureLimits { get; set; }

        [JsonProperty("is_suspended")]
        public bool IsSuspended { get; set; }

        [JsonProperty("is_installing")]
        public bool IsInstalling { get; set; }

        [JsonProperty("relationships")]
        public Relationships Relationships { get; set; }
    }
}

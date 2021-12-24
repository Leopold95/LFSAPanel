using Newtonsoft.Json;
using System.Collections.Generic;

namespace LFSAPanel.Models.ServerDetails
{
    public class Meta
    {
        [JsonProperty("is_server_owner")]
        public bool IsServerOwner { get; set; }

        [JsonProperty("user_permissions")]
        public List<string> UserPermissions { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LFSAPanel.Models.WebSocket
{
    public class Events
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("args")]
        public List<string> Args { get; set; }
    }
}

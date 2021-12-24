using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LFSAPanel.Models.ServerDetails
{
    public class Datum
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }
}

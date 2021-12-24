using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LFSAPanel.Models.Resourses
{
    public class Resources
    {
        [JsonProperty("memory_bytes")]
        public double MemoryBytes { get; set; }

        [JsonProperty("cpu_absolute")]
        public double CpuAbsolute { get; set; }

        [JsonProperty("disk_bytes")]
        public double DiskBytes { get; set; }

        [JsonProperty("network_rx_bytes")]
        public double NetworkRxBytes { get; set; }

        [JsonProperty("network_tx_bytes")]
        public double NetworkTxBytes { get; set; }
    }
}

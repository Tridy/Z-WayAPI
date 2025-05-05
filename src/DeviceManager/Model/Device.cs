using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace DeviceManager.Model
{
    [DebuggerDisplay("Id = {Id}, Instances = {Instances.Count}")]
    public class Device
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("data")]
        public Dictionary<string, object>? DeviceData { get; set; }

        [JsonPropertyName("instances")]
        public Dictionary<int, Instance>? Instances { get; set; }
    }
}

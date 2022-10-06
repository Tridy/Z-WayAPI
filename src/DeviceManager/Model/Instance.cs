using System.Diagnostics;
using System.Text.Json.Serialization;

namespace DeviceManager.Model
{
    [DebuggerDisplay("Id = {Id}, CommandClasses = {CommandClasses.Count}")]
    public class Instance
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("data")]
        public Dictionary<string, object>? InstanceData { get; set; }

        [JsonPropertyName("commandClasses")]
        public Dictionary<string, dynamic>? CommandClasses { get; set; }
    }
}

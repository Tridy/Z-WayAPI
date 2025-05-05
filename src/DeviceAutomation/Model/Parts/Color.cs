using System.Text.Json.Serialization;

namespace DeviceAutomation.Model;

public class Color
{
    [JsonPropertyName("r")]
    public int R { get; set; }

    [JsonPropertyName("g")]
    public int G { get; set; }

    [JsonPropertyName("b")]
    public int B { get; set; }
}
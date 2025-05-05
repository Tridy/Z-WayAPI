using System.Text.Json.Serialization;

namespace DeviceAutomation.Model;

public class Order
{
    [JsonPropertyName("rooms")]
    public int Rooms { get; set; }

    [JsonPropertyName("elements")]
    public int Elements { get; set; }

    [JsonPropertyName("dashboard")]
    public int Dashboard { get; set; }

    [JsonPropertyName("room")]
    public int Room { get; set; }
}
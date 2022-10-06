using System.Text.Json.Serialization;
using System.Diagnostics;

namespace DeviceManager.Model;

public abstract class DataBase
{
    [JsonPropertyName("invalidateTime")]
    public int? InvalidateTime { get; set; }

    [JsonPropertyName("updateTime")]
    public int? UpdateTime { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[DebuggerDisplay("Items = {Items.Count}")]
public class DeviceData : DataBase
{
    Dictionary<string, dynamic>? Items { get; set; }

    public DeviceData()
    {
        Items = new Dictionary<string, dynamic>();
    }
}
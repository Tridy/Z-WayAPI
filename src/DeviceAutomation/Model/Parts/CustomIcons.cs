using System.Text.Json.Serialization;

namespace DeviceAutomation.Model;

public class CustomIcons
{
    public CustomIcons()
    {
        this.Default = false;
    }

    [JsonPropertyName("default")]
    public object Default { get; set; }
}
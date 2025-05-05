using System.Text.Json.Serialization;

namespace DeviceAutomation.Model;

public class Metrics
{
    public Metrics()
    {
        this.Icon = "N/A";
        this.Title = "N/A";
        this.Color = new Color();
        this.Level = "N/A";
        this.Change = "N/A";
        this.IsFailed = false;
        this.LastToggledCmd = "N/A";
        this.ProbeTitle = "N/A";
        this.ScaleTitle = "N/A";
        this.Text = "N/A";
        this.OldColor = new OldColor();
        this.OldLevel = -1;
        this.State = "N/A";
        this.CurrentScene = "N/A";
        this.DiscreteStates = new DiscreteStates();
        this.KeyAttribute = -1;
        this.MaxScenes = -1;
        this.Count = -1;
        this.Type = "N/A";
    }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("color")]
    public Color Color { get; set; }

    [JsonPropertyName("level")]
    public object Level { get; set; }

    [JsonPropertyName("change")]
    public string Change { get; set; }

    [JsonPropertyName("isFailed")]
    public bool IsFailed { get; set; }

    [JsonPropertyName("lastToggledCmd")]
    public string LastToggledCmd { get; set; }

    [JsonPropertyName("probeTitle")]
    public string ProbeTitle { get; set; }

    [JsonPropertyName("scaleTitle")]
    public string ScaleTitle { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("oldColor")]
    public OldColor OldColor { get; set; }

    [JsonPropertyName("oldLevel")]
    public int OldLevel { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("currentScene")]
    public object CurrentScene { get; set; }

    [JsonPropertyName("discreteStates")]
    public DiscreteStates DiscreteStates { get; set; }

    [JsonPropertyName("keyAttribute")]
    public int KeyAttribute { get; set; }

    [JsonPropertyName("maxScenes")]
    public int MaxScenes { get; set; }

    [JsonPropertyName("cnt")]
    public int Count { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}
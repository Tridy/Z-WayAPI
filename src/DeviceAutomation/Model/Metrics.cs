namespace DeviceAutomation.Model;

public class Metrics
{
    public object level { get; set; }
    public string icon { get; set; }
    public string title { get; set; }
    public Color color { get; set; }
    public string probeTitle { get; set; }
    public string scaleTitle { get; set; }
    public string text { get; set; }
    public string change { get; set; }
    public bool isFailed { get; set; }
    public string lastToggledCmd { get; set; }
    public Oldcolor oldColor { get; set; }
    public int oldLevel { get; set; }
    public string state { get; set; }
    public object currentScene { get; set; }
    public Discretestates discreteStates { get; set; }
    public int keyAttribute { get; set; }
    public int maxScenes { get; set; }
    public int cnt { get; set; }
    public string type { get; set; }
}

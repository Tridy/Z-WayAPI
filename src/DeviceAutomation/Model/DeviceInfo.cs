namespace DeviceAutomation.Model;

public class DeviceInfo
{
    public DeviceData data { get; set; }
    public int code { get; set; }
    public string message { get; set; }
    public object error { get; set; }
}

public class DeviceData
{
    public int creationTime { get; set; }
    public int creatorId { get; set; }
    public Customicons customIcons { get; set; }
    public string deviceType { get; set; }
    public string firmware { get; set; }
    public int h { get; set; }
    public bool hasHistory { get; set; }
    public string id { get; set; }
    public int location { get; set; }
    public string locationName { get; set; }
    public string manufacturer { get; set; }
    public Metrics metrics { get; set; }
    public int nodeId { get; set; }
    public Order order { get; set; }
    public bool permanently_hidden { get; set; }
    public string probeType { get; set; }
    public string product { get; set; }
    public object[] tags { get; set; }
    public string technology { get; set; }
    public bool visibility { get; set; }
    public int updateTime { get; set; }
}
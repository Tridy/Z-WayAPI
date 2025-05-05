using System;
using System.Text.Json.Serialization;

namespace DeviceAutomation.Model;

public class DevicesInfo
{
    public DevicesInfo()
    {
        this.Data = new DevicesData();
        this.Code = -1;
        this.Message = "N/A";
        this.Error = null;
    }

    [JsonPropertyName("data")]
    public DevicesData Data { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("error")]
    public object? Error { get; set; }
}

public class DevicesData
{
    public DevicesData()
    {
        this.Devices = Array.Empty<Device>();
    }

    [JsonPropertyName("structureChanged")]
    public bool StructureChanged { get; set; }

    [JsonPropertyName("updateTime")]
    public int UpdateTime { get; set; }

    [JsonPropertyName("devices")]
    public Device[] Devices { get; set; }
}

public class Device
{
    public Device()
    {
        this.CustomIcons = new CustomIcons();
        this.DeviceType = "N/A";
        this.Firmware = "N/A";
        this.Id = "N/A";
        this.LocationName = "N/A";
        this.Manufacturer = "N/A";
        this.Metrics = new Metrics();
        this.Order = new Order();
        this.ProbeType = "N/A";
        this.Product = "N/A";
        this.Tags = Array.Empty<object>();
        this.Technology = "N/A";
        this.BindingName = "N/A";
        this.NodeId = "N/A";
    }

    [JsonPropertyName("creationTime")]
    public int CreationTime { get; set; }

    [JsonPropertyName("creatorId")]
    public int CreatorId { get; set; }

    [JsonPropertyName("customIcons")]
    public CustomIcons CustomIcons { get; set; }

    [JsonPropertyName("deviceType")]
    public string DeviceType { get; set; }

    [JsonPropertyName("firmware")]
    public string Firmware { get; set; }

    [JsonPropertyName("h")]
    public int H { get; set; }

    [JsonPropertyName("hasHistory")]
    public bool HasHistory { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("location")]
    public int Location { get; set; }

    [JsonPropertyName("locationName")]
    public string LocationName { get; set; }

    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; }

    [JsonPropertyName("metrics")]
    public Metrics Metrics { get; set; }

    [JsonPropertyName("order")]
    public Order Order { get; set; }

    [JsonPropertyName("permanently_hidden")]
    public bool PermanentlyHidden { get; set; }

    [JsonPropertyName("probeType")]
    public string ProbeType { get; set; }

    [JsonPropertyName("product")]
    public string Product { get; set; }

    [JsonPropertyName("tags")]
    public object[] Tags { get; set; }

    [JsonPropertyName("technology")]
    public string Technology { get; set; }

    [JsonPropertyName("visibility")]
    public bool Visibility { get; set; }

    [JsonPropertyName("updateTime")]
    public int UpdateTime { get; set; }

    [JsonPropertyName("bindingName")]
    public string BindingName { get; set; }

    [JsonPropertyName("nodeId")]
    public object NodeId { get; set; }
}
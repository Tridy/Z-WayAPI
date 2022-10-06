using DeviceManager.Converters;
using DeviceManager.Model;
using System.Text.Json;

namespace DeviceManager.Tests;

public class JsonTests
{
    [Fact]
    public void CanDeserialize()
    {
        var json = File.ReadAllBytes(@"json/devices.json");
        var options = new JsonSerializerOptions();
        options.Converters.Add(new IntIndexedDataConverter());
        options.Converters.Add(new StringIndexedDataConverter());
        var result = JsonSerializer.Deserialize<Dictionary<int, Device>>(json, options);
        Assert.NotEmpty(result);
    }
}
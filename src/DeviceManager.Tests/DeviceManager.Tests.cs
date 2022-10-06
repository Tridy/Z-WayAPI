using System.Reflection;
using DeviceManager.Model;
using Microsoft.Extensions.Configuration;

namespace DeviceManager.Tests;

public class DeviceManagerTests
{
    private readonly IConfigurationRoot _configuration;

    public DeviceManagerTests() 
    {
        _configuration = new ConfigurationBuilder()
            .AddUserSecrets(Assembly.GetExecutingAssembly(), false)
        .Build();
    }
    
    [Fact]
    public async Task CanGetController()
    {
        var deviceManager = DeviceManager.FromConfiguration(_configuration);
        ControllerInfo result = await deviceManager.GetControllerInfoAsync();
        Assert.NotNull(result);
    }

    [Fact]
    public async Task CanGetDevices()
    {
        var deviceManager = DeviceManager.FromConfiguration(_configuration);
        Dictionary<int, Device> result = await deviceManager.GetDevicesAsync();
        Assert.NotNull(result);
    }
}
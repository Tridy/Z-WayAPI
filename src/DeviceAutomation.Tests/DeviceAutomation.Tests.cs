using System.Reflection;
using DeviceAutomation.Model;
using Microsoft.Extensions.Configuration;

namespace DeviceManager.Tests;

public class DeviceAutomationTests
{
    private readonly IConfigurationRoot _configuration;

    public DeviceAutomationTests() 
    {
        _configuration = new ConfigurationBuilder()
            .AddUserSecrets(Assembly.GetExecutingAssembly(), false)
        .Build();
    }

    private const string DEVICE_NAME = "ZWayVDev_zway_46-0-37"; // change this by finding the device from CanGetDevicesInfo

    [Fact]
    public async Task CanGetDevicesInfo()
    {
        var manager = DeviceAutomation.DeviceAutomation.FromConfiguration(_configuration);
        var result = await manager.GetDevicesInfoAsync();
        Assert.NotNull(result);
    }

    [Fact]
    public async Task CanGetDeviceInfo()
    {
        var manager = DeviceAutomation.DeviceAutomation.FromConfiguration(_configuration);
        DeviceInfo result = await manager.GetDeviceInfoAsync(DEVICE_NAME);
        Assert.NotNull(result);
    }

    [Fact]
    public async Task SetDeviceOnOff()
    {
        var manager = DeviceAutomation.DeviceAutomation.FromConfiguration(_configuration);
        await manager.SendDeviceCommandAsync(DEVICE_NAME, "on");
        await Task.Delay(1000);
        await manager.SendDeviceCommandAsync(DEVICE_NAME, "off");
    }
}
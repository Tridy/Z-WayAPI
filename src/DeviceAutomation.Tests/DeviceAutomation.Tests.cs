using System.IO;
using System.Threading.Tasks;

using DeviceAutomation;
using DeviceAutomation.Model;
using Microsoft.Extensions.Configuration;

using Assembly = System.Reflection.Assembly;

namespace DeviceManager.Tests;

public class DeviceAutomationTests
{
    private readonly IConfigurationRoot _configuration;

    public DeviceAutomationTests() 
    {
        _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddUserSecrets(Assembly.GetExecutingAssembly(), optional: false)
            .Build();
    }

    private const string DEVICE_NAME = "ZWayVDev_zway_46-0-37"; // change this by finding the device from CanGetDevicesInfo

    [Test, Explicit]
    public async Task CanGetDevicesInfo()
    {
        IDeviceAutomation manager = DeviceAutomation.DeviceAutomation.FromConfiguration(_configuration);
        DevicesInfo result = await manager.GetDevicesInfoAsync();
        await Assert.That(result.Data.Devices).HasCount().GreaterThan(0);
    }

    [Test, Explicit]
    public async Task CanGetDeviceInfo()
    {
        IDeviceAutomation manager = DeviceAutomation.DeviceAutomation.FromConfiguration(_configuration);
        DeviceInfo result = await manager.GetDeviceInfoAsync(DEVICE_NAME);
        await Assert.That(result.Data.Id).IsNotNull();
    }

    [Test, Explicit]
    public async Task SetDeviceOnOff()
    {
        IDeviceAutomation manager = DeviceAutomation.DeviceAutomation.FromConfiguration(_configuration);
        await manager.SendDeviceCommandAsync(DEVICE_NAME, "on");
        await Task.Delay(1000);
        await manager.SendDeviceCommandAsync(DEVICE_NAME, "off");
    }
}
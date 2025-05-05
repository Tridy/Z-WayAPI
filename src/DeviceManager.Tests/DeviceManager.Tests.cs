using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using DeviceManager.Model;
using Microsoft.Extensions.Configuration;

using Assembly = System.Reflection.Assembly;

namespace DeviceManager.Tests;

public class DeviceManagerTests
{
    private readonly IConfigurationRoot _configuration;

    public DeviceManagerTests() 
    {
        _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddUserSecrets(Assembly.GetExecutingAssembly(), optional: false)
        .Build();
    }
    
    [Test, Explicit]
    public async Task CanGetController()
    {
        var deviceManager = DeviceManager.FromConfiguration(_configuration);
        ControllerInfo result = await deviceManager.GetControllerInfoAsync();
        await Assert.That(result).IsNotNull();
    }

    [Test, Explicit]
    public async Task CanGetDevices()
    {
        var deviceManager = DeviceManager.FromConfiguration(_configuration);
        Dictionary<int, Device> result = await deviceManager.GetDevicesAsync();
        await Assert.That(result).HasCount().GreaterThan(0);
    }
}
using DeviceAutomation.Model;
using Microsoft.Extensions.Configuration;
using Refit;
using System.Net;

namespace DeviceAutomation;

public class DeviceAutomation: IDeviceAutomation
{
    internal struct Configuration
    {
        public string? Token { get; set; }
        public string? IP { get; set; }
        public int? Port { get; set; }
    }

    private Configuration _configuration;
   
    private DeviceAutomation(IConfiguration configuration)
    {
        _configuration = GetSettingsFromConfiguration(configuration);
    }

    private IDeviceAutomation GetDeviceAutomation()
    {
        HttpClient client = GetHttpClient();
        var _api = RestService.For<IDeviceAutomation>(client);
        return _api;
    }

    private HttpClient GetHttpClient()
    {
        var baseAddress = new Uri($"http://{_configuration.IP}:{_configuration.Port}/ZAutomation/api/v1/devices");
        var handler = new HttpClientHandler();
        handler.CookieContainer.Add(baseAddress, new Cookie("ZWAYSession", _configuration.Token));
        var client = new HttpClient(handler) { BaseAddress = baseAddress };
        return client;
    }

    public static IDeviceAutomation FromConfiguration(IConfiguration configuration)
    {
        return new DeviceAutomation(configuration);
    }

    private Configuration GetSettingsFromConfiguration(IConfiguration configuration)
    {
        string _ip = configuration["IPAddress"] ?? throw new KeyNotFoundException("Cannot find 'IPAddress' in the configuration.");
        int _port = configuration["port"] == null ? throw new KeyNotFoundException("Cannot find 'port' in the configuration.") : int.Parse(configuration["port"]);
        string _token = configuration["token"] ?? throw new KeyNotFoundException("Cannot find 'token' in the configuration.");

        return new Configuration
        {
            IP = _ip,
            Port = _port,
            Token = _token
        };
    }

    public async Task<DevicesInfo> GetDevicesInfoAsync()
    {
        var deviceAutomation = GetDeviceAutomation();
        var result = await deviceAutomation.GetDevicesInfoAsync();
        return result;
    }

    public async Task<DeviceInfo> GetDeviceInfoAsync(string device)
    {
        var deviceAutomation = GetDeviceAutomation();
        var result = await deviceAutomation.GetDeviceInfoAsync(device);
        return result;
    }

    public async Task SendDeviceCommandAsync(string device, string command)
    {
        // "ZWayVDev_zway_46-0-37" "on"
        var deviceAutomation = GetDeviceAutomation();
        await deviceAutomation.SendDeviceCommandAsync(device, command);
    }
}
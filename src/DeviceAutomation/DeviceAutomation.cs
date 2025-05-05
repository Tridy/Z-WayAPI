using System;
using System.Collections.Generic;

using DeviceAutomation.Model;
using Microsoft.Extensions.Configuration;
using Refit;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeviceAutomation;

public interface IDeviceAutomation
{
    Task<DevicesInfo> GetDevicesInfoAsync();
    Task<DeviceInfo> GetDeviceInfoAsync(string deviceName);
    Task SendDeviceCommandAsync(string deviceName, string on);
}

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

    private IDeviceAutomationApi GetDeviceAutomation()
    {
        HttpClient client = GetHttpClient();
        var _api = RestService.For<IDeviceAutomationApi>(client);
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
        int _port = configuration["port"] == null ? throw new KeyNotFoundException("Cannot find 'port' in the configuration.") : int.Parse(configuration["port"] ?? throw new Exception("Cannot find 'port' in the configuration."));
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
        IDeviceAutomationApi deviceAutomation = GetDeviceAutomation();
        ApiResponse<DevicesInfo> apiResult = await deviceAutomation.GetDevicesInfoAsync();
        await apiResult.EnsureSuccessfulAsync().ConfigureAwait(false);
        DevicesInfo result = apiResult.Content ?? throw new InvalidOperationException("DevicesInfo is null");
        return result;
    }

    public async Task<DeviceInfo> GetDeviceInfoAsync(string deviceName)
    {
        IDeviceAutomationApi deviceAutomation = GetDeviceAutomation();
        // ApiResponse<string> apiResult1 = await deviceAutomation.GetDeviceInfoAsync2(deviceName);
        ApiResponse<DeviceInfo> apiResult = await deviceAutomation.GetDeviceInfoAsync(deviceName);
        await apiResult.EnsureSuccessfulAsync().ConfigureAwait(false);
        DeviceInfo result = apiResult.Content ?? throw new InvalidOperationException("DeviceInfo is null");
        return result;
    }

    public async Task SendDeviceCommandAsync(string device, string command)
    {
        // "ZWayVDev_zway_46-0-37" "on"
        var deviceAutomation = GetDeviceAutomation();
        await deviceAutomation.SendDeviceCommandAsync(device, command);
    }
}
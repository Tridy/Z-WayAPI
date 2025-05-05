using System;
using System.Collections.Generic;

using DeviceManager.Converters;
using DeviceManager.Model;
using Microsoft.Extensions.Configuration;
using Refit;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DeviceManager;

public interface IDeviceManager
{
    Task<ControllerInfo> GetControllerInfoAsync();
    Task<Dictionary<int, Device>> GetDevicesAsync();
}

public class DeviceManager: IDeviceManager
{
    internal struct Configuration
    {
        public string? Token { get; set; }
        public string? IP { get; set; }
        public int? Port { get; set; }
    }

    private Configuration _configuration;
   

    private DeviceManager(IConfiguration configuration)
    {
        _configuration = GetSettingsFromConfiguration(configuration);
    }

    private IDeviceManagerApi GetDeviceManager(JsonSerializerOptions options)
    {
        HttpClient client = GetHttpClient();

        var settings = new RefitSettings()
        {
            ContentSerializer = new SystemTextJsonContentSerializer(options)
        };

        var _api = RestService.For<IDeviceManagerApi>(client, settings);

        return _api;
    }

    private IDeviceManagerApi GetDeviceManager()
    {
        HttpClient client = GetHttpClient();
        var _api = RestService.For<IDeviceManagerApi>(client);
        return _api;
    }

    private HttpClient GetHttpClient()
    {
        var baseAddress = new Uri($"http://{_configuration.IP}:{_configuration.Port}/ZWaveAPI/Run");
        var handler = new HttpClientHandler();
        handler.CookieContainer.Add(baseAddress, new Cookie("ZWAYSession", _configuration.Token));
        var client = new HttpClient(handler) { BaseAddress = baseAddress };
        return client;
    }

    public static IDeviceManager FromConfiguration(IConfiguration configuration)
    {
        return new DeviceManager(configuration);
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

    public async Task<ControllerInfo> GetControllerInfoAsync()
    {
        IDeviceManagerApi api = GetDeviceManager();
        ApiResponse<ControllerInfo> apiResult = await api.GetControllerInfoAsync();
        await apiResult.EnsureSuccessfulAsync().ConfigureAwait(false);
        ControllerInfo result = apiResult.Content ?? throw new InvalidOperationException("ControllerInfo is null");
        return result;
    }

    public async Task<Dictionary<int, Device>> GetDevicesAsync()
    {
        JsonSerializerOptions options = new();
        options.Converters.Add(new IntIndexedDataConverter());
        options.Converters.Add(new StringIndexedDataConverter());

        var api = GetDeviceManager(options);
        var devices = await api.GetDevicesAsync();
        return devices;
    }
}
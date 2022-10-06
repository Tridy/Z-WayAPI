using DeviceAutomation.Model;
using Refit;

namespace DeviceAutomation;

public interface IDeviceAutomation
{
    [Get("")]
    Task<DevicesInfo> GetDevicesInfoAsync();

    [Get("/{deviceName}")]
    Task<DeviceInfo> GetDeviceInfoAsync(string deviceName);

    [Get("/{deviceName}/command/{command}")]
    Task SendDeviceCommandAsync(string deviceName, string command);
}
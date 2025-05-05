using System.Threading.Tasks;

using DeviceAutomation.Model;
using Refit;

namespace DeviceAutomation;

public interface IDeviceAutomationApi
{
    [Get("")]
    Task<ApiResponse<DevicesInfo>> GetDevicesInfoAsync();
    
    [Get("/{deviceName}")]
    Task<ApiResponse<DeviceInfo>> GetDeviceInfoAsync(string deviceName);

    [Get("/{deviceName}/command/{command}")]
    Task SendDeviceCommandAsync(string deviceName, string command);
}
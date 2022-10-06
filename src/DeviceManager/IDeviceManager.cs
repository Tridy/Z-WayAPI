using DeviceManager.Model;
using Refit;

namespace DeviceManager;

public interface IDeviceManager
{
    [Get("/controller")]
    Task<ControllerInfo> GetControllerInfoAsync();

    [Get("/devices")]
    Task<Dictionary<int, Device>> GetDevicesAsync();
}
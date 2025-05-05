using System.Collections.Generic;
using System.Threading.Tasks;

using DeviceManager.Model;
using Refit;

namespace DeviceManager;

public interface IDeviceManagerApi
{
    [Get("/controller")]
    Task<ApiResponse<ControllerInfo>> GetControllerInfoAsync();

    [Get("/devices")]
    Task<Dictionary<int, Device>> GetDevicesAsync();
}
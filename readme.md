# A demo application for calling Razberry Z-Way API (in local network)  and ZAutomation from .net/C#

## 0. What is this project for

This is a test solution that shows how to communicate with Z-WAY Automation API from a C# application. [Refit](https://github.com/reactiveui/refit) is used to help with the REST communication in the project.

## 1. Authentication

There are several ways of authenticating with Z-Way. I have found that using a Token Cookie worked best for my scenario. This can be found in the GetHttpClient() method in DeviceAutomation class.

### 1.1 Local Authentication

So far I have been working only with accessing Z-Way from my local network. There is a way of communicating with Z-Way through a remote server but I have not need for that yet.


### 1.2 Authentication via Token

To get a token, it can be done via Web UI of the Z-Way, by going to the dashboard > settings > my settings > generate auth tokens

## 2. Using User Secrets

I have chosen to use User Secrets to use for the secrets and configuration of IP address and the port of Z-Way. There are other ways with a local config/json file, but I decided to work with User Secrets for the sake of experiment.

### 2.1 Initializing of user secrets:

from the terminal for the projects, run:

`dotnet user-secrets init`

then add the secrets:
```powershell
dotnet user-secrets set token  "YOUR_TOKEN"
dotnet user-secrets set IPAddress  "RAZBERRY_IP_ADDRESS"
dotnet user-secrets set port  "8083"
```

after that the user secrets will be available through the  configuration, for example:
```c#
var configuration = new ConfigurationBuilder()
    .AddUserSecrets(Assembly.GetExecutingAssembly(), false)
    .Build();

_token = configuration["token"];
```

## 3. Solution Projects

### 3.1 DeviceAutomation/Tests project 

This is the easiest way to see how it works. It uses ZAutomation API.

As for now, I have implemented the 3 methods that perform the tasks of

1. getting all the devices `GetDevicesInfoAsync();`
2. getting a device information by name `GetDeviceInfoAsync(string deviceName);`
3. turning a device on/off `SendDeviceCommandAsync(string deviceName, string command);`

### 3.2 The other two projects DeviceManager/Tests 

These two have I have started earlies and it uses Z-Way API. It seems to be getting more details about the devices, instances, command classes but required more work with mapping json to the classes. In the end I found that *ZAutomation API* is sufficient for what I am doing. I am keeping it just in case.

## 4. API Examples of what a Z-Wave device can do

I also have discovered that from the Web UI device management, for each device, there is also a section called "API commands for developers" and it shows different REST methods for interacting with the particular device. If you have the authentication covered, this is probably all the info you need to be able to communicate for the devices through REST.

## 5. References

sources used:

https://z-wave.me/files/manual/z-way/Special_topics_Developers.html#SECTION001412000000000000000

https://gist.github.com/integrii/021f272f2cad0540fc3c

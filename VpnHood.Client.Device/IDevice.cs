﻿namespace VpnHood.Client.Device;

public interface IDevice : IDisposable
{
    event EventHandler StartedAsService;
    bool IsExcludeAppsSupported { get; }
    bool IsIncludeAppsSupported { get; }
    bool IsLogToConsoleSupported { get; }
    string OsInfo { get; }
    DeviceAppInfo[] InstalledApps { get; }
    Task<IPacketCapture> CreatePacketCapture();
    ICultureService? CultureService { get; }
}
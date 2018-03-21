// <copyright file="iDeviceActivationErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2018 Quamotion. All rights reserved.
// </copyright>

namespace iMobileDevice.iDeviceActivation
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class iDeviceActivationErrorExtensions
    {
        
        public static void ThrowOnError(this iDeviceActivationError value)
        {
            if ((value != iDeviceActivationError.Success))
            {
                throw new iDeviceActivationException(value);
            }
        }
        
        public static void ThrowOnError(this iDeviceActivationError value, string message)
        {
            if ((value != iDeviceActivationError.Success))
            {
                throw new iDeviceActivationException(value, message);
            }
        }
        
        public static bool IsError(this iDeviceActivationError value)
        {
            return (value != iDeviceActivationError.Success);
        }
    }
}

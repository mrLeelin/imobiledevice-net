// <copyright file="iDeviceActivationNativeMethods.cs" company="Quamotion">
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
    
    
    public partial class iDeviceActivationNativeMethods
    {
        
        const string libraryName = "ideviceactivation";
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_set_debug_level", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_set_debug_level(int level);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_new", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern iDeviceActivationError idevice_activation_request_new(iDeviceActivationClientType activationType, out iDeviceActivationRequestHandle request);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_new_from_lockdownd", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern iDeviceActivationError idevice_activation_request_new_from_lockdownd(iDeviceActivationClientType activationType, System.IntPtr lockdown, out iDeviceActivationRequestHandle request);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_drm_handshake_request_new", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern iDeviceActivationError idevice_activation_drm_handshake_request_new(iDeviceActivationClientType clientType, out iDeviceActivationRequestHandle request);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_free", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_request_free(System.IntPtr request);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_get_fields", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_request_get_fields(iDeviceActivationRequestHandle request, out PlistHandle fields);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_set_fields", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_request_set_fields(iDeviceActivationRequestHandle request, PlistHandle fields);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_set_fields_from_response", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_request_set_fields_from_response(iDeviceActivationRequestHandle request, iDeviceActivationResponseHandle response);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_set_field", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_request_set_field(iDeviceActivationRequestHandle request, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string key, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string value);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_get_field", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_request_get_field(iDeviceActivationRequestHandle request, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string key, out System.IntPtr value);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_get_url", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_request_get_url(iDeviceActivationRequestHandle request, out System.IntPtr url);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_request_set_url", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_request_set_url(iDeviceActivationRequestHandle request, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string url);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_new", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern iDeviceActivationError idevice_activation_response_new(out iDeviceActivationResponseHandle response);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_new_from_html", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern iDeviceActivationError idevice_activation_response_new_from_html([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string content, out iDeviceActivationResponseHandle response);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_to_buffer", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern iDeviceActivationError idevice_activation_response_to_buffer(iDeviceActivationResponseHandle response, out System.IntPtr buffer, ref uint size);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_free", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_response_free(System.IntPtr response);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_get_field", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_response_get_field(iDeviceActivationResponseHandle response, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string key, out System.IntPtr value);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_get_fields", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_response_get_fields(iDeviceActivationResponseHandle response, out PlistHandle fields);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_get_label", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_response_get_label(iDeviceActivationResponseHandle response, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string key, out System.IntPtr value);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_get_title", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_response_get_title(iDeviceActivationResponseHandle response, out System.IntPtr title);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_get_description", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_response_get_description(iDeviceActivationResponseHandle response, out System.IntPtr description);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_get_activation_record", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_response_get_activation_record(iDeviceActivationResponseHandle response, out PlistHandle activationRecord);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_get_headers", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void idevice_activation_response_get_headers(iDeviceActivationResponseHandle response, out PlistHandle headers);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_is_activation_acknowledged", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int idevice_activation_response_is_activation_acknowledged(iDeviceActivationResponseHandle response);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_is_authentication_required", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int idevice_activation_response_is_authentication_required(iDeviceActivationResponseHandle response);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_field_requires_input", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int idevice_activation_response_field_requires_input(iDeviceActivationResponseHandle response, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string key);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_response_has_errors", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int idevice_activation_response_has_errors(iDeviceActivationResponseHandle response);
        
        [System.Runtime.InteropServices.DllImportAttribute(iDeviceActivationNativeMethods.libraryName, EntryPoint="idevice_activation_send_request", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern iDeviceActivationError idevice_activation_send_request(iDeviceActivationRequestHandle request, out iDeviceActivationResponseHandle response);
    }
}

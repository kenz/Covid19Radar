﻿using Microsoft.Extensions.Configuration;

namespace Covid19Radar.Api
{
    public static class IConfigurationExtension
    {
        public static string ExportKeyUrl(this IConfiguration config) => config["ExportKeyUrl"];
        public static string TekExportBlobStorageContainerPrefix(this IConfiguration config) => config["TekExportBlobStorageContainerPrefix"];
        public static string AndroidBearerToken(this IConfiguration config) => config["AndroidBearerToken"];
        public static string AppleBearerToken(this IConfiguration config) => config["AppleBearerToken"];
        public static string[] SupportRegions(this IConfiguration config) => config["SupportRegions"].Split(',');
        public static string VerificationKeyId(this IConfiguration config) => config["VerificationKeyId"];
        public static string VerificationKeyVersion(this IConfiguration config) => config["VerificationKeyVersion"];
        public static string AndroidPackageName(this IConfiguration config) => config["AndroidPackageName"];
        public static string iOSBundleId(this IConfiguration config) => config["iOSBundleId"];
        public static string iOSDeviceCheckKeyId(this IConfiguration config) => config["iOSDeviceCheckKeyId"];
        public static string iOSDeviceCheckPrivateKey(this IConfiguration config) => config["iOSDeviceCheckPrivateKey"];
        public static string iOSDeviceCheckTeamId(this IConfiguration config) => config["iOSDeviceCheckTeamId"];
    }
}

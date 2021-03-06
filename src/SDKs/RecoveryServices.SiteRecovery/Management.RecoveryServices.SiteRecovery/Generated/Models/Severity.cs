// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Severity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Severity
    {
        [EnumMember(Value = "NONE")]
        NONE,
        [EnumMember(Value = "Warning")]
        Warning,
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "Info")]
        Info
    }
    internal static class SeverityEnumExtension
    {
        internal static string ToSerializedValue(this Severity? value)
        {
            return value == null ? null : ((Severity)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Severity value)
        {
            switch( value )
            {
                case Severity.NONE:
                    return "NONE";
                case Severity.Warning:
                    return "Warning";
                case Severity.Error:
                    return "Error";
                case Severity.Info:
                    return "Info";
            }
            return null;
        }

        internal static Severity? ParseSeverity(this string value)
        {
            switch( value )
            {
                case "NONE":
                    return Severity.NONE;
                case "Warning":
                    return Severity.Warning;
                case "Error":
                    return Severity.Error;
                case "Info":
                    return Severity.Info;
            }
            return null;
        }
    }
}

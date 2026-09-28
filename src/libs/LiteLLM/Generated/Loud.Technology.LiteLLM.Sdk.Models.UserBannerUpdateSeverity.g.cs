
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Visual style of the banner.<br/>
    /// Default Value: info
    /// </summary>
    public enum UserBannerUpdateSeverity
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Info,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserBannerUpdateSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserBannerUpdateSeverity value)
        {
            return value switch
            {
                UserBannerUpdateSeverity.Error => "error",
                UserBannerUpdateSeverity.Info => "info",
                UserBannerUpdateSeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserBannerUpdateSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => UserBannerUpdateSeverity.Error,
                "info" => UserBannerUpdateSeverity.Info,
                "warning" => UserBannerUpdateSeverity.Warning,
                _ => null,
            };
        }
    }
}
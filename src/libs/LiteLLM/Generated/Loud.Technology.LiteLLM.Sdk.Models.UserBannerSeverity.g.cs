
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Visual style of the banner.<br/>
    /// Default Value: info
    /// </summary>
    public enum UserBannerSeverity
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
    public static class UserBannerSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserBannerSeverity value)
        {
            return value switch
            {
                UserBannerSeverity.Error => "error",
                UserBannerSeverity.Info => "info",
                UserBannerSeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserBannerSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => UserBannerSeverity.Error,
                "info" => UserBannerSeverity.Info,
                "warning" => UserBannerSeverity.Warning,
                _ => null,
            };
        }
    }
}
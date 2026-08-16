
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum LoggingCallbackStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Healthy,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoggingCallbackStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoggingCallbackStatusStatus value)
        {
            return value switch
            {
                LoggingCallbackStatusStatus.Healthy => "healthy",
                LoggingCallbackStatusStatus.Unhealthy => "unhealthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoggingCallbackStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "healthy" => LoggingCallbackStatusStatus.Healthy,
                "unhealthy" => LoggingCallbackStatusStatus.Unhealthy,
                _ => null,
            };
        }
    }
}
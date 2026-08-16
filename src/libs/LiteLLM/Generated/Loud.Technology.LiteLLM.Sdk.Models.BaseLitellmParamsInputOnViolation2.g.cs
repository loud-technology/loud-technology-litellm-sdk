
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseLitellmParamsInputOnViolation2
    {
        /// <summary>
        /// 
        /// </summary>
        EndSession,
        /// <summary>
        /// 
        /// </summary>
        Warn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseLitellmParamsInputOnViolation2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseLitellmParamsInputOnViolation2 value)
        {
            return value switch
            {
                BaseLitellmParamsInputOnViolation2.EndSession => "end_session",
                BaseLitellmParamsInputOnViolation2.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseLitellmParamsInputOnViolation2? ToEnum(string value)
        {
            return value switch
            {
                "end_session" => BaseLitellmParamsInputOnViolation2.EndSession,
                "warn" => BaseLitellmParamsInputOnViolation2.Warn,
                _ => null,
            };
        }
    }
}
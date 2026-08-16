
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseLitellmParamsOutputOnViolation2
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
    public static class BaseLitellmParamsOutputOnViolation2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseLitellmParamsOutputOnViolation2 value)
        {
            return value switch
            {
                BaseLitellmParamsOutputOnViolation2.EndSession => "end_session",
                BaseLitellmParamsOutputOnViolation2.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseLitellmParamsOutputOnViolation2? ToEnum(string value)
        {
            return value switch
            {
                "end_session" => BaseLitellmParamsOutputOnViolation2.EndSession,
                "warn" => BaseLitellmParamsOutputOnViolation2.Warn,
                _ => null,
            };
        }
    }
}
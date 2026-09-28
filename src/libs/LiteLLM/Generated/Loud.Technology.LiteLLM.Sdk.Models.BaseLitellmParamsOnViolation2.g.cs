
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseLitellmParamsOnViolation2
    {
        /// <summary>
        ///
        /// </summary>
        Alert,
        /// <summary>
        ///
        /// </summary>
        Block,
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
    public static class BaseLitellmParamsOnViolation2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseLitellmParamsOnViolation2 value)
        {
            return value switch
            {
                BaseLitellmParamsOnViolation2.Alert => "alert",
                BaseLitellmParamsOnViolation2.Block => "block",
                BaseLitellmParamsOnViolation2.EndSession => "end_session",
                BaseLitellmParamsOnViolation2.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseLitellmParamsOnViolation2? ToEnum(string value)
        {
            return value switch
            {
                "alert" => BaseLitellmParamsOnViolation2.Alert,
                "block" => BaseLitellmParamsOnViolation2.Block,
                "end_session" => BaseLitellmParamsOnViolation2.EndSession,
                "warn" => BaseLitellmParamsOnViolation2.Warn,
                _ => null,
            };
        }
    }
}
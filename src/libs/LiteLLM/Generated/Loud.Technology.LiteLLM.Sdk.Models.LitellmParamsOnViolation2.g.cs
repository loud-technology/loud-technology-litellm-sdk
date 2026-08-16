
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum LitellmParamsOnViolation2
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
    public static class LitellmParamsOnViolation2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsOnViolation2 value)
        {
            return value switch
            {
                LitellmParamsOnViolation2.EndSession => "end_session",
                LitellmParamsOnViolation2.Warn => "warn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsOnViolation2? ToEnum(string value)
        {
            return value switch
            {
                "end_session" => LitellmParamsOnViolation2.EndSession,
                "warn" => LitellmParamsOnViolation2.Warn,
                _ => null,
            };
        }
    }
}
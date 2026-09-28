
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum LiteLLMMCPServerTableStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Healthy,
        /// <summary>
        ///
        /// </summary>
        Unhealthy,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiteLLMMCPServerTableStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteLLMMCPServerTableStatus2 value)
        {
            return value switch
            {
                LiteLLMMCPServerTableStatus2.Healthy => "healthy",
                LiteLLMMCPServerTableStatus2.Unhealthy => "unhealthy",
                LiteLLMMCPServerTableStatus2.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteLLMMCPServerTableStatus2? ToEnum(string value)
        {
            return value switch
            {
                "healthy" => LiteLLMMCPServerTableStatus2.Healthy,
                "unhealthy" => LiteLLMMCPServerTableStatus2.Unhealthy,
                "unknown" => LiteLLMMCPServerTableStatus2.Unknown,
                _ => null,
            };
        }
    }
}
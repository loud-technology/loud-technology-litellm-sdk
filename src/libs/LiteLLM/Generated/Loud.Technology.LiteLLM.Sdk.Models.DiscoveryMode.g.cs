
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// How to locate the upstream agent card.<br/>
    /// String-valued so it serializes cleanly over JSON / Pydantic.
    /// </summary>
    public enum DiscoveryMode
    {
        /// <summary>
        ///
        /// </summary>
        LanggraphPlatform,
        /// <summary>
        ///
        /// </summary>
        WellKnownFallback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiscoveryModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscoveryMode value)
        {
            return value switch
            {
                DiscoveryMode.LanggraphPlatform => "langgraph_platform",
                DiscoveryMode.WellKnownFallback => "well_known_fallback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscoveryMode? ToEnum(string value)
        {
            return value switch
            {
                "langgraph_platform" => DiscoveryMode.LanggraphPlatform,
                "well_known_fallback" => DiscoveryMode.WellKnownFallback,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum StandardLoggingRoutingDecisionRouterType
    {
        /// <summary>
        ///
        /// </summary>
        Adaptive,
        /// <summary>
        ///
        /// </summary>
        Complexity,
        /// <summary>
        ///
        /// </summary>
        Quality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StandardLoggingRoutingDecisionRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StandardLoggingRoutingDecisionRouterType value)
        {
            return value switch
            {
                StandardLoggingRoutingDecisionRouterType.Adaptive => "adaptive",
                StandardLoggingRoutingDecisionRouterType.Complexity => "complexity",
                StandardLoggingRoutingDecisionRouterType.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StandardLoggingRoutingDecisionRouterType? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => StandardLoggingRoutingDecisionRouterType.Adaptive,
                "complexity" => StandardLoggingRoutingDecisionRouterType.Complexity,
                "quality" => StandardLoggingRoutingDecisionRouterType.Quality,
                _ => null,
            };
        }
    }
}
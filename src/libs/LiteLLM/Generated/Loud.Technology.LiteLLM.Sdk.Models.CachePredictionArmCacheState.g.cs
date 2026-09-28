
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: unknown
    /// </summary>
    public enum CachePredictionArmCacheState
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Partial,
        /// <summary>
        ///
        /// </summary>
        Stale,
        /// <summary>
        ///
        /// </summary>
        Unknown,
        /// <summary>
        ///
        /// </summary>
        Warm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CachePredictionArmCacheStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CachePredictionArmCacheState value)
        {
            return value switch
            {
                CachePredictionArmCacheState.Disabled => "disabled",
                CachePredictionArmCacheState.Partial => "partial",
                CachePredictionArmCacheState.Stale => "stale",
                CachePredictionArmCacheState.Unknown => "unknown",
                CachePredictionArmCacheState.Warm => "warm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CachePredictionArmCacheState? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CachePredictionArmCacheState.Disabled,
                "partial" => CachePredictionArmCacheState.Partial,
                "stale" => CachePredictionArmCacheState.Stale,
                "unknown" => CachePredictionArmCacheState.Unknown,
                "warm" => CachePredictionArmCacheState.Warm,
                _ => null,
            };
        }
    }
}
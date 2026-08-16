
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegenerateKeyRequestTpmLimitType2
    {
        /// <summary>
        /// 
        /// </summary>
        BestEffortThroughput,
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        GuaranteedThroughput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegenerateKeyRequestTpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegenerateKeyRequestTpmLimitType2 value)
        {
            return value switch
            {
                RegenerateKeyRequestTpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                RegenerateKeyRequestTpmLimitType2.Dynamic => "dynamic",
                RegenerateKeyRequestTpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegenerateKeyRequestTpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => RegenerateKeyRequestTpmLimitType2.BestEffortThroughput,
                "dynamic" => RegenerateKeyRequestTpmLimitType2.Dynamic,
                "guaranteed_throughput" => RegenerateKeyRequestTpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
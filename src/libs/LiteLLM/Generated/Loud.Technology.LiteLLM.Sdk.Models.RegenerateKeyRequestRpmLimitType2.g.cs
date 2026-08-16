
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegenerateKeyRequestRpmLimitType2
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
    public static class RegenerateKeyRequestRpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegenerateKeyRequestRpmLimitType2 value)
        {
            return value switch
            {
                RegenerateKeyRequestRpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                RegenerateKeyRequestRpmLimitType2.Dynamic => "dynamic",
                RegenerateKeyRequestRpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegenerateKeyRequestRpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => RegenerateKeyRequestRpmLimitType2.BestEffortThroughput,
                "dynamic" => RegenerateKeyRequestRpmLimitType2.Dynamic,
                "guaranteed_throughput" => RegenerateKeyRequestRpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
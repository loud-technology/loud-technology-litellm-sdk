
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateKeyRequestTpmLimitType2
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
    public static class UpdateKeyRequestTpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKeyRequestTpmLimitType2 value)
        {
            return value switch
            {
                UpdateKeyRequestTpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                UpdateKeyRequestTpmLimitType2.Dynamic => "dynamic",
                UpdateKeyRequestTpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKeyRequestTpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => UpdateKeyRequestTpmLimitType2.BestEffortThroughput,
                "dynamic" => UpdateKeyRequestTpmLimitType2.Dynamic,
                "guaranteed_throughput" => UpdateKeyRequestTpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateKeyRequestRpmLimitType2
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
    public static class UpdateKeyRequestRpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKeyRequestRpmLimitType2 value)
        {
            return value switch
            {
                UpdateKeyRequestRpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                UpdateKeyRequestRpmLimitType2.Dynamic => "dynamic",
                UpdateKeyRequestRpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKeyRequestRpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => UpdateKeyRequestRpmLimitType2.BestEffortThroughput,
                "dynamic" => UpdateKeyRequestRpmLimitType2.Dynamic,
                "guaranteed_throughput" => UpdateKeyRequestRpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
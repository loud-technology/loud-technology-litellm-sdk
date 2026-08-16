
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeyUpdateFieldsTpmLimitType2
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
    public static class KeyUpdateFieldsTpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyUpdateFieldsTpmLimitType2 value)
        {
            return value switch
            {
                KeyUpdateFieldsTpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                KeyUpdateFieldsTpmLimitType2.Dynamic => "dynamic",
                KeyUpdateFieldsTpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyUpdateFieldsTpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => KeyUpdateFieldsTpmLimitType2.BestEffortThroughput,
                "dynamic" => KeyUpdateFieldsTpmLimitType2.Dynamic,
                "guaranteed_throughput" => KeyUpdateFieldsTpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
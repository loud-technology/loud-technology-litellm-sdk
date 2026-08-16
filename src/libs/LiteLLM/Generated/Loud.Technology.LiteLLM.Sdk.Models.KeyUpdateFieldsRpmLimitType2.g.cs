
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeyUpdateFieldsRpmLimitType2
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
    public static class KeyUpdateFieldsRpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyUpdateFieldsRpmLimitType2 value)
        {
            return value switch
            {
                KeyUpdateFieldsRpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                KeyUpdateFieldsRpmLimitType2.Dynamic => "dynamic",
                KeyUpdateFieldsRpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyUpdateFieldsRpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => KeyUpdateFieldsRpmLimitType2.BestEffortThroughput,
                "dynamic" => KeyUpdateFieldsRpmLimitType2.Dynamic,
                "guaranteed_throughput" => KeyUpdateFieldsRpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
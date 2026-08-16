
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewUserResponseRpmLimitType2
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
    public static class NewUserResponseRpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewUserResponseRpmLimitType2 value)
        {
            return value switch
            {
                NewUserResponseRpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                NewUserResponseRpmLimitType2.Dynamic => "dynamic",
                NewUserResponseRpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewUserResponseRpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => NewUserResponseRpmLimitType2.BestEffortThroughput,
                "dynamic" => NewUserResponseRpmLimitType2.Dynamic,
                "guaranteed_throughput" => NewUserResponseRpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewUserResponseTpmLimitType2
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
    public static class NewUserResponseTpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewUserResponseTpmLimitType2 value)
        {
            return value switch
            {
                NewUserResponseTpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                NewUserResponseTpmLimitType2.Dynamic => "dynamic",
                NewUserResponseTpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewUserResponseTpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => NewUserResponseTpmLimitType2.BestEffortThroughput,
                "dynamic" => NewUserResponseTpmLimitType2.Dynamic,
                "guaranteed_throughput" => NewUserResponseTpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
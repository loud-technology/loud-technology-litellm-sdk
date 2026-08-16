
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewTeamRequestTpmLimitType2
    {
        /// <summary>
        /// 
        /// </summary>
        BestEffortThroughput,
        /// <summary>
        /// 
        /// </summary>
        GuaranteedThroughput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewTeamRequestTpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewTeamRequestTpmLimitType2 value)
        {
            return value switch
            {
                NewTeamRequestTpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                NewTeamRequestTpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewTeamRequestTpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => NewTeamRequestTpmLimitType2.BestEffortThroughput,
                "guaranteed_throughput" => NewTeamRequestTpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
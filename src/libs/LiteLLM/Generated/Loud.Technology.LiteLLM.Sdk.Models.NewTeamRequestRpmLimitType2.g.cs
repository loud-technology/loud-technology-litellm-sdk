
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewTeamRequestRpmLimitType2
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
    public static class NewTeamRequestRpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewTeamRequestRpmLimitType2 value)
        {
            return value switch
            {
                NewTeamRequestRpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                NewTeamRequestRpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewTeamRequestRpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => NewTeamRequestRpmLimitType2.BestEffortThroughput,
                "guaranteed_throughput" => NewTeamRequestRpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
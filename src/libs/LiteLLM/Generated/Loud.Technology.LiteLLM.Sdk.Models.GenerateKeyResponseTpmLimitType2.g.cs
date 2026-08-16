
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateKeyResponseTpmLimitType2
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
    public static class GenerateKeyResponseTpmLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateKeyResponseTpmLimitType2 value)
        {
            return value switch
            {
                GenerateKeyResponseTpmLimitType2.BestEffortThroughput => "best_effort_throughput",
                GenerateKeyResponseTpmLimitType2.Dynamic => "dynamic",
                GenerateKeyResponseTpmLimitType2.GuaranteedThroughput => "guaranteed_throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateKeyResponseTpmLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "best_effort_throughput" => GenerateKeyResponseTpmLimitType2.BestEffortThroughput,
                "dynamic" => GenerateKeyResponseTpmLimitType2.Dynamic,
                "guaranteed_throughput" => GenerateKeyResponseTpmLimitType2.GuaranteedThroughput,
                _ => null,
            };
        }
    }
}
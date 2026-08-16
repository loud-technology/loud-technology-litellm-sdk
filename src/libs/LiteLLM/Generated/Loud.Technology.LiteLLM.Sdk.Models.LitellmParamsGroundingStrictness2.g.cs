
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum LitellmParamsGroundingStrictness2
    {
        /// <summary>
        /// 
        /// </summary>
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LitellmParamsGroundingStrictness2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsGroundingStrictness2 value)
        {
            return value switch
            {
                LitellmParamsGroundingStrictness2.Balanced => "BALANCED",
                LitellmParamsGroundingStrictness2.Strict => "STRICT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsGroundingStrictness2? ToEnum(string value)
        {
            return value switch
            {
                "BALANCED" => LitellmParamsGroundingStrictness2.Balanced,
                "STRICT" => LitellmParamsGroundingStrictness2.Strict,
                _ => null,
            };
        }
    }
}
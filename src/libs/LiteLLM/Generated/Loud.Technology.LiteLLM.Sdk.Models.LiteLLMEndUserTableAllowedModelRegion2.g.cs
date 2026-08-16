
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum LiteLLMEndUserTableAllowedModelRegion2
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiteLLMEndUserTableAllowedModelRegion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteLLMEndUserTableAllowedModelRegion2 value)
        {
            return value switch
            {
                LiteLLMEndUserTableAllowedModelRegion2.Eu => "eu",
                LiteLLMEndUserTableAllowedModelRegion2.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteLLMEndUserTableAllowedModelRegion2? ToEnum(string value)
        {
            return value switch
            {
                "eu" => LiteLLMEndUserTableAllowedModelRegion2.Eu,
                "us" => LiteLLMEndUserTableAllowedModelRegion2.Us,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: untrusted
    /// </summary>
    public enum LiteLLMToolTableRowOutputPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        Trusted,
        /// <summary>
        /// 
        /// </summary>
        Untrusted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiteLLMToolTableRowOutputPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteLLMToolTableRowOutputPolicy value)
        {
            return value switch
            {
                LiteLLMToolTableRowOutputPolicy.Trusted => "trusted",
                LiteLLMToolTableRowOutputPolicy.Untrusted => "untrusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteLLMToolTableRowOutputPolicy? ToEnum(string value)
        {
            return value switch
            {
                "trusted" => LiteLLMToolTableRowOutputPolicy.Trusted,
                "untrusted" => LiteLLMToolTableRowOutputPolicy.Untrusted,
                _ => null,
            };
        }
    }
}
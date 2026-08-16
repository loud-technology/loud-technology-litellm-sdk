
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: untrusted
    /// </summary>
    public enum LiteLLMToolTableRowInputPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
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
    public static class LiteLLMToolTableRowInputPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteLLMToolTableRowInputPolicy value)
        {
            return value switch
            {
                LiteLLMToolTableRowInputPolicy.Blocked => "blocked",
                LiteLLMToolTableRowInputPolicy.Trusted => "trusted",
                LiteLLMToolTableRowInputPolicy.Untrusted => "untrusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteLLMToolTableRowInputPolicy? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => LiteLLMToolTableRowInputPolicy.Blocked,
                "trusted" => LiteLLMToolTableRowInputPolicy.Trusted,
                "untrusted" => LiteLLMToolTableRowInputPolicy.Untrusted,
                _ => null,
            };
        }
    }
}
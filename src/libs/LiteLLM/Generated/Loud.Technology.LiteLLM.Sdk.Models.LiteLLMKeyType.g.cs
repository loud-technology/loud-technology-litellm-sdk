
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Enum for key types that determine what routes a key can access
    /// </summary>
    public enum LiteLLMKeyType
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        LlmApi,
        /// <summary>
        /// 
        /// </summary>
        Management,
        /// <summary>
        /// 
        /// </summary>
        ReadOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiteLLMKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteLLMKeyType value)
        {
            return value switch
            {
                LiteLLMKeyType.Default => "default",
                LiteLLMKeyType.LlmApi => "llm_api",
                LiteLLMKeyType.Management => "management",
                LiteLLMKeyType.ReadOnly => "read_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteLLMKeyType? ToEnum(string value)
        {
            return value switch
            {
                "default" => LiteLLMKeyType.Default,
                "llm_api" => LiteLLMKeyType.LlmApi,
                "management" => LiteLLMKeyType.Management,
                "read_only" => LiteLLMKeyType.ReadOnly,
                _ => null,
            };
        }
    }
}
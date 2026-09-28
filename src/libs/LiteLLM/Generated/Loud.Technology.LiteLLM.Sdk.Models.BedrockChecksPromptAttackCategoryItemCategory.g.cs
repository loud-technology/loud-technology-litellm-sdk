
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum BedrockChecksPromptAttackCategoryItemCategory
    {
        /// <summary>
        ///
        /// </summary>
        Jailbreak,
        /// <summary>
        ///
        /// </summary>
        PromptInjection,
        /// <summary>
        ///
        /// </summary>
        PromptLeakage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BedrockChecksPromptAttackCategoryItemCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BedrockChecksPromptAttackCategoryItemCategory value)
        {
            return value switch
            {
                BedrockChecksPromptAttackCategoryItemCategory.Jailbreak => "JAILBREAK",
                BedrockChecksPromptAttackCategoryItemCategory.PromptInjection => "PROMPT_INJECTION",
                BedrockChecksPromptAttackCategoryItemCategory.PromptLeakage => "PROMPT_LEAKAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BedrockChecksPromptAttackCategoryItemCategory? ToEnum(string value)
        {
            return value switch
            {
                "JAILBREAK" => BedrockChecksPromptAttackCategoryItemCategory.Jailbreak,
                "PROMPT_INJECTION" => BedrockChecksPromptAttackCategoryItemCategory.PromptInjection,
                "PROMPT_LEAKAGE" => BedrockChecksPromptAttackCategoryItemCategory.PromptLeakage,
                _ => null,
            };
        }
    }
}
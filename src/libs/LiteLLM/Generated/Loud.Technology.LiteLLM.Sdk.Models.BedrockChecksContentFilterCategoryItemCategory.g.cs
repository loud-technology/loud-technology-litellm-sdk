
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum BedrockChecksContentFilterCategoryItemCategory
    {
        /// <summary>
        ///
        /// </summary>
        Hate,
        /// <summary>
        ///
        /// </summary>
        Insults,
        /// <summary>
        ///
        /// </summary>
        Misconduct,
        /// <summary>
        ///
        /// </summary>
        Sexual,
        /// <summary>
        ///
        /// </summary>
        Violence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BedrockChecksContentFilterCategoryItemCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BedrockChecksContentFilterCategoryItemCategory value)
        {
            return value switch
            {
                BedrockChecksContentFilterCategoryItemCategory.Hate => "HATE",
                BedrockChecksContentFilterCategoryItemCategory.Insults => "INSULTS",
                BedrockChecksContentFilterCategoryItemCategory.Misconduct => "MISCONDUCT",
                BedrockChecksContentFilterCategoryItemCategory.Sexual => "SEXUAL",
                BedrockChecksContentFilterCategoryItemCategory.Violence => "VIOLENCE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BedrockChecksContentFilterCategoryItemCategory? ToEnum(string value)
        {
            return value switch
            {
                "HATE" => BedrockChecksContentFilterCategoryItemCategory.Hate,
                "INSULTS" => BedrockChecksContentFilterCategoryItemCategory.Insults,
                "MISCONDUCT" => BedrockChecksContentFilterCategoryItemCategory.Misconduct,
                "SEXUAL" => BedrockChecksContentFilterCategoryItemCategory.Sexual,
                "VIOLENCE" => BedrockChecksContentFilterCategoryItemCategory.Violence,
                _ => null,
            };
        }
    }
}
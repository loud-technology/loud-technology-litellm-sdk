
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptInfoPromptType
    {
        /// <summary>
        ///
        /// </summary>
        Config,
        /// <summary>
        ///
        /// </summary>
        Db,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptInfoPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptInfoPromptType value)
        {
            return value switch
            {
                PromptInfoPromptType.Config => "config",
                PromptInfoPromptType.Db => "db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptInfoPromptType? ToEnum(string value)
        {
            return value switch
            {
                "config" => PromptInfoPromptType.Config,
                "db" => PromptInfoPromptType.Db,
                _ => null,
            };
        }
    }
}
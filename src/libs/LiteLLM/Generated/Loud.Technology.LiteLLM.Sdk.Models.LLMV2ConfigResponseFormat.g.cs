
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: json_schema
    /// </summary>
    public enum LLMV2ConfigResponseFormat
    {
        /// <summary>
        ///
        /// </summary>
        JsonObject,
        /// <summary>
        ///
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMV2ConfigResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMV2ConfigResponseFormat value)
        {
            return value switch
            {
                LLMV2ConfigResponseFormat.JsonObject => "json_object",
                LLMV2ConfigResponseFormat.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMV2ConfigResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => LLMV2ConfigResponseFormat.JsonObject,
                "json_schema" => LLMV2ConfigResponseFormat.JsonSchema,
                _ => null,
            };
        }
    }
}
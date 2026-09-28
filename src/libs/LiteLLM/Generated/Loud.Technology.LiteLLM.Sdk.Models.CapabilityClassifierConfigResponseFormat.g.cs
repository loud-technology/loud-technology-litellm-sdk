
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Use json_object for judges without strict JSON Schema support. This appends the verdict schema to the packaged system prompt; both modes validate the returned verdict identically.<br/>
    /// Default Value: json_schema
    /// </summary>
    public enum CapabilityClassifierConfigResponseFormat
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
    public static class CapabilityClassifierConfigResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CapabilityClassifierConfigResponseFormat value)
        {
            return value switch
            {
                CapabilityClassifierConfigResponseFormat.JsonObject => "json_object",
                CapabilityClassifierConfigResponseFormat.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CapabilityClassifierConfigResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => CapabilityClassifierConfigResponseFormat.JsonObject,
                "json_schema" => CapabilityClassifierConfigResponseFormat.JsonSchema,
                _ => null,
            };
        }
    }
}
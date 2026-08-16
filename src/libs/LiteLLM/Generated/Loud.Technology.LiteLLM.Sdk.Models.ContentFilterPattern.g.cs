
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Represents a content filter pattern (prebuilt or custom regex)
    /// </summary>
    public sealed partial class ContentFilterPattern
    {
        /// <summary>
        /// Action to take when pattern matches (BLOCK or MASK)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ContentFilterActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ContentFilterAction Action { get; set; }

        /// <summary>
        /// Name for this pattern (used in logging and error messages)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Custom regex pattern. Required if pattern_type is 'regex'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Name of prebuilt pattern (e.g., 'us_ssn', 'credit_card'). Required if pattern_type is 'prebuilt'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_name")]
        public string? PatternName { get; set; }

        /// <summary>
        /// Type of pattern: 'prebuilt' for predefined patterns or 'regex' for custom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ContentFilterPatternPatternTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ContentFilterPatternPatternType PatternType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterPattern" /> class.
        /// </summary>
        /// <param name="action">
        /// Action to take when pattern matches (BLOCK or MASK)
        /// </param>
        /// <param name="patternType">
        /// Type of pattern: 'prebuilt' for predefined patterns or 'regex' for custom
        /// </param>
        /// <param name="name">
        /// Name for this pattern (used in logging and error messages)
        /// </param>
        /// <param name="pattern">
        /// Custom regex pattern. Required if pattern_type is 'regex'
        /// </param>
        /// <param name="patternName">
        /// Name of prebuilt pattern (e.g., 'us_ssn', 'credit_card'). Required if pattern_type is 'prebuilt'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFilterPattern(
            global::Loud.Technology.LiteLLM.Sdk.ContentFilterAction action,
            global::Loud.Technology.LiteLLM.Sdk.ContentFilterPatternPatternType patternType,
            string? name,
            string? pattern,
            string? patternName)
        {
            this.Action = action;
            this.Name = name;
            this.Pattern = pattern;
            this.PatternName = patternName;
            this.PatternType = patternType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterPattern" /> class.
        /// </summary>
        public ContentFilterPattern()
        {
        }

    }
}
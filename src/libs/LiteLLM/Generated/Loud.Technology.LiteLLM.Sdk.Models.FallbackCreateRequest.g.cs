
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for creating/updating fallbacks
    /// </summary>
    public sealed partial class FallbackCreateRequest
    {
        /// <summary>
        /// The model name to configure fallbacks for (e.g., 'gpt-3.5-turbo')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of fallback model names in order of priority
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FallbackModels { get; set; }

        /// <summary>
        /// Type of fallback: 'general' (default), 'context_window', or 'content_policy'<br/>
        /// Default Value: general
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.FallbackCreateRequestFallbackTypeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.FallbackCreateRequestFallbackType? FallbackType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCreateRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model name to configure fallbacks for (e.g., 'gpt-3.5-turbo')
        /// </param>
        /// <param name="fallbackModels">
        /// List of fallback model names in order of priority
        /// </param>
        /// <param name="fallbackType">
        /// Type of fallback: 'general' (default), 'context_window', or 'content_policy'<br/>
        /// Default Value: general
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackCreateRequest(
            string model,
            global::System.Collections.Generic.IList<string> fallbackModels,
            global::Loud.Technology.LiteLLM.Sdk.FallbackCreateRequestFallbackType? fallbackType)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.FallbackModels = fallbackModels ?? throw new global::System.ArgumentNullException(nameof(fallbackModels));
            this.FallbackType = fallbackType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCreateRequest" /> class.
        /// </summary>
        public FallbackCreateRequest()
        {
        }

    }
}
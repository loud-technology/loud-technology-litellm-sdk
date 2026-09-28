
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for getting fallbacks
    /// </summary>
    public sealed partial class FallbackGetResponse
    {
        /// <summary>
        /// The model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of fallback model names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FallbackModels { get; set; }

        /// <summary>
        /// Type of fallback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FallbackType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackGetResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The model name
        /// </param>
        /// <param name="fallbackModels">
        /// List of fallback model names
        /// </param>
        /// <param name="fallbackType">
        /// Type of fallback
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackGetResponse(
            string model,
            global::System.Collections.Generic.IList<string> fallbackModels,
            string fallbackType)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.FallbackModels = fallbackModels ?? throw new global::System.ArgumentNullException(nameof(fallbackModels));
            this.FallbackType = fallbackType ?? throw new global::System.ArgumentNullException(nameof(fallbackType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackGetResponse" /> class.
        /// </summary>
        public FallbackGetResponse()
        {
        }

    }
}
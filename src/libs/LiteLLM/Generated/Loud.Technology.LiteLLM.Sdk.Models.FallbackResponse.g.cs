
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for fallback operations
    /// </summary>
    public sealed partial class FallbackResponse
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
        /// Success message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackResponse" /> class.
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
        /// <param name="message">
        /// Success message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackResponse(
            string model,
            global::System.Collections.Generic.IList<string> fallbackModels,
            string fallbackType,
            string message)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.FallbackModels = fallbackModels ?? throw new global::System.ArgumentNullException(nameof(fallbackModels));
            this.FallbackType = fallbackType ?? throw new global::System.ArgumentNullException(nameof(fallbackType));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackResponse" /> class.
        /// </summary>
        public FallbackResponse()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptSpec
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Default Value: development
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PromptLiteLLMParams LitellmParams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PromptInfo PromptInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptSpec" /> class.
        /// </summary>
        /// <param name="litellmParams"></param>
        /// <param name="promptId"></param>
        /// <param name="promptInfo"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="environment">
        /// Default Value: development
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptSpec(
            global::Loud.Technology.LiteLLM.Sdk.PromptLiteLLMParams litellmParams,
            string promptId,
            global::Loud.Technology.LiteLLM.Sdk.PromptInfo promptInfo,
            global::System.DateTime? createdAt,
            string? createdBy,
            string? environment,
            global::System.DateTime? updatedAt,
            int? version)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Environment = environment;
            this.LitellmParams = litellmParams ?? throw new global::System.ArgumentNullException(nameof(litellmParams));
            this.PromptId = promptId ?? throw new global::System.ArgumentNullException(nameof(promptId));
            this.PromptInfo = promptInfo ?? throw new global::System.ArgumentNullException(nameof(promptInfo));
            this.UpdatedAt = updatedAt;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptSpec" /> class.
        /// </summary>
        public PromptSpec()
        {
        }

    }
}
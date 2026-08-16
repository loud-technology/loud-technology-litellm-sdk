
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Default Value: config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_definition_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.GuardrailDefinitionLocationJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.GuardrailDefinitionLocation? GuardrailDefinitionLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        public string? GuardrailId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_info")]
        public object? GuardrailInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsOutput? LitellmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailInfoResponse" /> class.
        /// </summary>
        /// <param name="guardrailName"></param>
        /// <param name="createdAt"></param>
        /// <param name="guardrailDefinitionLocation">
        /// Default Value: config
        /// </param>
        /// <param name="guardrailId"></param>
        /// <param name="guardrailInfo"></param>
        /// <param name="litellmParams"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailInfoResponse(
            string guardrailName,
            global::System.DateTime? createdAt,
            global::Loud.Technology.LiteLLM.Sdk.GuardrailDefinitionLocation? guardrailDefinitionLocation,
            string? guardrailId,
            object? guardrailInfo,
            global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsOutput? litellmParams,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.GuardrailDefinitionLocation = guardrailDefinitionLocation;
            this.GuardrailId = guardrailId;
            this.GuardrailInfo = guardrailInfo;
            this.GuardrailName = guardrailName ?? throw new global::System.ArgumentNullException(nameof(guardrailName));
            this.LitellmParams = litellmParams;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailInfoResponse" /> class.
        /// </summary>
        public GuardrailInfoResponse()
        {
        }

    }
}
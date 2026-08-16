
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Guardrail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.LitellmParams2 LitellmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_template")]
        public string? PolicyTemplate { get; set; }

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
        /// Initializes a new instance of the <see cref="Guardrail" /> class.
        /// </summary>
        /// <param name="guardrailName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="createdAt"></param>
        /// <param name="guardrailId"></param>
        /// <param name="guardrailInfo"></param>
        /// <param name="policyTemplate"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Guardrail(
            string guardrailName,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParams2 litellmParams,
            global::System.DateTime? createdAt,
            string? guardrailId,
            object? guardrailInfo,
            string? policyTemplate,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.GuardrailId = guardrailId;
            this.GuardrailInfo = guardrailInfo;
            this.GuardrailName = guardrailName ?? throw new global::System.ArgumentNullException(nameof(guardrailName));
            this.LitellmParams = litellmParams ?? throw new global::System.ArgumentNullException(nameof(litellmParams));
            this.PolicyTemplate = policyTemplate;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Guardrail" /> class.
        /// </summary>
        public Guardrail()
        {
        }

    }
}
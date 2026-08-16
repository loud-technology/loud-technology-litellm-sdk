
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchGuardrailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_info")]
        public object? GuardrailInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        public string? GuardrailName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsInput? LitellmParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchGuardrailRequest" /> class.
        /// </summary>
        /// <param name="guardrailInfo"></param>
        /// <param name="guardrailName"></param>
        /// <param name="litellmParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchGuardrailRequest(
            object? guardrailInfo,
            string? guardrailName,
            global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsInput? litellmParams)
        {
            this.GuardrailInfo = guardrailInfo;
            this.GuardrailName = guardrailName;
            this.LitellmParams = litellmParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchGuardrailRequest" /> class.
        /// </summary>
        public PatchGuardrailRequest()
        {
        }

    }
}
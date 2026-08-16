
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDeployment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public global::Loud.Technology.LiteLLM.Sdk.UpdateLiteLLMParams? LitellmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_info")]
        public global::Loud.Technology.LiteLLM.Sdk.ModelInfo? ModelInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeployment" /> class.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="modelInfo"></param>
        /// <param name="blocked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeployment(
            string? modelName,
            global::Loud.Technology.LiteLLM.Sdk.UpdateLiteLLMParams? litellmParams,
            global::Loud.Technology.LiteLLM.Sdk.ModelInfo? modelInfo,
            bool? blocked)
        {
            this.ModelName = modelName;
            this.LitellmParams = litellmParams;
            this.ModelInfo = modelInfo;
            this.Blocked = blocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeployment" /> class.
        /// </summary>
        public UpdateDeployment()
        {
        }

    }
}
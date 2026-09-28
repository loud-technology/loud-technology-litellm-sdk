
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Inline `checks` config for the resource-less Bedrock InvokeGuardrailChecks API.<br/>
    /// Include only the checks you want to run; at least one must be set.
    /// </summary>
    public sealed partial class BedrockChecksConfigModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentFilter")]
        public global::Loud.Technology.LiteLLM.Sdk.BedrockChecksContentFilterModel? ContentFilter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptAttack")]
        public global::Loud.Technology.LiteLLM.Sdk.BedrockChecksPromptAttackModel? PromptAttack { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitiveInformation")]
        public global::Loud.Technology.LiteLLM.Sdk.BedrockChecksSensitiveInformationModel? SensitiveInformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockChecksConfigModel" /> class.
        /// </summary>
        /// <param name="contentFilter"></param>
        /// <param name="promptAttack"></param>
        /// <param name="sensitiveInformation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BedrockChecksConfigModel(
            global::Loud.Technology.LiteLLM.Sdk.BedrockChecksContentFilterModel? contentFilter,
            global::Loud.Technology.LiteLLM.Sdk.BedrockChecksPromptAttackModel? promptAttack,
            global::Loud.Technology.LiteLLM.Sdk.BedrockChecksSensitiveInformationModel? sensitiveInformation)
        {
            this.ContentFilter = contentFilter;
            this.PromptAttack = promptAttack;
            this.SensitiveInformation = sensitiveInformation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockChecksConfigModel" /> class.
        /// </summary>
        public BedrockChecksConfigModel()
        {
        }

    }
}
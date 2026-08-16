
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentTypeDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentCredentialField> CredentialFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params_template")]
        public global::System.Collections.Generic.Dictionary<string, string>? LitellmParamsTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_template")]
        public string? ModelTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateInfo" /> class.
        /// </summary>
        /// <param name="agentType"></param>
        /// <param name="agentTypeDisplayName"></param>
        /// <param name="credentialFields"></param>
        /// <param name="description"></param>
        /// <param name="logoUrl"></param>
        /// <param name="litellmParamsTemplate"></param>
        /// <param name="modelTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCreateInfo(
            string agentType,
            string agentTypeDisplayName,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentCredentialField> credentialFields,
            string? description,
            string? logoUrl,
            global::System.Collections.Generic.Dictionary<string, string>? litellmParamsTemplate,
            string? modelTemplate)
        {
            this.AgentType = agentType ?? throw new global::System.ArgumentNullException(nameof(agentType));
            this.AgentTypeDisplayName = agentTypeDisplayName ?? throw new global::System.ArgumentNullException(nameof(agentTypeDisplayName));
            this.Description = description;
            this.LogoUrl = logoUrl;
            this.CredentialFields = credentialFields ?? throw new global::System.ArgumentNullException(nameof(credentialFields));
            this.LitellmParamsTemplate = litellmParamsTemplate;
            this.ModelTemplate = modelTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateInfo" /> class.
        /// </summary>
        public AgentCreateInfo()
        {
        }

    }
}
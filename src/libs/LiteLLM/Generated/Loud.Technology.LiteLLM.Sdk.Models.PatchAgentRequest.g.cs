
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAgentRequest
    {
        /// <summary>
        /// The AgentCard is a self-describing manifest for an agent.<br/>
        /// It provides essential metadata including the agent's identity, capabilities,<br/>
        /// skills, supported communication methods, and security requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_card_params")]
        public global::Loud.Technology.LiteLLM.Sdk.AgentCard? AgentCardParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_headers")]
        public global::System.Collections.Generic.IList<string>? ExtraHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public object? LitellmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.AgentObjectPermission? ObjectPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit")]
        public int? RpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_rpm_limit")]
        public int? SessionRpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_tpm_limit")]
        public int? SessionTpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? StaticHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit")]
        public int? TpmLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgentRequest" /> class.
        /// </summary>
        /// <param name="agentCardParams">
        /// The AgentCard is a self-describing manifest for an agent.<br/>
        /// It provides essential metadata including the agent's identity, capabilities,<br/>
        /// skills, supported communication methods, and security requirements.
        /// </param>
        /// <param name="agentName"></param>
        /// <param name="extraHeaders"></param>
        /// <param name="litellmParams"></param>
        /// <param name="objectPermission"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="sessionRpmLimit"></param>
        /// <param name="sessionTpmLimit"></param>
        /// <param name="staticHeaders"></param>
        /// <param name="tpmLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAgentRequest(
            global::Loud.Technology.LiteLLM.Sdk.AgentCard? agentCardParams,
            string? agentName,
            global::System.Collections.Generic.IList<string>? extraHeaders,
            object? litellmParams,
            global::Loud.Technology.LiteLLM.Sdk.AgentObjectPermission? objectPermission,
            int? rpmLimit,
            int? sessionRpmLimit,
            int? sessionTpmLimit,
            global::System.Collections.Generic.Dictionary<string, string>? staticHeaders,
            int? tpmLimit)
        {
            this.AgentCardParams = agentCardParams;
            this.AgentName = agentName;
            this.ExtraHeaders = extraHeaders;
            this.LitellmParams = litellmParams;
            this.ObjectPermission = objectPermission;
            this.RpmLimit = rpmLimit;
            this.SessionRpmLimit = sessionRpmLimit;
            this.SessionTpmLimit = sessionTpmLimit;
            this.StaticHeaders = staticHeaders;
            this.TpmLimit = tpmLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgentRequest" /> class.
        /// </summary>
        public PatchAgentRequest()
        {
        }

    }
}
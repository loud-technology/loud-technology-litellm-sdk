
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_card_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object AgentCardParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

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
        public object? ObjectPermission { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponse" /> class.
        /// </summary>
        /// <param name="agentCardParams"></param>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="extraHeaders"></param>
        /// <param name="litellmParams"></param>
        /// <param name="objectPermission"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="sessionRpmLimit"></param>
        /// <param name="sessionTpmLimit"></param>
        /// <param name="spend"></param>
        /// <param name="staticHeaders"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentResponse(
            object agentCardParams,
            string agentId,
            string agentName,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.Collections.Generic.IList<string>? extraHeaders,
            object? litellmParams,
            object? objectPermission,
            int? rpmLimit,
            int? sessionRpmLimit,
            int? sessionTpmLimit,
            double? spend,
            global::System.Collections.Generic.Dictionary<string, string>? staticHeaders,
            int? tpmLimit,
            global::System.DateTime? updatedAt,
            string? updatedBy)
        {
            this.AgentCardParams = agentCardParams ?? throw new global::System.ArgumentNullException(nameof(agentCardParams));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.ExtraHeaders = extraHeaders;
            this.LitellmParams = litellmParams;
            this.ObjectPermission = objectPermission;
            this.RpmLimit = rpmLimit;
            this.SessionRpmLimit = sessionRpmLimit;
            this.SessionTpmLimit = sessionTpmLimit;
            this.Spend = spend;
            this.StaticHeaders = staticHeaders;
            this.TpmLimit = tpmLimit;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponse" /> class.
        /// </summary>
        public AgentResponse()
        {
        }

    }
}
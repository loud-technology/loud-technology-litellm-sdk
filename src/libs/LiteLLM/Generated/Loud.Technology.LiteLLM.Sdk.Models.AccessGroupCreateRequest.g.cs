
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccessGroupCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_agent_ids")]
        public global::System.Collections.Generic.IList<string>? AccessAgentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_group_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessGroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? AccessMcpServerIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_model_names")]
        public global::System.Collections.Generic.IList<string>? AccessModelNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_key_ids")]
        public global::System.Collections.Generic.IList<string>? AssignedKeyIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_team_ids")]
        public global::System.Collections.Generic.IList<string>? AssignedTeamIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupCreateRequest" /> class.
        /// </summary>
        /// <param name="accessGroupName"></param>
        /// <param name="accessAgentIds"></param>
        /// <param name="accessMcpServerIds"></param>
        /// <param name="accessModelNames"></param>
        /// <param name="assignedKeyIds"></param>
        /// <param name="assignedTeamIds"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessGroupCreateRequest(
            string accessGroupName,
            global::System.Collections.Generic.IList<string>? accessAgentIds,
            global::System.Collections.Generic.IList<string>? accessMcpServerIds,
            global::System.Collections.Generic.IList<string>? accessModelNames,
            global::System.Collections.Generic.IList<string>? assignedKeyIds,
            global::System.Collections.Generic.IList<string>? assignedTeamIds,
            string? description)
        {
            this.AccessAgentIds = accessAgentIds;
            this.AccessGroupName = accessGroupName ?? throw new global::System.ArgumentNullException(nameof(accessGroupName));
            this.AccessMcpServerIds = accessMcpServerIds;
            this.AccessModelNames = accessModelNames;
            this.AssignedKeyIds = assignedKeyIds;
            this.AssignedTeamIds = assignedTeamIds;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupCreateRequest" /> class.
        /// </summary>
        public AccessGroupCreateRequest()
        {
        }

    }
}
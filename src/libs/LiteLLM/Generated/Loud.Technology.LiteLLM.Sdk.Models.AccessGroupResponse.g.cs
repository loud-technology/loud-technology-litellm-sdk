
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccessGroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_agent_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AccessAgentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessGroupId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AccessMcpServerIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_model_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AccessModelNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_key_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AssignedKeyIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_team_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AssignedTeamIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="AccessGroupResponse" /> class.
        /// </summary>
        /// <param name="accessAgentIds"></param>
        /// <param name="accessGroupId"></param>
        /// <param name="accessGroupName"></param>
        /// <param name="accessMcpServerIds"></param>
        /// <param name="accessModelNames"></param>
        /// <param name="assignedKeyIds"></param>
        /// <param name="assignedTeamIds"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="description"></param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessGroupResponse(
            global::System.Collections.Generic.IList<string> accessAgentIds,
            string accessGroupId,
            string accessGroupName,
            global::System.Collections.Generic.IList<string> accessMcpServerIds,
            global::System.Collections.Generic.IList<string> accessModelNames,
            global::System.Collections.Generic.IList<string> assignedKeyIds,
            global::System.Collections.Generic.IList<string> assignedTeamIds,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? createdBy,
            string? description,
            string? updatedBy)
        {
            this.AccessAgentIds = accessAgentIds ?? throw new global::System.ArgumentNullException(nameof(accessAgentIds));
            this.AccessGroupId = accessGroupId ?? throw new global::System.ArgumentNullException(nameof(accessGroupId));
            this.AccessGroupName = accessGroupName ?? throw new global::System.ArgumentNullException(nameof(accessGroupName));
            this.AccessMcpServerIds = accessMcpServerIds ?? throw new global::System.ArgumentNullException(nameof(accessMcpServerIds));
            this.AccessModelNames = accessModelNames ?? throw new global::System.ArgumentNullException(nameof(accessModelNames));
            this.AssignedKeyIds = assignedKeyIds ?? throw new global::System.ArgumentNullException(nameof(assignedKeyIds));
            this.AssignedTeamIds = assignedTeamIds ?? throw new global::System.ArgumentNullException(nameof(assignedTeamIds));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupResponse" /> class.
        /// </summary>
        public AccessGroupResponse()
        {
        }

    }
}
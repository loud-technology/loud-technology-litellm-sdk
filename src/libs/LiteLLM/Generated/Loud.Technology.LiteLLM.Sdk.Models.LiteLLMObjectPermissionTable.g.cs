
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Represents a LiteLLM_ObjectPermissionTable record
    /// </summary>
    public sealed partial class LiteLLMObjectPermissionTable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectPermissionId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<string>? McpServers { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_access_groups")]
        public global::System.Collections.Generic.IList<string>? McpAccessGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_permissions")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? McpToolPermissions { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_stores")]
        public global::System.Collections.Generic.IList<string>? VectorStores { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<string>? Agents { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_access_groups")]
        public global::System.Collections.Generic.IList<string>? AgentAccessGroups { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_toolsets")]
        public global::System.Collections.Generic.IList<string>? McpToolsets { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_tools")]
        public global::System.Collections.Generic.IList<string>? BlockedTools { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_tools")]
        public global::System.Collections.Generic.IList<string>? SearchTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_search_enabled")]
        public bool? McpToolSearchEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMObjectPermissionTable" /> class.
        /// </summary>
        /// <param name="objectPermissionId"></param>
        /// <param name="mcpServers">
        /// Default Value: []
        /// </param>
        /// <param name="mcpAccessGroups">
        /// Default Value: []
        /// </param>
        /// <param name="mcpToolPermissions"></param>
        /// <param name="vectorStores">
        /// Default Value: []
        /// </param>
        /// <param name="agents">
        /// Default Value: []
        /// </param>
        /// <param name="agentAccessGroups">
        /// Default Value: []
        /// </param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="mcpToolsets"></param>
        /// <param name="blockedTools">
        /// Default Value: []
        /// </param>
        /// <param name="searchTools">
        /// Default Value: []
        /// </param>
        /// <param name="mcpToolSearchEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMObjectPermissionTable(
            string objectPermissionId,
            global::System.Collections.Generic.IList<string>? mcpServers,
            global::System.Collections.Generic.IList<string>? mcpAccessGroups,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? mcpToolPermissions,
            global::System.Collections.Generic.IList<string>? vectorStores,
            global::System.Collections.Generic.IList<string>? agents,
            global::System.Collections.Generic.IList<string>? agentAccessGroups,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? mcpToolsets,
            global::System.Collections.Generic.IList<string>? blockedTools,
            global::System.Collections.Generic.IList<string>? searchTools,
            bool? mcpToolSearchEnabled)
        {
            this.ObjectPermissionId = objectPermissionId ?? throw new global::System.ArgumentNullException(nameof(objectPermissionId));
            this.McpServers = mcpServers;
            this.McpAccessGroups = mcpAccessGroups;
            this.McpToolPermissions = mcpToolPermissions;
            this.VectorStores = vectorStores;
            this.Agents = agents;
            this.AgentAccessGroups = agentAccessGroups;
            this.Models = models;
            this.McpToolsets = mcpToolsets;
            this.BlockedTools = blockedTools;
            this.SearchTools = searchTools;
            this.McpToolSearchEnabled = mcpToolSearchEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMObjectPermissionTable" /> class.
        /// </summary>
        public LiteLLMObjectPermissionTable()
        {
        }

    }
}
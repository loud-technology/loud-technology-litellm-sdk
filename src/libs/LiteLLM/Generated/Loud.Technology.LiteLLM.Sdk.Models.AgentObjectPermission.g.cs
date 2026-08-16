
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentObjectPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<string>? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_access_groups")]
        public global::System.Collections.Generic.IList<string>? McpAccessGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<string>? McpServers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_permissions")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? McpToolPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentObjectPermission" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="mcpAccessGroups"></param>
        /// <param name="mcpServers"></param>
        /// <param name="mcpToolPermissions"></param>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentObjectPermission(
            global::System.Collections.Generic.IList<string>? agents,
            global::System.Collections.Generic.IList<string>? mcpAccessGroups,
            global::System.Collections.Generic.IList<string>? mcpServers,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? mcpToolPermissions,
            global::System.Collections.Generic.IList<string>? models)
        {
            this.Agents = agents;
            this.McpAccessGroups = mcpAccessGroups;
            this.McpServers = mcpServers;
            this.McpToolPermissions = mcpToolPermissions;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentObjectPermission" /> class.
        /// </summary>
        public AgentObjectPermission()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPToolsetTool
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolsetTool" /> class.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="toolName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolsetTool(
            string serverId,
            string toolName)
        {
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolsetTool" /> class.
        /// </summary>
        public MCPToolsetTool()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPConnectorImportRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MCPConnectorEntry>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorEntry>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MCPConnectorEntry>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorEntry>> McpServers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPConnectorImportRequest" /> class.
        /// </summary>
        /// <param name="mcpServers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPConnectorImportRequest(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MCPConnectorEntry>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorEntry>> mcpServers)
        {
            this.McpServers = mcpServers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPConnectorImportRequest" /> class.
        /// </summary>
        public MCPConnectorImportRequest()
        {
        }

    }
}
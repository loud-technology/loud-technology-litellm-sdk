
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Safe params for public MCP servers
    /// </summary>
    public sealed partial class MCPPublicServer
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.MCPPublicServerTransportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.MCPPublicServerTransport Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec_path")]
        public string? SpecPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public global::Loud.Technology.LiteLLM.Sdk.MCPPublicServerAuthType2? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_info")]
        public object? McpInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPPublicServer" /> class.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="name"></param>
        /// <param name="transport"></param>
        /// <param name="alias"></param>
        /// <param name="serverName"></param>
        /// <param name="specPath"></param>
        /// <param name="authType"></param>
        /// <param name="mcpInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPPublicServer(
            string serverId,
            string name,
            global::Loud.Technology.LiteLLM.Sdk.MCPPublicServerTransport transport,
            string? alias,
            string? serverName,
            string? specPath,
            global::Loud.Technology.LiteLLM.Sdk.MCPPublicServerAuthType2? authType,
            object? mcpInfo)
        {
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Alias = alias;
            this.ServerName = serverName;
            this.Transport = transport;
            this.SpecPath = specPath;
            this.AuthType = authType;
            this.McpInfo = mcpInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPPublicServer" /> class.
        /// </summary>
        public MCPPublicServer()
        {
        }

    }
}
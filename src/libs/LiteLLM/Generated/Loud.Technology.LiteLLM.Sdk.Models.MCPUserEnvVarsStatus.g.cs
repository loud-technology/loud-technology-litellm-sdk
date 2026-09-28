
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Per-user env var status for a single MCP server.
    /// </summary>
    public sealed partial class MCPUserEnvVarsStatus
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing_count")]
        public int? MissingCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPUserEnvVarSpec>? Required { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup_url")]
        public string? SetupUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserEnvVarsStatus" /> class.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="alias"></param>
        /// <param name="missingCount">
        /// Default Value: 0
        /// </param>
        /// <param name="required"></param>
        /// <param name="serverName"></param>
        /// <param name="setupUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPUserEnvVarsStatus(
            string serverId,
            string? alias,
            int? missingCount,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPUserEnvVarSpec>? required,
            string? serverName,
            string? setupUrl)
        {
            this.Alias = alias;
            this.MissingCount = missingCount;
            this.Required = required;
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
            this.ServerName = serverName;
            this.SetupUrl = setupUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserEnvVarsStatus" /> class.
        /// </summary>
        public MCPUserEnvVarsStatus()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MakeMCPServersPublicRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> McpServerIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeMCPServersPublicRequest" /> class.
        /// </summary>
        /// <param name="mcpServerIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MakeMCPServersPublicRequest(
            global::System.Collections.Generic.IList<string> mcpServerIds)
        {
            this.McpServerIds = mcpServerIds ?? throw new global::System.ArgumentNullException(nameof(mcpServerIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeMCPServersPublicRequest" /> class.
        /// </summary>
        public MakeMCPServersPublicRequest()
        {
        }

    }
}
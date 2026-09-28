#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Import Mcp Servers<br/>
        /// Bulk-import MCP connectors from Anthropic mcpServers or mcp_servers JSON
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportResponse> ImportMcpServersV1McpServerImportPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Mcp Servers<br/>
        /// Bulk-import MCP connectors from Anthropic mcpServers or mcp_servers JSON
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportResponse>> ImportMcpServersV1McpServerImportPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Mcp Servers<br/>
        /// Bulk-import MCP connectors from Anthropic mcpServers or mcp_servers JSON
        /// </summary>
        /// <param name="mcpServers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportResponse> ImportMcpServersV1McpServerImportPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MCPConnectorEntry>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorEntry>> mcpServers,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
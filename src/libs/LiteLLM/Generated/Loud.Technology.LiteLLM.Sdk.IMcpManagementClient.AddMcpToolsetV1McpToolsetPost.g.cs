#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Add Mcp Toolset<br/>
        /// Create a new MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddMcpToolsetV1McpToolsetPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewMCPToolsetRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Mcp Toolset<br/>
        /// Create a new MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AddMcpToolsetV1McpToolsetPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewMCPToolsetRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Mcp Toolset<br/>
        /// Create a new MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="description"></param>
        /// <param name="tools">
        /// Default Value: []
        /// </param>
        /// <param name="toolsetName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddMcpToolsetV1McpToolsetPostAsync(
            string toolsetName,
            string? litellmChangedBy = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPToolsetTool>? tools = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
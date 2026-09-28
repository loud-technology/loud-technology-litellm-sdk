#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Edit Mcp Toolset<br/>
        /// Update an existing MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EditMcpToolsetV1McpToolsetPutAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateMCPToolsetRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Mcp Toolset<br/>
        /// Update an existing MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> EditMcpToolsetV1McpToolsetPutAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateMCPToolsetRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Mcp Toolset<br/>
        /// Update an existing MCP toolset (admin only)
        /// </summary>
        /// <param name="litellmChangedBy"></param>
        /// <param name="description"></param>
        /// <param name="tools"></param>
        /// <param name="toolsetId"></param>
        /// <param name="toolsetName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> EditMcpToolsetV1McpToolsetPutAsync(
            string toolsetId,
            string? litellmChangedBy = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPToolsetTool>? tools = default,
            string? toolsetName = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
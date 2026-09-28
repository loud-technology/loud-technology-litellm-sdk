#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Remove Mcp Toolset<br/>
        /// Delete an MCP toolset (admin only)
        /// </summary>
        /// <param name="toolsetId"></param>
        /// <param name="litellmChangedBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveMcpToolsetV1McpToolsetToolsetIdDeleteAsync(
            string toolsetId,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Mcp Toolset<br/>
        /// Delete an MCP toolset (admin only)
        /// </summary>
        /// <param name="toolsetId"></param>
        /// <param name="litellmChangedBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> RemoveMcpToolsetV1McpToolsetToolsetIdDeleteAsResponseAsync(
            string toolsetId,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
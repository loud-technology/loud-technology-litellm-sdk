#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Discover Mcp Servers<br/>
        /// Returns a curated list of well-known MCP servers for discovery UI
        /// </summary>
        /// <param name="query">
        /// Search filter for server names and descriptions
        /// </param>
        /// <param name="category">
        /// Filter by category
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DiscoverMcpServersV1McpDiscoverGetAsync(
            string? query = default,
            string? category = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Discover Mcp Servers<br/>
        /// Returns a curated list of well-known MCP servers for discovery UI
        /// </summary>
        /// <param name="query">
        /// Search filter for server names and descriptions
        /// </param>
        /// <param name="category">
        /// Filter by category
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DiscoverMcpServersV1McpDiscoverGetAsResponseAsync(
            string? query = default,
            string? category = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
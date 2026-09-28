#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Fetch All Mcp Servers<br/>
        /// Returns the mcp server list with associated teams
        /// </summary>
        /// <param name="teamId">
        /// Filter MCP servers by team scope. When provided, returns only servers the team has access to plus globally available (allow_all_keys) servers. Used by the Create Key UI to show team-scoped MCP servers.
        /// </param>
        /// <param name="connectedAppView">
        /// Annotate each returned server with connected_app_reachable: whether a connected app authorized by the calling user (a gateway OAuth session) is served this server on the aggregate MCP endpoint.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable>> FetchAllMcpServersV1McpServerGetAsync(
            string? teamId = default,
            bool? connectedAppView = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch All Mcp Servers<br/>
        /// Returns the mcp server list with associated teams
        /// </summary>
        /// <param name="teamId">
        /// Filter MCP servers by team scope. When provided, returns only servers the team has access to plus globally available (allow_all_keys) servers. Used by the Create Key UI to show team-scoped MCP servers.
        /// </param>
        /// <param name="connectedAppView">
        /// Annotate each returned server with connected_app_reachable: whether a connected app authorized by the calling user (a gateway OAuth session) is served this server on the aggregate MCP endpoint.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable>>> FetchAllMcpServersV1McpServerGetAsResponseAsync(
            string? teamId = default,
            bool? connectedAppView = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
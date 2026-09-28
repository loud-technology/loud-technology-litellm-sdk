#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpByokOauthClient
    {
        /// <summary>
        /// Oauth Protected Resource Mcp Standard<br/>
        /// OAuth protected resource discovery endpoint using standard MCP URL pattern.<br/>
        /// Standard pattern: /mcp/{server_name}<br/>
        /// Discovery path: /.well-known/oauth-protected-resource/mcp/{server_name}<br/>
        /// This endpoint is compliant with MCP specification and works with standard<br/>
        /// MCP clients like mcp-inspector and VSCode Copilot.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OauthProtectedResourceMcpStandardWellKnownOauthProtectedResourceMcpMcpServerNameGetAsync(
            string mcpServerName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Oauth Protected Resource Mcp Standard<br/>
        /// OAuth protected resource discovery endpoint using standard MCP URL pattern.<br/>
        /// Standard pattern: /mcp/{server_name}<br/>
        /// Discovery path: /.well-known/oauth-protected-resource/mcp/{server_name}<br/>
        /// This endpoint is compliant with MCP specification and works with standard<br/>
        /// MCP clients like mcp-inspector and VSCode Copilot.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OauthProtectedResourceMcpStandardWellKnownOauthProtectedResourceMcpMcpServerNameGetAsResponseAsync(
            string mcpServerName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
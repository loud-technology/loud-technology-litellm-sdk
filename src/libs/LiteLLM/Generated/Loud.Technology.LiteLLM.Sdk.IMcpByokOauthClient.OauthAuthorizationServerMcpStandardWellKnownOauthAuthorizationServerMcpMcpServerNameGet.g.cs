#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpByokOauthClient
    {
        /// <summary>
        /// Oauth Authorization Server Mcp Standard<br/>
        /// OAuth authorization server discovery endpoint using standard MCP URL pattern.<br/>
        /// Standard pattern: /mcp/{server_name}<br/>
        /// Discovery path: /.well-known/oauth-authorization-server/mcp/{server_name}
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OauthAuthorizationServerMcpStandardWellKnownOauthAuthorizationServerMcpMcpServerNameGetAsync(
            string mcpServerName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Oauth Authorization Server Mcp Standard<br/>
        /// OAuth authorization server discovery endpoint using standard MCP URL pattern.<br/>
        /// Standard pattern: /mcp/{server_name}<br/>
        /// Discovery path: /.well-known/oauth-authorization-server/mcp/{server_name}
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OauthAuthorizationServerMcpStandardWellKnownOauthAuthorizationServerMcpMcpServerNameGetAsResponseAsync(
            string mcpServerName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
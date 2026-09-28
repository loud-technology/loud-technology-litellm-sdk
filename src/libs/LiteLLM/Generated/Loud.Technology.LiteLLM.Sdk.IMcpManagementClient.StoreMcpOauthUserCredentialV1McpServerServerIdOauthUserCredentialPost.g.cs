#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Store Mcp Oauth User Credential<br/>
        /// Store the calling user's OAuth2 token for an OpenAPI MCP server
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.MCPOAuthUserCredentialStatus> StoreMcpOauthUserCredentialV1McpServerServerIdOauthUserCredentialPostAsync(
            string serverId,

            global::Loud.Technology.LiteLLM.Sdk.MCPOAuthUserCredentialRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store Mcp Oauth User Credential<br/>
        /// Store the calling user's OAuth2 token for an OpenAPI MCP server
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.MCPOAuthUserCredentialStatus>> StoreMcpOauthUserCredentialV1McpServerServerIdOauthUserCredentialPostAsResponseAsync(
            string serverId,

            global::Loud.Technology.LiteLLM.Sdk.MCPOAuthUserCredentialRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store Mcp Oauth User Credential<br/>
        /// Store the calling user's OAuth2 token for an OpenAPI MCP server
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="accessToken"></param>
        /// <param name="expiresIn"></param>
        /// <param name="refreshToken"></param>
        /// <param name="scopes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.MCPOAuthUserCredentialStatus> StoreMcpOauthUserCredentialV1McpServerServerIdOauthUserCredentialPostAsync(
            string serverId,
            string accessToken,
            int? expiresIn = default,
            string? refreshToken = default,
            global::System.Collections.Generic.IList<string>? scopes = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
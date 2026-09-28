#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Delete Mcp Oauth User Credential<br/>
        /// Revoke the calling user's stored OAuth2 token for an MCP server. A proxy admin may pass user_id to revoke another user's stored token.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.MCPOAuthUserCredentialStatus> DeleteMcpOauthUserCredentialV1McpServerServerIdOauthUserCredentialDeleteAsync(
            string serverId,
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Mcp Oauth User Credential<br/>
        /// Revoke the calling user's stored OAuth2 token for an MCP server. A proxy admin may pass user_id to revoke another user's stored token.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.MCPOAuthUserCredentialStatus>> DeleteMcpOauthUserCredentialV1McpServerServerIdOauthUserCredentialDeleteAsResponseAsync(
            string serverId,
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
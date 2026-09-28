#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Delete Mcp User Credential<br/>
        /// Delete the calling user's stored API key for a BYOK MCP server. A proxy admin may pass user_id to revoke another user's stored key.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.MCPUserCredentialResponse> DeleteMcpUserCredentialV1McpServerServerIdUserCredentialDeleteAsync(
            string serverId,
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Mcp User Credential<br/>
        /// Delete the calling user's stored API key for a BYOK MCP server. A proxy admin may pass user_id to revoke another user's stored key.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.MCPUserCredentialResponse>> DeleteMcpUserCredentialV1McpServerServerIdUserCredentialDeleteAsResponseAsync(
            string serverId,
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
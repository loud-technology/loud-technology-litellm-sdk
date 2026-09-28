#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpDiscoverableClient
    {
        /// <summary>
        /// Token Endpoint<br/>
        /// Accept the authorization code from client and exchange it for OAuth token.<br/>
        /// Supports PKCE flow by forwarding code_verifier to upstream provider.<br/>
        /// 1. Call the token endpoint with PKCE parameters<br/>
        /// 2. Store the user's token in the db - and generate a LiteLLM virtual key<br/>
        /// 3. Return the token<br/>
        /// 4. Return a virtual key in this response
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TokenEndpointMcpServerNameTokenPostAsync(
            string? mcpServerName,

            global::Loud.Technology.LiteLLM.Sdk.BodyTokenEndpointMcpServerNameTokenPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Token Endpoint<br/>
        /// Accept the authorization code from client and exchange it for OAuth token.<br/>
        /// Supports PKCE flow by forwarding code_verifier to upstream provider.<br/>
        /// 1. Call the token endpoint with PKCE parameters<br/>
        /// 2. Store the user's token in the db - and generate a LiteLLM virtual key<br/>
        /// 3. Return the token<br/>
        /// 4. Return a virtual key in this response
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TokenEndpointMcpServerNameTokenPostAsResponseAsync(
            string? mcpServerName,

            global::Loud.Technology.LiteLLM.Sdk.BodyTokenEndpointMcpServerNameTokenPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Token Endpoint<br/>
        /// Accept the authorization code from client and exchange it for OAuth token.<br/>
        /// Supports PKCE flow by forwarding code_verifier to upstream provider.<br/>
        /// 1. Call the token endpoint with PKCE parameters<br/>
        /// 2. Store the user's token in the db - and generate a LiteLLM virtual key<br/>
        /// 3. Return the token<br/>
        /// 4. Return a virtual key in this response
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="code"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="grantType"></param>
        /// <param name="redirectUri"></param>
        /// <param name="refreshToken"></param>
        /// <param name="requestedTokenType"></param>
        /// <param name="resource"></param>
        /// <param name="scope"></param>
        /// <param name="subjectToken"></param>
        /// <param name="subjectTokenType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TokenEndpointMcpServerNameTokenPostAsync(
            string? mcpServerName,
            string clientId,
            string grantType,
            string? clientSecret = default,
            string? code = default,
            string? codeVerifier = default,
            string? redirectUri = default,
            string? refreshToken = default,
            string? requestedTokenType = default,
            string? resource = default,
            string? scope = default,
            string? subjectToken = default,
            string? subjectTokenType = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
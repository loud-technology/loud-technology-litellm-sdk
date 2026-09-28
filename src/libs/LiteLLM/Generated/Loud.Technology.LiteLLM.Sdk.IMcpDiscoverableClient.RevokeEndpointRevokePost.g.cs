#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpDiscoverableClient
    {
        /// <summary>
        /// Revoke Endpoint<br/>
        /// RFC 7009 revocation for the gateway's refresh tokens (``lite logout``): 200 for a known<br/>
        /// client whatever the token's state, 503 when the shared single-use record cannot be written;<br/>
        /// access tokens expire on their own.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RevokeEndpointRevokePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyRevokeEndpointRevokePost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Endpoint<br/>
        /// RFC 7009 revocation for the gateway's refresh tokens (``lite logout``): 200 for a known<br/>
        /// client whatever the token's state, 503 when the shared single-use record cannot be written;<br/>
        /// access tokens expire on their own.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> RevokeEndpointRevokePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyRevokeEndpointRevokePost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke Endpoint<br/>
        /// RFC 7009 revocation for the gateway's refresh tokens (``lite logout``): 200 for a known<br/>
        /// client whatever the token's state, 503 when the shared single-use record cannot be written;<br/>
        /// access tokens expire on their own.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RevokeEndpointRevokePostAsync(
            string clientId,
            string token,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
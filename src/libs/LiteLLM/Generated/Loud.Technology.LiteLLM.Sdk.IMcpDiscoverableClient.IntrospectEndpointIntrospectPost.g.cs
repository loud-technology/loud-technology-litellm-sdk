#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpDiscoverableClient
    {
        /// <summary>
        /// Introspect Endpoint<br/>
        /// RFC 7662 introspection for gateway-issued session tokens (``llm_session_`` /<br/>
        /// ``llm_srefresh_``), so an external gateway can validate them without the signing<br/>
        /// secret. The caller authenticates with a LiteLLM virtual key (section 2.1, enforced by<br/>
        /// the route dependency); any token the gateway cannot vouch for answers<br/>
        /// ``{"active": false}`` with no further detail.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> IntrospectEndpointIntrospectPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyIntrospectEndpointIntrospectPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Introspect Endpoint<br/>
        /// RFC 7662 introspection for gateway-issued session tokens (``llm_session_`` /<br/>
        /// ``llm_srefresh_``), so an external gateway can validate them without the signing<br/>
        /// secret. The caller authenticates with a LiteLLM virtual key (section 2.1, enforced by<br/>
        /// the route dependency); any token the gateway cannot vouch for answers<br/>
        /// ``{"active": false}`` with no further detail.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> IntrospectEndpointIntrospectPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyIntrospectEndpointIntrospectPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Introspect Endpoint<br/>
        /// RFC 7662 introspection for gateway-issued session tokens (``llm_session_`` /<br/>
        /// ``llm_srefresh_``), so an external gateway can validate them without the signing<br/>
        /// secret. The caller authenticates with a LiteLLM virtual key (section 2.1, enforced by<br/>
        /// the route dependency); any token the gateway cannot vouch for answers<br/>
        /// ``{"active": false}`` with no further detail.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> IntrospectEndpointIntrospectPostAsync(
            string token,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
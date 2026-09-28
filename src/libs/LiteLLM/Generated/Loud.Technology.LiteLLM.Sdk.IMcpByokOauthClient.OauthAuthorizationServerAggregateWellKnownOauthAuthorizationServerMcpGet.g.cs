#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpByokOauthClient
    {
        /// <summary>
        /// Oauth Authorization Server Aggregate<br/>
        /// OAuth authorization server discovery for the aggregate /mcp endpoint, the RFC 8414<br/>
        /// path-inserted form for a client that treats {base}/mcp as its authorization base URL.<br/>
        /// The single-segment /mcp is reserved for the aggregate so the discovery chain stays<br/>
        /// consistent: the aggregate protected-resource document advertises {base}/mcp as its<br/>
        /// authorization server, so the document served here must have issuer {base}/mcp. A server<br/>
        /// literally named ``mcp`` therefore does not take this route; it keeps its standard<br/>
        /// two-segment discovery at /.well-known/oauth-authorization-server/mcp/mcp. Letting the<br/>
        /// per-server row win here instead would serve an issuer of {base} against a resource that<br/>
        /// advertised {base}/mcp, which fails the RFC 8414 issuer check and breaks the front door.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OauthAuthorizationServerAggregateWellKnownOauthAuthorizationServerMcpGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Oauth Authorization Server Aggregate<br/>
        /// OAuth authorization server discovery for the aggregate /mcp endpoint, the RFC 8414<br/>
        /// path-inserted form for a client that treats {base}/mcp as its authorization base URL.<br/>
        /// The single-segment /mcp is reserved for the aggregate so the discovery chain stays<br/>
        /// consistent: the aggregate protected-resource document advertises {base}/mcp as its<br/>
        /// authorization server, so the document served here must have issuer {base}/mcp. A server<br/>
        /// literally named ``mcp`` therefore does not take this route; it keeps its standard<br/>
        /// two-segment discovery at /.well-known/oauth-authorization-server/mcp/mcp. Letting the<br/>
        /// per-server row win here instead would serve an issuer of {base} against a resource that<br/>
        /// advertised {base}/mcp, which fails the RFC 8414 issuer check and breaks the front door.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OauthAuthorizationServerAggregateWellKnownOauthAuthorizationServerMcpGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
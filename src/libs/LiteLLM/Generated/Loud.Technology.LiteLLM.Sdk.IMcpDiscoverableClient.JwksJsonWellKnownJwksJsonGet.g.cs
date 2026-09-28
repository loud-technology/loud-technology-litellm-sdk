#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpDiscoverableClient
    {
        /// <summary>
        /// Jwks Json<br/>
        /// JSON Web Key Set endpoint.<br/>
        /// Returns the RSA public key used by MCPJWTSigner to sign outbound MCP tokens.<br/>
        /// MCP servers and gateways use this endpoint to verify liteLLM-issued JWTs.<br/>
        /// Returns an empty key set if MCPJWTSigner is not configured.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> JwksJsonWellKnownJwksJsonGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Jwks Json<br/>
        /// JSON Web Key Set endpoint.<br/>
        /// Returns the RSA public key used by MCPJWTSigner to sign outbound MCP tokens.<br/>
        /// MCP servers and gateways use this endpoint to verify liteLLM-issued JWTs.<br/>
        /// Returns an empty key set if MCPJWTSigner is not configured.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> JwksJsonWellKnownJwksJsonGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
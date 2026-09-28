#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get Supported Endpoints<br/>
        /// Return the list of LiteLLM proxy endpoints and which providers support each one.<br/>
        /// Reads from the bundled local backup file. Result is cached in-process for<br/>
        /// the lifetime of the server process.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SupportedEndpointsResponse> GetSupportedEndpointsPublicEndpointsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Supported Endpoints<br/>
        /// Return the list of LiteLLM proxy endpoints and which providers support each one.<br/>
        /// Reads from the bundled local backup file. Result is cached in-process for<br/>
        /// the lifetime of the server process.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SupportedEndpointsResponse>> GetSupportedEndpointsPublicEndpointsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
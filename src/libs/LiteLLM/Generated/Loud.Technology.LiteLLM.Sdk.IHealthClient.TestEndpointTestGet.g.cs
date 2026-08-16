#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Test Endpoint<br/>
        /// [DEPRECATED] use `/health/liveliness` instead.<br/>
        /// A test endpoint that pings the proxy server to check if it's healthy.<br/>
        /// Parameters:<br/>
        ///     request (Request): The incoming request.<br/>
        /// Returns:<br/>
        ///     dict: A dictionary containing the route of the request URL.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestEndpointTestGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Endpoint<br/>
        /// [DEPRECATED] use `/health/liveliness` instead.<br/>
        /// A test endpoint that pings the proxy server to check if it's healthy.<br/>
        /// Parameters:<br/>
        ///     request (Request): The incoming request.<br/>
        /// Returns:<br/>
        ///     dict: A dictionary containing the route of the request URL.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestEndpointTestGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
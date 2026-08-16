#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IWatsonxPassThroughClient
    {
        /// <summary>
        /// Watsonx Proxy Route<br/>
        /// Watsonx pass-through endpoint.<br/>
        /// Allows using Watsonx APIs with automatic IAM token management and version parameter injection.<br/>
        /// Example:<br/>
        ///     POST /watsonx/ml/v1/text/tokenization<br/>
        ///     POST /watsonx/ml/v1/text/generation
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> WatsonxProxyRouteWatsonxEndpointPutAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Watsonx Proxy Route<br/>
        /// Watsonx pass-through endpoint.<br/>
        /// Allows using Watsonx APIs with automatic IAM token management and version parameter injection.<br/>
        /// Example:<br/>
        ///     POST /watsonx/ml/v1/text/tokenization<br/>
        ///     POST /watsonx/ml/v1/text/generation
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> WatsonxProxyRouteWatsonxEndpointPutAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
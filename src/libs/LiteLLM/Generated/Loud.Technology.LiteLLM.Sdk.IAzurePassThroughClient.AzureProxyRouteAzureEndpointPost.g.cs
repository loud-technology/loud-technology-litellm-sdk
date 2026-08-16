#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAzurePassThroughClient
    {
        /// <summary>
        /// Azure Proxy Route<br/>
        /// Call any azure endpoint using the proxy.<br/>
        /// Just use `{PROXY_BASE_URL}/azure/{endpoint:path}`<br/>
        /// Checks if the deployment id in the url is a litellm model name. If so, it will route using the llm_router.allm_passthrough_route.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AzureProxyRouteAzureEndpointPostAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Azure Proxy Route<br/>
        /// Call any azure endpoint using the proxy.<br/>
        /// Just use `{PROXY_BASE_URL}/azure/{endpoint:path}`<br/>
        /// Checks if the deployment id in the url is a litellm model name. If so, it will route using the llm_router.allm_passthrough_route.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AzureProxyRouteAzureEndpointPostAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
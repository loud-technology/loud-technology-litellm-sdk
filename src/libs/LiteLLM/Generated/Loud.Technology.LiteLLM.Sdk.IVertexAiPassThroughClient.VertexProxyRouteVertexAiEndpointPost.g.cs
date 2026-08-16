#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVertexAiPassThroughClient
    {
        /// <summary>
        /// Vertex Proxy Route<br/>
        /// Call LiteLLM proxy via Vertex AI SDK.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/vertex_ai)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VertexProxyRouteVertexAiEndpointPostAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vertex Proxy Route<br/>
        /// Call LiteLLM proxy via Vertex AI SDK.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/vertex_ai)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VertexProxyRouteVertexAiEndpointPostAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
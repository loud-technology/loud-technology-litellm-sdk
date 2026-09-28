#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILangfusePassthroughClient
    {
        /// <summary>
        /// Langfuse Proxy Route<br/>
        /// Call Langfuse via LiteLLM proxy. Works with Langfuse SDK.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/langfuse)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LangfuseProxyRouteLangfuseEndpointPatchAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Langfuse Proxy Route<br/>
        /// Call Langfuse via LiteLLM proxy. Works with Langfuse SDK.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/langfuse)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> LangfuseProxyRouteLangfuseEndpointPatchAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
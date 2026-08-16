#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBedrockPassThroughClient
    {
        /// <summary>
        /// Bedrock Proxy Route<br/>
        /// This is the v1 passthrough for Bedrock.<br/>
        /// V2 is handled by the `/bedrock/v2` endpoint.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/bedrock)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BedrockProxyRouteBedrockEndpointGetAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bedrock Proxy Route<br/>
        /// This is the v1 passthrough for Bedrock.<br/>
        /// V2 is handled by the `/bedrock/v2` endpoint.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/bedrock)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> BedrockProxyRouteBedrockEndpointGetAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILlmPassthroughClient
    {
        /// <summary>
        /// Comprehend Medical Proxy Route<br/>
        /// Pass-through for Amazon Comprehend Medical, e.g. `POST /comprehendmedical/DetectEntitiesV2`.<br/>
        /// The request body is forwarded as-is to the AWS JSON 1.1 API and signed with SigV4<br/>
        /// using the proxy's AWS credentials.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/comprehend_medical)
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ComprehendMedicalProxyRouteComprehendmedicalOperationPostAsync(
            string operation,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Comprehend Medical Proxy Route<br/>
        /// Pass-through for Amazon Comprehend Medical, e.g. `POST /comprehendmedical/DetectEntitiesV2`.<br/>
        /// The request body is forwarded as-is to the AWS JSON 1.1 API and signed with SigV4<br/>
        /// using the proxy's AWS credentials.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/comprehend_medical)
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ComprehendMedicalProxyRouteComprehendmedicalOperationPostAsResponseAsync(
            string operation,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
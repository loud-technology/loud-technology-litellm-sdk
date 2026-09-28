#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILlmPassthroughClient
    {
        /// <summary>
        /// Nvidia Nim Proxy Route<br/>
        /// Relay a native NVIDIA NIM request through a LiteLLM model group.<br/>
        /// `{PROXY_BASE_URL}/nvidia_nim/{model_group}/v1/infer` forwards the body unchanged to the deployment's<br/>
        /// `api_base`, so object detection and OCR NIMs whose payload carries no `model` field still go through<br/>
        /// virtual key auth, model access checks, and spend logging.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> NvidiaNimProxyRouteNvidiaNimEndpointPutAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Nvidia Nim Proxy Route<br/>
        /// Relay a native NVIDIA NIM request through a LiteLLM model group.<br/>
        /// `{PROXY_BASE_URL}/nvidia_nim/{model_group}/v1/infer` forwards the body unchanged to the deployment's<br/>
        /// `api_base`, so object detection and OCR NIMs whose payload carries no `model` field still go through<br/>
        /// virtual key auth, model access checks, and spend logging.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> NvidiaNimProxyRouteNvidiaNimEndpointPutAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
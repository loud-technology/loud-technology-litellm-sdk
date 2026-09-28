#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILlmPassthroughClient
    {
        /// <summary>
        /// Transcribe Sdk Proxy Route<br/>
        /// AWS-SDK-shaped pass-through for Amazon Transcribe: point the SDK's `endpoint_url`<br/>
        /// at `/transcribe` and the operation is read from the `X-Amz-Target` header, per the<br/>
        /// AWS JSON 1.1 protocol.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/transcribe)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TranscribeSdkProxyRouteTranscribePostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe Sdk Proxy Route<br/>
        /// AWS-SDK-shaped pass-through for Amazon Transcribe: point the SDK's `endpoint_url`<br/>
        /// at `/transcribe` and the operation is read from the `X-Amz-Target` header, per the<br/>
        /// AWS JSON 1.1 protocol.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/transcribe)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TranscribeSdkProxyRouteTranscribePostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
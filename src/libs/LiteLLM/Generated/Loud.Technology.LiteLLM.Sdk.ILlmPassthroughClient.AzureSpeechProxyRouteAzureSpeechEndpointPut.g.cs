#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILlmPassthroughClient
    {
        /// <summary>
        /// Azure Speech Proxy Route<br/>
        /// Pass-through for the Azure AI Speech REST APIs (speech to text), e.g.<br/>
        /// `POST /azure_speech/speech/recognition/conversation/cognitiveservices/v1?language=en-US`<br/>
        /// with the raw audio as the body, or `POST /azure_speech/speechtotext/v3.2/transcriptions`.<br/>
        /// The body is forwarded byte for byte and the proxy injects its own<br/>
        /// `Ocp-Apim-Subscription-Key`; the caller's `Authorization` header is the LiteLLM key<br/>
        /// and is never forwarded.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/azure_speech)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AzureSpeechProxyRouteAzureSpeechEndpointPutAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Azure Speech Proxy Route<br/>
        /// Pass-through for the Azure AI Speech REST APIs (speech to text), e.g.<br/>
        /// `POST /azure_speech/speech/recognition/conversation/cognitiveservices/v1?language=en-US`<br/>
        /// with the raw audio as the body, or `POST /azure_speech/speechtotext/v3.2/transcriptions`.<br/>
        /// The body is forwarded byte for byte and the proxy injects its own<br/>
        /// `Ocp-Apim-Subscription-Key`; the caller's `Authorization` header is the LiteLLM key<br/>
        /// and is never forwarded.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/azure_speech)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AzureSpeechProxyRouteAzureSpeechEndpointPutAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
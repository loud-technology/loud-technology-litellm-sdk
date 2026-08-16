#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AudioTranscriptionsAudioTranscriptionsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyAudioTranscriptionsAudioTranscriptionsPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AudioTranscriptionsAudioTranscriptionsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyAudioTranscriptionsAudioTranscriptionsPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AudioTranscriptionsAudioTranscriptionsPostAsync(
            byte[] file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AudioTranscriptionsAudioTranscriptionsPostAsync(
            global::System.IO.Stream file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Transcriptions<br/>
        /// Same params as:<br/>
        /// https://platform.openai.com/docs/api-reference/audio/createTranscription?lang=curl
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AudioTranscriptionsAudioTranscriptionsPostAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
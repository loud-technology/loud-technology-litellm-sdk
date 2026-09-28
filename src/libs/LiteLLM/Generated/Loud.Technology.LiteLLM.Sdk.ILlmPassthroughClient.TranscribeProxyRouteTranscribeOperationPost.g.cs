#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILlmPassthroughClient
    {
        /// <summary>
        /// Transcribe Proxy Route<br/>
        /// Pass-through for the Amazon Transcribe API, e.g. `POST /transcribe/StartTranscriptionJob`.<br/>
        /// The request body is forwarded to the AWS JSON 1.1 API and signed with SigV4 using the<br/>
        /// proxy's AWS credentials. Standard jobs are tagged with the calling key's owner so that<br/>
        /// only that owner (or a proxy admin) can read or delete them, and keys other than proxy<br/>
        /// admins may only read media from and write transcripts to the S3 buckets listed in<br/>
        /// `general_settings.transcribe_media_buckets`; account-wide operations<br/>
        /// such as ListTranscriptionJobs are limited to proxy admins. Streaming transcription<br/>
        /// (`transcribestreaming`) uses a separate HTTP/2 event-stream protocol and is not served<br/>
        /// by this route.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/transcribe)
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TranscribeProxyRouteTranscribeOperationPostAsync(
            string operation,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe Proxy Route<br/>
        /// Pass-through for the Amazon Transcribe API, e.g. `POST /transcribe/StartTranscriptionJob`.<br/>
        /// The request body is forwarded to the AWS JSON 1.1 API and signed with SigV4 using the<br/>
        /// proxy's AWS credentials. Standard jobs are tagged with the calling key's owner so that<br/>
        /// only that owner (or a proxy admin) can read or delete them, and keys other than proxy<br/>
        /// admins may only read media from and write transcripts to the S3 buckets listed in<br/>
        /// `general_settings.transcribe_media_buckets`; account-wide operations<br/>
        /// such as ListTranscriptionJobs are limited to proxy admins. Streaming transcription<br/>
        /// (`transcribestreaming`) uses a separate HTTP/2 event-stream protocol and is not served<br/>
        /// by this route.<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/transcribe)
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TranscribeProxyRouteTranscribeOperationPostAsResponseAsync(
            string operation,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create Realtime Transcription Session<br/>
        /// Create an ephemeral Realtime transcription session<br/>
        /// (POST /v1/realtime/transcription_sessions) for the WebRTC/WebSocket flow.<br/>
        /// Mirrors the client_secrets route but targets the transcription_sessions<br/>
        /// endpoint and encrypts the ephemeral key returned under `client_secret.value`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RealtimeTranscriptionSessionResponse> CreateRealtimeTranscriptionSessionRealtimeTranscriptionSessionsPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Realtime Transcription Session<br/>
        /// Create an ephemeral Realtime transcription session<br/>
        /// (POST /v1/realtime/transcription_sessions) for the WebRTC/WebSocket flow.<br/>
        /// Mirrors the client_secrets route but targets the transcription_sessions<br/>
        /// endpoint and encrypts the ephemeral key returned under `client_secret.value`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RealtimeTranscriptionSessionResponse>> CreateRealtimeTranscriptionSessionRealtimeTranscriptionSessionsPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
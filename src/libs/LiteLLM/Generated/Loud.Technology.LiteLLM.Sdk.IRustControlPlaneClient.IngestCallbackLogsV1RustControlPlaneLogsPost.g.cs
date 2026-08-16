#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IRustControlPlaneClient
    {
        /// <summary>
        /// Ingest Callback Logs<br/>
        /// Replay a batch of finished logging payloads through the callback fan-out.<br/>
        /// Admin-only: the payloads write spend logs and trigger every callback, so this<br/>
        /// is a trusted internal route, not a public surface.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CallbackLogsResponse> IngestCallbackLogsV1RustControlPlaneLogsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CallbackLogsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest Callback Logs<br/>
        /// Replay a batch of finished logging payloads through the callback fan-out.<br/>
        /// Admin-only: the payloads write spend logs and trigger every callback, so this<br/>
        /// is a trusted internal route, not a public surface.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CallbackLogsResponse>> IngestCallbackLogsV1RustControlPlaneLogsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CallbackLogsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ingest Callback Logs<br/>
        /// Replay a batch of finished logging payloads through the callback fan-out.<br/>
        /// Admin-only: the payloads write spend logs and trigger every callback, so this<br/>
        /// is a trusted internal route, not a public surface.
        /// </summary>
        /// <param name="records"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CallbackLogsResponse> IngestCallbackLogsV1RustControlPlaneLogsPostAsync(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CallbackLogRecord> records,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
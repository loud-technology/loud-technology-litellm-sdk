#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAutoRouterClient
    {
        /// <summary>
        /// Get Auto Router Session<br/>
        /// One auto-routed session, for the key that ran it: the model its last turn was routed to and the<br/>
        /// session's spend against the router's savings baseline. Built for a coding agent's status line<br/>
        /// or stop hook, so any virtual key may call it and only ever sees rows written under its own<br/>
        /// key hash. Reads the LiteLLM_AutoRouterSession rollup, which the asynchronous spend flush<br/>
        /// fills a moment after each turn; a session with no flushed auto-routed turn yet is a 404. The<br/>
        /// id is bounded the way the writer bounded it, so an oversized client id still finds its row.
        /// </summary>
        /// <param name="sessionId">
        /// The client session id (x-*-session-id header) the turns were sent under
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoRouterSessionResponse> GetAutoRouterSessionAutoRouterSessionGetAsync(
            string sessionId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Auto Router Session<br/>
        /// One auto-routed session, for the key that ran it: the model its last turn was routed to and the<br/>
        /// session's spend against the router's savings baseline. Built for a coding agent's status line<br/>
        /// or stop hook, so any virtual key may call it and only ever sees rows written under its own<br/>
        /// key hash. Reads the LiteLLM_AutoRouterSession rollup, which the asynchronous spend flush<br/>
        /// fills a moment after each turn; a session with no flushed auto-routed turn yet is a 404. The<br/>
        /// id is bounded the way the writer bounded it, so an oversized client id still finds its row.
        /// </summary>
        /// <param name="sessionId">
        /// The client session id (x-*-session-id header) the turns were sent under
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AutoRouterSessionResponse>> GetAutoRouterSessionAutoRouterSessionGetAsResponseAsync(
            string sessionId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
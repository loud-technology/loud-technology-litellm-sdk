#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAutoRouterClient
    {
        /// <summary>
        /// Stop Shadow Eval Job<br/>
        /// Stop an active shadow eval job, every target it scopes at once. Attempts are kept;<br/>
        /// sampling halts within ~10s. Targets that already stopped on their own budget keep the<br/>
        /// stopped_at they earned. The statement is the whole state machine: it claims the job<br/>
        /// only while a leg still samples inside the window with no stop recorded, so a racing<br/>
        /// operator, a same-instant budget spend, and a repeat stop all read the same 400 with<br/>
        /// the status the job actually holds.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse> StopShadowEvalJobAutoRouterShadowEvalJobIdStopPostAsync(
            string jobId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop Shadow Eval Job<br/>
        /// Stop an active shadow eval job, every target it scopes at once. Attempts are kept;<br/>
        /// sampling halts within ~10s. Targets that already stopped on their own budget keep the<br/>
        /// stopped_at they earned. The statement is the whole state machine: it claims the job<br/>
        /// only while a leg still samples inside the window with no stop recorded, so a racing<br/>
        /// operator, a same-instant budget spend, and a repeat stop all read the same 400 with<br/>
        /// the status the job actually holds.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse>> StopShadowEvalJobAutoRouterShadowEvalJobIdStopPostAsResponseAsync(
            string jobId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
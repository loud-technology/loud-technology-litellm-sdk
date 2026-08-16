#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Backlog<br/>
        /// Returns the number of HTTP requests currently in-flight on this uvicorn worker.<br/>
        /// Use this to measure per-pod queue depth. A high value means the worker is<br/>
        /// processing many concurrent requests — requests arriving now will have to wait<br/>
        /// for the event loop to get to them, adding latency before LiteLLM even starts<br/>
        /// its own timer.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthBacklogHealthBacklogGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Backlog<br/>
        /// Returns the number of HTTP requests currently in-flight on this uvicorn worker.<br/>
        /// Use this to measure per-pod queue depth. A high value means the worker is<br/>
        /// processing many concurrent requests — requests arriving now will have to wait<br/>
        /// for the event loop to get to them, adding latency before LiteLLM even starts<br/>
        /// its own timer.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthBacklogHealthBacklogGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
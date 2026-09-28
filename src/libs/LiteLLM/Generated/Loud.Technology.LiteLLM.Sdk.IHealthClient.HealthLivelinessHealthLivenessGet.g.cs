#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Liveliness<br/>
        /// Unprotected endpoint for checking if worker is alive.<br/>
        /// Returns 503 once graceful shutdown has begun so Kubernetes stops counting<br/>
        /// the draining pod as live and terminates it on schedule.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthLivelinessHealthLivenessGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Liveliness<br/>
        /// Unprotected endpoint for checking if worker is alive.<br/>
        /// Returns 503 once graceful shutdown has begun so Kubernetes stops counting<br/>
        /// the draining pod as live and terminates it on schedule.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthLivelinessHealthLivenessGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
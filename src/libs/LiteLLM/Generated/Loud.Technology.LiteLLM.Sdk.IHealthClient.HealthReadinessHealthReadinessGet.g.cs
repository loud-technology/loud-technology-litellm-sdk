#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Readiness<br/>
        /// Public readiness probe. Returns a low-detail payload safe to expose to<br/>
        /// unauthenticated load balancers — `status` plus `db` so orchestrators and<br/>
        /// external probes can distinguish "healthy" from "DB unreachable" without a<br/>
        /// credential. Admins can opt into the legacy detailed payload with<br/>
        /// general_settings.allow_public_health_readiness_details.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthReadinessHealthReadinessGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Readiness<br/>
        /// Public readiness probe. Returns a low-detail payload safe to expose to<br/>
        /// unauthenticated load balancers — `status` plus `db` so orchestrators and<br/>
        /// external probes can distinguish "healthy" from "DB unreachable" without a<br/>
        /// credential. Admins can opt into the legacy detailed payload with<br/>
        /// general_settings.allow_public_health_readiness_details.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthReadinessHealthReadinessGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
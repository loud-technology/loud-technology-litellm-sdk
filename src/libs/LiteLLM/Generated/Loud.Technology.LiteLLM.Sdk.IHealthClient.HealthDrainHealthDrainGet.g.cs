#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Drain<br/>
        /// Graceful-drain probe for Kubernetes ``preStop`` hooks.<br/>
        /// Disabled by default and returns 404 unless ``general_settings`` sets<br/>
        /// ``enable_drain_endpoint: true``. Calling it flips a process-wide<br/>
        /// shutting-down flag, so a successful call permanently takes the worker out<br/>
        /// of rotation until the pod restarts.<br/>
        /// Because the kubelet calls preStop hooks without proxy credentials, the<br/>
        /// endpoint does not require ``user_api_key_auth``. To prevent any<br/>
        /// pod-reachable caller from triggering shutdown, set<br/>
        /// ``general_settings.drain_endpoint_token`` (or the ``DRAIN_ENDPOINT_TOKEN``<br/>
        /// env var) and supply the same value on the ``X-Drain-Token`` header from<br/>
        /// the preStop hook. Calls without the header (or with a wrong value) get a<br/>
        /// 401 and have no side effect.<br/>
        /// When enabled, it marks the worker as shutting down (so /health/readiness<br/>
        /// and /health/liveliness immediately start returning 503, removing the pod<br/>
        /// from service) and blocks until the in-flight request counter drains to<br/>
        /// zero or ``GRACEFUL_SHUTDOWN_TIMEOUT`` elapses. Unlike a fixed ``sleep``,<br/>
        /// this returns as soon as real in-flight work is done.<br/>
        /// Wire it up as:<br/>
        /// ```yaml<br/>
        /// lifecycle:<br/>
        ///   preStop:<br/>
        ///     httpGet:<br/>
        ///       path: /health/drain<br/>
        ///       port: 4000<br/>
        ///       httpHeaders:<br/>
        ///         - name: X-Drain-Token<br/>
        ///           value: &lt;same value as drain_endpoint_token&gt;<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthDrainHealthDrainGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Drain<br/>
        /// Graceful-drain probe for Kubernetes ``preStop`` hooks.<br/>
        /// Disabled by default and returns 404 unless ``general_settings`` sets<br/>
        /// ``enable_drain_endpoint: true``. Calling it flips a process-wide<br/>
        /// shutting-down flag, so a successful call permanently takes the worker out<br/>
        /// of rotation until the pod restarts.<br/>
        /// Because the kubelet calls preStop hooks without proxy credentials, the<br/>
        /// endpoint does not require ``user_api_key_auth``. To prevent any<br/>
        /// pod-reachable caller from triggering shutdown, set<br/>
        /// ``general_settings.drain_endpoint_token`` (or the ``DRAIN_ENDPOINT_TOKEN``<br/>
        /// env var) and supply the same value on the ``X-Drain-Token`` header from<br/>
        /// the preStop hook. Calls without the header (or with a wrong value) get a<br/>
        /// 401 and have no side effect.<br/>
        /// When enabled, it marks the worker as shutting down (so /health/readiness<br/>
        /// and /health/liveliness immediately start returning 503, removing the pod<br/>
        /// from service) and blocks until the in-flight request counter drains to<br/>
        /// zero or ``GRACEFUL_SHUTDOWN_TIMEOUT`` elapses. Unlike a fixed ``sleep``,<br/>
        /// this returns as soon as real in-flight work is done.<br/>
        /// Wire it up as:<br/>
        /// ```yaml<br/>
        /// lifecycle:<br/>
        ///   preStop:<br/>
        ///     httpGet:<br/>
        ///       path: /health/drain<br/>
        ///       port: 4000<br/>
        ///       httpHeaders:<br/>
        ///         - name: X-Drain-Token<br/>
        ///           value: &lt;same value as drain_endpoint_token&gt;<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthDrainHealthDrainGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Endpoint<br/>
        /// 🚨 USE `/health/liveliness` to health check the proxy 🚨<br/>
        /// See more 👉 https://docs.litellm.ai/docs/proxy/health<br/>
        /// Check the health of all the endpoints in config.yaml<br/>
        /// To run health checks in the background, add this to config.yaml:<br/>
        /// ```<br/>
        /// general_settings:<br/>
        ///     # ... other settings<br/>
        ///     background_health_checks: True<br/>
        /// ```<br/>
        /// else, the health checks will be run on models when /health is called.<br/>
        /// To skip deployments that set ``model_info.disable_background_health_check: true``<br/>
        /// on ``GET /health`` as well as in the background loop, set<br/>
        /// ``general_settings.health_check_skip_disabled_background_models: true``.
        /// </summary>
        /// <param name="model">
        /// Specify the model name (optional)
        /// </param>
        /// <param name="modelId">
        /// Specify the model ID (optional)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthEndpointHealthGetAsync(
            string? model = default,
            string? modelId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Endpoint<br/>
        /// 🚨 USE `/health/liveliness` to health check the proxy 🚨<br/>
        /// See more 👉 https://docs.litellm.ai/docs/proxy/health<br/>
        /// Check the health of all the endpoints in config.yaml<br/>
        /// To run health checks in the background, add this to config.yaml:<br/>
        /// ```<br/>
        /// general_settings:<br/>
        ///     # ... other settings<br/>
        ///     background_health_checks: True<br/>
        /// ```<br/>
        /// else, the health checks will be run on models when /health is called.<br/>
        /// To skip deployments that set ``model_info.disable_background_health_check: true``<br/>
        /// on ``GET /health`` as well as in the background loop, set<br/>
        /// ``general_settings.health_check_skip_disabled_background_models: true``.
        /// </summary>
        /// <param name="model">
        /// Specify the model name (optional)
        /// </param>
        /// <param name="modelId">
        /// Specify the model ID (optional)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthEndpointHealthGetAsResponseAsync(
            string? model = default,
            string? modelId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
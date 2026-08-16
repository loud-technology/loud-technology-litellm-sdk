#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Model List<br/>
        /// Use `/model/info` - to get detailed model information, example - pricing, mode, etc.<br/>
        /// This is just for compatibility with openai projects like aider.<br/>
        /// Query Parameters:<br/>
        /// - include_metadata: Include additional metadata in the response with fallback information<br/>
        /// - fallback_type: Type of fallbacks to include ("general", "context_window", "content_policy")<br/>
        ///                 Defaults to "general" when include_metadata=true<br/>
        /// - scope: Optional scope parameter. Currently only accepts "expand".<br/>
        ///          When scope=expand is passed, proxy admins, team admins, and org admins<br/>
        ///          will receive all proxy models as if they are a proxy admin.<br/>
        /// - healthy_only: When true, hide models whose backing deployments are all marked<br/>
        ///                 unhealthy by background health checks. Requires<br/>
        ///                 `background_health_checks: true` in general_settings; without<br/>
        ///                 health state the listing is returned unfiltered (fail open).<br/>
        ///                 Models expanded from wildcard routes (e.g. `openai/*`) are not<br/>
        ///                 filtered, and nothing is hidden when `allowed_fails_policy` is<br/>
        ///                 configured (cooldown remains the sole exclusion mechanism).<br/>
        ///                 Hiding is presentation-only: a hidden model can still be<br/>
        ///                 called directly.
        /// </summary>
        /// <param name="returnWildcardRoutes">
        /// Default Value: false
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="includeModelAccessGroups">
        /// Default Value: false
        /// </param>
        /// <param name="onlyModelAccessGroups">
        /// Default Value: false
        /// </param>
        /// <param name="includeMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="fallbackType"></param>
        /// <param name="scope"></param>
        /// <param name="healthyOnly">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelListModelsGetAsync(
            bool? returnWildcardRoutes = default,
            string? teamId = default,
            bool? includeModelAccessGroups = default,
            bool? onlyModelAccessGroups = default,
            bool? includeMetadata = default,
            string? fallbackType = default,
            string? scope = default,
            bool? healthyOnly = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model List<br/>
        /// Use `/model/info` - to get detailed model information, example - pricing, mode, etc.<br/>
        /// This is just for compatibility with openai projects like aider.<br/>
        /// Query Parameters:<br/>
        /// - include_metadata: Include additional metadata in the response with fallback information<br/>
        /// - fallback_type: Type of fallbacks to include ("general", "context_window", "content_policy")<br/>
        ///                 Defaults to "general" when include_metadata=true<br/>
        /// - scope: Optional scope parameter. Currently only accepts "expand".<br/>
        ///          When scope=expand is passed, proxy admins, team admins, and org admins<br/>
        ///          will receive all proxy models as if they are a proxy admin.<br/>
        /// - healthy_only: When true, hide models whose backing deployments are all marked<br/>
        ///                 unhealthy by background health checks. Requires<br/>
        ///                 `background_health_checks: true` in general_settings; without<br/>
        ///                 health state the listing is returned unfiltered (fail open).<br/>
        ///                 Models expanded from wildcard routes (e.g. `openai/*`) are not<br/>
        ///                 filtered, and nothing is hidden when `allowed_fails_policy` is<br/>
        ///                 configured (cooldown remains the sole exclusion mechanism).<br/>
        ///                 Hiding is presentation-only: a hidden model can still be<br/>
        ///                 called directly.
        /// </summary>
        /// <param name="returnWildcardRoutes">
        /// Default Value: false
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="includeModelAccessGroups">
        /// Default Value: false
        /// </param>
        /// <param name="onlyModelAccessGroups">
        /// Default Value: false
        /// </param>
        /// <param name="includeMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="fallbackType"></param>
        /// <param name="scope"></param>
        /// <param name="healthyOnly">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ModelListModelsGetAsResponseAsync(
            bool? returnWildcardRoutes = default,
            string? teamId = default,
            bool? includeModelAccessGroups = default,
            bool? onlyModelAccessGroups = default,
            bool? includeMetadata = default,
            string? fallbackType = default,
            string? scope = default,
            bool? healthyOnly = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
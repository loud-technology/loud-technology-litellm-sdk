#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICostTrackingClient
    {
        /// <summary>
        /// Update Cost Margin Config<br/>
        /// Update cost margin configuration.<br/>
        /// Updates the cost_margin_config in litellm_settings.<br/>
        /// Margins can be:<br/>
        /// - Percentage: {"openai": 0.10} = 10% margin<br/>
        /// - Fixed amount: {"openai": {"fixed_amount": 0.001}} = $0.001 per request<br/>
        /// - Combined: {"vertex_ai": {"percentage": 0.08, "fixed_amount": 0.0005}}<br/>
        /// - Global: {"global": 0.05} = 5% global margin on all providers<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "global": 0.05,<br/>
        ///     "openai": 0.10,<br/>
        ///     "anthropic": {"fixed_amount": 0.001},<br/>
        ///     "vertex_ai": {"percentage": 0.08, "fixed_amount": 0.0005}<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCostMarginConfigConfigCostMarginConfigPatchAsync(

            object request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cost Margin Config<br/>
        /// Update cost margin configuration.<br/>
        /// Updates the cost_margin_config in litellm_settings.<br/>
        /// Margins can be:<br/>
        /// - Percentage: {"openai": 0.10} = 10% margin<br/>
        /// - Fixed amount: {"openai": {"fixed_amount": 0.001}} = $0.001 per request<br/>
        /// - Combined: {"vertex_ai": {"percentage": 0.08, "fixed_amount": 0.0005}}<br/>
        /// - Global: {"global": 0.05} = 5% global margin on all providers<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "global": 0.05,<br/>
        ///     "openai": 0.10,<br/>
        ///     "anthropic": {"fixed_amount": 0.001},<br/>
        ///     "vertex_ai": {"percentage": 0.08, "fixed_amount": 0.0005}<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateCostMarginConfigConfigCostMarginConfigPatchAsResponseAsync(

            object request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cost Margin Config<br/>
        /// Update cost margin configuration.<br/>
        /// Updates the cost_margin_config in litellm_settings.<br/>
        /// Margins can be:<br/>
        /// - Percentage: {"openai": 0.10} = 10% margin<br/>
        /// - Fixed amount: {"openai": {"fixed_amount": 0.001}} = $0.001 per request<br/>
        /// - Combined: {"vertex_ai": {"percentage": 0.08, "fixed_amount": 0.0005}}<br/>
        /// - Global: {"global": 0.05} = 5% global margin on all providers<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "global": 0.05,<br/>
        ///     "openai": 0.10,<br/>
        ///     "anthropic": {"fixed_amount": 0.001},<br/>
        ///     "vertex_ai": {"percentage": 0.08, "fixed_amount": 0.0005}<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCostMarginConfigConfigCostMarginConfigPatchAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
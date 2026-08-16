#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICostTrackingClient
    {
        /// <summary>
        /// Update Cost Discount Config<br/>
        /// Update cost discount configuration.<br/>
        /// Updates the cost_discount_config in litellm_settings.<br/>
        /// Discounts should be between 0 and 1 (e.g., 0.05 = 5% discount).<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "vertex_ai": 0.05,<br/>
        ///     "gemini": 0.05,<br/>
        ///     "openai": 0.01<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCostDiscountConfigConfigCostDiscountConfigPatchAsync(

            global::System.Collections.Generic.Dictionary<string, double> request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cost Discount Config<br/>
        /// Update cost discount configuration.<br/>
        /// Updates the cost_discount_config in litellm_settings.<br/>
        /// Discounts should be between 0 and 1 (e.g., 0.05 = 5% discount).<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "vertex_ai": 0.05,<br/>
        ///     "gemini": 0.05,<br/>
        ///     "openai": 0.01<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateCostDiscountConfigConfigCostDiscountConfigPatchAsResponseAsync(

            global::System.Collections.Generic.Dictionary<string, double> request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cost Discount Config<br/>
        /// Update cost discount configuration.<br/>
        /// Updates the cost_discount_config in litellm_settings.<br/>
        /// Discounts should be between 0 and 1 (e.g., 0.05 = 5% discount).<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "vertex_ai": 0.05,<br/>
        ///     "gemini": 0.05,<br/>
        ///     "openai": 0.01<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCostDiscountConfigConfigCostDiscountConfigPatchAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
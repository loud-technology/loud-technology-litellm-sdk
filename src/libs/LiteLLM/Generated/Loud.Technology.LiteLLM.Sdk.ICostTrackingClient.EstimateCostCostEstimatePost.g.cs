#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICostTrackingClient
    {
        /// <summary>
        /// Estimate Cost<br/>
        /// Estimate cost for a given model and token counts.<br/>
        /// This endpoint uses the same cost calculation logic as actual requests,<br/>
        /// including any configured margins and discounts.<br/>
        /// Parameters:<br/>
        /// - model: Model name (e.g., "gpt-4", "claude-3-opus")<br/>
        /// - input_tokens: Expected input tokens per request<br/>
        /// - output_tokens: Expected output tokens per request<br/>
        /// - num_requests_per_day: Number of requests per day (optional)<br/>
        /// - num_requests_per_month: Number of requests per month (optional)<br/>
        /// Returns cost breakdown including:<br/>
        /// - Per-request costs (input, output, margin)<br/>
        /// - Daily costs (if num_requests_per_day provided)<br/>
        /// - Monthly costs (if num_requests_per_month provided)<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "model": "gpt-4",<br/>
        ///     "input_tokens": 1000,<br/>
        ///     "output_tokens": 500,<br/>
        ///     "num_requests_per_day": 100,<br/>
        ///     "num_requests_per_month": 3000<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CostEstimateResponse> EstimateCostCostEstimatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CostEstimateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Cost<br/>
        /// Estimate cost for a given model and token counts.<br/>
        /// This endpoint uses the same cost calculation logic as actual requests,<br/>
        /// including any configured margins and discounts.<br/>
        /// Parameters:<br/>
        /// - model: Model name (e.g., "gpt-4", "claude-3-opus")<br/>
        /// - input_tokens: Expected input tokens per request<br/>
        /// - output_tokens: Expected output tokens per request<br/>
        /// - num_requests_per_day: Number of requests per day (optional)<br/>
        /// - num_requests_per_month: Number of requests per month (optional)<br/>
        /// Returns cost breakdown including:<br/>
        /// - Per-request costs (input, output, margin)<br/>
        /// - Daily costs (if num_requests_per_day provided)<br/>
        /// - Monthly costs (if num_requests_per_month provided)<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "model": "gpt-4",<br/>
        ///     "input_tokens": 1000,<br/>
        ///     "output_tokens": 500,<br/>
        ///     "num_requests_per_day": 100,<br/>
        ///     "num_requests_per_month": 3000<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CostEstimateResponse>> EstimateCostCostEstimatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CostEstimateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Cost<br/>
        /// Estimate cost for a given model and token counts.<br/>
        /// This endpoint uses the same cost calculation logic as actual requests,<br/>
        /// including any configured margins and discounts.<br/>
        /// Parameters:<br/>
        /// - model: Model name (e.g., "gpt-4", "claude-3-opus")<br/>
        /// - input_tokens: Expected input tokens per request<br/>
        /// - output_tokens: Expected output tokens per request<br/>
        /// - num_requests_per_day: Number of requests per day (optional)<br/>
        /// - num_requests_per_month: Number of requests per month (optional)<br/>
        /// Returns cost breakdown including:<br/>
        /// - Per-request costs (input, output, margin)<br/>
        /// - Daily costs (if num_requests_per_day provided)<br/>
        /// - Monthly costs (if num_requests_per_month provided)<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "model": "gpt-4",<br/>
        ///     "input_tokens": 1000,<br/>
        ///     "output_tokens": 500,<br/>
        ///     "num_requests_per_day": 100,<br/>
        ///     "num_requests_per_month": 3000<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="model">
        /// Model name (from /model_group/info)
        /// </param>
        /// <param name="inputTokens">
        /// Expected input tokens per request
        /// </param>
        /// <param name="outputTokens">
        /// Expected output tokens per request
        /// </param>
        /// <param name="numRequestsPerDay">
        /// Number of requests per day
        /// </param>
        /// <param name="numRequestsPerMonth">
        /// Number of requests per month
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CostEstimateResponse> EstimateCostCostEstimatePostAsync(
            string model,
            int inputTokens,
            int outputTokens,
            int? numRequestsPerDay = default,
            int? numRequestsPerMonth = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
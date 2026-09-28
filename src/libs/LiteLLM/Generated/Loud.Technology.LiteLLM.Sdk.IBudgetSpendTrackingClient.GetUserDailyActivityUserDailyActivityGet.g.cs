#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Get User Daily Activity<br/>
        /// [BETA] This is a beta endpoint. It will change.<br/>
        /// Meant to optimize querying spend data for analytics for a user.<br/>
        /// Reads daily spend records that only ever accumulate and are never affected by budget<br/>
        /// resets. Their total can legitimately exceed the `spend` field returned by<br/>
        /// `/v2/user/info`, which is a running budget counter that every budget reset sets back<br/>
        /// to zero (or to the overage above `max_budget` when `budget_rollover` is enabled).<br/>
        /// Returns:<br/>
        /// (by date)<br/>
        /// - spend<br/>
        /// - prompt_tokens<br/>
        /// - completion_tokens<br/>
        /// - cache_read_input_tokens<br/>
        /// - cache_creation_input_tokens<br/>
        /// - total_tokens<br/>
        /// - api_requests<br/>
        /// - breakdown by model, api_key, provider
        /// </summary>
        /// <param name="startDate">
        /// Start date in YYYY-MM-DD format
        /// </param>
        /// <param name="endDate">
        /// End date in YYYY-MM-DD format
        /// </param>
        /// <param name="model">
        /// Filter by specific model
        /// </param>
        /// <param name="apiKey">
        /// Filter by specific API key
        /// </param>
        /// <param name="userId">
        /// Filter by specific user ID. Admins can filter by any user or omit for global view. Non-admins must provide their own user_id.
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="timezone">
        /// Timezone offset in minutes from UTC (e.g., 480 for PST). Matches JavaScript's Date.getTimezoneOffset() convention.
        /// </param>
        /// <param name="includeCurrentUtcDay">
        /// When the range ends on the caller's current local day, extend it to today's UTC bucket so spend written after the caller's local midnight (in UTC terms) is included. Requires the timezone parameter. Historical ranges are never extended.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse> GetUserDailyActivityUserDailyActivityGetAsync(
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            string? userId = default,
            int? page = default,
            int? pageSize = default,
            int? timezone = default,
            bool? includeCurrentUtcDay = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User Daily Activity<br/>
        /// [BETA] This is a beta endpoint. It will change.<br/>
        /// Meant to optimize querying spend data for analytics for a user.<br/>
        /// Reads daily spend records that only ever accumulate and are never affected by budget<br/>
        /// resets. Their total can legitimately exceed the `spend` field returned by<br/>
        /// `/v2/user/info`, which is a running budget counter that every budget reset sets back<br/>
        /// to zero (or to the overage above `max_budget` when `budget_rollover` is enabled).<br/>
        /// Returns:<br/>
        /// (by date)<br/>
        /// - spend<br/>
        /// - prompt_tokens<br/>
        /// - completion_tokens<br/>
        /// - cache_read_input_tokens<br/>
        /// - cache_creation_input_tokens<br/>
        /// - total_tokens<br/>
        /// - api_requests<br/>
        /// - breakdown by model, api_key, provider
        /// </summary>
        /// <param name="startDate">
        /// Start date in YYYY-MM-DD format
        /// </param>
        /// <param name="endDate">
        /// End date in YYYY-MM-DD format
        /// </param>
        /// <param name="model">
        /// Filter by specific model
        /// </param>
        /// <param name="apiKey">
        /// Filter by specific API key
        /// </param>
        /// <param name="userId">
        /// Filter by specific user ID. Admins can filter by any user or omit for global view. Non-admins must provide their own user_id.
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="timezone">
        /// Timezone offset in minutes from UTC (e.g., 480 for PST). Matches JavaScript's Date.getTimezoneOffset() convention.
        /// </param>
        /// <param name="includeCurrentUtcDay">
        /// When the range ends on the caller's current local day, extend it to today's UTC bucket so spend written after the caller's local midnight (in UTC terms) is included. Requires the timezone parameter. Historical ranges are never extended.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse>> GetUserDailyActivityUserDailyActivityGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            string? userId = default,
            int? page = default,
            int? pageSize = default,
            int? timezone = default,
            bool? includeCurrentUtcDay = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
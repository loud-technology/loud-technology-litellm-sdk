#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Ui View Spend Logs<br/>
        /// View spend logs with pagination support.<br/>
        /// Available at both `/spend/logs/v2` (public API) and `/spend/logs/ui` (internal UI).<br/>
        /// Returns paginated response with data, total, page, page_size, and total_pages.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs/v2?start_date=2025-11-25%2000:00:00&amp;end_date=2025-11-26%2023:59:59&amp;page=1&amp;page_size=50" -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="apiKey">
        /// Get spend logs based on api key
        /// </param>
        /// <param name="userId">
        /// Get spend logs based on user_id
        /// </param>
        /// <param name="requestId">
        /// request_id to get spend logs for specific request_id
        /// </param>
        /// <param name="sessionId">
        /// Filter spend logs by session_id (partial string match)
        /// </param>
        /// <param name="teamId">
        /// Filter spend logs by team_id
        /// </param>
        /// <param name="minSpend">
        /// Filter logs with spend greater than or equal to this value
        /// </param>
        /// <param name="maxSpend">
        /// Filter logs with spend less than or equal to this value
        /// </param>
        /// <param name="startDate">
        /// Time from which to start viewing key spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view key spend
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="statusFilter">
        /// Filter logs by status (e.g., success, failure)
        /// </param>
        /// <param name="model">
        /// Filter logs by model
        /// </param>
        /// <param name="modelId">
        /// Filter logs by model ID (litellm model deployment id)
        /// </param>
        /// <param name="modelGroup">
        /// Filter logs by model group
        /// </param>
        /// <param name="keyAlias">
        /// Filter logs by key alias
        /// </param>
        /// <param name="endUser">
        /// Filter logs by end user
        /// </param>
        /// <param name="errorCode">
        /// Filter logs by error code (e.g., '404', '500')
        /// </param>
        /// <param name="errorMessage">
        /// Filter logs by error message (partial string match)
        /// </param>
        /// <param name="sortBy">
        /// Sort logs by field: spend, total_tokens, startTime, endTime, request_duration_ms, model, or ttft_ms<br/>
        /// Default Value: startTime
        /// </param>
        /// <param name="sortOrder">
        /// Sort order: asc or desc<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UiViewSpendLogsSpendLogsV2GetAsync(
            string? apiKey = default,
            string? userId = default,
            string? requestId = default,
            string? sessionId = default,
            string? teamId = default,
            double? minSpend = default,
            double? maxSpend = default,
            string? startDate = default,
            string? endDate = default,
            int? page = default,
            int? pageSize = default,
            string? statusFilter = default,
            string? model = default,
            string? modelId = default,
            string? modelGroup = default,
            string? keyAlias = default,
            string? endUser = default,
            string? errorCode = default,
            string? errorMessage = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ui View Spend Logs<br/>
        /// View spend logs with pagination support.<br/>
        /// Available at both `/spend/logs/v2` (public API) and `/spend/logs/ui` (internal UI).<br/>
        /// Returns paginated response with data, total, page, page_size, and total_pages.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs/v2?start_date=2025-11-25%2000:00:00&amp;end_date=2025-11-26%2023:59:59&amp;page=1&amp;page_size=50" -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="apiKey">
        /// Get spend logs based on api key
        /// </param>
        /// <param name="userId">
        /// Get spend logs based on user_id
        /// </param>
        /// <param name="requestId">
        /// request_id to get spend logs for specific request_id
        /// </param>
        /// <param name="sessionId">
        /// Filter spend logs by session_id (partial string match)
        /// </param>
        /// <param name="teamId">
        /// Filter spend logs by team_id
        /// </param>
        /// <param name="minSpend">
        /// Filter logs with spend greater than or equal to this value
        /// </param>
        /// <param name="maxSpend">
        /// Filter logs with spend less than or equal to this value
        /// </param>
        /// <param name="startDate">
        /// Time from which to start viewing key spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view key spend
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="statusFilter">
        /// Filter logs by status (e.g., success, failure)
        /// </param>
        /// <param name="model">
        /// Filter logs by model
        /// </param>
        /// <param name="modelId">
        /// Filter logs by model ID (litellm model deployment id)
        /// </param>
        /// <param name="modelGroup">
        /// Filter logs by model group
        /// </param>
        /// <param name="keyAlias">
        /// Filter logs by key alias
        /// </param>
        /// <param name="endUser">
        /// Filter logs by end user
        /// </param>
        /// <param name="errorCode">
        /// Filter logs by error code (e.g., '404', '500')
        /// </param>
        /// <param name="errorMessage">
        /// Filter logs by error message (partial string match)
        /// </param>
        /// <param name="sortBy">
        /// Sort logs by field: spend, total_tokens, startTime, endTime, request_duration_ms, model, or ttft_ms<br/>
        /// Default Value: startTime
        /// </param>
        /// <param name="sortOrder">
        /// Sort order: asc or desc<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UiViewSpendLogsSpendLogsV2GetAsResponseAsync(
            string? apiKey = default,
            string? userId = default,
            string? requestId = default,
            string? sessionId = default,
            string? teamId = default,
            double? minSpend = default,
            double? maxSpend = default,
            string? startDate = default,
            string? endDate = default,
            int? page = default,
            int? pageSize = default,
            string? statusFilter = default,
            string? model = default,
            string? modelId = default,
            string? modelGroup = default,
            string? keyAlias = default,
            string? endUser = default,
            string? errorCode = default,
            string? errorMessage = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
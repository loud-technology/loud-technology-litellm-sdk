#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// View Spend Logs<br/>
        /// [DEPRECATED] This endpoint is not paginated and can cause performance issues.<br/>
        /// Please use `/spend/logs/v2` instead for paginated access to spend logs.<br/>
        /// View all spend logs, if request_id is provided, only logs for that request_id will be returned<br/>
        /// When start_date and end_date are provided:<br/>
        /// - summarize=true (default): Returns aggregated spend data grouped by date (maintains backward compatibility)<br/>
        /// - summarize=false: Returns filtered individual log entries within the date range<br/>
        /// Example Request for all logs<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Request for specific request_id<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs?request_id=chatcmpl-6dcb2540-d3d7-4e49-bb27-291f863f112e" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Request for specific api_key<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs?api_key=sk-test-example-key-123" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Request for specific user_id<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs?user_id=ishaan@berri.ai" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Request for date range with individual logs (unsummarized)<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs?start_date=2024-01-01&amp;end_date=2024-01-02&amp;summarize=false" -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="apiKey">
        /// Get spend logs based on api key
        /// </param>
        /// <param name="userId">
        /// Get spend logs based on user_id
        /// </param>
        /// <param name="requestId">
        /// request_id to get spend logs for specific request_id. If none passed then pass spend logs for all requests
        /// </param>
        /// <param name="startDate">
        /// Time from which to start viewing key spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view key spend
        /// </param>
        /// <param name="summarize">
        /// When start_date and end_date are provided, summarize=true returns aggregated data by date (legacy behavior), summarize=false returns filtered individual logs<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMSpendLogs>> ViewSpendLogsSpendLogsGetAsync(
            string? apiKey = default,
            string? userId = default,
            string? requestId = default,
            string? startDate = default,
            string? endDate = default,
            bool? summarize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// View Spend Logs<br/>
        /// [DEPRECATED] This endpoint is not paginated and can cause performance issues.<br/>
        /// Please use `/spend/logs/v2` instead for paginated access to spend logs.<br/>
        /// View all spend logs, if request_id is provided, only logs for that request_id will be returned<br/>
        /// When start_date and end_date are provided:<br/>
        /// - summarize=true (default): Returns aggregated spend data grouped by date (maintains backward compatibility)<br/>
        /// - summarize=false: Returns filtered individual log entries within the date range<br/>
        /// Example Request for all logs<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Request for specific request_id<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs?request_id=chatcmpl-6dcb2540-d3d7-4e49-bb27-291f863f112e" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Request for specific api_key<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs?api_key=sk-test-example-key-123" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Request for specific user_id<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs?user_id=ishaan@berri.ai" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Request for date range with individual logs (unsummarized)<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs?start_date=2024-01-01&amp;end_date=2024-01-02&amp;summarize=false" -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="apiKey">
        /// Get spend logs based on api key
        /// </param>
        /// <param name="userId">
        /// Get spend logs based on user_id
        /// </param>
        /// <param name="requestId">
        /// request_id to get spend logs for specific request_id. If none passed then pass spend logs for all requests
        /// </param>
        /// <param name="startDate">
        /// Time from which to start viewing key spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view key spend
        /// </param>
        /// <param name="summarize">
        /// When start_date and end_date are provided, summarize=true returns aggregated data by date (legacy behavior), summarize=false returns filtered individual logs<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMSpendLogs>>> ViewSpendLogsSpendLogsGetAsResponseAsync(
            string? apiKey = default,
            string? userId = default,
            string? requestId = default,
            string? startDate = default,
            string? endDate = default,
            bool? summarize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
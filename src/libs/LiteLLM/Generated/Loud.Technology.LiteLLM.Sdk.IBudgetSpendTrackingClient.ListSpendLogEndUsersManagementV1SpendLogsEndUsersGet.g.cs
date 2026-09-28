#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// List Spend Log End Users<br/>
        /// The distinct end users appearing in spend logs over a time window, for the logs<br/>
        /// page filter dropdown.<br/>
        /// Scoped like `/spend/logs/ui`: a proxy admin sees every end user in the window,<br/>
        /// anyone else sees only end users from their own requests or from teams they<br/>
        /// administer (or hold the `/spend/logs` permission on).<br/>
        /// The window is required and the inner scan is capped at SPEND_LOGS_FACET_SCAN_CAP<br/>
        /// rows, so the query cannot degrade into a full-table scan the way<br/>
        /// `/global/all_end_users` does.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --globoff 'http://0.0.0.0:4000/management/v1/spend_logs/end_users?filter[startTime][gte]=2026-07-23T00:00:00Z&amp;filter[startTime][lte]=2026-07-24T00:00:00Z&amp;page_size=50&amp;q=acme'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="filterStartTimeGte">
        /// Window start (UTC when no offset is given)
        /// </param>
        /// <param name="filterStartTimeLte">
        /// Window end (UTC when no offset is given)
        /// </param>
        /// <param name="q">
        /// Case-insensitive partial match on the end user id
        /// </param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.FacetListResponse> ListSpendLogEndUsersManagementV1SpendLogsEndUsersGetAsync(
            global::System.DateTime filterStartTimeGte,
            global::System.DateTime filterStartTimeLte,
            string? q = default,
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Spend Log End Users<br/>
        /// The distinct end users appearing in spend logs over a time window, for the logs<br/>
        /// page filter dropdown.<br/>
        /// Scoped like `/spend/logs/ui`: a proxy admin sees every end user in the window,<br/>
        /// anyone else sees only end users from their own requests or from teams they<br/>
        /// administer (or hold the `/spend/logs` permission on).<br/>
        /// The window is required and the inner scan is capped at SPEND_LOGS_FACET_SCAN_CAP<br/>
        /// rows, so the query cannot degrade into a full-table scan the way<br/>
        /// `/global/all_end_users` does.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --globoff 'http://0.0.0.0:4000/management/v1/spend_logs/end_users?filter[startTime][gte]=2026-07-23T00:00:00Z&amp;filter[startTime][lte]=2026-07-24T00:00:00Z&amp;page_size=50&amp;q=acme'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="filterStartTimeGte">
        /// Window start (UTC when no offset is given)
        /// </param>
        /// <param name="filterStartTimeLte">
        /// Window end (UTC when no offset is given)
        /// </param>
        /// <param name="q">
        /// Case-insensitive partial match on the end user id
        /// </param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.FacetListResponse>> ListSpendLogEndUsersManagementV1SpendLogsEndUsersGetAsResponseAsync(
            global::System.DateTime filterStartTimeGte,
            global::System.DateTime filterStartTimeLte,
            string? q = default,
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
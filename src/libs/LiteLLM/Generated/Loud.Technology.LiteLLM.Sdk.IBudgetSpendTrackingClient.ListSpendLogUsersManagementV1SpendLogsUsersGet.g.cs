#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// List Spend Log Users<br/>
        /// The distinct internal users appearing in spend logs the caller can read.
        /// </summary>
        /// <param name="filterStartTimeGte">
        /// Window start (UTC when no offset is given)
        /// </param>
        /// <param name="filterStartTimeLte">
        /// Window end (UTC when no offset is given)
        /// </param>
        /// <param name="q">
        /// Case-insensitive partial match on the internal user id
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.FacetListResponse> ListSpendLogUsersManagementV1SpendLogsUsersGetAsync(
            global::System.DateTime filterStartTimeGte,
            global::System.DateTime filterStartTimeLte,
            string? q = default,
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Spend Log Users<br/>
        /// The distinct internal users appearing in spend logs the caller can read.
        /// </summary>
        /// <param name="filterStartTimeGte">
        /// Window start (UTC when no offset is given)
        /// </param>
        /// <param name="filterStartTimeLte">
        /// Window end (UTC when no offset is given)
        /// </param>
        /// <param name="q">
        /// Case-insensitive partial match on the internal user id
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.FacetListResponse>> ListSpendLogUsersManagementV1SpendLogsUsersGetAsResponseAsync(
            global::System.DateTime filterStartTimeGte,
            global::System.DateTime filterStartTimeLte,
            string? q = default,
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
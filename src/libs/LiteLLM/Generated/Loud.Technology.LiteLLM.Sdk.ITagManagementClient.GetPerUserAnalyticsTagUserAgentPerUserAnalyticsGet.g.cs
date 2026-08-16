#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Get Per User Analytics<br/>
        /// Get per-user analytics including successful requests, tokens, and spend by individual users.<br/>
        /// This endpoint provides usage metrics broken down by individual users based on their<br/>
        /// tag activity during the last 30 days ending on UTC today + 1 day.<br/>
        /// Args:<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        ///     page: Page number for pagination<br/>
        ///     page_size: Number of items per page<br/>
        /// Returns:<br/>
        ///     PerUserAnalyticsResponse: Analytics data broken down by individual users for the last 30 days
        /// </summary>
        /// <param name="tagFilter">
        /// Filter by specific tag (optional)
        /// </param>
        /// <param name="tagFilters">
        /// Filter by multiple specific tags (optional, takes precedence over tag_filter)
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PerUserAnalyticsResponse> GetPerUserAnalyticsTagUserAgentPerUserAnalyticsGetAsync(
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Per User Analytics<br/>
        /// Get per-user analytics including successful requests, tokens, and spend by individual users.<br/>
        /// This endpoint provides usage metrics broken down by individual users based on their<br/>
        /// tag activity during the last 30 days ending on UTC today + 1 day.<br/>
        /// Args:<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        ///     page: Page number for pagination<br/>
        ///     page_size: Number of items per page<br/>
        /// Returns:<br/>
        ///     PerUserAnalyticsResponse: Analytics data broken down by individual users for the last 30 days
        /// </summary>
        /// <param name="tagFilter">
        /// Filter by specific tag (optional)
        /// </param>
        /// <param name="tagFilters">
        /// Filter by multiple specific tags (optional, takes precedence over tag_filter)
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PerUserAnalyticsResponse>> GetPerUserAnalyticsTagUserAgentPerUserAnalyticsGetAsResponseAsync(
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
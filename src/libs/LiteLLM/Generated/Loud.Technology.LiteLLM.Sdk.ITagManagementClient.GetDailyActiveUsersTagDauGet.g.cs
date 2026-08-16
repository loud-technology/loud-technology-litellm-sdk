#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Get Daily Active Users<br/>
        /// Get Daily Active Users (DAU) by tags for the last {MAX_DAYS} days ending on UTC today + 1 day.<br/>
        /// This endpoint efficiently calculates unique users per tag for each of the last {MAX_DAYS} days<br/>
        /// using a single optimized SQL query, perfect for dashboard time series visualization.<br/>
        /// Args:<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        /// Returns:<br/>
        ///     ActiveUsersAnalyticsResponse: DAU data by tag for each of the last {MAX_DAYS} days
        /// </summary>
        /// <param name="tagFilter">
        /// Filter by specific tag (optional)
        /// </param>
        /// <param name="tagFilters">
        /// Filter by multiple specific tags (optional, takes precedence over tag_filter)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ActiveUsersAnalyticsResponse> GetDailyActiveUsersTagDauGetAsync(
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Daily Active Users<br/>
        /// Get Daily Active Users (DAU) by tags for the last {MAX_DAYS} days ending on UTC today + 1 day.<br/>
        /// This endpoint efficiently calculates unique users per tag for each of the last {MAX_DAYS} days<br/>
        /// using a single optimized SQL query, perfect for dashboard time series visualization.<br/>
        /// Args:<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        /// Returns:<br/>
        ///     ActiveUsersAnalyticsResponse: DAU data by tag for each of the last {MAX_DAYS} days
        /// </summary>
        /// <param name="tagFilter">
        /// Filter by specific tag (optional)
        /// </param>
        /// <param name="tagFilters">
        /// Filter by multiple specific tags (optional, takes precedence over tag_filter)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ActiveUsersAnalyticsResponse>> GetDailyActiveUsersTagDauGetAsResponseAsync(
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
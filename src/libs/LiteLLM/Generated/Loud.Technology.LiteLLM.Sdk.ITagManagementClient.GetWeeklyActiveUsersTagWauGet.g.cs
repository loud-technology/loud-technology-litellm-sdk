#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Get Weekly Active Users<br/>
        /// Get Weekly Active Users (WAU) by tags for the last {MAX_WEEKS} weeks ending on UTC today + 1 day.<br/>
        /// Shows week-by-week breakdown:<br/>
        /// - Week 1 (Jan 1): Earliest week (7 weeks ago)<br/>
        /// - Week 2 (Jan 8): Next week (6 weeks ago)<br/>
        /// - Week 3 (Jan 15): Next week (5 weeks ago)<br/>
        /// - ... and so on for {MAX_WEEKS} weeks total<br/>
        /// - Week 7: Most recent week ending on UTC today + 1 day<br/>
        /// Args:<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        /// Returns:<br/>
        ///     ActiveUsersAnalyticsResponse: WAU data by tag for each of the last {MAX_WEEKS} weeks with descriptive week labels (e.g., "Week 1 (Jan 1)")
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ActiveUsersAnalyticsResponse> GetWeeklyActiveUsersTagWauGetAsync(
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Weekly Active Users<br/>
        /// Get Weekly Active Users (WAU) by tags for the last {MAX_WEEKS} weeks ending on UTC today + 1 day.<br/>
        /// Shows week-by-week breakdown:<br/>
        /// - Week 1 (Jan 1): Earliest week (7 weeks ago)<br/>
        /// - Week 2 (Jan 8): Next week (6 weeks ago)<br/>
        /// - Week 3 (Jan 15): Next week (5 weeks ago)<br/>
        /// - ... and so on for {MAX_WEEKS} weeks total<br/>
        /// - Week 7: Most recent week ending on UTC today + 1 day<br/>
        /// Args:<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        /// Returns:<br/>
        ///     ActiveUsersAnalyticsResponse: WAU data by tag for each of the last {MAX_WEEKS} weeks with descriptive week labels (e.g., "Week 1 (Jan 1)")
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ActiveUsersAnalyticsResponse>> GetWeeklyActiveUsersTagWauGetAsResponseAsync(
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
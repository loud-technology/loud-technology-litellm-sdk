#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Get Monthly Active Users<br/>
        /// Get Monthly Active Users (MAU) by tags for the last {MAX_MONTHS} months ending on UTC today + 1 day.<br/>
        /// Shows month-by-month breakdown:<br/>
        /// - Month 1 (Nov): Earliest month (7 months ago, 30-day period)<br/>
        /// - Month 2 (Dec): Next month (6 months ago)<br/>
        /// - Month 3 (Jan): Next month (5 months ago)<br/>
        /// - ... and so on for {MAX_MONTHS} months total<br/>
        /// - Month 7: Most recent month ending on UTC today + 1 day<br/>
        /// Args:<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        /// Returns:<br/>
        ///     ActiveUsersAnalyticsResponse: MAU data by tag for each of the last {MAX_MONTHS} months with descriptive month labels (e.g., "Month 1 (Nov)")
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ActiveUsersAnalyticsResponse> GetMonthlyActiveUsersTagMauGetAsync(
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Monthly Active Users<br/>
        /// Get Monthly Active Users (MAU) by tags for the last {MAX_MONTHS} months ending on UTC today + 1 day.<br/>
        /// Shows month-by-month breakdown:<br/>
        /// - Month 1 (Nov): Earliest month (7 months ago, 30-day period)<br/>
        /// - Month 2 (Dec): Next month (6 months ago)<br/>
        /// - Month 3 (Jan): Next month (5 months ago)<br/>
        /// - ... and so on for {MAX_MONTHS} months total<br/>
        /// - Month 7: Most recent month ending on UTC today + 1 day<br/>
        /// Args:<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        /// Returns:<br/>
        ///     ActiveUsersAnalyticsResponse: MAU data by tag for each of the last {MAX_MONTHS} months with descriptive month labels (e.g., "Month 1 (Nov)")
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ActiveUsersAnalyticsResponse>> GetMonthlyActiveUsersTagMauGetAsResponseAsync(
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Get Tag Summary<br/>
        /// Get summary analytics for tags including unique users, requests, tokens, and spend.<br/>
        /// Args:<br/>
        ///     start_date: Start date for the analytics period (YYYY-MM-DD)<br/>
        ///     end_date: End date for the analytics period (YYYY-MM-DD)<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        /// Returns:<br/>
        ///     TagSummaryResponse: Summary analytics data by tag
        /// </summary>
        /// <param name="startDate">
        /// Start date in YYYY-MM-DD format
        /// </param>
        /// <param name="endDate">
        /// End date in YYYY-MM-DD format
        /// </param>
        /// <param name="tagFilter">
        /// Filter by specific tag (optional)
        /// </param>
        /// <param name="tagFilters">
        /// Filter by multiple specific tags (optional, takes precedence over tag_filter)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TagSummaryResponse> GetTagSummaryTagSummaryGetAsync(
            string startDate,
            string endDate,
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Tag Summary<br/>
        /// Get summary analytics for tags including unique users, requests, tokens, and spend.<br/>
        /// Args:<br/>
        ///     start_date: Start date for the analytics period (YYYY-MM-DD)<br/>
        ///     end_date: End date for the analytics period (YYYY-MM-DD)<br/>
        ///     tag_filter: Optional filter to specific tag (legacy)<br/>
        ///     tag_filters: Optional filter to multiple specific tags (takes precedence over tag_filter)<br/>
        /// Returns:<br/>
        ///     TagSummaryResponse: Summary analytics data by tag
        /// </summary>
        /// <param name="startDate">
        /// Start date in YYYY-MM-DD format
        /// </param>
        /// <param name="endDate">
        /// End date in YYYY-MM-DD format
        /// </param>
        /// <param name="tagFilter">
        /// Filter by specific tag (optional)
        /// </param>
        /// <param name="tagFilters">
        /// Filter by multiple specific tags (optional, takes precedence over tag_filter)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TagSummaryResponse>> GetTagSummaryTagSummaryGetAsResponseAsync(
            string startDate,
            string endDate,
            string? tagFilter = default,
            global::System.Collections.Generic.IList<string>? tagFilters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
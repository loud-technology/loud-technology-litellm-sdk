#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Get Team Daily Activity Aggregated<br/>
        /// Aggregated daily activity for teams without pagination, including per-team breakdown.<br/>
        /// One SQL GROUPING SETS pass returns every day in the range regardless of row<br/>
        /// volume, so callers never reassemble pages. Same response shape as the<br/>
        /// paginated endpoint with page metadata pinned to a single page.<br/>
        /// Args:<br/>
        ///     team_ids (Optional[str]): Comma-separated list of team IDs to filter by. If not provided, returns data for all teams.<br/>
        ///     start_date (Optional[str]): Start date for the activity period (YYYY-MM-DD).<br/>
        ///     end_date (Optional[str]): End date for the activity period (YYYY-MM-DD).<br/>
        ///     model (Optional[str]): Filter by model name.<br/>
        ///     api_key (Optional[str]): Filter by API key.<br/>
        ///     exclude_team_ids (Optional[str]): Comma-separated list of team IDs to exclude.<br/>
        ///     timezone (Optional[int]): Timezone offset in minutes from UTC, matching JavaScript's Date.getTimezoneOffset() convention.<br/>
        /// Returns:<br/>
        ///     SpendAnalyticsPaginatedResponse: Response containing all daily activity data for the range.
        /// </summary>
        /// <param name="teamIds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="apiKey"></param>
        /// <param name="excludeTeamIds"></param>
        /// <param name="timezone"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse> GetTeamDailyActivityAggregatedTeamDailyActivityAggregatedGetAsync(
            string? teamIds = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            string? excludeTeamIds = default,
            int? timezone = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Team Daily Activity Aggregated<br/>
        /// Aggregated daily activity for teams without pagination, including per-team breakdown.<br/>
        /// One SQL GROUPING SETS pass returns every day in the range regardless of row<br/>
        /// volume, so callers never reassemble pages. Same response shape as the<br/>
        /// paginated endpoint with page metadata pinned to a single page.<br/>
        /// Args:<br/>
        ///     team_ids (Optional[str]): Comma-separated list of team IDs to filter by. If not provided, returns data for all teams.<br/>
        ///     start_date (Optional[str]): Start date for the activity period (YYYY-MM-DD).<br/>
        ///     end_date (Optional[str]): End date for the activity period (YYYY-MM-DD).<br/>
        ///     model (Optional[str]): Filter by model name.<br/>
        ///     api_key (Optional[str]): Filter by API key.<br/>
        ///     exclude_team_ids (Optional[str]): Comma-separated list of team IDs to exclude.<br/>
        ///     timezone (Optional[int]): Timezone offset in minutes from UTC, matching JavaScript's Date.getTimezoneOffset() convention.<br/>
        /// Returns:<br/>
        ///     SpendAnalyticsPaginatedResponse: Response containing all daily activity data for the range.
        /// </summary>
        /// <param name="teamIds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="apiKey"></param>
        /// <param name="excludeTeamIds"></param>
        /// <param name="timezone"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse>> GetTeamDailyActivityAggregatedTeamDailyActivityAggregatedGetAsResponseAsync(
            string? teamIds = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            string? excludeTeamIds = default,
            int? timezone = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Get Tag Daily Activity<br/>
        /// Get daily activity for specific tags or all tags.<br/>
        /// Args:<br/>
        ///     tags (Optional[str]): Comma-separated list of tags to filter by. If not provided, returns data for all tags.<br/>
        ///     start_date (Optional[str]): Start date for the activity period (YYYY-MM-DD).<br/>
        ///     end_date (Optional[str]): End date for the activity period (YYYY-MM-DD).<br/>
        ///     model (Optional[str]): Filter by model name.<br/>
        ///     api_key (Optional[str]): Filter by API key.<br/>
        ///     page (int): Page number for pagination.<br/>
        ///     page_size (int): Number of items per page.<br/>
        /// Returns:<br/>
        ///     SpendAnalyticsPaginatedResponse: Paginated response containing daily activity data.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="apiKey"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse> GetTagDailyActivityTagDailyActivityGetAsync(
            string? tags = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Tag Daily Activity<br/>
        /// Get daily activity for specific tags or all tags.<br/>
        /// Args:<br/>
        ///     tags (Optional[str]): Comma-separated list of tags to filter by. If not provided, returns data for all tags.<br/>
        ///     start_date (Optional[str]): Start date for the activity period (YYYY-MM-DD).<br/>
        ///     end_date (Optional[str]): End date for the activity period (YYYY-MM-DD).<br/>
        ///     model (Optional[str]): Filter by model name.<br/>
        ///     api_key (Optional[str]): Filter by API key.<br/>
        ///     page (int): Page number for pagination.<br/>
        ///     page_size (int): Number of items per page.<br/>
        /// Returns:<br/>
        ///     SpendAnalyticsPaginatedResponse: Paginated response containing daily activity data.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="apiKey"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse>> GetTagDailyActivityTagDailyActivityGetAsResponseAsync(
            string? tags = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
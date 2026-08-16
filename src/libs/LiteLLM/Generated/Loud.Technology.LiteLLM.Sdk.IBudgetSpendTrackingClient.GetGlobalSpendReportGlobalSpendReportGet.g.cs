#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Get Global Spend Report<br/>
        /// Get Daily Spend per Team, based on specific startTime and endTime. Per team, view usage by each key, model<br/>
        /// [<br/>
        ///     {<br/>
        ///         "group-by-day": "2024-05-10",<br/>
        ///         "teams": [<br/>
        ///             {<br/>
        ///                 "team_name": "team-1"<br/>
        ///                 "spend": 10,<br/>
        ///                 "keys": [<br/>
        ///                     "key": "1213",<br/>
        ///                     "usage": {<br/>
        ///                         "model-1": {<br/>
        ///                                 "cost": 12.50,<br/>
        ///                                 "input_tokens": 1000,<br/>
        ///                                 "output_tokens": 5000,<br/>
        ///                                 "requests": 100<br/>
        ///                             },<br/>
        ///                             "audio-modelname1": {<br/>
        ///                             "cost": 25.50,<br/>
        ///                             "seconds": 25,<br/>
        ///                             "requests": 50<br/>
        ///                     },<br/>
        ///                     }<br/>
        ///                 }<br/>
        ///         ]<br/>
        ///     ]<br/>
        /// }
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend
        /// </param>
        /// <param name="groupBy">
        /// Group spend by internal team or customer or api_key<br/>
        /// Default Value: team
        /// </param>
        /// <param name="apiKey">
        /// View spend for a specific api_key. Example api_key='sk-1234
        /// </param>
        /// <param name="internalUserId">
        /// View spend for a specific internal_user_id. Example internal_user_id='1234
        /// </param>
        /// <param name="teamId">
        /// View spend for a specific team_id. Example team_id='1234
        /// </param>
        /// <param name="customerId">
        /// View spend for a specific customer_id. Example customer_id='1234. Can be used in conjunction with team_id as well.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMSpendLogs>> GetGlobalSpendReportGlobalSpendReportGetAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.GetGlobalSpendReportGlobalSpendReportGetGroupBy2? groupBy = default,
            string? apiKey = default,
            string? internalUserId = default,
            string? teamId = default,
            string? customerId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Global Spend Report<br/>
        /// Get Daily Spend per Team, based on specific startTime and endTime. Per team, view usage by each key, model<br/>
        /// [<br/>
        ///     {<br/>
        ///         "group-by-day": "2024-05-10",<br/>
        ///         "teams": [<br/>
        ///             {<br/>
        ///                 "team_name": "team-1"<br/>
        ///                 "spend": 10,<br/>
        ///                 "keys": [<br/>
        ///                     "key": "1213",<br/>
        ///                     "usage": {<br/>
        ///                         "model-1": {<br/>
        ///                                 "cost": 12.50,<br/>
        ///                                 "input_tokens": 1000,<br/>
        ///                                 "output_tokens": 5000,<br/>
        ///                                 "requests": 100<br/>
        ///                             },<br/>
        ///                             "audio-modelname1": {<br/>
        ///                             "cost": 25.50,<br/>
        ///                             "seconds": 25,<br/>
        ///                             "requests": 50<br/>
        ///                     },<br/>
        ///                     }<br/>
        ///                 }<br/>
        ///         ]<br/>
        ///     ]<br/>
        /// }
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend
        /// </param>
        /// <param name="groupBy">
        /// Group spend by internal team or customer or api_key<br/>
        /// Default Value: team
        /// </param>
        /// <param name="apiKey">
        /// View spend for a specific api_key. Example api_key='sk-1234
        /// </param>
        /// <param name="internalUserId">
        /// View spend for a specific internal_user_id. Example internal_user_id='1234
        /// </param>
        /// <param name="teamId">
        /// View spend for a specific team_id. Example team_id='1234
        /// </param>
        /// <param name="customerId">
        /// View spend for a specific customer_id. Example customer_id='1234. Can be used in conjunction with team_id as well.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMSpendLogs>>> GetGlobalSpendReportGlobalSpendReportGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.GetGlobalSpendReportGlobalSpendReportGetGroupBy2? groupBy = default,
            string? apiKey = default,
            string? internalUserId = default,
            string? teamId = default,
            string? customerId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
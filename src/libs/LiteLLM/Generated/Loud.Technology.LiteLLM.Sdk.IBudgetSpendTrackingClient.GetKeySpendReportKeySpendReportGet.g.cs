#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Get Key Spend Report<br/>
        /// Get spend for the calling api_key over a date range, with a per-model breakdown.<br/>
        /// Same row shape as `/global/spend/report?api_key=...`, but callable by any key:<br/>
        /// non-admin callers are always scoped to their own api_key, while proxy admins<br/>
        /// may pass `?api_key=` to view any key.
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend (YYYY-MM-DD)
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend (YYYY-MM-DD)
        /// </param>
        /// <param name="apiKey">
        /// View spend for a specific api_key. Proxy admin only; other callers are scoped to their own key. Pass the key's sha256 hash so the raw key stays out of URLs and access logs. Example api_key='d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> GetKeySpendReportKeySpendReportGetAsync(
            string? startDate = default,
            string? endDate = default,
            string? apiKey = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Key Spend Report<br/>
        /// Get spend for the calling api_key over a date range, with a per-model breakdown.<br/>
        /// Same row shape as `/global/spend/report?api_key=...`, but callable by any key:<br/>
        /// non-admin callers are always scoped to their own api_key, while proxy admins<br/>
        /// may pass `?api_key=` to view any key.
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend (YYYY-MM-DD)
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend (YYYY-MM-DD)
        /// </param>
        /// <param name="apiKey">
        /// View spend for a specific api_key. Proxy admin only; other callers are scoped to their own key. Pass the key's sha256 hash so the raw key stays out of URLs and access logs. Example api_key='d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> GetKeySpendReportKeySpendReportGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            string? apiKey = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
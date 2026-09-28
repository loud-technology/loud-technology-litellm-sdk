#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Get User Spend Report<br/>
        /// Get spend for the calling user over a date range, grouped by api_key with a per-model breakdown.<br/>
        /// Same row shape as `/global/spend/report?internal_user_id=...`, but callable by<br/>
        /// any key with a user: non-admin callers are always scoped to their own user_id,<br/>
        /// while proxy admins may pass `?internal_user_id=` to view any user.
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend (YYYY-MM-DD)
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend (YYYY-MM-DD)
        /// </param>
        /// <param name="internalUserId">
        /// View spend for a specific internal_user_id. Proxy admin only; other callers are scoped to their own user_id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> GetUserSpendReportUserSpendReportGetAsync(
            string? startDate = default,
            string? endDate = default,
            string? internalUserId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get User Spend Report<br/>
        /// Get spend for the calling user over a date range, grouped by api_key with a per-model breakdown.<br/>
        /// Same row shape as `/global/spend/report?internal_user_id=...`, but callable by<br/>
        /// any key with a user: non-admin callers are always scoped to their own user_id,<br/>
        /// while proxy admins may pass `?internal_user_id=` to view any user.
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend (YYYY-MM-DD)
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend (YYYY-MM-DD)
        /// </param>
        /// <param name="internalUserId">
        /// View spend for a specific internal_user_id. Proxy admin only; other callers are scoped to their own user_id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> GetUserSpendReportUserSpendReportGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            string? internalUserId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
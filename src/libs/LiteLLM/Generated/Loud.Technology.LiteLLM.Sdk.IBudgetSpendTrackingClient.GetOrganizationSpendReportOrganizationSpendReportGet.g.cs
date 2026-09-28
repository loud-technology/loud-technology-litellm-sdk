#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Get Organization Spend Report<br/>
        /// Get spend for an organization over a date range, grouped by api_key with a per-model and per-team breakdown.<br/>
        /// Covers spend logged against the organization directly and against any of its<br/>
        /// teams. Callable by proxy admins (any organization) and org admins (their own<br/>
        /// organizations). Defaults to the calling key's organization_id when<br/>
        /// `?organization_id=` is omitted.
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend (YYYY-MM-DD)
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend (YYYY-MM-DD)
        /// </param>
        /// <param name="organizationId">
        /// View spend for a specific organization_id. Proxy admins may pass any organization; org admins are scoped to organizations they administer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> GetOrganizationSpendReportOrganizationSpendReportGetAsync(
            string? startDate = default,
            string? endDate = default,
            string? organizationId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Organization Spend Report<br/>
        /// Get spend for an organization over a date range, grouped by api_key with a per-model and per-team breakdown.<br/>
        /// Covers spend logged against the organization directly and against any of its<br/>
        /// teams. Callable by proxy admins (any organization) and org admins (their own<br/>
        /// organizations). Defaults to the calling key's organization_id when<br/>
        /// `?organization_id=` is omitted.
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing spend (YYYY-MM-DD)
        /// </param>
        /// <param name="endDate">
        /// Time till which to view spend (YYYY-MM-DD)
        /// </param>
        /// <param name="organizationId">
        /// View spend for a specific organization_id. Proxy admins may pass any organization; org admins are scoped to organizations they administer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> GetOrganizationSpendReportOrganizationSpendReportGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            string? organizationId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
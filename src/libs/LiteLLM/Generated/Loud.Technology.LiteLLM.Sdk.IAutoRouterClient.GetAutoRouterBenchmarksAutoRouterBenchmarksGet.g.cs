#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAutoRouterClient
    {
        /// <summary>
        /// Get Auto Router Benchmarks<br/>
        /// Benchmarks for the auto-router dashboard: session shape, savings against the configured<br/>
        /// baseline, and prompt-caching behaviour bucketed by what the router did.<br/>
        /// Reads session rollups folded once per request at spend-write time, so this endpoint<br/>
        /// never scans LiteLLM_SpendLogs. A user filter selects only turns attributed to that<br/>
        /// internal user when written; older key-only history remains outside user views. A session<br/>
        /// is in the window when it overlaps it: its last turn is on or after start_date and its first turn is on or before<br/>
        /// end_date. Overall hit rate is over telemetry-bearing turns; each bucket's hit rate is<br/>
        /// over that bucket's turns.<br/>
        /// The rollup supplies the measures, never the list. Which routers appear comes from the<br/>
        /// model registry, so one shows up as soon as it is configured and reads zero until it<br/>
        /// serves traffic, and `routers_in_scope` counts those too rather than only the routers the<br/>
        /// window recorded.
        /// </summary>
        /// <param name="startDate">
        /// YYYY-MM-DD UTC, inclusive (defaults to 30 days before end_date)
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD UTC, inclusive (defaults to today)
        /// </param>
        /// <param name="apiKey">
        /// Filter to one virtual key token hash
        /// </param>
        /// <param name="userId">
        /// Filter to one canonical internal user recorded on each turn
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoRouterBenchmarksResponse> GetAutoRouterBenchmarksAutoRouterBenchmarksGetAsync(
            string? startDate = default,
            string? endDate = default,
            string? apiKey = default,
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Auto Router Benchmarks<br/>
        /// Benchmarks for the auto-router dashboard: session shape, savings against the configured<br/>
        /// baseline, and prompt-caching behaviour bucketed by what the router did.<br/>
        /// Reads session rollups folded once per request at spend-write time, so this endpoint<br/>
        /// never scans LiteLLM_SpendLogs. A user filter selects only turns attributed to that<br/>
        /// internal user when written; older key-only history remains outside user views. A session<br/>
        /// is in the window when it overlaps it: its last turn is on or after start_date and its first turn is on or before<br/>
        /// end_date. Overall hit rate is over telemetry-bearing turns; each bucket's hit rate is<br/>
        /// over that bucket's turns.<br/>
        /// The rollup supplies the measures, never the list. Which routers appear comes from the<br/>
        /// model registry, so one shows up as soon as it is configured and reads zero until it<br/>
        /// serves traffic, and `routers_in_scope` counts those too rather than only the routers the<br/>
        /// window recorded.
        /// </summary>
        /// <param name="startDate">
        /// YYYY-MM-DD UTC, inclusive (defaults to 30 days before end_date)
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD UTC, inclusive (defaults to today)
        /// </param>
        /// <param name="apiKey">
        /// Filter to one virtual key token hash
        /// </param>
        /// <param name="userId">
        /// Filter to one canonical internal user recorded on each turn
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AutoRouterBenchmarksResponse>> GetAutoRouterBenchmarksAutoRouterBenchmarksGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            string? apiKey = default,
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get Tool Spend<br/>
        /// Spend attributed to each tool over a date range, for the Cost Optimization dashboard.<br/>
        /// Reads the ``LiteLLM_DailyToolSpend`` rollup, written at request time from invoked<br/>
        /// tools only (MCP tool calls and response tool_calls; declaring a tool without<br/>
        /// invoking it does not count). A request that invoked multiple tools counts its<br/>
        /// full spend toward each of them, so per-tool numbers are attributions and do not<br/>
        /// sum to a deduplicated total.<br/>
        /// ``by_tool`` is the top ``TOOL_SPEND_TOP_TOOLS`` tools by spend, aggregated in<br/>
        /// SQL, and ``daily`` covers only those tools, so the response is bounded by<br/>
        /// days x TOOL_SPEND_TOP_TOOLS regardless of the requested range or how many<br/>
        /// distinct tool names exist.
        /// </summary>
        /// <param name="startDate">
        /// YYYY-MM-DD (defaults to 30 days ago)
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD (defaults to today)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ToolSpendResponse> GetToolSpendV1ToolSpendGetAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Tool Spend<br/>
        /// Spend attributed to each tool over a date range, for the Cost Optimization dashboard.<br/>
        /// Reads the ``LiteLLM_DailyToolSpend`` rollup, written at request time from invoked<br/>
        /// tools only (MCP tool calls and response tool_calls; declaring a tool without<br/>
        /// invoking it does not count). A request that invoked multiple tools counts its<br/>
        /// full spend toward each of them, so per-tool numbers are attributions and do not<br/>
        /// sum to a deduplicated total.<br/>
        /// ``by_tool`` is the top ``TOOL_SPEND_TOP_TOOLS`` tools by spend, aggregated in<br/>
        /// SQL, and ``daily`` covers only those tools, so the response is bounded by<br/>
        /// days x TOOL_SPEND_TOP_TOOLS regardless of the requested range or how many<br/>
        /// distinct tool names exist.
        /// </summary>
        /// <param name="startDate">
        /// YYYY-MM-DD (defaults to 30 days ago)
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD (defaults to today)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ToolSpendResponse>> GetToolSpendV1ToolSpendGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
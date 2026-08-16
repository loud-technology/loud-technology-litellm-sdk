#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get Tool Usage Logs<br/>
        /// Return paginated spend logs for requests that invoked this tool (from SpendLogToolIndex).<br/>
        /// Declaring a tool in a request body without the model invoking it does not create an entry.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="startDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ToolUsageLogsResponse> GetToolUsageLogsV1ToolToolNameLogsGetAsync(
            string toolName,
            int? page = default,
            int? pageSize = default,
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Tool Usage Logs<br/>
        /// Return paginated spend logs for requests that invoked this tool (from SpendLogToolIndex).<br/>
        /// Declaring a tool in a request body without the model invoking it does not create an entry.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="startDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ToolUsageLogsResponse>> GetToolUsageLogsV1ToolToolNameLogsGetAsResponseAsync(
            string toolName,
            int? page = default,
            int? pageSize = default,
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
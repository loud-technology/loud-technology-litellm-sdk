#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Approve Mcp Server Submission<br/>
        /// Approve a pending MCP server submission (admin only). Mirrors PUT /guardrails/{id}/approve.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable> ApproveMcpServerSubmissionV1McpServerServerIdApprovePutAsync(
            string serverId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approve Mcp Server Submission<br/>
        /// Approve a pending MCP server submission (admin only). Mirrors PUT /guardrails/{id}/approve.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable>> ApproveMcpServerSubmissionV1McpServerServerIdApprovePutAsResponseAsync(
            string serverId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
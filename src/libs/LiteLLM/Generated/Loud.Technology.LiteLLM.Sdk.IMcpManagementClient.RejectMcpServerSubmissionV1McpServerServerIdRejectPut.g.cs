#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Reject Mcp Server Submission<br/>
        /// Reject a pending MCP server submission (admin only). Mirrors PUT /guardrails/{id}/reject.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable> RejectMcpServerSubmissionV1McpServerServerIdRejectPutAsync(
            string serverId,

            global::Loud.Technology.LiteLLM.Sdk.RejectMCPServerRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reject Mcp Server Submission<br/>
        /// Reject a pending MCP server submission (admin only). Mirrors PUT /guardrails/{id}/reject.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable>> RejectMcpServerSubmissionV1McpServerServerIdRejectPutAsResponseAsync(
            string serverId,

            global::Loud.Technology.LiteLLM.Sdk.RejectMCPServerRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reject Mcp Server Submission<br/>
        /// Reject a pending MCP server submission (admin only). Mirrors PUT /guardrails/{id}/reject.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="reviewNotes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable> RejectMcpServerSubmissionV1McpServerServerIdRejectPutAsync(
            string serverId,
            string? reviewNotes = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
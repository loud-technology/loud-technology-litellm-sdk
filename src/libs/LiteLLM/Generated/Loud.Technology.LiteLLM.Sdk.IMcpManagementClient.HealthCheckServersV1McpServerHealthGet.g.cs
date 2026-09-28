#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Health Check Servers<br/>
        /// Health check for MCP servers
        /// </summary>
        /// <param name="serverIds">
        /// Server IDs to check. If not provided, checks all accessible servers.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthCheckServersV1McpServerHealthGetAsync(
            global::System.Collections.Generic.IList<string>? serverIds = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Check Servers<br/>
        /// Health check for MCP servers
        /// </summary>
        /// <param name="serverIds">
        /// Server IDs to check. If not provided, checks all accessible servers.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthCheckServersV1McpServerHealthGetAsResponseAsync(
            global::System.Collections.Generic.IList<string>? serverIds = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
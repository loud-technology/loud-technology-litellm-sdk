#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpManagementClient
    {
        /// <summary>
        /// Store Mcp User Env Vars<br/>
        /// Store the calling user's per-user MCP env var values for this server. Submitted values are merged over any previously stored values, so you only send the fields you want to set or change; a variable omitted (or sent empty) keeps its stored value. Use DELETE to clear all stored values.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.MCPUserEnvVarsStatus> StoreMcpUserEnvVarsV1McpServerServerIdUserEnvVarsPostAsync(
            string serverId,

            global::Loud.Technology.LiteLLM.Sdk.MCPUserEnvVarsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store Mcp User Env Vars<br/>
        /// Store the calling user's per-user MCP env var values for this server. Submitted values are merged over any previously stored values, so you only send the fields you want to set or change; a variable omitted (or sent empty) keeps its stored value. Use DELETE to clear all stored values.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.MCPUserEnvVarsStatus>> StoreMcpUserEnvVarsV1McpServerServerIdUserEnvVarsPostAsResponseAsync(
            string serverId,

            global::Loud.Technology.LiteLLM.Sdk.MCPUserEnvVarsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store Mcp User Env Vars<br/>
        /// Store the calling user's per-user MCP env var values for this server. Submitted values are merged over any previously stored values, so you only send the fields you want to set or change; a variable omitted (or sent empty) keeps its stored value. Use DELETE to clear all stored values.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="values"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.MCPUserEnvVarsStatus> StoreMcpUserEnvVarsV1McpServerServerIdUserEnvVarsPostAsync(
            string serverId,
            global::System.Collections.Generic.Dictionary<string, string> values,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
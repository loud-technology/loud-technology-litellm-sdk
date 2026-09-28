#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Toolset Mcp Route<br/>
        /// Namespace a toolset as its own MCP endpoint.<br/>
        /// Connecting to /toolset/&lt;name&gt;/mcp exposes exactly the tools defined in<br/>
        /// the toolset. Access is enforced: non-admin API keys must have the toolset<br/>
        /// listed in their object_permission.mcp_toolsets grant list, or the request<br/>
        /// will be rejected with a 403.
        /// </summary>
        /// <param name="toolsetName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ToolsetMcpRouteToolsetToolsetNameMcpPatchAsync(
            string toolsetName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Toolset Mcp Route<br/>
        /// Namespace a toolset as its own MCP endpoint.<br/>
        /// Connecting to /toolset/&lt;name&gt;/mcp exposes exactly the tools defined in<br/>
        /// the toolset. Access is enforced: non-admin API keys must have the toolset<br/>
        /// listed in their object_permission.mcp_toolsets grant list, or the request<br/>
        /// will be rejected with a 403.
        /// </summary>
        /// <param name="toolsetName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ToolsetMcpRouteToolsetToolsetNameMcpPatchAsResponseAsync(
            string toolsetName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
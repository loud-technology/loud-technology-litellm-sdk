#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Dynamic Mcp Route<br/>
        /// Handle /{name}/mcp for MCP server aliases, toolsets, MCP access group tags, and comma-separated lists.<br/>
        /// Resolution order:<br/>
        /// 1. Registered MCP server alias / name<br/>
        /// 2. Comma-separated list (short-circuits before any DB call)<br/>
        /// 3. Toolset name (DB lookup, cached)<br/>
        /// 4. MCP access group tag (DB lookup, cached)
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DynamicMcpRouteMcpServerNameMcpPatchAsync(
            string mcpServerName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dynamic Mcp Route<br/>
        /// Handle /{name}/mcp for MCP server aliases, toolsets, MCP access group tags, and comma-separated lists.<br/>
        /// Resolution order:<br/>
        /// 1. Registered MCP server alias / name<br/>
        /// 2. Comma-separated list (short-circuits before any DB call)<br/>
        /// 3. Toolset name (DB lookup, cached)<br/>
        /// 4. MCP access group tag (DB lookup, cached)
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DynamicMcpRouteMcpServerNameMcpPatchAsResponseAsync(
            string mcpServerName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
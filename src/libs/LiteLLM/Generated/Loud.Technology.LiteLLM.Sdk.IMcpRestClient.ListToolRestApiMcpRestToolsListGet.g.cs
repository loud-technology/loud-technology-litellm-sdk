#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpRestClient
    {
        /// <summary>
        /// List Tool Rest Api<br/>
        /// List all available tools with information about the server they belong to.<br/>
        /// Example response:<br/>
        /// {<br/>
        ///     "tools": [<br/>
        ///         {<br/>
        ///             "name": "create_zap",<br/>
        ///             "description": "Create a new zap",<br/>
        ///             "inputSchema": "tool_input_schema",<br/>
        ///             "mcp_info": {<br/>
        ///                 "server_name": "zapier",<br/>
        ///                 "logo_url": "https://www.zapier.com/logo.png",<br/>
        ///                 "server_id": "a1b2c3d4-...",<br/>
        ///                 "alias": "zapier_prod",<br/>
        ///             }<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "error": null,<br/>
        ///     "message": "Successfully retrieved tools"<br/>
        /// }
        /// </summary>
        /// <param name="serverId">
        /// The server id to list tools for
        /// </param>
        /// <param name="mcpServerName">
        /// Filter tools to a single MCP server by name or alias
        /// </param>
        /// <param name="toolsetName">
        /// Filter tools to a single toolset by name
        /// </param>
        /// <param name="includeDisabledTools">
        /// Admin only. Return the full server tool catalog without the allowed_tools filter or per-key tool permissions, so the MCP settings UI can configure the allowlist. Ignored for non-admins.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListToolRestApiMcpRestToolsListGetAsync(
            string? serverId = default,
            string? mcpServerName = default,
            string? toolsetName = default,
            bool? includeDisabledTools = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tool Rest Api<br/>
        /// List all available tools with information about the server they belong to.<br/>
        /// Example response:<br/>
        /// {<br/>
        ///     "tools": [<br/>
        ///         {<br/>
        ///             "name": "create_zap",<br/>
        ///             "description": "Create a new zap",<br/>
        ///             "inputSchema": "tool_input_schema",<br/>
        ///             "mcp_info": {<br/>
        ///                 "server_name": "zapier",<br/>
        ///                 "logo_url": "https://www.zapier.com/logo.png",<br/>
        ///                 "server_id": "a1b2c3d4-...",<br/>
        ///                 "alias": "zapier_prod",<br/>
        ///             }<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "error": null,<br/>
        ///     "message": "Successfully retrieved tools"<br/>
        /// }
        /// </summary>
        /// <param name="serverId">
        /// The server id to list tools for
        /// </param>
        /// <param name="mcpServerName">
        /// Filter tools to a single MCP server by name or alias
        /// </param>
        /// <param name="toolsetName">
        /// Filter tools to a single toolset by name
        /// </param>
        /// <param name="includeDisabledTools">
        /// Admin only. Return the full server tool catalog without the allowed_tools filter or per-key tool permissions, so the MCP settings UI can configure the allowlist. Ignored for non-admins.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListToolRestApiMcpRestToolsListGetAsResponseAsync(
            string? serverId = default,
            string? mcpServerName = default,
            string? toolsetName = default,
            bool? includeDisabledTools = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
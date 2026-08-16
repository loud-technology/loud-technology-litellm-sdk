#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpRestClient
    {
        /// <summary>
        /// Test Tools List<br/>
        /// Preview tools available from MCP server before adding it
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestToolsListMcpRestTestToolsListPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Tools List<br/>
        /// Preview tools available from MCP server before adding it
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestToolsListMcpRestTestToolsListPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Tools List<br/>
        /// Preview tools available from MCP server before adding it
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="allowAllKeys">
        /// Default Value: false
        /// </param>
        /// <param name="allowedTools"></param>
        /// <param name="approvalStatus">
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </param>
        /// <param name="args"></param>
        /// <param name="authType"></param>
        /// <param name="authorizationUrl"></param>
        /// <param name="availableOnPublicInternet">
        /// Default Value: true
        /// </param>
        /// <param name="byokApiKeyHelpUrl"></param>
        /// <param name="byokDescription"></param>
        /// <param name="command"></param>
        /// <param name="credentials"></param>
        /// <param name="description"></param>
        /// <param name="env"></param>
        /// <param name="extraHeaders"></param>
        /// <param name="instructions"></param>
        /// <param name="isByok">
        /// Default Value: false
        /// </param>
        /// <param name="mcpAccessGroups"></param>
        /// <param name="mcpInfo"></param>
        /// <param name="oauth2Flow"></param>
        /// <param name="registrationUrl"></param>
        /// <param name="serverId"></param>
        /// <param name="serverName"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="specPath"></param>
        /// <param name="staticHeaders"></param>
        /// <param name="submittedAt">
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </param>
        /// <param name="submittedBy">
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </param>
        /// <param name="tokenUrl"></param>
        /// <param name="toolNameToDescription"></param>
        /// <param name="toolNameToDisplayName"></param>
        /// <param name="transport">
        /// Default Value: sse
        /// </param>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TestToolsListMcpRestTestToolsListPostAsync(
            string? alias = default,
            bool? allowAllKeys = default,
            global::System.Collections.Generic.IList<string>? allowedTools = default,
            string? approvalStatus = default,
            global::System.Collections.Generic.IList<string>? args = default,
            global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestAuthType2? authType = default,
            string? authorizationUrl = default,
            bool? availableOnPublicInternet = default,
            string? byokApiKeyHelpUrl = default,
            global::System.Collections.Generic.IList<string>? byokDescription = default,
            string? command = default,
            global::Loud.Technology.LiteLLM.Sdk.MCPCredentials? credentials = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            global::System.Collections.Generic.IList<string>? extraHeaders = default,
            string? instructions = default,
            bool? isByok = default,
            global::System.Collections.Generic.IList<string>? mcpAccessGroups = default,
            object? mcpInfo = default,
            global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestOauth2Flow2? oauth2Flow = default,
            string? registrationUrl = default,
            string? serverId = default,
            string? serverName = default,
            string? sourceUrl = default,
            string? specPath = default,
            global::System.Collections.Generic.Dictionary<string, string>? staticHeaders = default,
            global::System.DateTime? submittedAt = default,
            string? submittedBy = default,
            string? tokenUrl = default,
            global::System.Collections.Generic.Dictionary<string, string>? toolNameToDescription = default,
            global::System.Collections.Generic.Dictionary<string, string>? toolNameToDisplayName = default,
            global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestTransport? transport = default,
            string? url = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
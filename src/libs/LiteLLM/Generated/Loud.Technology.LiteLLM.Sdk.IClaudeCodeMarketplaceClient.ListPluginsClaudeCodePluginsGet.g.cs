#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IClaudeCodeMarketplaceClient
    {
        /// <summary>
        /// List Plugins<br/>
        /// List all plugins in the marketplace.<br/>
        /// Parameters:<br/>
        ///     - enabled_only: If true, only return enabled plugins<br/>
        /// Returns:<br/>
        ///     List of plugins with their metadata.
        /// </summary>
        /// <param name="enabledOnly">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListPluginsResponse> ListPluginsClaudeCodePluginsGetAsync(
            bool? enabledOnly = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Plugins<br/>
        /// List all plugins in the marketplace.<br/>
        /// Parameters:<br/>
        ///     - enabled_only: If true, only return enabled plugins<br/>
        /// Returns:<br/>
        ///     List of plugins with their metadata.
        /// </summary>
        /// <param name="enabledOnly">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListPluginsResponse>> ListPluginsClaudeCodePluginsGetAsResponseAsync(
            bool? enabledOnly = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
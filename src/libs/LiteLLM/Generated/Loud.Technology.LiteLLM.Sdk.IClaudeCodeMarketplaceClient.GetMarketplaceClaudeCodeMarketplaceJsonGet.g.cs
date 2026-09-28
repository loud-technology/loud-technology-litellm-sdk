#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IClaudeCodeMarketplaceClient
    {
        /// <summary>
        /// Get Marketplace<br/>
        /// Serve marketplace.json for Claude Code plugin discovery.<br/>
        /// This endpoint is accessed by Claude Code CLI when users run:<br/>
        /// - claude plugin marketplace add &lt;url&gt;<br/>
        /// - claude plugin install &lt;name&gt;@&lt;marketplace&gt;<br/>
        /// Without `key` the catalog holds the enabled (public) plugins. With `?key=sk-...`<br/>
        /// the key is authenticated and the catalog also holds the disabled plugins granted<br/>
        /// to it through `object_permission.skills` on the key or its team.<br/>
        /// Returns:<br/>
        ///     Marketplace catalog with list of available plugins and their git sources.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     claude plugin marketplace add http://localhost:4000/claude-code/marketplace.json<br/>
        ///     claude plugin marketplace add "http://localhost:4000/claude-code/marketplace.json?key=sk-..."<br/>
        ///     claude plugin install my-plugin@litellm<br/>
        ///     ```
        /// </summary>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetMarketplaceClaudeCodeMarketplaceJsonGetAsync(
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Marketplace<br/>
        /// Serve marketplace.json for Claude Code plugin discovery.<br/>
        /// This endpoint is accessed by Claude Code CLI when users run:<br/>
        /// - claude plugin marketplace add &lt;url&gt;<br/>
        /// - claude plugin install &lt;name&gt;@&lt;marketplace&gt;<br/>
        /// Without `key` the catalog holds the enabled (public) plugins. With `?key=sk-...`<br/>
        /// the key is authenticated and the catalog also holds the disabled plugins granted<br/>
        /// to it through `object_permission.skills` on the key or its team.<br/>
        /// Returns:<br/>
        ///     Marketplace catalog with list of available plugins and their git sources.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     claude plugin marketplace add http://localhost:4000/claude-code/marketplace.json<br/>
        ///     claude plugin marketplace add "http://localhost:4000/claude-code/marketplace.json?key=sk-..."<br/>
        ///     claude plugin install my-plugin@litellm<br/>
        ///     ```
        /// </summary>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetMarketplaceClaudeCodeMarketplaceJsonGetAsResponseAsync(
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
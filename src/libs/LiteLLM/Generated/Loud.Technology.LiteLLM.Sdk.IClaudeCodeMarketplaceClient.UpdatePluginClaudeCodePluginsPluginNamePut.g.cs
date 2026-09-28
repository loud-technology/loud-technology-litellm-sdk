#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IClaudeCodeMarketplaceClient
    {
        /// <summary>
        /// Update Plugin<br/>
        /// Update an existing plugin in the LiteLLM marketplace.<br/>
        /// The plugin is identified by its name in the path, which is the resource<br/>
        /// identity and cannot be changed here. This is a full replace, not a merge:<br/>
        /// the manifest is rebuilt from the request body, so any optional field left<br/>
        /// out is reset to its default (e.g. an omitted version is cleared, not kept).<br/>
        /// Send the full desired state.<br/>
        /// Returns 404 if no plugin with the given name exists; use<br/>
        /// POST /claude-code/plugins to create a new plugin.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: Name of the plugin to update (path parameter)<br/>
        ///     - source: Plugin source reference (github, url, git-subdir, or archive format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Update status (action is always "updated") and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X PUT http://localhost:4000/claude-code/plugins/my-plugin \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "2.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse> UpdatePluginClaudeCodePluginsPluginNamePutAsync(
            string pluginName,

            global::Loud.Technology.LiteLLM.Sdk.UpdatePluginRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Plugin<br/>
        /// Update an existing plugin in the LiteLLM marketplace.<br/>
        /// The plugin is identified by its name in the path, which is the resource<br/>
        /// identity and cannot be changed here. This is a full replace, not a merge:<br/>
        /// the manifest is rebuilt from the request body, so any optional field left<br/>
        /// out is reset to its default (e.g. an omitted version is cleared, not kept).<br/>
        /// Send the full desired state.<br/>
        /// Returns 404 if no plugin with the given name exists; use<br/>
        /// POST /claude-code/plugins to create a new plugin.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: Name of the plugin to update (path parameter)<br/>
        ///     - source: Plugin source reference (github, url, git-subdir, or archive format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Update status (action is always "updated") and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X PUT http://localhost:4000/claude-code/plugins/my-plugin \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "2.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse>> UpdatePluginClaudeCodePluginsPluginNamePutAsResponseAsync(
            string pluginName,

            global::Loud.Technology.LiteLLM.Sdk.UpdatePluginRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Plugin<br/>
        /// Update an existing plugin in the LiteLLM marketplace.<br/>
        /// The plugin is identified by its name in the path, which is the resource<br/>
        /// identity and cannot be changed here. This is a full replace, not a merge:<br/>
        /// the manifest is rebuilt from the request body, so any optional field left<br/>
        /// out is reset to its default (e.g. an omitted version is cleared, not kept).<br/>
        /// Send the full desired state.<br/>
        /// Returns 404 if no plugin with the given name exists; use<br/>
        /// POST /claude-code/plugins to create a new plugin.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: Name of the plugin to update (path parameter)<br/>
        ///     - source: Plugin source reference (github, url, git-subdir, or archive format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Update status (action is always "updated") and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X PUT http://localhost:4000/claude-code/plugins/my-plugin \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "2.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="author">
        /// Plugin author
        /// </param>
        /// <param name="category">
        /// Plugin category
        /// </param>
        /// <param name="description">
        /// Plugin description
        /// </param>
        /// <param name="domain">
        /// Skill domain (e.g., 'Productivity')
        /// </param>
        /// <param name="homepage">
        /// Plugin homepage URL
        /// </param>
        /// <param name="keywords">
        /// Search keywords
        /// </param>
        /// <param name="namespace">
        /// Skill namespace within domain (e.g., 'workflows')
        /// </param>
        /// <param name="source">
        /// Plugin source reference. Supported formats:<br/>
        /// - GitHub: {'source': 'github', 'repo': 'org/repo'}<br/>
        /// - Git URL: {'source': 'url', 'url': 'https://github.com/org/repo.git'}<br/>
        /// - Git Subdir: {'source': 'git-subdir', 'url': 'https://github.com/org/repo.git', 'path': 'plugins/plugin-name'}<br/>
        /// - Zip archive on any https host (e.g. S3): {'source': 'archive', 'url': 'https://bucket.s3.amazonaws.com/plugin.zip', 'sha256': '&lt;optional hex digest&gt;'}
        /// </param>
        /// <param name="version">
        /// Semantic version; cleared if omitted
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse> UpdatePluginClaudeCodePluginsPluginNamePutAsync(
            string pluginName,
            global::System.Collections.Generic.Dictionary<string, string> source,
            global::Loud.Technology.LiteLLM.Sdk.PluginAuthor? author = default,
            string? category = default,
            string? description = default,
            string? domain = default,
            string? homepage = default,
            global::System.Collections.Generic.IList<string>? keywords = default,
            string? @namespace = default,
            string? version = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
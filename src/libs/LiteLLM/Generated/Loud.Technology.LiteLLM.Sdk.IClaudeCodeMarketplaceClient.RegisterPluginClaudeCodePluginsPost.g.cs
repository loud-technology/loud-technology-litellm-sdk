#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IClaudeCodeMarketplaceClient
    {
        /// <summary>
        /// Register Plugin<br/>
        /// Register a plugin in the LiteLLM marketplace.<br/>
        /// LiteLLM acts as a registry/discovery layer. Plugins are hosted on<br/>
        /// GitHub/GitLab/Bitbucket. Claude Code will clone from the git source<br/>
        /// when users install.<br/>
        /// Parameters:<br/>
        ///     - name: Plugin name (kebab-case)<br/>
        ///     - source: Git source reference (github, url, or git-subdir format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Registration status and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X POST http://localhost:4000/claude-code/plugins \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "name": "my-plugin",<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "1.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RegisterPluginClaudeCodePluginsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.RegisterPluginRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register Plugin<br/>
        /// Register a plugin in the LiteLLM marketplace.<br/>
        /// LiteLLM acts as a registry/discovery layer. Plugins are hosted on<br/>
        /// GitHub/GitLab/Bitbucket. Claude Code will clone from the git source<br/>
        /// when users install.<br/>
        /// Parameters:<br/>
        ///     - name: Plugin name (kebab-case)<br/>
        ///     - source: Git source reference (github, url, or git-subdir format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Registration status and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X POST http://localhost:4000/claude-code/plugins \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "name": "my-plugin",<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "1.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> RegisterPluginClaudeCodePluginsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.RegisterPluginRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register Plugin<br/>
        /// Register a plugin in the LiteLLM marketplace.<br/>
        /// LiteLLM acts as a registry/discovery layer. Plugins are hosted on<br/>
        /// GitHub/GitLab/Bitbucket. Claude Code will clone from the git source<br/>
        /// when users install.<br/>
        /// Parameters:<br/>
        ///     - name: Plugin name (kebab-case)<br/>
        ///     - source: Git source reference (github, url, or git-subdir format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Registration status and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X POST http://localhost:4000/claude-code/plugins \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "name": "my-plugin",<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "1.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
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
        /// <param name="name">
        /// Plugin name (kebab-case, e.g., 'my-plugin')
        /// </param>
        /// <param name="namespace">
        /// Skill namespace within domain (e.g., 'workflows')
        /// </param>
        /// <param name="source">
        /// Git source reference. Supported formats:<br/>
        /// - GitHub: {'source': 'github', 'repo': 'org/repo'}<br/>
        /// - Git URL: {'source': 'url', 'url': 'https://github.com/org/repo.git'}<br/>
        /// - Git Subdir: {'source': 'git-subdir', 'url': 'https://github.com/org/repo.git', 'path': 'plugins/plugin-name'}
        /// </param>
        /// <param name="version">
        /// Semantic version<br/>
        /// Default Value: 1.0.0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RegisterPluginClaudeCodePluginsPostAsync(
            string name,
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
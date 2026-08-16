
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for registering a plugin in the marketplace.<br/>
    /// LiteLLM acts as a registry/discovery layer. Plugins are hosted on<br/>
    /// GitHub/GitLab/Bitbucket and referenced by their git source.
    /// </summary>
    public sealed partial class RegisterPluginRequest
    {
        /// <summary>
        /// Plugin author
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::Loud.Technology.LiteLLM.Sdk.PluginAuthor? Author { get; set; }

        /// <summary>
        /// Plugin category
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Plugin description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Skill domain (e.g., 'Productivity')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Plugin homepage URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// Search keywords
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Plugin name (kebab-case, e.g., 'my-plugin')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Skill namespace within domain (e.g., 'workflows')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Git source reference. Supported formats:<br/>
        /// - GitHub: {'source': 'github', 'repo': 'org/repo'}<br/>
        /// - Git URL: {'source': 'url', 'url': 'https://github.com/org/repo.git'}<br/>
        /// - Git Subdir: {'source': 'git-subdir', 'url': 'https://github.com/org/repo.git', 'path': 'plugins/plugin-name'}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Source { get; set; }

        /// <summary>
        /// Semantic version<br/>
        /// Default Value: 1.0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPluginRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Plugin name (kebab-case, e.g., 'my-plugin')
        /// </param>
        /// <param name="source">
        /// Git source reference. Supported formats:<br/>
        /// - GitHub: {'source': 'github', 'repo': 'org/repo'}<br/>
        /// - Git URL: {'source': 'url', 'url': 'https://github.com/org/repo.git'}<br/>
        /// - Git Subdir: {'source': 'git-subdir', 'url': 'https://github.com/org/repo.git', 'path': 'plugins/plugin-name'}
        /// </param>
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
        /// <param name="version">
        /// Semantic version<br/>
        /// Default Value: 1.0.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterPluginRequest(
            string name,
            global::System.Collections.Generic.Dictionary<string, string> source,
            global::Loud.Technology.LiteLLM.Sdk.PluginAuthor? author,
            string? category,
            string? description,
            string? domain,
            string? homepage,
            global::System.Collections.Generic.IList<string>? keywords,
            string? @namespace,
            string? version)
        {
            this.Author = author;
            this.Category = category;
            this.Description = description;
            this.Domain = domain;
            this.Homepage = homepage;
            this.Keywords = keywords;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Namespace = @namespace;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPluginRequest" /> class.
        /// </summary>
        public RegisterPluginRequest()
        {
        }

    }
}
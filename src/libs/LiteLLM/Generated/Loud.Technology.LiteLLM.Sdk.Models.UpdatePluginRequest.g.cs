
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for replacing an existing plugin.<br/>
    /// The plugin name is the resource identity and is supplied as the path<br/>
    /// parameter, so it cannot be changed here. This is a full replace: omitted<br/>
    /// fields reset to their defaults, so version is cleared rather than<br/>
    /// defaulting to the create-time "1.0.0".
    /// </summary>
    public sealed partial class UpdatePluginRequest
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
        /// Skill namespace within domain (e.g., 'workflows')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Plugin source reference. Supported formats:<br/>
        /// - GitHub: {'source': 'github', 'repo': 'org/repo'}<br/>
        /// - Git URL: {'source': 'url', 'url': 'https://github.com/org/repo.git'}<br/>
        /// - Git Subdir: {'source': 'git-subdir', 'url': 'https://github.com/org/repo.git', 'path': 'plugins/plugin-name'}<br/>
        /// - Zip archive on any https host (e.g. S3): {'source': 'archive', 'url': 'https://bucket.s3.amazonaws.com/plugin.zip', 'sha256': '&lt;optional hex digest&gt;'}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Source { get; set; }

        /// <summary>
        /// Semantic version; cleared if omitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePluginRequest" /> class.
        /// </summary>
        /// <param name="source">
        /// Plugin source reference. Supported formats:<br/>
        /// - GitHub: {'source': 'github', 'repo': 'org/repo'}<br/>
        /// - Git URL: {'source': 'url', 'url': 'https://github.com/org/repo.git'}<br/>
        /// - Git Subdir: {'source': 'git-subdir', 'url': 'https://github.com/org/repo.git', 'path': 'plugins/plugin-name'}<br/>
        /// - Zip archive on any https host (e.g. S3): {'source': 'archive', 'url': 'https://bucket.s3.amazonaws.com/plugin.zip', 'sha256': '&lt;optional hex digest&gt;'}
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
        /// Semantic version; cleared if omitted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePluginRequest(
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
            this.Namespace = @namespace;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePluginRequest" /> class.
        /// </summary>
        public UpdatePluginRequest()
        {
        }

    }
}
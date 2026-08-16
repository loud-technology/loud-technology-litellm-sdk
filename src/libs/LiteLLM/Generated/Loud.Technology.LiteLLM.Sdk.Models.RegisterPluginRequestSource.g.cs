
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Git source reference. Supported formats:<br/>
    /// - GitHub: {'source': 'github', 'repo': 'org/repo'}<br/>
    /// - Git URL: {'source': 'url', 'url': 'https://github.com/org/repo.git'}<br/>
    /// - Git Subdir: {'source': 'git-subdir', 'url': 'https://github.com/org/repo.git', 'path': 'plugins/plugin-name'}
    /// </summary>
    public sealed partial class RegisterPluginRequestSource
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
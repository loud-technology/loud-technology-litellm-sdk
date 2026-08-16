
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicModelHubInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocsTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_docs_description")]
        public string? CustomDocsDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LitellmVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useful_links")]
        public object? UsefulLinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicModelHubInfo" /> class.
        /// </summary>
        /// <param name="docsTitle"></param>
        /// <param name="litellmVersion"></param>
        /// <param name="customDocsDescription"></param>
        /// <param name="usefulLinks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicModelHubInfo(
            string docsTitle,
            string litellmVersion,
            string? customDocsDescription,
            object? usefulLinks)
        {
            this.DocsTitle = docsTitle ?? throw new global::System.ArgumentNullException(nameof(docsTitle));
            this.CustomDocsDescription = customDocsDescription;
            this.LitellmVersion = litellmVersion ?? throw new global::System.ArgumentNullException(nameof(litellmVersion));
            this.UsefulLinks = usefulLinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicModelHubInfo" /> class.
        /// </summary>
        public PublicModelHubInfo()
        {
        }

    }
}
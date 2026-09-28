
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// category: "harmful_self_harm"<br/>
    ///               enabled: true<br/>
    ///               action: "BLOCK"<br/>
    ///               severity_threshold: "medium"<br/>
    ///               category_file: "/path/to/custom_file.yaml"  # optional override
    /// </summary>
    public sealed partial class ContentFilterCategoryConfig
    {
        /// <summary>
        /// The action to take when the category is detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ContentFilterCategoryConfigActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ContentFilterCategoryConfigAction Action { get; set; }

        /// <summary>
        /// The category to detect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// Optional override. Use your own category file instead of the default one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_file")]
        public string? CategoryFile { get; set; }

        /// <summary>
        /// Whether the category is enabled<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The severity threshold to detect the category<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_threshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ContentFilterCategoryConfigSeverityThresholdJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.ContentFilterCategoryConfigSeverityThreshold? SeverityThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterCategoryConfig" /> class.
        /// </summary>
        /// <param name="action">
        /// The action to take when the category is detected
        /// </param>
        /// <param name="category">
        /// The category to detect
        /// </param>
        /// <param name="categoryFile">
        /// Optional override. Use your own category file instead of the default one.
        /// </param>
        /// <param name="enabled">
        /// Whether the category is enabled<br/>
        /// Default Value: true
        /// </param>
        /// <param name="severityThreshold">
        /// The severity threshold to detect the category<br/>
        /// Default Value: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFilterCategoryConfig(
            global::Loud.Technology.LiteLLM.Sdk.ContentFilterCategoryConfigAction action,
            string category,
            string? categoryFile,
            bool? enabled,
            global::Loud.Technology.LiteLLM.Sdk.ContentFilterCategoryConfigSeverityThreshold? severityThreshold)
        {
            this.Action = action;
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.CategoryFile = categoryFile;
            this.Enabled = enabled;
            this.SeverityThreshold = severityThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterCategoryConfig" /> class.
        /// </summary>
        public ContentFilterCategoryConfig()
        {
        }

    }
}
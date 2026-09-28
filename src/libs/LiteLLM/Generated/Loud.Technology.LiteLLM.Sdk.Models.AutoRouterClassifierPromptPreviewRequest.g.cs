
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A POST rather than query params: the classification sections are the operator's own text,<br/>
    /// which must not reach access logs through a URL.
    /// </summary>
    public sealed partial class AutoRouterClassifierPromptPreviewRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_definitions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDefinition>? TierDefinitions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? TierLabels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_rubric")]
        public global::Loud.Technology.LiteLLM.Sdk.ClassificationRubric? ClassificationRubric { get; set; }

        /// <summary>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window_size")]
        public int? ContextWindowSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_prompt")]
        public string? ClassificationPrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_examples")]
        public string? ClassificationExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterClassifierPromptPreviewRequest" /> class.
        /// </summary>
        /// <param name="tierDefinitions"></param>
        /// <param name="tierLabels"></param>
        /// <param name="classificationRubric"></param>
        /// <param name="contextWindowSize">
        /// Default Value: 3
        /// </param>
        /// <param name="classificationPrompt"></param>
        /// <param name="classificationExamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterClassifierPromptPreviewRequest(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDefinition>? tierDefinitions,
            global::System.Collections.Generic.Dictionary<string, string>? tierLabels,
            global::Loud.Technology.LiteLLM.Sdk.ClassificationRubric? classificationRubric,
            int? contextWindowSize,
            string? classificationPrompt,
            string? classificationExamples)
        {
            this.TierDefinitions = tierDefinitions;
            this.TierLabels = tierLabels;
            this.ClassificationRubric = classificationRubric;
            this.ContextWindowSize = contextWindowSize;
            this.ClassificationPrompt = classificationPrompt;
            this.ClassificationExamples = classificationExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterClassifierPromptPreviewRequest" /> class.
        /// </summary>
        public AutoRouterClassifierPromptPreviewRequest()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptTemplateBase
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_prompt_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LitellmPromptId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplateBase" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="litellmPromptId"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptTemplateBase(
            string content,
            string litellmPromptId,
            object? metadata)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.LitellmPromptId = litellmPromptId ?? throw new global::System.ArgumentNullException(nameof(litellmPromptId));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplateBase" /> class.
        /// </summary>
        public PromptTemplateBase()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionAnnotation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        public global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAnnotationURLCitation? UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAnnotation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="urlCitation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAnnotation(
            string? type,
            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAnnotationURLCitation? urlCitation)
        {
            this.Type = type;
            this.UrlCitation = urlCitation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAnnotation" /> class.
        /// </summary>
        public ChatCompletionAnnotation()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Represents an OpenAI Responses API reasoning item for round-tripping in conversation history.
    /// </summary>
    public sealed partial class ChatCompletionReasoningItem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"reasoning"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "reasoning";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionReasoningSummaryTextBlock>? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionReasoningItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="summary"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionReasoningItem(
            string? id,
            string? encryptedContent,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionReasoningSummaryTextBlock>? summary,
            string type = "reasoning")
        {
            this.Type = type;
            this.Id = id;
            this.EncryptedContent = encryptedContent;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionReasoningItem" /> class.
        /// </summary>
        public ChatCompletionReasoningItem()
        {
        }

    }
}
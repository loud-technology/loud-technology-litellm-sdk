
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.MessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        public global::Loud.Technology.LiteLLM.Sdk.FunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAudioResponse? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ImageURLListItem>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_blocks")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionThinkingBlock, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionRedactedThinkingBlock>>? ThinkingBlocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_items")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionReasoningItem>? ReasoningItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_specific_fields")]
        public object? ProviderSpecificFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAnnotation>? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="toolCalls"></param>
        /// <param name="functionCall"></param>
        /// <param name="audio"></param>
        /// <param name="images"></param>
        /// <param name="reasoningContent"></param>
        /// <param name="thinkingBlocks"></param>
        /// <param name="reasoningItems"></param>
        /// <param name="providerSpecificFields"></param>
        /// <param name="annotations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Message(
            global::Loud.Technology.LiteLLM.Sdk.MessageRole role,
            string? content,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionMessageToolCall>? toolCalls,
            global::Loud.Technology.LiteLLM.Sdk.FunctionCall? functionCall,
            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAudioResponse? audio,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ImageURLListItem>? images,
            string? reasoningContent,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionThinkingBlock, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionRedactedThinkingBlock>>? thinkingBlocks,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionReasoningItem>? reasoningItems,
            object? providerSpecificFields,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAnnotation>? annotations)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCalls = toolCalls;
            this.FunctionCall = functionCall;
            this.Audio = audio;
            this.Images = images;
            this.ReasoningContent = reasoningContent;
            this.ThinkingBlocks = thinkingBlocks;
            this.ReasoningItems = reasoningItems;
            this.ProviderSpecificFields = providerSpecificFields;
            this.Annotations = annotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }

    }
}
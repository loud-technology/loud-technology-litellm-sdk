
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenericGuardrailAPIInputs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_messages")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionUserMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAssistantMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionSystemMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFunctionMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionDeveloperMessage>>? StructuredMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        public global::System.Collections.Generic.IList<string>? Texts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolCallChunk>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionMessageToolCall>>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolCallChunk>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionMessageToolCall>>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolParam>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericGuardrailAPIInputs" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="model"></param>
        /// <param name="structuredMessages"></param>
        /// <param name="texts"></param>
        /// <param name="toolCalls"></param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenericGuardrailAPIInputs(
            global::System.Collections.Generic.IList<string>? images,
            string? model,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionUserMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAssistantMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionSystemMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFunctionMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionDeveloperMessage>>? structuredMessages,
            global::System.Collections.Generic.IList<string>? texts,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolCallChunk>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionMessageToolCall>>? toolCalls,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolParam>? tools)
        {
            this.Images = images;
            this.Model = model;
            this.StructuredMessages = structuredMessages;
            this.Texts = texts;
            this.ToolCalls = toolCalls;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericGuardrailAPIInputs" /> class.
        /// </summary>
        public GenericGuardrailAPIInputs()
        {
        }

    }
}
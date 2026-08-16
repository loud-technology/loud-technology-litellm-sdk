
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRedactedThinkingBlock
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"redacted_thinking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "redacted_thinking";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<object, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContent, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<object, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContent, object>? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRedactedThinkingBlock" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRedactedThinkingBlock(
            string? data,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<object, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContent, object>? cacheControl,
            string type = "redacted_thinking")
        {
            this.Type = type;
            this.Data = data;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRedactedThinkingBlock" /> class.
        /// </summary>
        public ChatCompletionRedactedThinkingBlock()
        {
        }

    }
}
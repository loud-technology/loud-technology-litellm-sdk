
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionThinkingBlock
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"thinking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "thinking";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public string? Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCompletionThinkingBlock" /> class.
        /// </summary>
        /// <param name="thinking"></param>
        /// <param name="signature"></param>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionThinkingBlock(
            string? thinking,
            string? signature,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<object, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContent, object>? cacheControl,
            string type = "thinking")
        {
            this.Type = type;
            this.Thinking = thinking;
            this.Signature = signature;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionThinkingBlock" /> class.
        /// </summary>
        public ChatCompletionThinkingBlock()
        {
        }

    }
}
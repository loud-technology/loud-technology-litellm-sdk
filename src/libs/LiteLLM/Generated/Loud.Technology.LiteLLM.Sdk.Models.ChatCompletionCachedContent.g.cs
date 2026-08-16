
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionCachedContent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"ephemeral"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ephemeral";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ChatCompletionCachedContentTtlJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContentTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionCachedContent" /> class.
        /// </summary>
        /// <param name="ttl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionCachedContent(
            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContentTtl? ttl,
            string type = "ephemeral")
        {
            this.Type = type;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionCachedContent" /> class.
        /// </summary>
        public ChatCompletionCachedContent()
        {
        }

    }
}
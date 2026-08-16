
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUserMessage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "user";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionTextObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionImageObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAudioObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionDocumentObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionVideoObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFileObject>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionTextObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionImageObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAudioObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionDocumentObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionVideoObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFileObject>>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContent? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="cacheControl"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessage(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionTextObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionImageObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAudioObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionDocumentObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionVideoObject, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFileObject>>> content,
            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContent? cacheControl,
            string role = "user")
        {
            this.Role = role;
            this.Content = content;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessage" /> class.
        /// </summary>
        public ChatCompletionUserMessage()
        {
        }

    }
}
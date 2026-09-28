
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionToolParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<string>? AllowedCallers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContent? CacheControl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eager_input_streaming")]
        public bool? EagerInputStreaming { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolParamFunctionChunk Function { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolParam" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
        /// <param name="allowedCallers"></param>
        /// <param name="cacheControl"></param>
        /// <param name="eagerInputStreaming"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionToolParam(
            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolParamFunctionChunk function,
            string type,
            global::System.Collections.Generic.IList<string>? allowedCallers,
            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionCachedContent? cacheControl,
            bool? eagerInputStreaming)
        {
            this.AllowedCallers = allowedCallers;
            this.CacheControl = cacheControl;
            this.EagerInputStreaming = eagerInputStreaming;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolParam" /> class.
        /// </summary>
        public ChatCompletionToolParam()
        {
        }

    }
}
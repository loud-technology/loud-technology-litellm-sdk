
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageAIChatRequest
    {
        /// <summary>
        /// Chat messages (user/assistant history)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatMessage> Messages { get; set; }

        /// <summary>
        /// Model to use for AI chat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAIChatRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Chat messages (user/assistant history)
        /// </param>
        /// <param name="model">
        /// Model to use for AI chat
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageAIChatRequest(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatMessage> messages,
            string? model)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageAIChatRequest" /> class.
        /// </summary>
        public UsageAIChatRequest()
        {
        }

    }
}
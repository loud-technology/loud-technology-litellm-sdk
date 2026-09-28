
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestPromptRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_history")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? ConversationHistory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dotprompt_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DotpromptContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_variables")]
        public object? PromptVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPromptRequest" /> class.
        /// </summary>
        /// <param name="dotpromptContent"></param>
        /// <param name="conversationHistory"></param>
        /// <param name="promptVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestPromptRequest(
            string dotpromptContent,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? conversationHistory,
            object? promptVariables)
        {
            this.ConversationHistory = conversationHistory;
            this.DotpromptContent = dotpromptContent ?? throw new global::System.ArgumentNullException(nameof(dotpromptContent));
            this.PromptVariables = promptVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPromptRequest" /> class.
        /// </summary>
        public TestPromptRequest()
        {
        }

    }
}
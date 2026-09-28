
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The built-in system prompt an auto-router's LLM classifier uses when none is configured.<br/>
    /// Served so the dashboard's prompt editor prefills the rubric the proxy actually sends, rather than<br/>
    /// a copy in the frontend that drifts the moment the rubric is edited.
    /// </summary>
    public sealed partial class AutoRouterClassifierDefaultPromptResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterClassifierDefaultPromptResponse" /> class.
        /// </summary>
        /// <param name="systemPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterClassifierDefaultPromptResponse(
            string systemPrompt)
        {
            this.SystemPrompt = systemPrompt ?? throw new global::System.ArgumentNullException(nameof(systemPrompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterClassifierDefaultPromptResponse" /> class.
        /// </summary>
        public AutoRouterClassifierDefaultPromptResponse()
        {
        }

    }
}
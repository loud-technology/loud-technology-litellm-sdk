
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListPromptsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PromptSpec> Prompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromptsResponse" /> class.
        /// </summary>
        /// <param name="prompts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPromptsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PromptSpec> prompts)
        {
            this.Prompts = prompts ?? throw new global::System.ArgumentNullException(nameof(prompts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromptsResponse" /> class.
        /// </summary>
        public ListPromptsResponse()
        {
        }

    }
}
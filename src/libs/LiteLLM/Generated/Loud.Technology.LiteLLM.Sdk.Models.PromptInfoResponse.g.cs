
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptInfoResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<string>? Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PromptSpec PromptSpec { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_prompt_template")]
        public global::Loud.Technology.LiteLLM.Sdk.PromptTemplateBase? RawPromptTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInfoResponse" /> class.
        /// </summary>
        /// <param name="promptSpec"></param>
        /// <param name="environments"></param>
        /// <param name="rawPromptTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptInfoResponse(
            global::Loud.Technology.LiteLLM.Sdk.PromptSpec promptSpec,
            global::System.Collections.Generic.IList<string>? environments,
            global::Loud.Technology.LiteLLM.Sdk.PromptTemplateBase? rawPromptTemplate)
        {
            this.Environments = environments;
            this.PromptSpec = promptSpec ?? throw new global::System.ArgumentNullException(nameof(promptSpec));
            this.RawPromptTemplate = rawPromptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInfoResponse" /> class.
        /// </summary>
        public PromptInfoResponse()
        {
        }

    }
}
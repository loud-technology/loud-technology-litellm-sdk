
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptInfo
    {
        /// <summary>
        /// Default Value: development
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.PromptInfoPromptTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PromptInfoPromptType PromptType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInfo" /> class.
        /// </summary>
        /// <param name="promptType"></param>
        /// <param name="environment">
        /// Default Value: development
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptInfo(
            global::Loud.Technology.LiteLLM.Sdk.PromptInfoPromptType promptType,
            string? environment)
        {
            this.Environment = environment;
            this.PromptType = promptType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInfo" /> class.
        /// </summary>
        public PromptInfo()
        {
        }

    }
}
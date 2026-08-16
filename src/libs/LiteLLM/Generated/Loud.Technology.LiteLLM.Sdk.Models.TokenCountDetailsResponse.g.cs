
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response structure for token count details with modality breakdown.<br/>
    /// Example:<br/>
    ///     {'totalTokens': 12, 'promptTokensDetails': [{'modality': 'TEXT', 'tokenCount': 12}]}
    /// </summary>
    public sealed partial class TokenCountDetailsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokensDetails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PromptTokensDetails> PromptTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCountDetailsResponse" /> class.
        /// </summary>
        /// <param name="totalTokens"></param>
        /// <param name="promptTokensDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenCountDetailsResponse(
            int totalTokens,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PromptTokensDetails> promptTokensDetails)
        {
            this.TotalTokens = totalTokens;
            this.PromptTokensDetails = promptTokensDetails ?? throw new global::System.ArgumentNullException(nameof(promptTokensDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCountDetailsResponse" /> class.
        /// </summary>
        public TokenCountDetailsResponse()
        {
        }

    }
}
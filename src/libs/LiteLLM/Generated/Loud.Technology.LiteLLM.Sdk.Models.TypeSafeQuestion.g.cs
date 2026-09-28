
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TypeSafeQuestion
    {
        /// <summary>
        /// Question kind: `choice`, `score`, or `noul` (yes/no).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.TypeSafeQuestionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.TypeSafeQuestionType Type { get; set; }

        /// <summary>
        /// Question asked about the state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Options mapped to descriptions for `choice` (required, up to 255) and `noul` (optional `true`/`false` keys), or ordered levels for `score` (required, 2-10).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string?>, global::System.Collections.Generic.IList<string>>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.Dictionary<string, string?>, global::System.Collections.Generic.IList<string>>? Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSafeQuestion" /> class.
        /// </summary>
        /// <param name="type">
        /// Question kind: `choice`, `score`, or `noul` (yes/no).
        /// </param>
        /// <param name="instructions">
        /// Question asked about the state.
        /// </param>
        /// <param name="criteria">
        /// Options mapped to descriptions for `choice` (required, up to 255) and `noul` (optional `true`/`false` keys), or ordered levels for `score` (required, 2-10).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypeSafeQuestion(
            global::Loud.Technology.LiteLLM.Sdk.TypeSafeQuestionType type,
            string? instructions,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.Dictionary<string, string?>, global::System.Collections.Generic.IList<string>>? criteria)
        {
            this.Type = type;
            this.Instructions = instructions;
            this.Criteria = criteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSafeQuestion" /> class.
        /// </summary>
        public TypeSafeQuestion()
        {
        }

    }
}
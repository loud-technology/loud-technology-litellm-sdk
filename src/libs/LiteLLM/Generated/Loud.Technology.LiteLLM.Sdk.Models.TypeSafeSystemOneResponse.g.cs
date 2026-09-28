
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TypeSafeSystemOneResponse
    {
        /// <summary>
        /// Model version used for the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Answers keyed by question id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.TypeSafeAnswer> Answers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Loud.Technology.LiteLLM.Sdk.TypeSafeUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSafeSystemOneResponse" /> class.
        /// </summary>
        /// <param name="answers">
        /// Answers keyed by question id.
        /// </param>
        /// <param name="model">
        /// Model version used for the evaluation.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypeSafeSystemOneResponse(
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.TypeSafeAnswer> answers,
            string? model,
            global::Loud.Technology.LiteLLM.Sdk.TypeSafeUsage? usage)
        {
            this.Model = model;
            this.Answers = answers ?? throw new global::System.ArgumentNullException(nameof(answers));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSafeSystemOneResponse" /> class.
        /// </summary>
        public TypeSafeSystemOneResponse()
        {
        }

    }
}
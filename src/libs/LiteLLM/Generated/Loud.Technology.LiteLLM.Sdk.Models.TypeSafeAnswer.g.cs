
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TypeSafeAnswer
    {
        /// <summary>
        /// Kind of the question that produced this answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.TypeSafeAnswerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.TypeSafeAnswerType Type { get; set; }

        /// <summary>
        /// Selected option for `choice` answers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice")]
        public string? Choice { get; set; }

        /// <summary>
        /// Continuous level index for `score` answers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Probability that the statement is true for `noul` answers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noul")]
        public double? Noul { get; set; }

        /// <summary>
        /// Level index mapped to its label for `score` answers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legend")]
        public global::System.Collections.Generic.Dictionary<string, string>? Legend { get; set; }

        /// <summary>
        /// Option or level index mapped to its probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        public global::System.Collections.Generic.Dictionary<string, double>? Probabilities { get; set; }

        /// <summary>
        /// Confidence from 0 to 1 for `choice` and `score` answers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSafeAnswer" /> class.
        /// </summary>
        /// <param name="type">
        /// Kind of the question that produced this answer.
        /// </param>
        /// <param name="choice">
        /// Selected option for `choice` answers.
        /// </param>
        /// <param name="score">
        /// Continuous level index for `score` answers.
        /// </param>
        /// <param name="noul">
        /// Probability that the statement is true for `noul` answers.
        /// </param>
        /// <param name="legend">
        /// Level index mapped to its label for `score` answers.
        /// </param>
        /// <param name="probabilities">
        /// Option or level index mapped to its probability.
        /// </param>
        /// <param name="confidence">
        /// Confidence from 0 to 1 for `choice` and `score` answers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypeSafeAnswer(
            global::Loud.Technology.LiteLLM.Sdk.TypeSafeAnswerType type,
            string? choice,
            double? score,
            double? noul,
            global::System.Collections.Generic.Dictionary<string, string>? legend,
            global::System.Collections.Generic.Dictionary<string, double>? probabilities,
            double? confidence)
        {
            this.Type = type;
            this.Choice = choice;
            this.Score = score;
            this.Noul = noul;
            this.Legend = legend;
            this.Probabilities = probabilities;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSafeAnswer" /> class.
        /// </summary>
        public TypeSafeAnswer()
        {
        }

    }
}
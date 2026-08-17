
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResult
    {
        /// <summary>
        /// Zero-based index of the document in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Cohere-compatible relevance score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        public double? RelevanceScore { get; set; }

        /// <summary>
        /// Provider-specific score fallback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResult" /> class.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the document in the request.
        /// </param>
        /// <param name="relevanceScore">
        /// Cohere-compatible relevance score.
        /// </param>
        /// <param name="score">
        /// Provider-specific score fallback.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResult(
            int index,
            double? relevanceScore,
            double? score)
        {
            this.Index = index;
            this.RelevanceScore = relevanceScore;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResult" /> class.
        /// </summary>
        public RerankResult()
        {
        }

    }
}
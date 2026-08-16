
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for MCP Semantic Tool Filter
    /// </summary>
    public sealed partial class MCPSemanticFilterSettings
    {
        /// <summary>
        /// Enable semantic filtering of MCP tools based on query relevance<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Embedding model to use for semantic similarity (e.g., 'text-embedding-3-small', 'text-embedding-ada-002')<br/>
        /// Default Value: text-embedding-3-small
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        public string? EmbeddingModel { get; set; }

        /// <summary>
        /// Number of most relevant tools to return<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Minimum similarity score for tool inclusion (0.0 to 1.0, where 1.0 = exact match)<br/>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_threshold")]
        public double? SimilarityThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPSemanticFilterSettings" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable semantic filtering of MCP tools based on query relevance<br/>
        /// Default Value: false
        /// </param>
        /// <param name="embeddingModel">
        /// Embedding model to use for semantic similarity (e.g., 'text-embedding-3-small', 'text-embedding-ada-002')<br/>
        /// Default Value: text-embedding-3-small
        /// </param>
        /// <param name="topK">
        /// Number of most relevant tools to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="similarityThreshold">
        /// Minimum similarity score for tool inclusion (0.0 to 1.0, where 1.0 = exact match)<br/>
        /// Default Value: 0.3F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPSemanticFilterSettings(
            bool? enabled,
            string? embeddingModel,
            int? topK,
            double? similarityThreshold)
        {
            this.Enabled = enabled;
            this.EmbeddingModel = embeddingModel;
            this.TopK = topK;
            this.SimilarityThreshold = similarityThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPSemanticFilterSettings" /> class.
        /// </summary>
        public MCPSemanticFilterSettings()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// `litellm_settings.mcp_tool_search`: how the native `mcp_tool_search` virtual tool ranks the caller's tools.
    /// </summary>
    public sealed partial class MCPToolSearchSettings
    {
        /// <summary>
        /// Embedding model from model_list used to rank tools by meaning. Unset keeps keyword matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        public string? EmbeddingModel { get; set; }

        /// <summary>
        /// Most ranked tools a search returns. A smaller top_k in the tool call wins. Core tools do not count.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Lowest cosine similarity a tool needs to appear in semantic results (0.0 = no cutoff).<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_threshold")]
        public double? SimilarityThreshold { get; set; }

        /// <summary>
        /// Tool names always returned first when the caller can access them, e.g. `my_server-get_rates`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("core_tools")]
        public global::System.Collections.Generic.IList<string>? CoreTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolSearchSettings" /> class.
        /// </summary>
        /// <param name="embeddingModel">
        /// Embedding model from model_list used to rank tools by meaning. Unset keeps keyword matching.
        /// </param>
        /// <param name="topK">
        /// Most ranked tools a search returns. A smaller top_k in the tool call wins. Core tools do not count.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="similarityThreshold">
        /// Lowest cosine similarity a tool needs to appear in semantic results (0.0 = no cutoff).<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="coreTools">
        /// Tool names always returned first when the caller can access them, e.g. `my_server-get_rates`.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolSearchSettings(
            string? embeddingModel,
            int? topK,
            double? similarityThreshold,
            global::System.Collections.Generic.IList<string>? coreTools)
        {
            this.EmbeddingModel = embeddingModel;
            this.TopK = topK;
            this.SimilarityThreshold = similarityThreshold;
            this.CoreTools = coreTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolSearchSettings" /> class.
        /// </summary>
        public MCPToolSearchSettings()
        {
        }

    }
}
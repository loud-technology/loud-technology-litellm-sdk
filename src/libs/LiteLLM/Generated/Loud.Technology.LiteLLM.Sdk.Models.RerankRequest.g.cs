
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankRequest
    {
        /// <summary>
        /// Reranking model or LiteLLM model alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Query used to rank the documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Documents to rank against the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>
        /// Maximum number of ranked results to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopN { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Reranking model or LiteLLM model alias.
        /// </param>
        /// <param name="query">
        /// Query used to rank the documents.
        /// </param>
        /// <param name="documents">
        /// Documents to rank against the query.
        /// </param>
        /// <param name="topN">
        /// Maximum number of ranked results to return.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankRequest(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            int topN)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.TopN = topN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        public RerankRequest()
        {
        }

    }
}
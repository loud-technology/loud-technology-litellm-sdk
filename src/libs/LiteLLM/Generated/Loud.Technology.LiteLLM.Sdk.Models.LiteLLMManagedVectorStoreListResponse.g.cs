
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response format for listing vector stores
    /// </summary>
    public sealed partial class LiteLLMManagedVectorStoreListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_page")]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMManagedVectorStore>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMManagedVectorStoreListResponse" /> class.
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="data"></param>
        /// <param name="object"></param>
        /// <param name="totalCount"></param>
        /// <param name="totalPages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMManagedVectorStoreListResponse(
            int? currentPage,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMManagedVectorStore>? data,
            string? @object,
            int? totalCount,
            int? totalPages)
        {
            this.CurrentPage = currentPage;
            this.Data = data;
            this.Object = @object;
            this.TotalCount = totalCount;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMManagedVectorStoreListResponse" /> class.
        /// </summary>
        public LiteLLMManagedVectorStoreListResponse()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// LiteLLM managed vector store index object - this is is the object stored in the database
    /// </summary>
    public sealed partial class LiteLLMManagedVectorStoreIndex
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_info")]
        public object? IndexInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.IndexCreateLiteLLMParams LitellmParams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMManagedVectorStoreIndex" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="indexName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="indexInfo"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMManagedVectorStoreIndex(
            string id,
            string indexName,
            global::Loud.Technology.LiteLLM.Sdk.IndexCreateLiteLLMParams litellmParams,
            global::System.DateTime? createdAt,
            string? createdBy,
            object? indexInfo,
            global::System.DateTime? updatedAt,
            string? updatedBy)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IndexInfo = indexInfo;
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.LitellmParams = litellmParams ?? throw new global::System.ArgumentNullException(nameof(litellmParams));
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMManagedVectorStoreIndex" /> class.
        /// </summary>
        public LiteLLMManagedVectorStoreIndex()
        {
        }

    }
}
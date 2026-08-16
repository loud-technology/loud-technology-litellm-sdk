
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_provider")]
        public string? CustomLlmProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_description")]
        public string? VectorStoreDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorStoreId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_metadata")]
        public object? VectorStoreMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_name")]
        public string? VectorStoreName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreUpdateRequest" /> class.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="customLlmProvider"></param>
        /// <param name="vectorStoreDescription"></param>
        /// <param name="vectorStoreMetadata"></param>
        /// <param name="vectorStoreName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreUpdateRequest(
            string vectorStoreId,
            string? customLlmProvider,
            string? vectorStoreDescription,
            object? vectorStoreMetadata,
            string? vectorStoreName)
        {
            this.CustomLlmProvider = customLlmProvider;
            this.VectorStoreDescription = vectorStoreDescription;
            this.VectorStoreId = vectorStoreId ?? throw new global::System.ArgumentNullException(nameof(vectorStoreId));
            this.VectorStoreMetadata = vectorStoreMetadata;
            this.VectorStoreName = vectorStoreName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreUpdateRequest" /> class.
        /// </summary>
        public VectorStoreUpdateRequest()
        {
        }

    }
}
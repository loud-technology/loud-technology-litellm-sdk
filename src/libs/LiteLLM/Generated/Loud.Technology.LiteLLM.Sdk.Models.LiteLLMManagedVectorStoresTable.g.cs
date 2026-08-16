
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiteLLMManagedVectorStoresTable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomLlmProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_credential_name")]
        public string? LitellmCredentialName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public object? LitellmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

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
        /// Initializes a new instance of the <see cref="LiteLLMManagedVectorStoresTable" /> class.
        /// </summary>
        /// <param name="customLlmProvider"></param>
        /// <param name="vectorStoreId"></param>
        /// <param name="createdAt"></param>
        /// <param name="litellmCredentialName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="teamId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
        /// <param name="vectorStoreDescription"></param>
        /// <param name="vectorStoreMetadata"></param>
        /// <param name="vectorStoreName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMManagedVectorStoresTable(
            string customLlmProvider,
            string vectorStoreId,
            global::System.DateTime? createdAt,
            string? litellmCredentialName,
            object? litellmParams,
            string? teamId,
            global::System.DateTime? updatedAt,
            string? userId,
            string? vectorStoreDescription,
            object? vectorStoreMetadata,
            string? vectorStoreName)
        {
            this.CreatedAt = createdAt;
            this.CustomLlmProvider = customLlmProvider ?? throw new global::System.ArgumentNullException(nameof(customLlmProvider));
            this.LitellmCredentialName = litellmCredentialName;
            this.LitellmParams = litellmParams;
            this.TeamId = teamId;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
            this.VectorStoreDescription = vectorStoreDescription;
            this.VectorStoreId = vectorStoreId ?? throw new global::System.ArgumentNullException(nameof(vectorStoreId));
            this.VectorStoreMetadata = vectorStoreMetadata;
            this.VectorStoreName = vectorStoreName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMManagedVectorStoresTable" /> class.
        /// </summary>
        public LiteLLMManagedVectorStoresTable()
        {
        }

    }
}
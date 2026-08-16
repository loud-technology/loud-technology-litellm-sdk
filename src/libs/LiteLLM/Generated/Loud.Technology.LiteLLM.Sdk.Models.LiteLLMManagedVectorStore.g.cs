
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// LiteLLM managed vector store object - this is is the object stored in the database
    /// </summary>
    public sealed partial class LiteLLMManagedVectorStore
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
        public string? CustomLlmProvider { get; set; }

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
        public string? VectorStoreId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<object, string, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<object, string, object>? VectorStoreMetadata { get; set; }

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
        /// Initializes a new instance of the <see cref="LiteLLMManagedVectorStore" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="customLlmProvider"></param>
        /// <param name="litellmCredentialName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="teamId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
        /// <param name="vectorStoreDescription"></param>
        /// <param name="vectorStoreId"></param>
        /// <param name="vectorStoreMetadata"></param>
        /// <param name="vectorStoreName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMManagedVectorStore(
            global::System.DateTime? createdAt,
            string? customLlmProvider,
            string? litellmCredentialName,
            object? litellmParams,
            string? teamId,
            global::System.DateTime? updatedAt,
            string? userId,
            string? vectorStoreDescription,
            string? vectorStoreId,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<object, string, object>? vectorStoreMetadata,
            string? vectorStoreName)
        {
            this.CreatedAt = createdAt;
            this.CustomLlmProvider = customLlmProvider;
            this.LitellmCredentialName = litellmCredentialName;
            this.LitellmParams = litellmParams;
            this.TeamId = teamId;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
            this.VectorStoreDescription = vectorStoreDescription;
            this.VectorStoreId = vectorStoreId;
            this.VectorStoreMetadata = vectorStoreMetadata;
            this.VectorStoreName = vectorStoreName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMManagedVectorStore" /> class.
        /// </summary>
        public LiteLLMManagedVectorStore()
        {
        }

    }
}
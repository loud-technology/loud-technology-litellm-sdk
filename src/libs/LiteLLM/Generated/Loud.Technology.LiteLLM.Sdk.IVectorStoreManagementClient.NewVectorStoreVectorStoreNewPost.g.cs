#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVectorStoreManagementClient
    {
        /// <summary>
        /// New Vector Store<br/>
        /// Create a new vector store.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - Unique identifier for the vector store<br/>
        /// - custom_llm_provider: str - Provider of the vector store<br/>
        /// - vector_store_name: Optional[str] - Name of the vector store<br/>
        /// - vector_store_description: Optional[str] - Description of the vector store<br/>
        /// - vector_store_metadata: Optional[Dict] - Additional metadata for the vector store
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> NewVectorStoreVectorStoreNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.LiteLLMManagedVectorStore request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New Vector Store<br/>
        /// Create a new vector store.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - Unique identifier for the vector store<br/>
        /// - custom_llm_provider: str - Provider of the vector store<br/>
        /// - vector_store_name: Optional[str] - Name of the vector store<br/>
        /// - vector_store_description: Optional[str] - Description of the vector store<br/>
        /// - vector_store_metadata: Optional[Dict] - Additional metadata for the vector store
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> NewVectorStoreVectorStoreNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.LiteLLMManagedVectorStore request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New Vector Store<br/>
        /// Create a new vector store.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - Unique identifier for the vector store<br/>
        /// - custom_llm_provider: str - Provider of the vector store<br/>
        /// - vector_store_name: Optional[str] - Name of the vector store<br/>
        /// - vector_store_description: Optional[str] - Description of the vector store<br/>
        /// - vector_store_metadata: Optional[Dict] - Additional metadata for the vector store
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> NewVectorStoreVectorStoreNewPostAsync(
            global::System.DateTime? createdAt = default,
            string? customLlmProvider = default,
            string? litellmCredentialName = default,
            object? litellmParams = default,
            string? teamId = default,
            global::System.DateTime? updatedAt = default,
            string? userId = default,
            string? vectorStoreDescription = default,
            string? vectorStoreId = default,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<object, string, object>? vectorStoreMetadata = default,
            string? vectorStoreName = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
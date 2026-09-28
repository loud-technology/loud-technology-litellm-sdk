#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVectorStoreManagementClient
    {
        /// <summary>
        /// Delete Vector Store<br/>
        /// Delete a vector store from both database and in-memory registry.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - ID of the vector store to delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteVectorStoreVectorStoreDeletePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.VectorStoreDeleteRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Vector Store<br/>
        /// Delete a vector store from both database and in-memory registry.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - ID of the vector store to delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteVectorStoreVectorStoreDeletePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.VectorStoreDeleteRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Vector Store<br/>
        /// Delete a vector store from both database and in-memory registry.<br/>
        /// Parameters:<br/>
        /// - vector_store_id: str - ID of the vector store to delete
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteVectorStoreVectorStoreDeletePostAsync(
            string vectorStoreId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVectorStoreManagementClient
    {
        /// <summary>
        /// List Vector Stores<br/>
        /// List all available vector stores with optional filtering and pagination.<br/>
        /// Combines both in-memory vector stores and those stored in the database.<br/>
        /// Database is the source of truth - deleted stores are removed from memory, updated stores sync to memory.<br/>
        /// Parameters:<br/>
        /// - page: int - Page number for pagination (default: 1)<br/>
        /// - page_size: int - Number of items per page (default: 100)
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMManagedVectorStoreListResponse> ListVectorStoresVectorStoreListGetAsync(
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Vector Stores<br/>
        /// List all available vector stores with optional filtering and pagination.<br/>
        /// Combines both in-memory vector stores and those stored in the database.<br/>
        /// Database is the source of truth - deleted stores are removed from memory, updated stores sync to memory.<br/>
        /// Parameters:<br/>
        /// - page: int - Page number for pagination (default: 1)<br/>
        /// - page_size: int - Number of items per page (default: 100)
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMManagedVectorStoreListResponse>> ListVectorStoresVectorStoreListGetAsResponseAsync(
            int? page = default,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
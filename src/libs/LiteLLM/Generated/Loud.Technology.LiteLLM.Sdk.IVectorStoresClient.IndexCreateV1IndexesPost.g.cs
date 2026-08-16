#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Index Create<br/>
        /// Create an index. Just writes the index to the database.<br/>
        /// ```bash<br/>
        /// curl -L -X POST 'http://0.0.0.0:4000/indexes/create'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -H 'LiteLLM-Beta: indexes_beta=v1'         -d '{ <br/>
        ///         "index_name": "dall-e-3",<br/>
        ///         "vector_store_index": "real-index-name",<br/>
        ///         "vector_store_name": "azure-ai-search"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> IndexCreateV1IndexesPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.IndexCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Index Create<br/>
        /// Create an index. Just writes the index to the database.<br/>
        /// ```bash<br/>
        /// curl -L -X POST 'http://0.0.0.0:4000/indexes/create'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -H 'LiteLLM-Beta: indexes_beta=v1'         -d '{ <br/>
        ///         "index_name": "dall-e-3",<br/>
        ///         "vector_store_index": "real-index-name",<br/>
        ///         "vector_store_name": "azure-ai-search"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> IndexCreateV1IndexesPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.IndexCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Index Create<br/>
        /// Create an index. Just writes the index to the database.<br/>
        /// ```bash<br/>
        /// curl -L -X POST 'http://0.0.0.0:4000/indexes/create'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -H 'LiteLLM-Beta: indexes_beta=v1'         -d '{ <br/>
        ///         "index_name": "dall-e-3",<br/>
        ///         "vector_store_index": "real-index-name",<br/>
        ///         "vector_store_name": "azure-ai-search"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="indexInfo"></param>
        /// <param name="indexName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> IndexCreateV1IndexesPostAsync(
            string indexName,
            global::Loud.Technology.LiteLLM.Sdk.IndexCreateLiteLLMParams litellmParams,
            object? indexInfo = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
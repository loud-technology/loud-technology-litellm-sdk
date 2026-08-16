#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IRagClient
    {
        /// <summary>
        /// Rag Query<br/>
        /// RAG Query endpoint - search vector store, optionally rerank, and generate LLM response.<br/>
        /// This endpoint:<br/>
        /// 1. Extracts the query from the last user message<br/>
        /// 2. Searches the vector store for relevant context<br/>
        /// 3. Optionally reranks the results<br/>
        /// 4. Generates an LLM response with the retrieved context<br/>
        /// ## Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/query" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "model": "gpt-4o-mini",<br/>
        ///         "messages": [{"role": "user", "content": "What is LiteLLM?"}],<br/>
        ///         "retrieval_config": {<br/>
        ///             "vector_store_id": "vs_abc123",<br/>
        ///             "custom_llm_provider": "openai",<br/>
        ///             "top_k": 5<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// ## With Reranking:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/query" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "model": "gpt-4o-mini",<br/>
        ///         "messages": [{"role": "user", "content": "What is LiteLLM?"}],<br/>
        ///         "retrieval_config": {<br/>
        ///             "vector_store_id": "vs_abc123",<br/>
        ///             "custom_llm_provider": "openai",<br/>
        ///             "top_k": 10<br/>
        ///         },<br/>
        ///         "rerank": {<br/>
        ///             "enabled": true,<br/>
        ///             "model": "cohere/rerank-english-v3.0",<br/>
        ///             "top_n": 3<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RagQueryRagQueryPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rag Query<br/>
        /// RAG Query endpoint - search vector store, optionally rerank, and generate LLM response.<br/>
        /// This endpoint:<br/>
        /// 1. Extracts the query from the last user message<br/>
        /// 2. Searches the vector store for relevant context<br/>
        /// 3. Optionally reranks the results<br/>
        /// 4. Generates an LLM response with the retrieved context<br/>
        /// ## Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/query" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "model": "gpt-4o-mini",<br/>
        ///         "messages": [{"role": "user", "content": "What is LiteLLM?"}],<br/>
        ///         "retrieval_config": {<br/>
        ///             "vector_store_id": "vs_abc123",<br/>
        ///             "custom_llm_provider": "openai",<br/>
        ///             "top_k": 5<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// ## With Reranking:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/query" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "model": "gpt-4o-mini",<br/>
        ///         "messages": [{"role": "user", "content": "What is LiteLLM?"}],<br/>
        ///         "retrieval_config": {<br/>
        ///             "vector_store_id": "vs_abc123",<br/>
        ///             "custom_llm_provider": "openai",<br/>
        ///             "top_k": 10<br/>
        ///         },<br/>
        ///         "rerank": {<br/>
        ///             "enabled": true,<br/>
        ///             "model": "cohere/rerank-english-v3.0",<br/>
        ///             "top_n": 3<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> RagQueryRagQueryPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
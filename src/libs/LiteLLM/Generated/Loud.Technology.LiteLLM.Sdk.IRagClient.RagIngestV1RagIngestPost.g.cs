#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IRagClient
    {
        /// <summary>
        /// Rag Ingest<br/>
        /// RAG Ingest endpoint - all-in-one document ingestion pipeline.<br/>
        /// Supports form upload (for files) or JSON body (for URLs).<br/>
        /// ## Form upload (for files):<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/ingest" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -F file="@document.pdf" \<br/>
        ///     -F 'ingest_options={"vector_store": {"custom_llm_provider": "openai"}}'<br/>
        /// ```<br/>
        /// ## JSON body (for URLs):<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/ingest" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "file_url": "https://example.com/document.pdf",<br/>
        ///         "ingest_options": {"vector_store": {"custom_llm_provider": "openai"}}<br/>
        ///     }'<br/>
        /// ```<br/>
        /// ## Bedrock:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/ingest" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -F file="@document.pdf" \<br/>
        ///     -F 'ingest_options={"vector_store": {"custom_llm_provider": "bedrock"}}'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RagIngestV1RagIngestPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rag Ingest<br/>
        /// RAG Ingest endpoint - all-in-one document ingestion pipeline.<br/>
        /// Supports form upload (for files) or JSON body (for URLs).<br/>
        /// ## Form upload (for files):<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/ingest" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -F file="@document.pdf" \<br/>
        ///     -F 'ingest_options={"vector_store": {"custom_llm_provider": "openai"}}'<br/>
        /// ```<br/>
        /// ## JSON body (for URLs):<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/ingest" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "file_url": "https://example.com/document.pdf",<br/>
        ///         "ingest_options": {"vector_store": {"custom_llm_provider": "openai"}}<br/>
        ///     }'<br/>
        /// ```<br/>
        /// ## Bedrock:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/rag/ingest" \<br/>
        ///     -H "Authorization: Bearer sk-1234" \<br/>
        ///     -F file="@document.pdf" \<br/>
        ///     -F 'ingest_options={"vector_store": {"custom_llm_provider": "bedrock"}}'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> RagIngestV1RagIngestPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
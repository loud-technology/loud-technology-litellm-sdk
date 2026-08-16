#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Embeddings<br/>
        /// Follows the exact same API spec as `OpenAI's Embeddings API https://platform.openai.com/docs/api-reference/embeddings`<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/embeddings <br/>
        /// -H "Content-Type: application/json" <br/>
        /// -H "Authorization: Bearer sk-1234" <br/>
        /// -d '{<br/>
        ///     "model": "text-embedding-ada-002",<br/>
        ///     "input": "The quick brown fox jumps over the lazy dog"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EmbeddingsV1EmbeddingsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.EmbeddingsV1EmbeddingsPostRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// Follows the exact same API spec as `OpenAI's Embeddings API https://platform.openai.com/docs/api-reference/embeddings`<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/embeddings <br/>
        /// -H "Content-Type: application/json" <br/>
        /// -H "Authorization: Bearer sk-1234" <br/>
        /// -d '{<br/>
        ///     "model": "text-embedding-ada-002",<br/>
        ///     "input": "The quick brown fox jumps over the lazy dog"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> EmbeddingsV1EmbeddingsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.EmbeddingsV1EmbeddingsPostRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// Follows the exact same API spec as `OpenAI's Embeddings API https://platform.openai.com/docs/api-reference/embeddings`<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/embeddings <br/>
        /// -H "Content-Type: application/json" <br/>
        /// -H "Authorization: Bearer sk-1234" <br/>
        /// -d '{<br/>
        ///     "model": "text-embedding-ada-002",<br/>
        ///     "input": "The quick brown fox jumps over the lazy dog"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input">
        /// Default Value: []
        /// </param>
        /// <param name="timeout">
        /// Default Value: 600
        /// </param>
        /// <param name="apiBase">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="apiVersion">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="apiKey">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="apiType">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="caching">
        /// Default Value: false
        /// </param>
        /// <param name="user">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="customLlmProvider">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="litellmCallId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="litellmLoggingObj">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="loggerFn">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> EmbeddingsV1EmbeddingsPostAsync(
            string model,
            global::System.Collections.Generic.IList<string>? input = default,
            int? timeout = default,
            string? apiBase = default,
            string? apiVersion = default,
            string? apiKey = default,
            string? apiType = default,
            bool? caching = default,
            string? user = default,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, object>? customLlmProvider = default,
            string? litellmCallId = default,
            object? litellmLoggingObj = default,
            string? loggerFn = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
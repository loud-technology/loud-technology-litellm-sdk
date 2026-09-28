#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Vector Store Create<br/>
        /// Create a vector store.<br/>
        /// API Reference:<br/>
        /// https://platform.openai.com/docs/api-reference/vector-stores/create<br/>
        /// Supports target_model_names parameter for creating vector stores across multiple models:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "name": "my-vector-store",<br/>
        ///     "target_model_names": "gpt-4,gemini-2.0"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VectorStoreCreateV1VectorStoresPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vector Store Create<br/>
        /// Create a vector store.<br/>
        /// API Reference:<br/>
        /// https://platform.openai.com/docs/api-reference/vector-stores/create<br/>
        /// Supports target_model_names parameter for creating vector stores across multiple models:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "name": "my-vector-store",<br/>
        ///     "target_model_names": "gpt-4,gemini-2.0"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VectorStoreCreateV1VectorStoresPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
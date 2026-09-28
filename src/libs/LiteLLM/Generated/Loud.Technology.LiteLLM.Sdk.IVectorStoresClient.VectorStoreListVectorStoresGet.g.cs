#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Vector Store List<br/>
        /// List vector stores.<br/>
        /// API Reference:<br/>
        /// https://platform.openai.com/docs/api-reference/vector-stores/list
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VectorStoreListVectorStoresGetAsync(
            string? after = default,
            string? before = default,
            int? limit = default,
            string? order = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vector Store List<br/>
        /// List vector stores.<br/>
        /// API Reference:<br/>
        /// https://platform.openai.com/docs/api-reference/vector-stores/list
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VectorStoreListVectorStoresGetAsResponseAsync(
            string? after = default,
            string? before = default,
            int? limit = default,
            string? order = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
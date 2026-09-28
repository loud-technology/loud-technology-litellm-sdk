#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IRerankClient
    {
        /// <summary>
        /// Rerank
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RerankResponse> RerankV1RerankPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.RerankRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RerankResponse>> RerankV1RerankPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.RerankRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank
        /// </summary>
        /// <param name="model">
        /// Reranking model or LiteLLM model alias.
        /// </param>
        /// <param name="query">
        /// Query used to rank the documents.
        /// </param>
        /// <param name="documents">
        /// Documents to rank against the query.
        /// </param>
        /// <param name="topN">
        /// Maximum number of ranked results to return.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RerankResponse> RerankV1RerankPostAsync(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            int topN,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
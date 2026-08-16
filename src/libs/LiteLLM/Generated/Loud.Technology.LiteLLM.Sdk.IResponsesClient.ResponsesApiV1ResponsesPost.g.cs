#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Responses Api<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses<br/>
        /// Supports background mode with polling_via_cache for partial response retrieval.<br/>
        /// When background=true and polling_via_cache is enabled, returns a polling_id immediately<br/>
        /// and streams the response in the background, updating Redis cache.<br/>
        /// ```bash<br/>
        /// # Normal request<br/>
        /// curl -X POST http://localhost:4000/v1/responses     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": "Tell me about AI"<br/>
        /// }'<br/>
        /// # Background request with polling<br/>
        /// curl -X POST http://localhost:4000/v1/responses     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": "Tell me about AI",<br/>
        ///     "background": true<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResponsesApiV1ResponsesPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Responses Api<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses<br/>
        /// Supports background mode with polling_via_cache for partial response retrieval.<br/>
        /// When background=true and polling_via_cache is enabled, returns a polling_id immediately<br/>
        /// and streams the response in the background, updating Redis cache.<br/>
        /// ```bash<br/>
        /// # Normal request<br/>
        /// curl -X POST http://localhost:4000/v1/responses     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": "Tell me about AI"<br/>
        /// }'<br/>
        /// # Background request with polling<br/>
        /// curl -X POST http://localhost:4000/v1/responses     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": "Tell me about AI",<br/>
        ///     "background": true<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ResponsesApiV1ResponsesPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
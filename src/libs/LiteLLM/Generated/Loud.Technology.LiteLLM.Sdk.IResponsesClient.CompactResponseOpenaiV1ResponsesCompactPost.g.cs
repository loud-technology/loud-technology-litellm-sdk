#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Compact Response<br/>
        /// Compact a response by running a compaction pass over a conversation.<br/>
        /// Returns encrypted, opaque items that can be used to reduce context size.<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses/compact<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/responses/compact     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": [{"role": "user", "content": "Hello"}]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CompactResponseOpenaiV1ResponsesCompactPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compact Response<br/>
        /// Compact a response by running a compaction pass over a conversation.<br/>
        /// Returns encrypted, opaque items that can be used to reduce context size.<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses/compact<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/responses/compact     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": [{"role": "user", "content": "Hello"}]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CompactResponseOpenaiV1ResponsesCompactPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
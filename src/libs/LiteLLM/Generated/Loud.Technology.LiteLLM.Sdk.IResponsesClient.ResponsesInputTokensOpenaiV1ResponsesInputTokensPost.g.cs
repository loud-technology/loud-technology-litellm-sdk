#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Responses Input Tokens<br/>
        /// Count the input tokens of a Responses API request without calling the model.<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses/input-tokens<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/responses/input_tokens     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": "Hello, how are you?"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns: `{"object": "response.input_tokens", "input_tokens": &lt;count&gt;}`
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResponsesInputTokensOpenaiV1ResponsesInputTokensPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Responses Input Tokens<br/>
        /// Count the input tokens of a Responses API request without calling the model.<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses/input-tokens<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/responses/input_tokens     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": "Hello, how are you?"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns: `{"object": "response.input_tokens", "input_tokens": &lt;count&gt;}`
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ResponsesInputTokensOpenaiV1ResponsesInputTokensPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
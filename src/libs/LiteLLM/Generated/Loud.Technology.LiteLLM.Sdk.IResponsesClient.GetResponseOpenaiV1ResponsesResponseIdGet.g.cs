#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Get Response<br/>
        /// Get a response by ID.<br/>
        /// Supports both:<br/>
        /// - Polling IDs (litellm_poll_*): Returns cumulative cached content from background responses<br/>
        /// - Provider response IDs: Passes through to provider API<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses/get<br/>
        /// ```bash<br/>
        /// # Get polling response<br/>
        /// curl -X GET http://localhost:4000/v1/responses/litellm_poll_abc123     -H "Authorization: Bearer sk-1234"<br/>
        /// # Get provider response<br/>
        /// curl -X GET http://localhost:4000/v1/responses/resp_abc123     -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetResponseOpenaiV1ResponsesResponseIdGetAsync(
            string responseId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Response<br/>
        /// Get a response by ID.<br/>
        /// Supports both:<br/>
        /// - Polling IDs (litellm_poll_*): Returns cumulative cached content from background responses<br/>
        /// - Provider response IDs: Passes through to provider API<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses/get<br/>
        /// ```bash<br/>
        /// # Get polling response<br/>
        /// curl -X GET http://localhost:4000/v1/responses/litellm_poll_abc123     -H "Authorization: Bearer sk-1234"<br/>
        /// # Get provider response<br/>
        /// curl -X GET http://localhost:4000/v1/responses/resp_abc123     -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetResponseOpenaiV1ResponsesResponseIdGetAsResponseAsync(
            string responseId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
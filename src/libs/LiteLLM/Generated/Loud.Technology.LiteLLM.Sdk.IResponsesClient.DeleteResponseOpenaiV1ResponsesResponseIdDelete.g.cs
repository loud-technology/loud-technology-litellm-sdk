#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Delete Response<br/>
        /// Delete a response by ID.<br/>
        /// Supports both:<br/>
        /// - Polling IDs (litellm_poll_*): Deletes from Redis cache<br/>
        /// - Provider response IDs: Passes through to provider API<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses/delete<br/>
        /// ```bash<br/>
        /// curl -X DELETE http://localhost:4000/v1/responses/resp_abc123     -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteResponseOpenaiV1ResponsesResponseIdDeleteAsync(
            string responseId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Response<br/>
        /// Delete a response by ID.<br/>
        /// Supports both:<br/>
        /// - Polling IDs (litellm_poll_*): Deletes from Redis cache<br/>
        /// - Provider response IDs: Passes through to provider API<br/>
        /// Follows the OpenAI Responses API spec: https://platform.openai.com/docs/api-reference/responses/delete<br/>
        /// ```bash<br/>
        /// curl -X DELETE http://localhost:4000/v1/responses/resp_abc123     -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteResponseOpenaiV1ResponsesResponseIdDeleteAsResponseAsync(
            string responseId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Get Response Input Items<br/>
        /// List input items for a response.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetResponseInputItemsOpenaiV1ResponsesResponseIdInputItemsGetAsync(
            string responseId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Response Input Items<br/>
        /// List input items for a response.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetResponseInputItemsOpenaiV1ResponsesResponseIdInputItemsGetAsResponseAsync(
            string responseId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
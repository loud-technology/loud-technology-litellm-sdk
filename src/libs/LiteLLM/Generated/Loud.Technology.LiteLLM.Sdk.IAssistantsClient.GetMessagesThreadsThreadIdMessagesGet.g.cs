#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Get Messages<br/>
        /// Returns a list of messages for a given thread.<br/>
        /// API Reference - https://platform.openai.com/docs/api-reference/messages/listMessages
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetMessagesThreadsThreadIdMessagesGetAsync(
            string threadId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Messages<br/>
        /// Returns a list of messages for a given thread.<br/>
        /// API Reference - https://platform.openai.com/docs/api-reference/messages/listMessages
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetMessagesThreadsThreadIdMessagesGetAsResponseAsync(
            string threadId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
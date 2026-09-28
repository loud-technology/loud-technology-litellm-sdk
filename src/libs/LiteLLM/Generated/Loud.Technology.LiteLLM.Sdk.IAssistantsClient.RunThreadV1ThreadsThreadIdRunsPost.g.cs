#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Run Thread<br/>
        /// Create a run.<br/>
        /// API Reference: https://platform.openai.com/docs/api-reference/runs/createRun
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RunThreadV1ThreadsThreadIdRunsPostAsync(
            string threadId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Thread<br/>
        /// Create a run.<br/>
        /// API Reference: https://platform.openai.com/docs/api-reference/runs/createRun
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> RunThreadV1ThreadsThreadIdRunsPostAsResponseAsync(
            string threadId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
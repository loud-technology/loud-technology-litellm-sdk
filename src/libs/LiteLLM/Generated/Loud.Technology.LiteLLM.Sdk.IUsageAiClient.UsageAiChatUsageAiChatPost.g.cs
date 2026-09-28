#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IUsageAiClient
    {
        /// <summary>
        /// Usage Ai Chat<br/>
        /// AI chat about usage data. Streams SSE events with the AI response.<br/>
        /// The AI agent has access to tools that query aggregated daily activity data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UsageAiChatUsageAiChatPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.UsageAIChatRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Usage Ai Chat<br/>
        /// AI chat about usage data. Streams SSE events with the AI response.<br/>
        /// The AI agent has access to tools that query aggregated daily activity data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UsageAiChatUsageAiChatPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UsageAIChatRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Usage Ai Chat<br/>
        /// AI chat about usage data. Streams SSE events with the AI response.<br/>
        /// The AI agent has access to tools that query aggregated daily activity data.
        /// </summary>
        /// <param name="messages">
        /// Chat messages (user/assistant history)
        /// </param>
        /// <param name="model">
        /// Model to use for AI chat
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UsageAiChatUsageAiChatPostAsync(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ChatMessage> messages,
            string? model = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
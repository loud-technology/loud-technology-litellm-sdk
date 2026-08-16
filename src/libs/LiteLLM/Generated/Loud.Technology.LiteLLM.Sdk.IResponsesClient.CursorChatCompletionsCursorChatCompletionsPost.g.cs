#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Cursor Chat Completions<br/>
        /// Cursor-specific endpoint that accepts Responses API input format but returns chat completions format.<br/>
        /// This endpoint handles requests from Cursor IDE which sends Responses API format (`input` field)<br/>
        /// but expects chat completions format response (`choices`, `messages`, etc.).<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/cursor/chat/completions     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": [{"role": "user", "content": "Hello"}]<br/>
        /// }'<br/>
        /// Responds back in chat completions format.<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CursorChatCompletionsCursorChatCompletionsPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cursor Chat Completions<br/>
        /// Cursor-specific endpoint that accepts Responses API input format but returns chat completions format.<br/>
        /// This endpoint handles requests from Cursor IDE which sends Responses API format (`input` field)<br/>
        /// but expects chat completions format response (`choices`, `messages`, etc.).<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/cursor/chat/completions     -H "Content-Type: application/json"     -H "Authorization: Bearer sk-1234"     -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "input": [{"role": "user", "content": "Hello"}]<br/>
        /// }'<br/>
        /// Responds back in chat completions format.<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CursorChatCompletionsCursorChatCompletionsPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
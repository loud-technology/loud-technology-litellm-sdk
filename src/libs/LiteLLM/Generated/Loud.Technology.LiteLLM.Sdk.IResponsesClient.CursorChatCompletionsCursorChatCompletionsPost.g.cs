#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Cursor Chat Completions<br/>
        /// Cursor BYOK endpoint. Accepts both request shapes Cursor sends to its OpenAI-compatible<br/>
        /// base URL and always answers in chat completions format.<br/>
        /// Cursor agent mode sends Responses API format bodies (`input`, flat tool defs, `reasoning`,<br/>
        /// custom tools) to the chat/completions path while expecting chat completions responses;<br/>
        /// those are routed through the Responses API pipeline and converted back. Genuine chat<br/>
        /// completions bodies (`messages` present) are routed through the standard chat completions<br/>
        /// pipeline, after normalizing each level of the `tools` array and `tool_choice` to the chat<br/>
        /// completions shapes OpenAI requires. Cursor mixes Responses API shapes into chat bodies<br/>
        /// per level, independently: a flat tool def (`{"type": "custom", "name": "ApplyPatch", ...}`)<br/>
        /// gets nested under `custom`, and a flat grammar format<br/>
        /// (`{"type": "grammar", "definition", "syntax"}`) gets wrapped as<br/>
        /// `{"type": "grammar", "grammar": {...}}` wherever it appears, including inside tool defs<br/>
        /// Cursor already sent pre-nested.<br/>
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
        /// Cursor BYOK endpoint. Accepts both request shapes Cursor sends to its OpenAI-compatible<br/>
        /// base URL and always answers in chat completions format.<br/>
        /// Cursor agent mode sends Responses API format bodies (`input`, flat tool defs, `reasoning`,<br/>
        /// custom tools) to the chat/completions path while expecting chat completions responses;<br/>
        /// those are routed through the Responses API pipeline and converted back. Genuine chat<br/>
        /// completions bodies (`messages` present) are routed through the standard chat completions<br/>
        /// pipeline, after normalizing each level of the `tools` array and `tool_choice` to the chat<br/>
        /// completions shapes OpenAI requires. Cursor mixes Responses API shapes into chat bodies<br/>
        /// per level, independently: a flat tool def (`{"type": "custom", "name": "ApplyPatch", ...}`)<br/>
        /// gets nested under `custom`, and a flat grammar format<br/>
        /// (`{"type": "grammar", "definition", "syntax"}`) gets wrapped as<br/>
        /// `{"type": "grammar", "grammar": {...}}` wherever it appears, including inside tool defs<br/>
        /// Cursor already sent pre-nested.<br/>
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
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Test Prompt<br/>
        /// Test a prompt by rendering it with variables and executing an LLM call.<br/>
        /// This endpoint allows testing prompts before saving them to the database.<br/>
        /// The response is always streamed.<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/prompts/test" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "dotprompt_content": "---\nmodel: gpt-4o\ntemperature: 0.7\n---\n\nUser: Hello {{name}}",<br/>
        ///         "prompt_variables": {<br/>
        ///             "name": "World"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestPromptPromptsTestPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TestPromptRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Prompt<br/>
        /// Test a prompt by rendering it with variables and executing an LLM call.<br/>
        /// This endpoint allows testing prompts before saving them to the database.<br/>
        /// The response is always streamed.<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/prompts/test" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "dotprompt_content": "---\nmodel: gpt-4o\ntemperature: 0.7\n---\n\nUser: Hello {{name}}",<br/>
        ///         "prompt_variables": {<br/>
        ///             "name": "World"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestPromptPromptsTestPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TestPromptRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Prompt<br/>
        /// Test a prompt by rendering it with variables and executing an LLM call.<br/>
        /// This endpoint allows testing prompts before saving them to the database.<br/>
        /// The response is always streamed.<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/prompts/test" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "dotprompt_content": "---\nmodel: gpt-4o\ntemperature: 0.7\n---\n\nUser: Hello {{name}}",<br/>
        ///         "prompt_variables": {<br/>
        ///             "name": "World"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="conversationHistory"></param>
        /// <param name="dotpromptContent"></param>
        /// <param name="promptVariables"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TestPromptPromptsTestPostAsync(
            string dotpromptContent,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? conversationHistory = default,
            object? promptVariables = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
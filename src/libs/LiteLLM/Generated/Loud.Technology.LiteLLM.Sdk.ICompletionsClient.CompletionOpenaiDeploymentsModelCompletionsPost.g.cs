#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICompletionsClient
    {
        /// <summary>
        /// Completion<br/>
        /// Follows the exact same API spec as `OpenAI's Completions API https://platform.openai.com/docs/api-reference/completions`<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/completions <br/>
        /// -H "Content-Type: application/json" <br/>
        /// -H "Authorization: Bearer sk-1234" <br/>
        /// -d '{<br/>
        ///     "model": "gpt-3.5-turbo-instruct",<br/>
        ///     "prompt": "Once upon a time",<br/>
        ///     "max_tokens": 50,<br/>
        ///     "temperature": 0.7<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CompletionOpenaiDeploymentsModelCompletionsPostAsync(
            string? model,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Completion<br/>
        /// Follows the exact same API spec as `OpenAI's Completions API https://platform.openai.com/docs/api-reference/completions`<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/completions <br/>
        /// -H "Content-Type: application/json" <br/>
        /// -H "Authorization: Bearer sk-1234" <br/>
        /// -d '{<br/>
        ///     "model": "gpt-3.5-turbo-instruct",<br/>
        ///     "prompt": "Once upon a time",<br/>
        ///     "max_tokens": 50,<br/>
        ///     "temperature": 0.7<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CompletionOpenaiDeploymentsModelCompletionsPostAsResponseAsync(
            string? model,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
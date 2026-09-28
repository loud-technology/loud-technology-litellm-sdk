#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create Prompt<br/>
        /// Create a new prompt<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/prompts" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "prompt_id": "my_prompt",<br/>
        ///         "litellm_params": {<br/>
        ///             "prompt_id": "my_prompt",<br/>
        ///             "prompt_integration": "dotprompt",<br/>
        ///             "prompt_data": {"content": "This is a prompt", "metadata": {"model": "gpt-4"}}<br/>
        ///         },<br/>
        ///         "prompt_info": {<br/>
        ///             "prompt_type": "config"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreatePromptPromptsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.Prompt request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Prompt<br/>
        /// Create a new prompt<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/prompts" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "prompt_id": "my_prompt",<br/>
        ///         "litellm_params": {<br/>
        ///             "prompt_id": "my_prompt",<br/>
        ///             "prompt_integration": "dotprompt",<br/>
        ///             "prompt_data": {"content": "This is a prompt", "metadata": {"model": "gpt-4"}}<br/>
        ///         },<br/>
        ///         "prompt_info": {<br/>
        ///             "prompt_type": "config"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreatePromptPromptsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.Prompt request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Prompt<br/>
        /// Create a new prompt<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/prompts" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "prompt_id": "my_prompt",<br/>
        ///         "litellm_params": {<br/>
        ///             "prompt_id": "my_prompt",<br/>
        ///             "prompt_integration": "dotprompt",<br/>
        ///             "prompt_data": {"content": "This is a prompt", "metadata": {"model": "gpt-4"}}<br/>
        ///         },<br/>
        ///         "prompt_info": {<br/>
        ///             "prompt_type": "config"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmParams"></param>
        /// <param name="promptId"></param>
        /// <param name="promptInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreatePromptPromptsPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.PromptLiteLLMParams litellmParams,
            string promptId,
            global::Loud.Technology.LiteLLM.Sdk.PromptInfo? promptInfo = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
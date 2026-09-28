#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// List Prompts<br/>
        /// List the prompts that are available on the proxy server<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/prompts/list" -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "prompts": [<br/>
        ///         {<br/>
        ///             "prompt_id": "my_prompt_id",<br/>
        ///             "litellm_params": {<br/>
        ///                 "prompt_id": "my_prompt_id",<br/>
        ///                 "prompt_integration": "dotprompt",<br/>
        ///                 "prompt_directory": "/path/to/prompts"<br/>
        ///             },<br/>
        ///             "prompt_info": {<br/>
        ///                 "prompt_type": "config"<br/>
        ///             },<br/>
        ///             "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///             "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListPromptsResponse> ListPromptsPromptsListGetAsync(
            string? environment = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Prompts<br/>
        /// List the prompts that are available on the proxy server<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/prompts/list" -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "prompts": [<br/>
        ///         {<br/>
        ///             "prompt_id": "my_prompt_id",<br/>
        ///             "litellm_params": {<br/>
        ///                 "prompt_id": "my_prompt_id",<br/>
        ///                 "prompt_integration": "dotprompt",<br/>
        ///                 "prompt_directory": "/path/to/prompts"<br/>
        ///             },<br/>
        ///             "prompt_info": {<br/>
        ///                 "prompt_type": "config"<br/>
        ///             },<br/>
        ///             "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///             "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListPromptsResponse>> ListPromptsPromptsListGetAsResponseAsync(
            string? environment = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
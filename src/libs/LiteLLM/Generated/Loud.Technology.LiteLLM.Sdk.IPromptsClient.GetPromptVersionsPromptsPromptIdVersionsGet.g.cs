#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get Prompt Versions<br/>
        /// Get all versions of a specific prompt by base prompt ID<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/prompts/jack_success/versions" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "prompts": [<br/>
        ///         {<br/>
        ///             "prompt_id": "jack_success.v1",<br/>
        ///             "litellm_params": {...},<br/>
        ///             "prompt_info": {"prompt_type": "db"},<br/>
        ///             "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///             "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "prompt_id": "jack_success.v2",<br/>
        ///             "litellm_params": {...},<br/>
        ///             "prompt_info": {"prompt_type": "db"},<br/>
        ///             "created_at": "2023-11-09T13:45:12.345Z",<br/>
        ///             "updated_at": "2023-11-09T13:45:12.345Z"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListPromptsResponse> GetPromptVersionsPromptsPromptIdVersionsGetAsync(
            string promptId,
            string? environment = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Prompt Versions<br/>
        /// Get all versions of a specific prompt by base prompt ID<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/prompts/jack_success/versions" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "prompts": [<br/>
        ///         {<br/>
        ///             "prompt_id": "jack_success.v1",<br/>
        ///             "litellm_params": {...},<br/>
        ///             "prompt_info": {"prompt_type": "db"},<br/>
        ///             "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///             "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "prompt_id": "jack_success.v2",<br/>
        ///             "litellm_params": {...},<br/>
        ///             "prompt_info": {"prompt_type": "db"},<br/>
        ///             "created_at": "2023-11-09T13:45:12.345Z",<br/>
        ///             "updated_at": "2023-11-09T13:45:12.345Z"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="environment"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListPromptsResponse>> GetPromptVersionsPromptsPromptIdVersionsGetAsResponseAsync(
            string promptId,
            string? environment = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
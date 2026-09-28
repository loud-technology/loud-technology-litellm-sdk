#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Patch Prompt<br/>
        /// Partially update an existing prompt<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// This endpoint allows updating specific fields of a prompt without sending the entire object.<br/>
        /// Only the following fields can be updated:<br/>
        /// - litellm_params: LiteLLM parameters for the prompt<br/>
        /// - prompt_info: Additional information about the prompt<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PATCH "http://localhost:4000/prompts/my_prompt_id" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "prompt_info": {<br/>
        ///             "prompt_type": "db"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="environment"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PatchPromptPromptsPromptIdPatchAsync(
            string promptId,

            global::Loud.Technology.LiteLLM.Sdk.PatchPromptRequest request,
            string? environment = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Prompt<br/>
        /// Partially update an existing prompt<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// This endpoint allows updating specific fields of a prompt without sending the entire object.<br/>
        /// Only the following fields can be updated:<br/>
        /// - litellm_params: LiteLLM parameters for the prompt<br/>
        /// - prompt_info: Additional information about the prompt<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PATCH "http://localhost:4000/prompts/my_prompt_id" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "prompt_info": {<br/>
        ///             "prompt_type": "db"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="environment"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> PatchPromptPromptsPromptIdPatchAsResponseAsync(
            string promptId,

            global::Loud.Technology.LiteLLM.Sdk.PatchPromptRequest request,
            string? environment = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Prompt<br/>
        /// Partially update an existing prompt<br/>
        /// 👉 [Prompt docs](https://docs.litellm.ai/docs/proxy/prompt_management)<br/>
        /// This endpoint allows updating specific fields of a prompt without sending the entire object.<br/>
        /// Only the following fields can be updated:<br/>
        /// - litellm_params: LiteLLM parameters for the prompt<br/>
        /// - prompt_info: Additional information about the prompt<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PATCH "http://localhost:4000/prompts/my_prompt_id" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "prompt_info": {<br/>
        ///             "prompt_type": "db"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="environment"></param>
        /// <param name="litellmParams"></param>
        /// <param name="promptInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PatchPromptPromptsPromptIdPatchAsync(
            string promptId,
            string? environment = default,
            global::Loud.Technology.LiteLLM.Sdk.PromptLiteLLMParams? litellmParams = default,
            global::Loud.Technology.LiteLLM.Sdk.PromptInfo? promptInfo = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
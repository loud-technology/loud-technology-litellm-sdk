#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGeminiAgentsClient
    {
        /// <summary>
        /// Delete Gemini Agent<br/>
        /// Delete a custom agent by name.<br/>
        /// Pass per-request Gemini credentials via the JSON-encoded<br/>
        /// ``litellm_params_template`` query parameter. Flat query parameters<br/>
        /// (e.g. ``?api_key=AIza...``) are intentionally ignored — see<br/>
        /// ``_merge_query_params_into_data`` for the rationale.<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/v1beta/agents/my-custom-slides-agent?litellm_params_template=%7B%22api_key%22%3A%22AIza...%22%7D" \<br/>
        ///     -H "Authorization: Bearer sk-..."<br/>
        /// ```
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteGeminiAgentV1betaAgentsNameDeleteAsync(
            string name,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Gemini Agent<br/>
        /// Delete a custom agent by name.<br/>
        /// Pass per-request Gemini credentials via the JSON-encoded<br/>
        /// ``litellm_params_template`` query parameter. Flat query parameters<br/>
        /// (e.g. ``?api_key=AIza...``) are intentionally ignored — see<br/>
        /// ``_merge_query_params_into_data`` for the rationale.<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/v1beta/agents/my-custom-slides-agent?litellm_params_template=%7B%22api_key%22%3A%22AIza...%22%7D" \<br/>
        ///     -H "Authorization: Bearer sk-..."<br/>
        /// ```
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteGeminiAgentV1betaAgentsNameDeleteAsResponseAsync(
            string name,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
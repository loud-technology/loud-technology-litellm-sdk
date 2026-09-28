#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAnthropicSkillsClient
    {
        /// <summary>
        /// List Skills<br/>
        /// List skills on Anthropic.<br/>
        /// Requires `?beta=true` query parameter.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: claude-account-1`<br/>
        /// - Pass model via query: `?model=claude-account-1`<br/>
        /// - Pass model via body: `{"model": "claude-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// # Basic usage<br/>
        /// curl "http://localhost:4000/v1/skills?beta=true&amp;limit=10"       -H "Authorization: Bearer your-key"<br/>
        /// # With model-based routing<br/>
        /// curl "http://localhost:4000/v1/skills?beta=true&amp;limit=10"       -H "Authorization: Bearer your-key"       -H "x-litellm-model: claude-account-1"<br/>
        /// ```<br/>
        /// Pass `?custom_llm_provider=litellm_proxy&amp;query=&lt;task&gt;` to rank the LiteLLM-hosted skills you can<br/>
        /// access by semantic similarity instead of paging through the whole registry:<br/>
        /// ```bash<br/>
        /// curl "http://localhost:4000/v1/skills?custom_llm_provider=litellm_proxy&amp;query=summarize+a+pdf&amp;top_k=5"       -H "Authorization: Bearer your-key"<br/>
        /// ```<br/>
        /// Returns: ListSkillsResponse with list of skills
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="afterId"></param>
        /// <param name="beforeId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: anthropic
        /// </param>
        /// <param name="query">
        /// Describe what you need in natural language to rank the skills you can access by semantic similarity over their title and description. Each result carries a search_score. Only supported for custom_llm_provider=litellm_proxy. Requires litellm_settings.skill_search_embedding_model.
        /// </param>
        /// <param name="topK">
        /// With query: the maximum number of ranked skills to return.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListSkillsResponse> ListSkillsV1SkillsGetAsync(
            int? limit = default,
            string? afterId = default,
            string? beforeId = default,
            string? customLlmProvider = default,
            string? query = default,
            int? topK = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Skills<br/>
        /// List skills on Anthropic.<br/>
        /// Requires `?beta=true` query parameter.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: claude-account-1`<br/>
        /// - Pass model via query: `?model=claude-account-1`<br/>
        /// - Pass model via body: `{"model": "claude-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// # Basic usage<br/>
        /// curl "http://localhost:4000/v1/skills?beta=true&amp;limit=10"       -H "Authorization: Bearer your-key"<br/>
        /// # With model-based routing<br/>
        /// curl "http://localhost:4000/v1/skills?beta=true&amp;limit=10"       -H "Authorization: Bearer your-key"       -H "x-litellm-model: claude-account-1"<br/>
        /// ```<br/>
        /// Pass `?custom_llm_provider=litellm_proxy&amp;query=&lt;task&gt;` to rank the LiteLLM-hosted skills you can<br/>
        /// access by semantic similarity instead of paging through the whole registry:<br/>
        /// ```bash<br/>
        /// curl "http://localhost:4000/v1/skills?custom_llm_provider=litellm_proxy&amp;query=summarize+a+pdf&amp;top_k=5"       -H "Authorization: Bearer your-key"<br/>
        /// ```<br/>
        /// Returns: ListSkillsResponse with list of skills
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="afterId"></param>
        /// <param name="beforeId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: anthropic
        /// </param>
        /// <param name="query">
        /// Describe what you need in natural language to rank the skills you can access by semantic similarity over their title and description. Each result carries a search_score. Only supported for custom_llm_provider=litellm_proxy. Requires litellm_settings.skill_search_embedding_model.
        /// </param>
        /// <param name="topK">
        /// With query: the maximum number of ranked skills to return.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListSkillsResponse>> ListSkillsV1SkillsGetAsResponseAsync(
            int? limit = default,
            string? afterId = default,
            string? beforeId = default,
            string? customLlmProvider = default,
            string? query = default,
            int? topK = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
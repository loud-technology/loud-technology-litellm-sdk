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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListSkillsResponse> ListSkillsV1SkillsGetAsync(
            int? limit = default,
            string? afterId = default,
            string? beforeId = default,
            string? customLlmProvider = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListSkillsResponse>> ListSkillsV1SkillsGetAsResponseAsync(
            int? limit = default,
            string? afterId = default,
            string? beforeId = default,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
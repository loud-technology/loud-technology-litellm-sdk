#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAnthropicSkillsClient
    {
        /// <summary>
        /// Get Skill<br/>
        /// Get a specific skill by ID from Anthropic.<br/>
        /// Requires `?beta=true` query parameter.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: claude-account-1`<br/>
        /// - Pass model via query: `?model=claude-account-1`<br/>
        /// - Pass model via body: `{"model": "claude-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// # Basic usage<br/>
        /// curl "http://localhost:4000/v1/skills/skill_123?beta=true"       -H "Authorization: Bearer your-key"<br/>
        /// # With model-based routing<br/>
        /// curl "http://localhost:4000/v1/skills/skill_123?beta=true"       -H "Authorization: Bearer your-key"       -H "x-litellm-model: claude-account-1"<br/>
        /// ```<br/>
        /// Returns: Skill object
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: anthropic
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.Skill> GetSkillV1SkillsSkillIdGetAsync(
            string skillId,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Skill<br/>
        /// Get a specific skill by ID from Anthropic.<br/>
        /// Requires `?beta=true` query parameter.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: claude-account-1`<br/>
        /// - Pass model via query: `?model=claude-account-1`<br/>
        /// - Pass model via body: `{"model": "claude-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// # Basic usage<br/>
        /// curl "http://localhost:4000/v1/skills/skill_123?beta=true"       -H "Authorization: Bearer your-key"<br/>
        /// # With model-based routing<br/>
        /// curl "http://localhost:4000/v1/skills/skill_123?beta=true"       -H "Authorization: Bearer your-key"       -H "x-litellm-model: claude-account-1"<br/>
        /// ```<br/>
        /// Returns: Skill object
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: anthropic
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.Skill>> GetSkillV1SkillsSkillIdGetAsResponseAsync(
            string skillId,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
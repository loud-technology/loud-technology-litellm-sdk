#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAnthropicSkillsClient
    {
        /// <summary>
        /// Delete Skill<br/>
        /// Delete a skill by ID from Anthropic.<br/>
        /// Requires `?beta=true` query parameter.<br/>
        /// Note: Anthropic does not allow deleting skills with existing versions.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: claude-account-1`<br/>
        /// - Pass model via query: `?model=claude-account-1`<br/>
        /// - Pass model via body: `{"model": "claude-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// # Basic usage<br/>
        /// curl -X DELETE "http://localhost:4000/v1/skills/skill_123?beta=true"       -H "Authorization: Bearer your-key"<br/>
        /// # With model-based routing<br/>
        /// curl -X DELETE "http://localhost:4000/v1/skills/skill_123?beta=true"       -H "Authorization: Bearer your-key"       -H "x-litellm-model: claude-account-1"<br/>
        /// ```<br/>
        /// Returns: DeleteSkillResponse with type="skill_deleted"
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: anthropic
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.DeleteSkillResponse> DeleteSkillV1SkillsSkillIdDeleteAsync(
            string skillId,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Skill<br/>
        /// Delete a skill by ID from Anthropic.<br/>
        /// Requires `?beta=true` query parameter.<br/>
        /// Note: Anthropic does not allow deleting skills with existing versions.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: claude-account-1`<br/>
        /// - Pass model via query: `?model=claude-account-1`<br/>
        /// - Pass model via body: `{"model": "claude-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// # Basic usage<br/>
        /// curl -X DELETE "http://localhost:4000/v1/skills/skill_123?beta=true"       -H "Authorization: Bearer your-key"<br/>
        /// # With model-based routing<br/>
        /// curl -X DELETE "http://localhost:4000/v1/skills/skill_123?beta=true"       -H "Authorization: Bearer your-key"       -H "x-litellm-model: claude-account-1"<br/>
        /// ```<br/>
        /// Returns: DeleteSkillResponse with type="skill_deleted"
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: anthropic
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.DeleteSkillResponse>> DeleteSkillV1SkillsSkillIdDeleteAsResponseAsync(
            string skillId,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
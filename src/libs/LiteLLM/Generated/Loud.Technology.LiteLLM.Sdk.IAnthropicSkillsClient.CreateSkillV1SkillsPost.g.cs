#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAnthropicSkillsClient
    {
        /// <summary>
        /// Create Skill<br/>
        /// Create a new skill on Anthropic.<br/>
        /// Requires `?beta=true` query parameter.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: claude-account-1`<br/>
        /// - Pass model via query: `?model=claude-account-1`<br/>
        /// - Pass model via form field: `model=claude-account-1`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// # Basic usage<br/>
        /// curl -X POST "http://localhost:4000/v1/skills?beta=true"       -H "Content-Type: multipart/form-data"       -H "Authorization: Bearer your-key"       -F "display_title=My Skill"       -F "files[]=@skill.zip"<br/>
        /// # With model-based routing<br/>
        /// curl -X POST "http://localhost:4000/v1/skills?beta=true"       -H "Content-Type: multipart/form-data"       -H "Authorization: Bearer your-key"       -H "x-litellm-model: claude-account-1"       -F "display_title=My Skill"       -F "files[]=@skill.zip"<br/>
        /// ```<br/>
        /// Returns: Skill object with id, display_title, etc.
        /// </summary>
        /// <param name="customLlmProvider">
        /// Default Value: anthropic
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.Skill> CreateSkillV1SkillsPostAsync(
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Skill<br/>
        /// Create a new skill on Anthropic.<br/>
        /// Requires `?beta=true` query parameter.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: claude-account-1`<br/>
        /// - Pass model via query: `?model=claude-account-1`<br/>
        /// - Pass model via form field: `model=claude-account-1`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// # Basic usage<br/>
        /// curl -X POST "http://localhost:4000/v1/skills?beta=true"       -H "Content-Type: multipart/form-data"       -H "Authorization: Bearer your-key"       -F "display_title=My Skill"       -F "files[]=@skill.zip"<br/>
        /// # With model-based routing<br/>
        /// curl -X POST "http://localhost:4000/v1/skills?beta=true"       -H "Content-Type: multipart/form-data"       -H "Authorization: Bearer your-key"       -H "x-litellm-model: claude-account-1"       -F "display_title=My Skill"       -F "files[]=@skill.zip"<br/>
        /// ```<br/>
        /// Returns: Skill object with id, display_title, etc.
        /// </summary>
        /// <param name="customLlmProvider">
        /// Default Value: anthropic
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.Skill>> CreateSkillV1SkillsPostAsResponseAsync(
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
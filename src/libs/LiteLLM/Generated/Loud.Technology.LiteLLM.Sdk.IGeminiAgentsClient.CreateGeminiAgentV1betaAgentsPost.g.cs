#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGeminiAgentsClient
    {
        /// <summary>
        /// Create Gemini Agent<br/>
        /// Create a named custom agent on the Gemini side.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1beta/agents" \<br/>
        ///     -H "Authorization: Bearer sk-..." \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "name": "my-custom-slides-agent",<br/>
        ///         "base_agent": "waverunner",<br/>
        ///         "instructions": "You are a helpful assistant that creates slides.",<br/>
        ///         "base_environment": {<br/>
        ///             "type": "remote",<br/>
        ///             "sources": [<br/>
        ///                 {"type": "gcs", "source": "gs://eap-templates/slides-skill",<br/>
        ///                  "target": "/.agents/skills/slides-skill"}<br/>
        ///             ]<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGeminiAgentV1betaAgentsPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Gemini Agent<br/>
        /// Create a named custom agent on the Gemini side.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1beta/agents" \<br/>
        ///     -H "Authorization: Bearer sk-..." \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "name": "my-custom-slides-agent",<br/>
        ///         "base_agent": "waverunner",<br/>
        ///         "instructions": "You are a helpful assistant that creates slides.",<br/>
        ///         "base_environment": {<br/>
        ///             "type": "remote",<br/>
        ///             "sources": [<br/>
        ///                 {"type": "gcs", "source": "gs://eap-templates/slides-skill",<br/>
        ///                  "target": "/.agents/skills/slides-skill"}<br/>
        ///             ]<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateGeminiAgentV1betaAgentsPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
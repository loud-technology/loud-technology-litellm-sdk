#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update Agent<br/>
        /// Update an existing agent<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/agents/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent": {<br/>
        ///             "agent_name": "updated-agent",<br/>
        ///             "agent_card_params": {<br/>
        ///                 "protocolVersion": "1.0",<br/>
        ///                 "name": "Updated Agent",<br/>
        ///                 "description": "Updated description",<br/>
        ///                 "url": "http://localhost:9999/",<br/>
        ///                 "version": "1.1.0",<br/>
        ///                 "defaultInputModes": ["text"],<br/>
        ///                 "defaultOutputModes": ["text"],<br/>
        ///                 "capabilities": {<br/>
        ///                     "streaming": true<br/>
        ///                 },<br/>
        ///                 "skills": []<br/>
        ///             },<br/>
        ///             "litellm_params": {<br/>
        ///                 "make_public": false<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AgentResponse> UpdateAgentV1AgentsAgentIdPutAsync(
            string agentId,

            global::Loud.Technology.LiteLLM.Sdk.AgentConfig request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent<br/>
        /// Update an existing agent<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/agents/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent": {<br/>
        ///             "agent_name": "updated-agent",<br/>
        ///             "agent_card_params": {<br/>
        ///                 "protocolVersion": "1.0",<br/>
        ///                 "name": "Updated Agent",<br/>
        ///                 "description": "Updated description",<br/>
        ///                 "url": "http://localhost:9999/",<br/>
        ///                 "version": "1.1.0",<br/>
        ///                 "defaultInputModes": ["text"],<br/>
        ///                 "defaultOutputModes": ["text"],<br/>
        ///                 "capabilities": {<br/>
        ///                     "streaming": true<br/>
        ///                 },<br/>
        ///                 "skills": []<br/>
        ///             },<br/>
        ///             "litellm_params": {<br/>
        ///                 "make_public": false<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AgentResponse>> UpdateAgentV1AgentsAgentIdPutAsResponseAsync(
            string agentId,

            global::Loud.Technology.LiteLLM.Sdk.AgentConfig request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent<br/>
        /// Update an existing agent<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/agents/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent": {<br/>
        ///             "agent_name": "updated-agent",<br/>
        ///             "agent_card_params": {<br/>
        ///                 "protocolVersion": "1.0",<br/>
        ///                 "name": "Updated Agent",<br/>
        ///                 "description": "Updated description",<br/>
        ///                 "url": "http://localhost:9999/",<br/>
        ///                 "version": "1.1.0",<br/>
        ///                 "defaultInputModes": ["text"],<br/>
        ///                 "defaultOutputModes": ["text"],<br/>
        ///                 "capabilities": {<br/>
        ///                     "streaming": true<br/>
        ///                 },<br/>
        ///                 "skills": []<br/>
        ///             },<br/>
        ///             "litellm_params": {<br/>
        ///                 "make_public": false<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentCardParams">
        /// The AgentCard is a self-describing manifest for an agent.<br/>
        /// It provides essential metadata including the agent's identity, capabilities,<br/>
        /// skills, supported communication methods, and security requirements.
        /// </param>
        /// <param name="agentName"></param>
        /// <param name="extraHeaders"></param>
        /// <param name="litellmParams"></param>
        /// <param name="objectPermission"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="sessionRpmLimit"></param>
        /// <param name="sessionTpmLimit"></param>
        /// <param name="staticHeaders"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AgentResponse> UpdateAgentV1AgentsAgentIdPutAsync(
            string agentId,
            global::Loud.Technology.LiteLLM.Sdk.AgentCard agentCardParams,
            string agentName,
            global::System.Collections.Generic.IList<string>? extraHeaders = default,
            object? litellmParams = default,
            global::Loud.Technology.LiteLLM.Sdk.AgentObjectPermission? objectPermission = default,
            int? rpmLimit = default,
            int? sessionRpmLimit = default,
            int? sessionTpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, string>? staticHeaders = default,
            int? tpmLimit = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
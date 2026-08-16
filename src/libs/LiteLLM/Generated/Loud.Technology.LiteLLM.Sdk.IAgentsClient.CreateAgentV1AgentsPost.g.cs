#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create Agent<br/>
        /// Create a new agent<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/agents" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent_name": "my-custom-agent",<br/>
        ///             "agent_card_params": {<br/>
        ///                 "protocolVersion": "1.0",<br/>
        ///                 "name": "Hello World Agent",<br/>
        ///                 "description": "Just a hello world agent",<br/>
        ///                 "url": "http://localhost:9999/",<br/>
        ///                 "version": "1.0.0",<br/>
        ///                 "defaultInputModes": ["text"],<br/>
        ///                 "defaultOutputModes": ["text"],<br/>
        ///                 "capabilities": {<br/>
        ///                     "streaming": true<br/>
        ///                 },<br/>
        ///                 "skills": [<br/>
        ///                     {<br/>
        ///                         "id": "hello_world",<br/>
        ///                         "name": "Returns hello world",<br/>
        ///                         "description": "just returns hello world",<br/>
        ///                         "tags": ["hello world"],<br/>
        ///                         "examples": ["hi", "hello world"]<br/>
        ///                     }<br/>
        ///                 ]<br/>
        ///             },<br/>
        ///             "litellm_params": {<br/>
        ///                 "make_public": true<br/>
        ///        }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AgentResponse> CreateAgentV1AgentsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.AgentConfig request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create a new agent<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/agents" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent_name": "my-custom-agent",<br/>
        ///             "agent_card_params": {<br/>
        ///                 "protocolVersion": "1.0",<br/>
        ///                 "name": "Hello World Agent",<br/>
        ///                 "description": "Just a hello world agent",<br/>
        ///                 "url": "http://localhost:9999/",<br/>
        ///                 "version": "1.0.0",<br/>
        ///                 "defaultInputModes": ["text"],<br/>
        ///                 "defaultOutputModes": ["text"],<br/>
        ///                 "capabilities": {<br/>
        ///                     "streaming": true<br/>
        ///                 },<br/>
        ///                 "skills": [<br/>
        ///                     {<br/>
        ///                         "id": "hello_world",<br/>
        ///                         "name": "Returns hello world",<br/>
        ///                         "description": "just returns hello world",<br/>
        ///                         "tags": ["hello world"],<br/>
        ///                         "examples": ["hi", "hello world"]<br/>
        ///                     }<br/>
        ///                 ]<br/>
        ///             },<br/>
        ///             "litellm_params": {<br/>
        ///                 "make_public": true<br/>
        ///        }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AgentResponse>> CreateAgentV1AgentsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.AgentConfig request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent<br/>
        /// Create a new agent<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/agents" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent_name": "my-custom-agent",<br/>
        ///             "agent_card_params": {<br/>
        ///                 "protocolVersion": "1.0",<br/>
        ///                 "name": "Hello World Agent",<br/>
        ///                 "description": "Just a hello world agent",<br/>
        ///                 "url": "http://localhost:9999/",<br/>
        ///                 "version": "1.0.0",<br/>
        ///                 "defaultInputModes": ["text"],<br/>
        ///                 "defaultOutputModes": ["text"],<br/>
        ///                 "capabilities": {<br/>
        ///                     "streaming": true<br/>
        ///                 },<br/>
        ///                 "skills": [<br/>
        ///                     {<br/>
        ///                         "id": "hello_world",<br/>
        ///                         "name": "Returns hello world",<br/>
        ///                         "description": "just returns hello world",<br/>
        ///                         "tags": ["hello world"],<br/>
        ///                         "examples": ["hi", "hello world"]<br/>
        ///                     }<br/>
        ///                 ]<br/>
        ///             },<br/>
        ///             "litellm_params": {<br/>
        ///                 "make_public": true<br/>
        ///        }<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AgentResponse> CreateAgentV1AgentsPostAsync(
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
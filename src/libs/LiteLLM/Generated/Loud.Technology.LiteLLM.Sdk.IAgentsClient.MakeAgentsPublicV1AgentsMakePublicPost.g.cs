#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Make Agents Public<br/>
        /// Make multiple agents publicly discoverable<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/agents/make_public" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent_ids": ["123e4567-e89b-12d3-a456-426614174000", "123e4567-e89b-12d3-a456-426614174001"]<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "agent_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "agent_name": "my-custom-agent",<br/>
        ///     "litellm_params": {<br/>
        ///         "make_public": true<br/>
        ///     },<br/>
        ///     "agent_card_params": {...},<br/>
        ///     "created_at": "2025-11-15T10:30:00Z",<br/>
        ///     "updated_at": "2025-11-15T10:35:00Z",<br/>
        ///     "created_by": "user123",<br/>
        ///     "updated_by": "user123"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AgentMakePublicResponse> MakeAgentsPublicV1AgentsMakePublicPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.MakeAgentsPublicRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Make Agents Public<br/>
        /// Make multiple agents publicly discoverable<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/agents/make_public" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent_ids": ["123e4567-e89b-12d3-a456-426614174000", "123e4567-e89b-12d3-a456-426614174001"]<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "agent_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "agent_name": "my-custom-agent",<br/>
        ///     "litellm_params": {<br/>
        ///         "make_public": true<br/>
        ///     },<br/>
        ///     "agent_card_params": {...},<br/>
        ///     "created_at": "2025-11-15T10:30:00Z",<br/>
        ///     "updated_at": "2025-11-15T10:35:00Z",<br/>
        ///     "created_by": "user123",<br/>
        ///     "updated_by": "user123"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AgentMakePublicResponse>> MakeAgentsPublicV1AgentsMakePublicPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.MakeAgentsPublicRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Make Agents Public<br/>
        /// Make multiple agents publicly discoverable<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/agents/make_public" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "agent_ids": ["123e4567-e89b-12d3-a456-426614174000", "123e4567-e89b-12d3-a456-426614174001"]<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "agent_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "agent_name": "my-custom-agent",<br/>
        ///     "litellm_params": {<br/>
        ///         "make_public": true<br/>
        ///     },<br/>
        ///     "agent_card_params": {...},<br/>
        ///     "created_at": "2025-11-15T10:30:00Z",<br/>
        ///     "updated_at": "2025-11-15T10:35:00Z",<br/>
        ///     "created_by": "user123",<br/>
        ///     "updated_by": "user123"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AgentMakePublicResponse> MakeAgentsPublicV1AgentsMakePublicPostAsync(
            global::System.Collections.Generic.IList<string> agentIds,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
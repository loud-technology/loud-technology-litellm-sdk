#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Agents<br/>
        /// Example usage:<br/>
        /// ```<br/>
        /// curl -X GET "http://localhost:4000/v1/agents"       -H "Content-Type: application/json"       -H "Authorization: Bearer your-key"     ```<br/>
        /// Pass `?health_check=true` to filter out agents whose URL is unreachable:<br/>
        /// ```<br/>
        /// curl -X GET "http://localhost:4000/v1/agents?health_check=true"       -H "Content-Type: application/json"       -H "Authorization: Bearer your-key"     ```<br/>
        /// Returns: List[AgentResponse]
        /// </summary>
        /// <param name="healthCheck">
        /// When true, performs a GET request to each agent's URL. Agents with reachable URLs (HTTP status &lt; 500) and agents without a URL are returned; unreachable agents are filtered out.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentResponse>> GetAgentsV1AgentsGetAsync(
            bool? healthCheck = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agents<br/>
        /// Example usage:<br/>
        /// ```<br/>
        /// curl -X GET "http://localhost:4000/v1/agents"       -H "Content-Type: application/json"       -H "Authorization: Bearer your-key"     ```<br/>
        /// Pass `?health_check=true` to filter out agents whose URL is unreachable:<br/>
        /// ```<br/>
        /// curl -X GET "http://localhost:4000/v1/agents?health_check=true"       -H "Content-Type: application/json"       -H "Authorization: Bearer your-key"     ```<br/>
        /// Returns: List[AgentResponse]
        /// </summary>
        /// <param name="healthCheck">
        /// When true, performs a GET request to each agent's URL. Agents with reachable URLs (HTTP status &lt; 500) and agents without a URL are returned; unreachable agents are filtered out.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentResponse>>> GetAgentsV1AgentsGetAsResponseAsync(
            bool? healthCheck = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
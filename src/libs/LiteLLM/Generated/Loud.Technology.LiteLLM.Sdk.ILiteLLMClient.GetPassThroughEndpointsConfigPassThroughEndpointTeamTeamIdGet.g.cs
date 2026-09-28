#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Get Pass Through Endpoints<br/>
        /// GET configured pass through endpoint.<br/>
        /// If no endpoint_id given, return all configured endpoints.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="endpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PassThroughEndpointResponse> GetPassThroughEndpointsConfigPassThroughEndpointTeamTeamIdGetAsync(
            string? teamId,
            string? endpointId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Pass Through Endpoints<br/>
        /// GET configured pass through endpoint.<br/>
        /// If no endpoint_id given, return all configured endpoints.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="endpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PassThroughEndpointResponse>> GetPassThroughEndpointsConfigPassThroughEndpointTeamTeamIdGetAsResponseAsync(
            string? teamId,
            string? endpointId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
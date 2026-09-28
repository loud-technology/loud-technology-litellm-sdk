#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGoogleGenaiEndpointsClient
    {
        /// <summary>
        /// Get Interaction<br/>
        /// Get an interaction by ID.<br/>
        /// Per OpenAPI spec: GET /{api_version}/interactions/{interaction_id}
        /// </summary>
        /// <param name="interactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetInteractionV1betaInteractionsInteractionIdGetAsync(
            string interactionId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Interaction<br/>
        /// Get an interaction by ID.<br/>
        /// Per OpenAPI spec: GET /{api_version}/interactions/{interaction_id}
        /// </summary>
        /// <param name="interactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetInteractionV1betaInteractionsInteractionIdGetAsResponseAsync(
            string interactionId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
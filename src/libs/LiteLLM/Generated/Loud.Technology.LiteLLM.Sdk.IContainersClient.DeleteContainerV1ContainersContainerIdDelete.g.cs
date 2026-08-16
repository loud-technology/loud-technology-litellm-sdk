#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IContainersClient
    {
        /// <summary>
        /// Delete Container<br/>
        /// Container delete endpoint for deleting a specific container.<br/>
        /// Follows the OpenAI Containers API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/containers<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/v1/containers/cntr_123"         -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Or specify provider via header:<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/v1/containers/cntr_123"         -H "Authorization: Bearer sk-1234"         -H "custom-llm-provider: azure"<br/>
        /// ```
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteContainerV1ContainersContainerIdDeleteAsync(
            string containerId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Container<br/>
        /// Container delete endpoint for deleting a specific container.<br/>
        /// Follows the OpenAI Containers API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/containers<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/v1/containers/cntr_123"         -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Or specify provider via header:<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/v1/containers/cntr_123"         -H "Authorization: Bearer sk-1234"         -H "custom-llm-provider: azure"<br/>
        /// ```
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteContainerV1ContainersContainerIdDeleteAsResponseAsync(
            string containerId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IContainersClient
    {
        /// <summary>
        /// Create Container<br/>
        /// Container creation endpoint for creating new containers.<br/>
        /// Follows the OpenAI Containers API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/containers<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/containers"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "name": "My Container",<br/>
        ///         "expires_after": {<br/>
        ///             "anchor": "last_active_at",<br/>
        ///             "minutes": 20<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Or specify provider via header:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/containers"         -H "Authorization: Bearer sk-1234"         -H "custom-llm-provider: azure"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "name": "My Container"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateContainerV1ContainersPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Container<br/>
        /// Container creation endpoint for creating new containers.<br/>
        /// Follows the OpenAI Containers API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/containers<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/containers"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "name": "My Container",<br/>
        ///         "expires_after": {<br/>
        ///             "anchor": "last_active_at",<br/>
        ///             "minutes": 20<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Or specify provider via header:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/containers"         -H "Authorization: Bearer sk-1234"         -H "custom-llm-provider: azure"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "name": "My Container"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateContainerV1ContainersPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
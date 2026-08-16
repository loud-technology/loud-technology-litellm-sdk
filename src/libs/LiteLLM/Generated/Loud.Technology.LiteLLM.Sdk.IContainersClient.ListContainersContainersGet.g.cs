#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IContainersClient
    {
        /// <summary>
        /// List Containers<br/>
        /// Container list endpoint for retrieving a list of containers.<br/>
        /// Follows the OpenAI Containers API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/containers<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v1/containers?limit=20&amp;order=desc"         -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Or specify provider via header or query param:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v1/containers?custom_llm_provider=azure"         -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListContainersContainersGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Containers<br/>
        /// Container list endpoint for retrieving a list of containers.<br/>
        /// Follows the OpenAI Containers API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/containers<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v1/containers?limit=20&amp;order=desc"         -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Or specify provider via header or query param:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v1/containers?custom_llm_provider=azure"         -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListContainersContainersGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
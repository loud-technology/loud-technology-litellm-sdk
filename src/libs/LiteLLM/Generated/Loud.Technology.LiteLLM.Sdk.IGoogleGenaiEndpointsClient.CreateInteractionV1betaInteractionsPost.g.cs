#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGoogleGenaiEndpointsClient
    {
        /// <summary>
        /// Create Interaction<br/>
        /// Create a new interaction using Google's Interactions API.<br/>
        /// Per OpenAPI spec: POST /{api_version}/interactions<br/>
        /// Supports both model interactions and agent interactions:<br/>
        /// - Model: Provide `model` parameter (e.g., "gemini-2.5-flash")<br/>
        /// - Agent: Provide `agent` parameter (e.g., "deep-research-pro-preview-12-2025")<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1beta/interactions"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "model": "gemini/gemini-2.5-flash",<br/>
        ///         "input": "Hello, how are you?"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateInteractionV1betaInteractionsPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Interaction<br/>
        /// Create a new interaction using Google's Interactions API.<br/>
        /// Per OpenAPI spec: POST /{api_version}/interactions<br/>
        /// Supports both model interactions and agent interactions:<br/>
        /// - Model: Provide `model` parameter (e.g., "gemini-2.5-flash")<br/>
        /// - Agent: Provide `agent` parameter (e.g., "deep-research-pro-preview-12-2025")<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1beta/interactions"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "model": "gemini/gemini-2.5-flash",<br/>
        ///         "input": "Hello, how are you?"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateInteractionV1betaInteractionsPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
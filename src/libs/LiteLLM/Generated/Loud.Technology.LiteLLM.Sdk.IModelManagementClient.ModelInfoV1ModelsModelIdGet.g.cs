#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Model Info<br/>
        /// Retrieve information about a specific model accessible to your API key.<br/>
        /// Returns model details only if the model is available to your API key/team.<br/>
        /// Returns 404 if the model doesn't exist or is not accessible.<br/>
        /// Follows OpenAI API specification for individual model retrieval.<br/>
        /// https://platform.openai.com/docs/api-reference/models/retrieve<br/>
        /// Query parameters mirror `/v1/models` so the same caller context (team<br/>
        /// scoping, health filtering, paused deployments) drives both endpoints; the<br/>
        /// listing's public id must resolve to the same internal deployment here.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="teamId"></param>
        /// <param name="healthyOnly">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelInfoV1ModelsModelIdGetAsync(
            string modelId,
            string? teamId = default,
            bool? healthyOnly = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Info<br/>
        /// Retrieve information about a specific model accessible to your API key.<br/>
        /// Returns model details only if the model is available to your API key/team.<br/>
        /// Returns 404 if the model doesn't exist or is not accessible.<br/>
        /// Follows OpenAI API specification for individual model retrieval.<br/>
        /// https://platform.openai.com/docs/api-reference/models/retrieve<br/>
        /// Query parameters mirror `/v1/models` so the same caller context (team<br/>
        /// scoping, health filtering, paused deployments) drives both endpoints; the<br/>
        /// listing's public id must resolve to the same internal deployment here.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="teamId"></param>
        /// <param name="healthyOnly">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ModelInfoV1ModelsModelIdGetAsResponseAsync(
            string modelId,
            string? teamId = default,
            bool? healthyOnly = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
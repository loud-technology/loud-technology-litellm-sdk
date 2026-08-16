#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Model Info V1<br/>
        /// Provides more info about each model in /models, including config.yaml descriptions (except api key and api base)<br/>
        /// Parameters:<br/>
        ///     litellm_model_id: Optional[str] = None (this is the value of `x-litellm-model-id` returned in response headers)<br/>
        ///     - When litellm_model_id is passed, it will return the info for that specific model<br/>
        ///     - When litellm_model_id is not passed, it will return the info for all models<br/>
        ///     - include_team_models: When true, filter to deployments the caller can use (same as /v2/model/info).<br/>
        ///     - teamId: Filter to models accessible by the given team.<br/>
        /// Each model in the list response includes `model_info.access_via_team_ids` and<br/>
        /// `model_info.direct_access` when the proxy database is connected.<br/>
        /// Returns:<br/>
        ///     Returns a dictionary containing information about each model.<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "data": [<br/>
        ///                 {<br/>
        ///                     "model_name": "fake-openai-endpoint",<br/>
        ///                     "litellm_params": {<br/>
        ///                         "api_base": "https://exampleopenaiendpoint-production.up.railway.app/",<br/>
        ///                         "model": "openai/fake"<br/>
        ///                     },<br/>
        ///                     "model_info": {<br/>
        ///                         "id": "112f74fab24a7a5245d2ced3536dd8f5f9192c57ee6e332af0f0512e08bed5af",<br/>
        ///                         "db_model": false<br/>
        ///                     }<br/>
        ///                 }<br/>
        ///             ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="litellmModelId"></param>
        /// <param name="includeTeamModels">
        /// When true, filter to deployments the caller can use via direct access or team membership.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="teamId">
        /// Filter models by team ID. Returns models with direct_access=True or teamId in access_via_team_ids
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelInfoV1ModelInfoGetAsync(
            string? litellmModelId = default,
            bool? includeTeamModels = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Info V1<br/>
        /// Provides more info about each model in /models, including config.yaml descriptions (except api key and api base)<br/>
        /// Parameters:<br/>
        ///     litellm_model_id: Optional[str] = None (this is the value of `x-litellm-model-id` returned in response headers)<br/>
        ///     - When litellm_model_id is passed, it will return the info for that specific model<br/>
        ///     - When litellm_model_id is not passed, it will return the info for all models<br/>
        ///     - include_team_models: When true, filter to deployments the caller can use (same as /v2/model/info).<br/>
        ///     - teamId: Filter to models accessible by the given team.<br/>
        /// Each model in the list response includes `model_info.access_via_team_ids` and<br/>
        /// `model_info.direct_access` when the proxy database is connected.<br/>
        /// Returns:<br/>
        ///     Returns a dictionary containing information about each model.<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "data": [<br/>
        ///                 {<br/>
        ///                     "model_name": "fake-openai-endpoint",<br/>
        ///                     "litellm_params": {<br/>
        ///                         "api_base": "https://exampleopenaiendpoint-production.up.railway.app/",<br/>
        ///                         "model": "openai/fake"<br/>
        ///                     },<br/>
        ///                     "model_info": {<br/>
        ///                         "id": "112f74fab24a7a5245d2ced3536dd8f5f9192c57ee6e332af0f0512e08bed5af",<br/>
        ///                         "db_model": false<br/>
        ///                     }<br/>
        ///                 }<br/>
        ///             ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="litellmModelId"></param>
        /// <param name="includeTeamModels">
        /// When true, filter to deployments the caller can use via direct access or team membership.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="teamId">
        /// Filter models by team ID. Returns models with direct_access=True or teamId in access_via_team_ids
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ModelInfoV1ModelInfoGetAsResponseAsync(
            string? litellmModelId = default,
            bool? includeTeamModels = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
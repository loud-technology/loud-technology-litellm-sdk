#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Model Info V2<br/>
        /// Paginated model metadata for proxy deployments (pricing, provider, team access).<br/>
        /// Returns configured router deployments with enriched `model_info` (costs, provider,<br/>
        /// context window, etc.). Sensitive fields such as API keys and api_base are omitted.<br/>
        /// Query parameters:<br/>
        ///     model: Filter to a single public `model_name`.<br/>
        ///     user_models_only: When true, only return models created by the calling user.<br/>
        ///     include_team_models: When true, populate `access_via_team_ids` and `direct_access`<br/>
        ///         on each model and filter to deployments the caller can use.<br/>
        ///     page / size: Pagination controls (defaults: page=1, size=50).<br/>
        ///     search: Case-insensitive partial match on model name or team public name.<br/>
        ///     modelId: Return a single deployment by LiteLLM model id.<br/>
        ///     teamId: Filter to models with direct access or team membership for this team id.<br/>
        ///     sortBy / sortOrder: Sort by model_name, created_at, updated_at, costs, or status.<br/>
        /// Example request:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/v2/model/info?include_team_models=true&amp;page=1&amp;size=50' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Example response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "data": [<br/>
        ///         {<br/>
        ///             "model_name": "gpt-4",<br/>
        ///             "litellm_params": {"model": "openai/gpt-4.1"},<br/>
        ///             "model_info": {<br/>
        ///                 "id": "abc123",<br/>
        ///                 "litellm_provider": "openai",<br/>
        ///                 "access_via_team_ids": ["team-1"],<br/>
        ///                 "direct_access": true<br/>
        ///             }<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "total_count": 1,<br/>
        ///     "current_page": 1,<br/>
        ///     "total_pages": 1,<br/>
        ///     "size": 50<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="model">
        /// Specify the model name (optional)
        /// </param>
        /// <param name="userModelsOnly">
        /// Only return models added by this user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTeamModels">
        /// Return all models across all teams user is in.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="debug">
        /// Default Value: false
        /// </param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Search model names (case-insensitive partial match)
        /// </param>
        /// <param name="modelId">
        /// Search for a specific model by its unique ID
        /// </param>
        /// <param name="teamId">
        /// Filter models by team ID. Returns models with direct_access=True or teamId in access_via_team_ids
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by. Options: model_name, created_at, updated_at, costs, status
        /// </param>
        /// <param name="sortOrder">
        /// Sort order. Options: asc, desc<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="excludeAutoRouters">
        /// Omit auto-router deployments (litellm model prefixed `auto_router/`). They select among deployments rather than being deployments themselves, so a caller rendering a deployment list can leave them out. Defaults to false, so existing callers are unaffected<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelInfoV2V2ModelInfoGetAsync(
            string? model = default,
            bool? userModelsOnly = default,
            bool? includeTeamModels = default,
            bool? debug = default,
            int? page = default,
            int? size = default,
            string? search = default,
            string? modelId = default,
            string? teamId = default,
            string? sortBy = default,
            string? sortOrder = default,
            bool? excludeAutoRouters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Info V2<br/>
        /// Paginated model metadata for proxy deployments (pricing, provider, team access).<br/>
        /// Returns configured router deployments with enriched `model_info` (costs, provider,<br/>
        /// context window, etc.). Sensitive fields such as API keys and api_base are omitted.<br/>
        /// Query parameters:<br/>
        ///     model: Filter to a single public `model_name`.<br/>
        ///     user_models_only: When true, only return models created by the calling user.<br/>
        ///     include_team_models: When true, populate `access_via_team_ids` and `direct_access`<br/>
        ///         on each model and filter to deployments the caller can use.<br/>
        ///     page / size: Pagination controls (defaults: page=1, size=50).<br/>
        ///     search: Case-insensitive partial match on model name or team public name.<br/>
        ///     modelId: Return a single deployment by LiteLLM model id.<br/>
        ///     teamId: Filter to models with direct access or team membership for this team id.<br/>
        ///     sortBy / sortOrder: Sort by model_name, created_at, updated_at, costs, or status.<br/>
        /// Example request:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/v2/model/info?include_team_models=true&amp;page=1&amp;size=50' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Example response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "data": [<br/>
        ///         {<br/>
        ///             "model_name": "gpt-4",<br/>
        ///             "litellm_params": {"model": "openai/gpt-4.1"},<br/>
        ///             "model_info": {<br/>
        ///                 "id": "abc123",<br/>
        ///                 "litellm_provider": "openai",<br/>
        ///                 "access_via_team_ids": ["team-1"],<br/>
        ///                 "direct_access": true<br/>
        ///             }<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "total_count": 1,<br/>
        ///     "current_page": 1,<br/>
        ///     "total_pages": 1,<br/>
        ///     "size": 50<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="model">
        /// Specify the model name (optional)
        /// </param>
        /// <param name="userModelsOnly">
        /// Only return models added by this user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTeamModels">
        /// Return all models across all teams user is in.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="debug">
        /// Default Value: false
        /// </param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Search model names (case-insensitive partial match)
        /// </param>
        /// <param name="modelId">
        /// Search for a specific model by its unique ID
        /// </param>
        /// <param name="teamId">
        /// Filter models by team ID. Returns models with direct_access=True or teamId in access_via_team_ids
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by. Options: model_name, created_at, updated_at, costs, status
        /// </param>
        /// <param name="sortOrder">
        /// Sort order. Options: asc, desc<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="excludeAutoRouters">
        /// Omit auto-router deployments (litellm model prefixed `auto_router/`). They select among deployments rather than being deployments themselves, so a caller rendering a deployment list can leave them out. Defaults to false, so existing callers are unaffected<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ModelInfoV2V2ModelInfoGetAsResponseAsync(
            string? model = default,
            bool? userModelsOnly = default,
            bool? includeTeamModels = default,
            bool? debug = default,
            int? page = default,
            int? size = default,
            string? search = default,
            string? modelId = default,
            string? teamId = default,
            string? sortBy = default,
            string? sortOrder = default,
            bool? excludeAutoRouters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
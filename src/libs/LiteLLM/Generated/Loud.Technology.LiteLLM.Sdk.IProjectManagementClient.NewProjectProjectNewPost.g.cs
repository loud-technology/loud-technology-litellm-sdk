#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IProjectManagementClient
    {
        /// <summary>
        /// New Project<br/>
        /// Create a new project. Projects sit between teams and keys in the hierarchy.<br/>
        /// Only admins or team admins can create projects.<br/>
        /// # Parameters<br/>
        /// - project_alias: *Optional[str]* - The name of the project.<br/>
        /// - description: *Optional[str]* - Description of the project's purpose and use case.<br/>
        /// - team_id: *str* - The team id that this project belongs to. Required.<br/>
        /// - models: *List* - The models the project has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the project.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for project<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for project<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for project<br/>
        /// - max_parallel_requests: *Optional[int]* - Max parallel requests for project<br/>
        /// - soft_budget: *Optional[float]* - Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model. Example: {"gpt-4": 100.0, "gpt-3.5-turbo": 50.0}<br/>
        /// - model_rpm_limit: *Optional[dict]* - RPM limits per model. Example: {"gpt-4": 1000, "gpt-3.5-turbo": 5000}<br/>
        /// - model_tpm_limit: *Optional[dict]* - TPM limits per model. Example: {"gpt-4": 50000, "gpt-3.5-turbo": 100000}<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting project budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for project, store information for project. Example metadata - {"use_case_id": "SNOW-12345", "responsible_ai_id": "RAI-67890"}<br/>
        /// - tags: *Optional[list]* - Tags for the project. Example: ["production", "api"]<br/>
        /// - blocked: *bool* - Flag indicating if the project is blocked or not - will stop all calls from keys with this project_id.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - project-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// Example 1: Create new project **without** a budget_id, with model-specific limits<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/new' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_alias": "flight-search-assistant",<br/>
        ///     "description": "AI-powered flight search and booking assistant",<br/>
        ///     "team_id": "team-123",<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"],<br/>
        ///     "max_budget": 100,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 1000,<br/>
        ///         "gpt-3.5-turbo": 5000<br/>
        ///     },<br/>
        ///     "model_tpm_limit": {<br/>
        ///         "gpt-4": 50000,<br/>
        ///         "gpt-3.5-turbo": 100000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "responsible_ai_id": "RAI-67890"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```<br/>
        /// Example 2: Create new project **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/new' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_alias": "hotel-recommendations",<br/>
        ///     "description": "Personalized hotel recommendation engine",<br/>
        ///     "team_id": "team-123",<br/>
        ///     "models": ["claude-3-sonnet"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689",<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-54321"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewProjectResponse> NewProjectProjectNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewProjectRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New Project<br/>
        /// Create a new project. Projects sit between teams and keys in the hierarchy.<br/>
        /// Only admins or team admins can create projects.<br/>
        /// # Parameters<br/>
        /// - project_alias: *Optional[str]* - The name of the project.<br/>
        /// - description: *Optional[str]* - Description of the project's purpose and use case.<br/>
        /// - team_id: *str* - The team id that this project belongs to. Required.<br/>
        /// - models: *List* - The models the project has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the project.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for project<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for project<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for project<br/>
        /// - max_parallel_requests: *Optional[int]* - Max parallel requests for project<br/>
        /// - soft_budget: *Optional[float]* - Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model. Example: {"gpt-4": 100.0, "gpt-3.5-turbo": 50.0}<br/>
        /// - model_rpm_limit: *Optional[dict]* - RPM limits per model. Example: {"gpt-4": 1000, "gpt-3.5-turbo": 5000}<br/>
        /// - model_tpm_limit: *Optional[dict]* - TPM limits per model. Example: {"gpt-4": 50000, "gpt-3.5-turbo": 100000}<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting project budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for project, store information for project. Example metadata - {"use_case_id": "SNOW-12345", "responsible_ai_id": "RAI-67890"}<br/>
        /// - tags: *Optional[list]* - Tags for the project. Example: ["production", "api"]<br/>
        /// - blocked: *bool* - Flag indicating if the project is blocked or not - will stop all calls from keys with this project_id.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - project-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// Example 1: Create new project **without** a budget_id, with model-specific limits<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/new' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_alias": "flight-search-assistant",<br/>
        ///     "description": "AI-powered flight search and booking assistant",<br/>
        ///     "team_id": "team-123",<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"],<br/>
        ///     "max_budget": 100,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 1000,<br/>
        ///         "gpt-3.5-turbo": 5000<br/>
        ///     },<br/>
        ///     "model_tpm_limit": {<br/>
        ///         "gpt-4": 50000,<br/>
        ///         "gpt-3.5-turbo": 100000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "responsible_ai_id": "RAI-67890"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```<br/>
        /// Example 2: Create new project **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/new' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_alias": "hotel-recommendations",<br/>
        ///     "description": "Personalized hotel recommendation engine",<br/>
        ///     "team_id": "team-123",<br/>
        ///     "models": ["claude-3-sonnet"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689",<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-54321"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.NewProjectResponse>> NewProjectProjectNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewProjectRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New Project<br/>
        /// Create a new project. Projects sit between teams and keys in the hierarchy.<br/>
        /// Only admins or team admins can create projects.<br/>
        /// # Parameters<br/>
        /// - project_alias: *Optional[str]* - The name of the project.<br/>
        /// - description: *Optional[str]* - Description of the project's purpose and use case.<br/>
        /// - team_id: *str* - The team id that this project belongs to. Required.<br/>
        /// - models: *List* - The models the project has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the project.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for project<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for project<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for project<br/>
        /// - max_parallel_requests: *Optional[int]* - Max parallel requests for project<br/>
        /// - soft_budget: *Optional[float]* - Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model. Example: {"gpt-4": 100.0, "gpt-3.5-turbo": 50.0}<br/>
        /// - model_rpm_limit: *Optional[dict]* - RPM limits per model. Example: {"gpt-4": 1000, "gpt-3.5-turbo": 5000}<br/>
        /// - model_tpm_limit: *Optional[dict]* - TPM limits per model. Example: {"gpt-4": 50000, "gpt-3.5-turbo": 100000}<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting project budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for project, store information for project. Example metadata - {"use_case_id": "SNOW-12345", "responsible_ai_id": "RAI-67890"}<br/>
        /// - tags: *Optional[list]* - Tags for the project. Example: ["production", "api"]<br/>
        /// - blocked: *bool* - Flag indicating if the project is blocked or not - will stop all calls from keys with this project_id.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - project-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// Example 1: Create new project **without** a budget_id, with model-specific limits<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/new' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_alias": "flight-search-assistant",<br/>
        ///     "description": "AI-powered flight search and booking assistant",<br/>
        ///     "team_id": "team-123",<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"],<br/>
        ///     "max_budget": 100,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 1000,<br/>
        ///         "gpt-3.5-turbo": 5000<br/>
        ///     },<br/>
        ///     "model_tpm_limit": {<br/>
        ///         "gpt-4": 50000,<br/>
        ///         "gpt-3.5-turbo": 100000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "responsible_ai_id": "RAI-67890"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```<br/>
        /// Example 2: Create new project **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/new' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_alias": "hotel-recommendations",<br/>
        ///     "description": "Personalized hotel recommendation engine",<br/>
        ///     "team_id": "team-123",<br/>
        ///     "models": ["claude-3-sonnet"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689",<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-54321"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="softBudget"></param>
        /// <param name="maxBudget"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="modelMaxBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="allowedModels"></param>
        /// <param name="projectId"></param>
        /// <param name="projectAlias"></param>
        /// <param name="description"></param>
        /// <param name="teamId"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="blocked">
        /// Default Value: false
        /// </param>
        /// <param name="objectPermission"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewProjectResponse> NewProjectProjectNewPostAsync(
            string teamId,
            string? budgetId = default,
            double? softBudget = default,
            double? maxBudget = default,
            int? maxParallelRequests = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            object? modelMaxBudget = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            string? projectId = default,
            string? projectAlias = default,
            string? description = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? guardrails = default,
            global::System.Collections.Generic.IList<string>? policies = default,
            global::System.Collections.Generic.IList<string>? models = default,
            object? modelRpmLimit = default,
            object? modelTpmLimit = default,
            bool? blocked = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
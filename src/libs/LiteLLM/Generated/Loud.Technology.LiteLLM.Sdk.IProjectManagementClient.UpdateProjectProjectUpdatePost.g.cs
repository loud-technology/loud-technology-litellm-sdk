#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IProjectManagementClient
    {
        /// <summary>
        /// Update Project<br/>
        /// Update a project<br/>
        /// Parameters:<br/>
        /// - project_id: *str* - The project id to update. Required.<br/>
        /// - project_alias: *Optional[str]* - Updated name for the project<br/>
        /// - description: *Optional[str]* - Updated description for the project<br/>
        /// - team_id: *Optional[str]* - Updated team_id for the project<br/>
        /// - metadata: *Optional[dict]* - Updated metadata for project<br/>
        /// - models: *Optional[list]* - Updated list of models for the project<br/>
        /// - blocked: *Optional[bool]* - Updated blocked status<br/>
        /// - max_budget: *Optional[float]* - Updated max budget<br/>
        /// - tpm_limit: *Optional[int]* - Updated tpm limit<br/>
        /// - rpm_limit: *Optional[int]* - Updated rpm limit<br/>
        /// - model_rpm_limit: *Optional[dict]* - Updated RPM limits per model<br/>
        /// - model_tpm_limit: *Optional[dict]* - Updated TPM limits per model<br/>
        /// - budget_duration: *Optional[str]* - Updated budget duration<br/>
        /// - tags: *Optional[list]* - Updated list of tags for the project<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Updated object permission<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/update' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_id": "project-123",<br/>
        ///     "description": "Updated flight search system with enhanced capabilities",<br/>
        ///     "max_budget": 200,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 2000,<br/>
        ///         "gpt-3.5-turbo": 10000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "status": "active"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable> UpdateProjectProjectUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateProjectRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Update a project<br/>
        /// Parameters:<br/>
        /// - project_id: *str* - The project id to update. Required.<br/>
        /// - project_alias: *Optional[str]* - Updated name for the project<br/>
        /// - description: *Optional[str]* - Updated description for the project<br/>
        /// - team_id: *Optional[str]* - Updated team_id for the project<br/>
        /// - metadata: *Optional[dict]* - Updated metadata for project<br/>
        /// - models: *Optional[list]* - Updated list of models for the project<br/>
        /// - blocked: *Optional[bool]* - Updated blocked status<br/>
        /// - max_budget: *Optional[float]* - Updated max budget<br/>
        /// - tpm_limit: *Optional[int]* - Updated tpm limit<br/>
        /// - rpm_limit: *Optional[int]* - Updated rpm limit<br/>
        /// - model_rpm_limit: *Optional[dict]* - Updated RPM limits per model<br/>
        /// - model_tpm_limit: *Optional[dict]* - Updated TPM limits per model<br/>
        /// - budget_duration: *Optional[str]* - Updated budget duration<br/>
        /// - tags: *Optional[list]* - Updated list of tags for the project<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Updated object permission<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/update' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_id": "project-123",<br/>
        ///     "description": "Updated flight search system with enhanced capabilities",<br/>
        ///     "max_budget": 200,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 2000,<br/>
        ///         "gpt-3.5-turbo": 10000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "status": "active"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable>> UpdateProjectProjectUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateProjectRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Project<br/>
        /// Update a project<br/>
        /// Parameters:<br/>
        /// - project_id: *str* - The project id to update. Required.<br/>
        /// - project_alias: *Optional[str]* - Updated name for the project<br/>
        /// - description: *Optional[str]* - Updated description for the project<br/>
        /// - team_id: *Optional[str]* - Updated team_id for the project<br/>
        /// - metadata: *Optional[dict]* - Updated metadata for project<br/>
        /// - models: *Optional[list]* - Updated list of models for the project<br/>
        /// - blocked: *Optional[bool]* - Updated blocked status<br/>
        /// - max_budget: *Optional[float]* - Updated max budget<br/>
        /// - tpm_limit: *Optional[int]* - Updated tpm limit<br/>
        /// - rpm_limit: *Optional[int]* - Updated rpm limit<br/>
        /// - model_rpm_limit: *Optional[dict]* - Updated RPM limits per model<br/>
        /// - model_tpm_limit: *Optional[dict]* - Updated TPM limits per model<br/>
        /// - budget_duration: *Optional[str]* - Updated budget duration<br/>
        /// - tags: *Optional[list]* - Updated list of tags for the project<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Updated object permission<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/update' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_id": "project-123",<br/>
        ///     "description": "Updated flight search system with enhanced capabilities",<br/>
        ///     "max_budget": 200,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 2000,<br/>
        ///         "gpt-3.5-turbo": 10000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "status": "active"<br/>
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
        /// <param name="models"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="blocked"></param>
        /// <param name="objectPermission"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable> UpdateProjectProjectUpdatePostAsync(
            string projectId,
            string? budgetId = default,
            double? softBudget = default,
            double? maxBudget = default,
            int? maxParallelRequests = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            object? modelMaxBudget = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            string? projectAlias = default,
            string? description = default,
            string? teamId = default,
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
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// New Organization<br/>
        /// Allow orgs to own teams<br/>
        /// Set org level budgets + model access.<br/>
        /// Only admins can create orgs.<br/>
        /// # Parameters<br/>
        /// - organization_alias: *str* - The name of the organization.<br/>
        /// - models: *List* - The models the organization has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the organization.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for org<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for org<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for org<br/>
        /// - model_rpm_limit: *Optional[Dict[str, int]]* - The RPM (Requests Per Minute) limit per model for this organization.<br/>
        /// - model_tpm_limit: *Optional[Dict[str, int]]* - The TPM (Tokens Per Minute) limit per model for this organization.<br/>
        /// - max_parallel_requests: *Optional[int]* - [Not Implemented Yet] Max parallel requests for org<br/>
        /// - soft_budget: *Optional[float]* - [Not Implemented Yet] Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting org budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for organization, store information for organization. Example metadata - {"extra_info": "some info"}<br/>
        /// - blocked: *bool* - Flag indicating if the org is blocked or not - will stop all calls from keys with this org_id.<br/>
        /// - tags: *Optional[List[str]]* - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - organization_id: *Optional[str]* - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - organization-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// - allowed_models: Optional[List[str]] - List of models the organization is allowed to access. If not set, defaults to the models field.<br/>
        /// Case 1: Create new org **without** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "max_budget": 100<br/>
        /// }'<br/>
        /// ```<br/>
        /// Case 2: Create new org **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse> NewOrganizationOrganizationNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewOrganizationRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New Organization<br/>
        /// Allow orgs to own teams<br/>
        /// Set org level budgets + model access.<br/>
        /// Only admins can create orgs.<br/>
        /// # Parameters<br/>
        /// - organization_alias: *str* - The name of the organization.<br/>
        /// - models: *List* - The models the organization has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the organization.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for org<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for org<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for org<br/>
        /// - model_rpm_limit: *Optional[Dict[str, int]]* - The RPM (Requests Per Minute) limit per model for this organization.<br/>
        /// - model_tpm_limit: *Optional[Dict[str, int]]* - The TPM (Tokens Per Minute) limit per model for this organization.<br/>
        /// - max_parallel_requests: *Optional[int]* - [Not Implemented Yet] Max parallel requests for org<br/>
        /// - soft_budget: *Optional[float]* - [Not Implemented Yet] Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting org budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for organization, store information for organization. Example metadata - {"extra_info": "some info"}<br/>
        /// - blocked: *bool* - Flag indicating if the org is blocked or not - will stop all calls from keys with this org_id.<br/>
        /// - tags: *Optional[List[str]]* - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - organization_id: *Optional[str]* - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - organization-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// - allowed_models: Optional[List[str]] - List of models the organization is allowed to access. If not set, defaults to the models field.<br/>
        /// Case 1: Create new org **without** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "max_budget": 100<br/>
        /// }'<br/>
        /// ```<br/>
        /// Case 2: Create new org **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse>> NewOrganizationOrganizationNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewOrganizationRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New Organization<br/>
        /// Allow orgs to own teams<br/>
        /// Set org level budgets + model access.<br/>
        /// Only admins can create orgs.<br/>
        /// # Parameters<br/>
        /// - organization_alias: *str* - The name of the organization.<br/>
        /// - models: *List* - The models the organization has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the organization.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for org<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for org<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for org<br/>
        /// - model_rpm_limit: *Optional[Dict[str, int]]* - The RPM (Requests Per Minute) limit per model for this organization.<br/>
        /// - model_tpm_limit: *Optional[Dict[str, int]]* - The TPM (Tokens Per Minute) limit per model for this organization.<br/>
        /// - max_parallel_requests: *Optional[int]* - [Not Implemented Yet] Max parallel requests for org<br/>
        /// - soft_budget: *Optional[float]* - [Not Implemented Yet] Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting org budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for organization, store information for organization. Example metadata - {"extra_info": "some info"}<br/>
        /// - blocked: *bool* - Flag indicating if the org is blocked or not - will stop all calls from keys with this org_id.<br/>
        /// - tags: *Optional[List[str]]* - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - organization_id: *Optional[str]* - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - organization-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// - allowed_models: Optional[List[str]] - List of models the organization is allowed to access. If not set, defaults to the models field.<br/>
        /// Case 1: Create new org **without** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "max_budget": 100<br/>
        /// }'<br/>
        /// ```<br/>
        /// Case 2: Create new org **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689"<br/>
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
        /// <param name="organizationId"></param>
        /// <param name="organizationAlias"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="objectPermission"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse> NewOrganizationOrganizationNewPostAsync(
            string organizationAlias,
            string? budgetId = default,
            double? softBudget = default,
            double? maxBudget = default,
            int? maxParallelRequests = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            object? modelMaxBudget = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<object>? models = default,
            object? metadata = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelRpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelTpmLimit = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
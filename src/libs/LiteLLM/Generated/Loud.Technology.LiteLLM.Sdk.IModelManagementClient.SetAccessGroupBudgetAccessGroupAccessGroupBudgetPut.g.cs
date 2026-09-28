#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Set Access Group Budget<br/>
        /// Set or replace the shared budget of an access group. Idempotent.<br/>
        /// Every key that can reach a model in the group draws from this one budget.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X PUT 'http://localhost:4000/access_group/production-models/budget' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "max_budget": 100.0,<br/>
        ///     "budget_duration": "30d"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// - max_budget: Optional[float] - Requests fail once the group's shared spend exceeds this<br/>
        /// - soft_budget: Optional[float] - Fires an alert when reached; requests still succeed<br/>
        /// - budget_duration: Optional[str] - Frequency of resetting the group's spend (e.g. '30d')<br/>
        /// - budget_id: Optional[str] - Link an existing budget instead of creating one<br/>
        /// Returns:<br/>
        /// - AccessGroupBudgetResponse with the stored budget and current spend<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If no budget field is given, or budget_duration cannot be parsed<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudgetResponse> SetAccessGroupBudgetAccessGroupAccessGroupBudgetPutAsync(
            string accessGroup,

            global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudgetRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Access Group Budget<br/>
        /// Set or replace the shared budget of an access group. Idempotent.<br/>
        /// Every key that can reach a model in the group draws from this one budget.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X PUT 'http://localhost:4000/access_group/production-models/budget' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "max_budget": 100.0,<br/>
        ///     "budget_duration": "30d"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// - max_budget: Optional[float] - Requests fail once the group's shared spend exceeds this<br/>
        /// - soft_budget: Optional[float] - Fires an alert when reached; requests still succeed<br/>
        /// - budget_duration: Optional[str] - Frequency of resetting the group's spend (e.g. '30d')<br/>
        /// - budget_id: Optional[str] - Link an existing budget instead of creating one<br/>
        /// Returns:<br/>
        /// - AccessGroupBudgetResponse with the stored budget and current spend<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If no budget field is given, or budget_duration cannot be parsed<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudgetResponse>> SetAccessGroupBudgetAccessGroupAccessGroupBudgetPutAsResponseAsync(
            string accessGroup,

            global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudgetRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Access Group Budget<br/>
        /// Set or replace the shared budget of an access group. Idempotent.<br/>
        /// Every key that can reach a model in the group draws from this one budget.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X PUT 'http://localhost:4000/access_group/production-models/budget' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "max_budget": 100.0,<br/>
        ///     "budget_duration": "30d"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// - max_budget: Optional[float] - Requests fail once the group's shared spend exceeds this<br/>
        /// - soft_budget: Optional[float] - Fires an alert when reached; requests still succeed<br/>
        /// - budget_duration: Optional[str] - Frequency of resetting the group's spend (e.g. '30d')<br/>
        /// - budget_id: Optional[str] - Link an existing budget instead of creating one<br/>
        /// Returns:<br/>
        /// - AccessGroupBudgetResponse with the stored budget and current spend<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If no budget field is given, or budget_duration cannot be parsed<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="budgetId"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudgetResponse> SetAccessGroupBudgetAccessGroupAccessGroupBudgetPutAsync(
            string accessGroup,
            string? budgetId = default,
            double? maxBudget = default,
            double? softBudget = default,
            string? budgetDuration = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
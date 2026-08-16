#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetManagementClient
    {
        /// <summary>
        /// Update Budget<br/>
        /// Update an existing budget object.<br/>
        /// Parameters:<br/>
        /// - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        /// - budget_id: Optional[str] - The id of the budget. If not provided, a new id will be generated.<br/>
        /// - max_budget: Optional[float] - The max budget for the budget.<br/>
        /// - soft_budget: Optional[float] - The soft budget for the budget.<br/>
        /// - max_parallel_requests: Optional[int] - The max number of parallel requests for the budget.<br/>
        /// - tpm_limit: Optional[int] - The tokens per minute limit for the budget.<br/>
        /// - rpm_limit: Optional[int] - The requests per minute limit for the budget.<br/>
        /// - model_max_budget: Optional[dict] - Specify max budget for a given model. Example: {"openai/gpt-4o-mini": {"max_budget": 100.0, "budget_duration": "1d", "tpm_limit": 100000, "rpm_limit": 100000}}<br/>
        /// - budget_reset_at: Optional[datetime] - Update the Datetime when the budget was last reset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateBudgetBudgetUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BudgetNewRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Budget<br/>
        /// Update an existing budget object.<br/>
        /// Parameters:<br/>
        /// - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        /// - budget_id: Optional[str] - The id of the budget. If not provided, a new id will be generated.<br/>
        /// - max_budget: Optional[float] - The max budget for the budget.<br/>
        /// - soft_budget: Optional[float] - The soft budget for the budget.<br/>
        /// - max_parallel_requests: Optional[int] - The max number of parallel requests for the budget.<br/>
        /// - tpm_limit: Optional[int] - The tokens per minute limit for the budget.<br/>
        /// - rpm_limit: Optional[int] - The requests per minute limit for the budget.<br/>
        /// - model_max_budget: Optional[dict] - Specify max budget for a given model. Example: {"openai/gpt-4o-mini": {"max_budget": 100.0, "budget_duration": "1d", "tpm_limit": 100000, "rpm_limit": 100000}}<br/>
        /// - budget_reset_at: Optional[datetime] - Update the Datetime when the budget was last reset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateBudgetBudgetUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BudgetNewRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Budget<br/>
        /// Update an existing budget object.<br/>
        /// Parameters:<br/>
        /// - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        /// - budget_id: Optional[str] - The id of the budget. If not provided, a new id will be generated.<br/>
        /// - max_budget: Optional[float] - The max budget for the budget.<br/>
        /// - soft_budget: Optional[float] - The soft budget for the budget.<br/>
        /// - max_parallel_requests: Optional[int] - The max number of parallel requests for the budget.<br/>
        /// - tpm_limit: Optional[int] - The tokens per minute limit for the budget.<br/>
        /// - rpm_limit: Optional[int] - The requests per minute limit for the budget.<br/>
        /// - model_max_budget: Optional[dict] - Specify max budget for a given model. Example: {"openai/gpt-4o-mini": {"max_budget": 100.0, "budget_duration": "1d", "tpm_limit": 100000, "rpm_limit": 100000}}<br/>
        /// - budget_reset_at: Optional[datetime] - Update the Datetime when the budget was last reset.
        /// </summary>
        /// <param name="budgetId">
        /// The unique budget id.
        /// </param>
        /// <param name="maxBudget">
        /// Requests will fail if this budget (in USD) is exceeded.
        /// </param>
        /// <param name="softBudget">
        /// Requests will NOT fail if this is exceeded. Will fire alerting though.
        /// </param>
        /// <param name="maxParallelRequests">
        /// Max concurrent requests allowed for this budget id.
        /// </param>
        /// <param name="tpmLimit">
        /// Max tokens per minute, allowed for this budget id.
        /// </param>
        /// <param name="rpmLimit">
        /// Max requests per minute, allowed for this budget id.
        /// </param>
        /// <param name="budgetDuration">
        /// Max duration budget should be set for (e.g. '1hr', '1d', '28d')
        /// </param>
        /// <param name="modelMaxBudget">
        /// Max budget for each model (e.g. {'gpt-4o': {'max_budget': '0.0000001', 'budget_duration': '1d', 'tpm_limit': 1000, 'rpm_limit': 1000}})
        /// </param>
        /// <param name="budgetResetAt">
        /// Datetime when the budget is reset
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateBudgetBudgetUpdatePostAsync(
            string? budgetId = default,
            double? maxBudget = default,
            double? softBudget = default,
            int? maxParallelRequests = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.BudgetConfig>? modelMaxBudget = default,
            global::System.DateTime? budgetResetAt = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
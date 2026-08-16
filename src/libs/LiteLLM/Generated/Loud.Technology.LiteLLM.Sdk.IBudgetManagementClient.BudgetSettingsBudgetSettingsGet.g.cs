#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetManagementClient
    {
        /// <summary>
        /// Budget Settings<br/>
        /// Get list of configurable params + current value for a budget item + description of each field<br/>
        /// Used on Admin UI.<br/>
        /// Query Parameters:<br/>
        /// - budget_id: str - The budget id to get information for
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BudgetSettingsBudgetSettingsGetAsync(
            string budgetId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Budget Settings<br/>
        /// Get list of configurable params + current value for a budget item + description of each field<br/>
        /// Used on Admin UI.<br/>
        /// Query Parameters:<br/>
        /// - budget_id: str - The budget id to get information for
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> BudgetSettingsBudgetSettingsGetAsResponseAsync(
            string budgetId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
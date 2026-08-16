#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetManagementClient
    {
        /// <summary>
        /// List Budgets<br/>
        /// The budgets defined on this proxy, paged, sortable and filterable, for the<br/>
        /// Budgets page.<br/>
        /// Readable by a proxy admin or an admin viewer; anyone else is refused 403. The<br/>
        /// older `/budget/list` answers with the whole table as a bare array and has no<br/>
        /// way to page, sort or filter it.<br/>
        /// `sort` takes a comma-separated list of `budget_id`, `max_budget`, `tpm_limit`,<br/>
        /// `rpm_limit` or `created_at`, each optionally prefixed with `-` for descending,<br/>
        /// and defaults to `-created_at`. `budget_id` is appended to every sort as the<br/>
        /// tiebreaker. `q` is a case-insensitive substring match on `budget_id`.<br/>
        /// `page_size` defaults to 50 and is capped at 100. Filters are<br/>
        /// `filter[budget_duration][in|is_null]`, `filter[max_budget][gte|lte|is_null]`<br/>
        /// and `filter[created_at][gte|lte]`.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --globoff 'http://0.0.0.0:4000/management/v1/budgets?sort=-max_budget&amp;filter[budget_duration][in]=7d,30d&amp;page_size=25'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListResponseBudgetListItem> ListBudgetsManagementV1BudgetsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Budgets<br/>
        /// The budgets defined on this proxy, paged, sortable and filterable, for the<br/>
        /// Budgets page.<br/>
        /// Readable by a proxy admin or an admin viewer; anyone else is refused 403. The<br/>
        /// older `/budget/list` answers with the whole table as a bare array and has no<br/>
        /// way to page, sort or filter it.<br/>
        /// `sort` takes a comma-separated list of `budget_id`, `max_budget`, `tpm_limit`,<br/>
        /// `rpm_limit` or `created_at`, each optionally prefixed with `-` for descending,<br/>
        /// and defaults to `-created_at`. `budget_id` is appended to every sort as the<br/>
        /// tiebreaker. `q` is a case-insensitive substring match on `budget_id`.<br/>
        /// `page_size` defaults to 50 and is capped at 100. Filters are<br/>
        /// `filter[budget_duration][in|is_null]`, `filter[max_budget][gte|lte|is_null]`<br/>
        /// and `filter[created_at][gte|lte]`.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --globoff 'http://0.0.0.0:4000/management/v1/budgets?sort=-max_budget&amp;filter[budget_duration][in]=7d,30d&amp;page_size=25'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListResponseBudgetListItem>> ListBudgetsManagementV1BudgetsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
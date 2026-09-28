#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// View Spend Tags<br/>
        /// LiteLLM Enterprise - View Spend Per Request Tag<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/tags" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Spend with Start Date and End Date<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/tags?start_date=2022-01-01&amp;end_date=2022-02-01" -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing key spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view key spend
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMSpendLogs>> ViewSpendTagsSpendTagsGetAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// View Spend Tags<br/>
        /// LiteLLM Enterprise - View Spend Per Request Tag<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/tags" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Spend with Start Date and End Date<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/tags?start_date=2022-01-01&amp;end_date=2022-02-01" -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="startDate">
        /// Time from which to start viewing key spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view key spend
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMSpendLogs>>> ViewSpendTagsSpendTagsGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
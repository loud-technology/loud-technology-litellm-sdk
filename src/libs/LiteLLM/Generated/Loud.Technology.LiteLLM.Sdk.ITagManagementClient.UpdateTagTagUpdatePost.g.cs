#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Update Tag<br/>
        /// Update an existing tag.<br/>
        /// Parameters:<br/>
        /// - name: str - The name of the tag to update<br/>
        /// - description: Optional[str] - Updated description<br/>
        /// - models: List[str] - Updated list of allowed LLM models<br/>
        /// - budget_id: Optional[str] - The id for a budget to associate with the tag<br/>
        /// ### BUDGET UPDATE PARAMS ###<br/>
        /// - max_budget: Optional[float] - Max budget for tag<br/>
        /// - tpm_limit: Optional[int] - Max tpm limit for tag<br/>
        /// - rpm_limit: Optional[int] - Max rpm limit for tag<br/>
        /// - max_parallel_requests: Optional[int] - Max parallel requests for tag<br/>
        /// - soft_budget: Optional[float] - Get a slack alert when this soft budget is reached<br/>
        /// - model_max_budget: Optional[dict] - Max budget for a specific model<br/>
        /// - budget_duration: Optional[str] - Frequency of resetting tag budget
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateTagTagUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TagUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tag<br/>
        /// Update an existing tag.<br/>
        /// Parameters:<br/>
        /// - name: str - The name of the tag to update<br/>
        /// - description: Optional[str] - Updated description<br/>
        /// - models: List[str] - Updated list of allowed LLM models<br/>
        /// - budget_id: Optional[str] - The id for a budget to associate with the tag<br/>
        /// ### BUDGET UPDATE PARAMS ###<br/>
        /// - max_budget: Optional[float] - Max budget for tag<br/>
        /// - tpm_limit: Optional[int] - Max tpm limit for tag<br/>
        /// - rpm_limit: Optional[int] - Max rpm limit for tag<br/>
        /// - max_parallel_requests: Optional[int] - Max parallel requests for tag<br/>
        /// - soft_budget: Optional[float] - Get a slack alert when this soft budget is reached<br/>
        /// - model_max_budget: Optional[dict] - Max budget for a specific model<br/>
        /// - budget_duration: Optional[str] - Frequency of resetting tag budget
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateTagTagUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TagUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tag<br/>
        /// Update an existing tag.<br/>
        /// Parameters:<br/>
        /// - name: str - The name of the tag to update<br/>
        /// - description: Optional[str] - Updated description<br/>
        /// - models: List[str] - Updated list of allowed LLM models<br/>
        /// - budget_id: Optional[str] - The id for a budget to associate with the tag<br/>
        /// ### BUDGET UPDATE PARAMS ###<br/>
        /// - max_budget: Optional[float] - Max budget for tag<br/>
        /// - tpm_limit: Optional[int] - Max tpm limit for tag<br/>
        /// - rpm_limit: Optional[int] - Max rpm limit for tag<br/>
        /// - max_parallel_requests: Optional[int] - Max parallel requests for tag<br/>
        /// - soft_budget: Optional[float] - Get a slack alert when this soft budget is reached<br/>
        /// - model_max_budget: Optional[dict] - Max budget for a specific model<br/>
        /// - budget_duration: Optional[str] - Frequency of resetting tag budget
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="models"></param>
        /// <param name="modelInfo"></param>
        /// <param name="budgetId"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="modelMaxBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateTagTagUpdatePostAsync(
            string name,
            string? description = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.Dictionary<string, string>? modelInfo = default,
            string? budgetId = default,
            double? maxBudget = default,
            double? softBudget = default,
            int? maxParallelRequests = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            object? modelMaxBudget = default,
            string? budgetDuration = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
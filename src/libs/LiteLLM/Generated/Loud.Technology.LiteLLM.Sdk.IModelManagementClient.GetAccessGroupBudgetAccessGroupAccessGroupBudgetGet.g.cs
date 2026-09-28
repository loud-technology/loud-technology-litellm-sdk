#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Get Access Group Budget<br/>
        /// Get the shared budget of an access group, and the spend drawn against it.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET 'http://localhost:4000/access_group/production-models/budget' \<br/>
        ///   -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// Returns:<br/>
        /// - AccessGroupBudgetResponse; budget is null when the group has no budget set<br/>
        /// Raises:<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudgetResponse> GetAccessGroupBudgetAccessGroupAccessGroupBudgetGetAsync(
            string accessGroup,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Access Group Budget<br/>
        /// Get the shared budget of an access group, and the spend drawn against it.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET 'http://localhost:4000/access_group/production-models/budget' \<br/>
        ///   -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// Returns:<br/>
        /// - AccessGroupBudgetResponse; budget is null when the group has no budget set<br/>
        /// Raises:<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AccessGroupBudgetResponse>> GetAccessGroupBudgetAccessGroupAccessGroupBudgetGetAsResponseAsync(
            string accessGroup,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
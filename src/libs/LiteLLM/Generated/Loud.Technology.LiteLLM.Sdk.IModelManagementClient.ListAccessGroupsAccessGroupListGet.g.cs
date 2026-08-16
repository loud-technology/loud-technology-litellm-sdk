#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// List Access Groups<br/>
        /// List all access groups.<br/>
        /// Returns a list of all access groups with their model names and deployment counts.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET 'http://localhost:4000/access_group/list' \<br/>
        ///   -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - ListAccessGroupsResponse with all access groups
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListAccessGroupsResponse> ListAccessGroupsAccessGroupListGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Access Groups<br/>
        /// List all access groups.<br/>
        /// Returns a list of all access groups with their model names and deployment counts.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET 'http://localhost:4000/access_group/list' \<br/>
        ///   -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - ListAccessGroupsResponse with all access groups
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListAccessGroupsResponse>> ListAccessGroupsAccessGroupListGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// Delete Organization<br/>
        /// Delete an organization<br/>
        /// # Parameters:<br/>
        /// - organization_ids: List[str] - The organization ids to delete.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>> DeleteOrganizationOrganizationDeleteDeleteAsync(

            global::Loud.Technology.LiteLLM.Sdk.DeleteOrganizationRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Organization<br/>
        /// Delete an organization<br/>
        /// # Parameters:<br/>
        /// - organization_ids: List[str] - The organization ids to delete.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>>> DeleteOrganizationOrganizationDeleteDeleteAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.DeleteOrganizationRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Organization<br/>
        /// Delete an organization<br/>
        /// # Parameters:<br/>
        /// - organization_ids: List[str] - The organization ids to delete.
        /// </summary>
        /// <param name="organizationIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>> DeleteOrganizationOrganizationDeleteDeleteAsync(
            global::System.Collections.Generic.IList<string> organizationIds,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
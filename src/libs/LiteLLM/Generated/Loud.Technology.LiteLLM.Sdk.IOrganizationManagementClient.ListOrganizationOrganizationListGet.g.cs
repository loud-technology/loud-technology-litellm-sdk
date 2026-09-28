#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// List Organization<br/>
        /// Get a list of organizations with optional filtering.<br/>
        /// Parameters:<br/>
        ///     org_id: Optional[str]<br/>
        ///         Filter organizations by exact organization_id match<br/>
        ///     org_alias: Optional[str]<br/>
        ///         Filter organizations by partial organization_alias match (case-insensitive)<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl --location --request GET 'http://0.0.0.0:4000/organization/list?org_alias=my-org'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Example with org_id:<br/>
        /// ```<br/>
        /// curl --location --request GET 'http://0.0.0.0:4000/organization/list?org_id=123e4567-e89b-12d3-a456-426614174000'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="orgId">
        /// Filter organizations by exact organization_id match
        /// </param>
        /// <param name="orgAlias">
        /// Filter organizations by partial organization_alias match. Supports case-insensitive search.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>> ListOrganizationOrganizationListGetAsync(
            string? orgId = default,
            string? orgAlias = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Organization<br/>
        /// Get a list of organizations with optional filtering.<br/>
        /// Parameters:<br/>
        ///     org_id: Optional[str]<br/>
        ///         Filter organizations by exact organization_id match<br/>
        ///     org_alias: Optional[str]<br/>
        ///         Filter organizations by partial organization_alias match (case-insensitive)<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl --location --request GET 'http://0.0.0.0:4000/organization/list?org_alias=my-org'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Example with org_id:<br/>
        /// ```<br/>
        /// curl --location --request GET 'http://0.0.0.0:4000/organization/list?org_id=123e4567-e89b-12d3-a456-426614174000'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="orgId">
        /// Filter organizations by exact organization_id match
        /// </param>
        /// <param name="orgAlias">
        /// Filter organizations by partial organization_alias match. Supports case-insensitive search.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>>> ListOrganizationOrganizationListGetAsResponseAsync(
            string? orgId = default,
            string? orgAlias = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
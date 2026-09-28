#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// Update Organization V2<br/>
        /// Partial update of an organization (RESTful PATCH, RFC 7396 merge-patch semantics).<br/>
        /// A sent field is written and an omitted one is left untouched (presence is read from<br/>
        /// ``model_fields_set``). Clear tokens are per field: budget limits and ``metadata`` clear with<br/>
        /// ``null``, ``models`` with ``[]``, and ``object_permission`` with ``null`` (it merges when sent,<br/>
        /// so an empty ``{}`` is rejected). ``organization_alias`` is required and cannot be cleared.<br/>
        /// Validation failures return 422; the object-permission upsert, budget-row write, and<br/>
        /// org-row write are one transaction.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers> UpdateOrganizationV2V2OrganizationOrganizationIdPatchAsync(
            string organizationId,

            global::Loud.Technology.LiteLLM.Sdk.OrganizationUpdateRequestV2 request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Organization V2<br/>
        /// Partial update of an organization (RESTful PATCH, RFC 7396 merge-patch semantics).<br/>
        /// A sent field is written and an omitted one is left untouched (presence is read from<br/>
        /// ``model_fields_set``). Clear tokens are per field: budget limits and ``metadata`` clear with<br/>
        /// ``null``, ``models`` with ``[]``, and ``object_permission`` with ``null`` (it merges when sent,<br/>
        /// so an empty ``{}`` is rejected). ``organization_alias`` is required and cannot be cleared.<br/>
        /// Validation failures return 422; the object-permission upsert, budget-row write, and<br/>
        /// org-row write are one transaction.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers>> UpdateOrganizationV2V2OrganizationOrganizationIdPatchAsResponseAsync(
            string organizationId,

            global::Loud.Technology.LiteLLM.Sdk.OrganizationUpdateRequestV2 request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Organization V2<br/>
        /// Partial update of an organization (RESTful PATCH, RFC 7396 merge-patch semantics).<br/>
        /// A sent field is written and an omitted one is left untouched (presence is read from<br/>
        /// ``model_fields_set``). Clear tokens are per field: budget limits and ``metadata`` clear with<br/>
        /// ``null``, ``models`` with ``[]``, and ``object_permission`` with ``null`` (it merges when sent,<br/>
        /// so an empty ``{}`` is rejected). ``organization_alias`` is required and cannot be cleared.<br/>
        /// Validation failures return 422; the object-permission upsert, budget-row write, and<br/>
        /// org-row write are one transaction.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="organizationAlias"></param>
        /// <param name="models"></param>
        /// <param name="metadata"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="modelMaxBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="objectPermission"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationTableWithMembers> UpdateOrganizationV2V2OrganizationOrganizationIdPatchAsync(
            string organizationId,
            string? organizationAlias = default,
            global::System.Collections.Generic.IList<string>? models = default,
            object? metadata = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            double? maxBudget = default,
            double? softBudget = default,
            int? maxParallelRequests = default,
            object? modelMaxBudget = default,
            string? budgetDuration = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
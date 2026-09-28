#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// Update Access Group
        /// </summary>
        /// <param name="accessGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AccessGroupResponse> UpdateAccessGroupV1UnifiedAccessGroupAccessGroupIdPutAsync(
            string accessGroupId,

            global::Loud.Technology.LiteLLM.Sdk.AccessGroupUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Access Group
        /// </summary>
        /// <param name="accessGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AccessGroupResponse>> UpdateAccessGroupV1UnifiedAccessGroupAccessGroupIdPutAsResponseAsync(
            string accessGroupId,

            global::Loud.Technology.LiteLLM.Sdk.AccessGroupUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Access Group
        /// </summary>
        /// <param name="accessGroupId"></param>
        /// <param name="accessAgentIds"></param>
        /// <param name="accessGroupName"></param>
        /// <param name="accessMcpServerIds"></param>
        /// <param name="accessModelNames"></param>
        /// <param name="assignedKeyIds"></param>
        /// <param name="assignedTeamIds"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AccessGroupResponse> UpdateAccessGroupV1UnifiedAccessGroupAccessGroupIdPutAsync(
            string accessGroupId,
            global::System.Collections.Generic.IList<string>? accessAgentIds = default,
            string? accessGroupName = default,
            global::System.Collections.Generic.IList<string>? accessMcpServerIds = default,
            global::System.Collections.Generic.IList<string>? accessModelNames = default,
            global::System.Collections.Generic.IList<string>? assignedKeyIds = default,
            global::System.Collections.Generic.IList<string>? assignedTeamIds = default,
            string? description = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
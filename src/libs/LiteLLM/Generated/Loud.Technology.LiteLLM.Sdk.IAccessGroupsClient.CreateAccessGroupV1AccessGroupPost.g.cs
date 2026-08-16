#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAccessGroupsClient
    {
        /// <summary>
        /// Create Access Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AccessGroupResponse> CreateAccessGroupV1AccessGroupPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.AccessGroupCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Access Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AccessGroupResponse>> CreateAccessGroupV1AccessGroupPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.AccessGroupCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Access Group
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AccessGroupResponse> CreateAccessGroupV1AccessGroupPostAsync(
            string accessGroupName,
            global::System.Collections.Generic.IList<string>? accessAgentIds = default,
            global::System.Collections.Generic.IList<string>? accessMcpServerIds = default,
            global::System.Collections.Generic.IList<string>? accessModelNames = default,
            global::System.Collections.Generic.IList<string>? assignedKeyIds = default,
            global::System.Collections.Generic.IList<string>? assignedTeamIds = default,
            string? description = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
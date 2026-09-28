#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get Groups<br/>
        /// Get a list of groups according to SCIM v2 protocol
        /// </summary>
        /// <param name="startIndex">
        /// Default Value: 1
        /// </param>
        /// <param name="count">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SCIMListResponse> GetGroupsScimV2GroupsGetAsync(
            int? startIndex = default,
            int? count = default,
            string? filter = default,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Groups<br/>
        /// Get a list of groups according to SCIM v2 protocol
        /// </summary>
        /// <param name="startIndex">
        /// Default Value: 1
        /// </param>
        /// <param name="count">
        /// Default Value: 10
        /// </param>
        /// <param name="filter"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SCIMListResponse>> GetGroupsScimV2GroupsGetAsResponseAsync(
            int? startIndex = default,
            int? count = default,
            string? filter = default,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
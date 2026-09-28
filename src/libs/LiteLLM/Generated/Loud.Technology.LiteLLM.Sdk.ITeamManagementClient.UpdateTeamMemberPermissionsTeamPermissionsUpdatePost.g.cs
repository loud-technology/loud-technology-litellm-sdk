#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Update Team Member Permissions<br/>
        /// Update the team member permissions for a team
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable> UpdateTeamMemberPermissionsTeamPermissionsUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateTeamMemberPermissionsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Team Member Permissions<br/>
        /// Update the team member permissions for a team
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable>> UpdateTeamMemberPermissionsTeamPermissionsUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateTeamMemberPermissionsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Team Member Permissions<br/>
        /// Update the team member permissions for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="teamMemberPermissions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable> UpdateTeamMemberPermissionsTeamPermissionsUpdatePostAsync(
            string teamId,
            global::System.Collections.Generic.IList<string> teamMemberPermissions,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
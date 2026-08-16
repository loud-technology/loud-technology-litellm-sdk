#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Bulk Update Team Member Permissions<br/>
        /// Append permissions to existing teams.<br/>
        /// Either pass team_ids to target specific teams, or set<br/>
        /// apply_to_all_teams=True to update every team. For each team,<br/>
        /// the provided permissions are merged with the team's existing<br/>
        /// permissions (duplicates are skipped).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateTeamMemberPermissionsResponse> BulkUpdateTeamMemberPermissionsTeamPermissionsBulkUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkUpdateTeamMemberPermissionsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update Team Member Permissions<br/>
        /// Append permissions to existing teams.<br/>
        /// Either pass team_ids to target specific teams, or set<br/>
        /// apply_to_all_teams=True to update every team. For each team,<br/>
        /// the provided permissions are merged with the team's existing<br/>
        /// permissions (duplicates are skipped).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateTeamMemberPermissionsResponse>> BulkUpdateTeamMemberPermissionsTeamPermissionsBulkUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkUpdateTeamMemberPermissionsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update Team Member Permissions<br/>
        /// Append permissions to existing teams.<br/>
        /// Either pass team_ids to target specific teams, or set<br/>
        /// apply_to_all_teams=True to update every team. For each team,<br/>
        /// the provided permissions are merged with the team's existing<br/>
        /// permissions (duplicates are skipped).
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="teamIds"></param>
        /// <param name="applyToAllTeams">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateTeamMemberPermissionsResponse> BulkUpdateTeamMemberPermissionsTeamPermissionsBulkUpdatePostAsync(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeyManagementRoutes> permissions,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            bool? applyToAllTeams = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
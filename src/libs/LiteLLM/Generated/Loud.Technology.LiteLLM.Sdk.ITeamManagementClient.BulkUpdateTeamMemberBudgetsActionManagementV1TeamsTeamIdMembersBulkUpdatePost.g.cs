#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Bulk Update Team Member Budgets Action<br/>
        /// Set per-member limits for up to 500 members of one team in one call. Same<br/>
        /// authorization and member addressing as `/team/member_update`: proxy admins, the team's<br/>
        /// admins, and admins of the team's organization, with each member named by exactly one of<br/>
        /// `user_id` or `user_email`. Unknown body fields are a 422 and an unknown team is a 404.<br/>
        /// Each row is a merge patch of that member's limits: a field left out is untouched, a<br/>
        /// field sent as null is cleared, and clearing the last limit drops the member back to the<br/>
        /// team default. A budget row shared by several memberships, the team default included, is<br/>
        /// copied for the member being patched rather than written in place, so one member's new<br/>
        /// cap never lands on anybody else.<br/>
        /// `data` holds one result per requested member, in request order, carrying the limits in<br/>
        /// force after the write. A row is `success: false` with an `error` when it names nobody on<br/>
        /// the team or repeats an earlier row. Roles are not part of this route; `/team/member_update`<br/>
        /// still owns them.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/teams/team-1/members/bulk_update'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"members": [{"user_id": "user-1", "max_budget_in_team": 10}, {"user_email": "user-2@example.com", "max_budget_in_team": 10, "budget_duration": "30d"}]}'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberBudgetUpdateResponse> BulkUpdateTeamMemberBudgetsActionManagementV1TeamsTeamIdMembersBulkUpdatePostAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberBudgetUpdateRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update Team Member Budgets Action<br/>
        /// Set per-member limits for up to 500 members of one team in one call. Same<br/>
        /// authorization and member addressing as `/team/member_update`: proxy admins, the team's<br/>
        /// admins, and admins of the team's organization, with each member named by exactly one of<br/>
        /// `user_id` or `user_email`. Unknown body fields are a 422 and an unknown team is a 404.<br/>
        /// Each row is a merge patch of that member's limits: a field left out is untouched, a<br/>
        /// field sent as null is cleared, and clearing the last limit drops the member back to the<br/>
        /// team default. A budget row shared by several memberships, the team default included, is<br/>
        /// copied for the member being patched rather than written in place, so one member's new<br/>
        /// cap never lands on anybody else.<br/>
        /// `data` holds one result per requested member, in request order, carrying the limits in<br/>
        /// force after the write. A row is `success: false` with an `error` when it names nobody on<br/>
        /// the team or repeats an earlier row. Roles are not part of this route; `/team/member_update`<br/>
        /// still owns them.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/teams/team-1/members/bulk_update'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"members": [{"user_id": "user-1", "max_budget_in_team": 10}, {"user_email": "user-2@example.com", "max_budget_in_team": 10, "budget_duration": "30d"}]}'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberBudgetUpdateResponse>> BulkUpdateTeamMemberBudgetsActionManagementV1TeamsTeamIdMembersBulkUpdatePostAsResponseAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberBudgetUpdateRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update Team Member Budgets Action<br/>
        /// Set per-member limits for up to 500 members of one team in one call. Same<br/>
        /// authorization and member addressing as `/team/member_update`: proxy admins, the team's<br/>
        /// admins, and admins of the team's organization, with each member named by exactly one of<br/>
        /// `user_id` or `user_email`. Unknown body fields are a 422 and an unknown team is a 404.<br/>
        /// Each row is a merge patch of that member's limits: a field left out is untouched, a<br/>
        /// field sent as null is cleared, and clearing the last limit drops the member back to the<br/>
        /// team default. A budget row shared by several memberships, the team default included, is<br/>
        /// copied for the member being patched rather than written in place, so one member's new<br/>
        /// cap never lands on anybody else.<br/>
        /// `data` holds one result per requested member, in request order, carrying the limits in<br/>
        /// force after the write. A row is `success: false` with an `error` when it names nobody on<br/>
        /// the team or repeats an earlier row. Roles are not part of this route; `/team/member_update`<br/>
        /// still owns them.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/teams/team-1/members/bulk_update'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"members": [{"user_id": "user-1", "max_budget_in_team": 10}, {"user_email": "user-2@example.com", "max_budget_in_team": 10, "budget_duration": "30d"}]}'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="members"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberBudgetUpdateResponse> BulkUpdateTeamMemberBudgetsActionManagementV1TeamsTeamIdMembersBulkUpdatePostAsync(
            string teamId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TeamMemberBudgetPatch> members,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Bulk Delete Team Members Action<br/>
        /// Remove up to 500 members from one team in one call. Same authorization as<br/>
        /// `/team/member_delete`: proxy admins, the team's admins, and admins of the team's<br/>
        /// organization. Each member is named by exactly one of `user_id` or `user_email`;<br/>
        /// unknown body fields are a 422 and an unknown team is a 404.<br/>
        /// `data` holds one result per requested member, in request order. A row is<br/>
        /// `success: false` with an `error` when it names nobody on the team or repeats an<br/>
        /// earlier row. The roster is rewritten once, under the team's advisory lock, so a<br/>
        /// concurrent member_add is never overwritten from a stale read.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/teams/team-1/members/bulk_delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"members": [{"user_id": "user-1"}, {"user_email": "user-2@example.com"}]}'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberDeleteResponse> BulkDeleteTeamMembersActionManagementV1TeamsTeamIdMembersBulkDeletePostAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberDeleteRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Delete Team Members Action<br/>
        /// Remove up to 500 members from one team in one call. Same authorization as<br/>
        /// `/team/member_delete`: proxy admins, the team's admins, and admins of the team's<br/>
        /// organization. Each member is named by exactly one of `user_id` or `user_email`;<br/>
        /// unknown body fields are a 422 and an unknown team is a 404.<br/>
        /// `data` holds one result per requested member, in request order. A row is<br/>
        /// `success: false` with an `error` when it names nobody on the team or repeats an<br/>
        /// earlier row. The roster is rewritten once, under the team's advisory lock, so a<br/>
        /// concurrent member_add is never overwritten from a stale read.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/teams/team-1/members/bulk_delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"members": [{"user_id": "user-1"}, {"user_email": "user-2@example.com"}]}'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberDeleteResponse>> BulkDeleteTeamMembersActionManagementV1TeamsTeamIdMembersBulkDeletePostAsResponseAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberDeleteRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Delete Team Members Action<br/>
        /// Remove up to 500 members from one team in one call. Same authorization as<br/>
        /// `/team/member_delete`: proxy admins, the team's admins, and admins of the team's<br/>
        /// organization. Each member is named by exactly one of `user_id` or `user_email`;<br/>
        /// unknown body fields are a 422 and an unknown team is a 404.<br/>
        /// `data` holds one result per requested member, in request order. A row is<br/>
        /// `success: false` with an `error` when it names nobody on the team or repeats an<br/>
        /// earlier row. The roster is rewritten once, under the team's advisory lock, so a<br/>
        /// concurrent member_add is never overwritten from a stale read.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/teams/team-1/members/bulk_delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"members": [{"user_id": "user-1"}, {"user_email": "user-2@example.com"}]}'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="members"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberDeleteResponse> BulkDeleteTeamMembersActionManagementV1TeamsTeamIdMembersBulkDeletePostAsync(
            string teamId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TeamMemberRef> members,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
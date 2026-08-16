#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Team Member Me<br/>
        /// Get the caller's own team-membership row for the given team.<br/>
        /// Used by internal users to view their own spend, budget, budget reset<br/>
        /// date, rate limits, and role within a team — without exposing other<br/>
        /// members' data. The caller is resolved from their API key; the path<br/>
        /// `/members/me` always refers to that caller.<br/>
        /// Returns 404 if the caller is not a member of the team.<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/team/your_team_id/members/me'     --header 'Authorization: Bearer your_api_key_here'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamMemberInfoResponse> TeamMemberMeTeamTeamIdMembersMeGetAsync(
            string teamId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Member Me<br/>
        /// Get the caller's own team-membership row for the given team.<br/>
        /// Used by internal users to view their own spend, budget, budget reset<br/>
        /// date, rate limits, and role within a team — without exposing other<br/>
        /// members' data. The caller is resolved from their API key; the path<br/>
        /// `/members/me` always refers to that caller.<br/>
        /// Returns 404 if the caller is not a member of the team.<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/team/your_team_id/members/me'     --header 'Authorization: Bearer your_api_key_here'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamMemberInfoResponse>> TeamMemberMeTeamTeamIdMembersMeGetAsResponseAsync(
            string teamId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
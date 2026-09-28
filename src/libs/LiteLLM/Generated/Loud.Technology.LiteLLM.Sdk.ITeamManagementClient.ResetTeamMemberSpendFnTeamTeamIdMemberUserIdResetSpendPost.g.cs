#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Reset Team Member Spend Fn<br/>
        /// Reset a team member's tracked spend against their per-member budget.<br/>
        /// A member's spend is tracked separately from both their own personal<br/>
        /// budget and the team's own budget (LiteLLM_TeamMembership.spend), so<br/>
        /// neither /user/update nor /team/update can clear it: this is the only<br/>
        /// endpoint that does. The cross-pod spend counter and cached membership<br/>
        /// reads are invalidated so the reset takes effect on the member's next<br/>
        /// request rather than waiting on the membership cache's TTL.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResetTeamMemberSpendFnTeamTeamIdMemberUserIdResetSpendPostAsync(
            string teamId,
            string userId,

            global::Loud.Technology.LiteLLM.Sdk.ResetSpendRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset Team Member Spend Fn<br/>
        /// Reset a team member's tracked spend against their per-member budget.<br/>
        /// A member's spend is tracked separately from both their own personal<br/>
        /// budget and the team's own budget (LiteLLM_TeamMembership.spend), so<br/>
        /// neither /user/update nor /team/update can clear it: this is the only<br/>
        /// endpoint that does. The cross-pod spend counter and cached membership<br/>
        /// reads are invalidated so the reset takes effect on the member's next<br/>
        /// request rather than waiting on the membership cache's TTL.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ResetTeamMemberSpendFnTeamTeamIdMemberUserIdResetSpendPostAsResponseAsync(
            string teamId,
            string userId,

            global::Loud.Technology.LiteLLM.Sdk.ResetSpendRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset Team Member Spend Fn<br/>
        /// Reset a team member's tracked spend against their per-member budget.<br/>
        /// A member's spend is tracked separately from both their own personal<br/>
        /// budget and the team's own budget (LiteLLM_TeamMembership.spend), so<br/>
        /// neither /user/update nor /team/update can clear it: this is the only<br/>
        /// endpoint that does. The cross-pod spend counter and cached membership<br/>
        /// reads are invalidated so the reset takes effect on the member's next<br/>
        /// request rather than waiting on the membership cache's TTL.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="resetTo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ResetTeamMemberSpendFnTeamTeamIdMemberUserIdResetSpendPostAsync(
            string teamId,
            string userId,
            double resetTo,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
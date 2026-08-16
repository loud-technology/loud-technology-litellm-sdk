#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Team Member Add<br/>
        /// Add new members (either via user_email or user_id) to a team<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or admin of team, allowed to access this endpoint.<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/team/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{"team_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849", "member": {"role": "user", "user_id": "krrish247652@berri.ai"}}'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamAddMemberResponse> TeamMemberAddTeamMemberAddPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TeamMemberAddRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Member Add<br/>
        /// Add new members (either via user_email or user_id) to a team<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or admin of team, allowed to access this endpoint.<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/team/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{"team_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849", "member": {"role": "user", "user_id": "krrish247652@berri.ai"}}'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamAddMemberResponse>> TeamMemberAddTeamMemberAddPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TeamMemberAddRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Member Add<br/>
        /// Add new members (either via user_email or user_id) to a team<br/>
        /// If user doesn't exist, new user row will also be added to User Table<br/>
        /// Only proxy_admin or admin of team, allowed to access this endpoint.<br/>
        /// ```<br/>
        /// curl -X POST 'http://0.0.0.0:4000/team/member_add'     -H 'Authorization: Bearer sk-1234'     -H 'Content-Type: application/json'     -d '{"team_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849", "member": {"role": "user", "user_id": "krrish247652@berri.ai"}}'<br/>
        /// ```
        /// </summary>
        /// <param name="member">
        /// Member object or list of member objects to add. Each member must include either user_id or user_email, and a role
        /// </param>
        /// <param name="teamId">
        /// The ID of the team to add the member to
        /// </param>
        /// <param name="maxBudgetInTeam">
        /// Maximum budget allocated to this user within the team. If not set, user has unlimited budget within team limits
        /// </param>
        /// <param name="budgetDuration">
        /// Duration after which this team member's budget resets (e.g. '1h', '24h', '7d', '30d'). If not set, the budget never resets.
        /// </param>
        /// <param name="allowedModels">
        /// List of models this team member can access. If not set, inherits the team's default_team_member_models or all team models.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamAddMemberResponse> TeamMemberAddTeamMemberAddPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>, global::Loud.Technology.LiteLLM.Sdk.Member> member,
            string teamId,
            double? maxBudgetInTeam = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
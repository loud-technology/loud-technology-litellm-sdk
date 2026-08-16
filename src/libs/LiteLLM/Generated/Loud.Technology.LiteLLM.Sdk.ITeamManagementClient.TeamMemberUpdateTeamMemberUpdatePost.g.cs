#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Team Member Update<br/>
        /// [BETA]<br/>
        /// Update team member budgets and team member role
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamMemberUpdateResponse> TeamMemberUpdateTeamMemberUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TeamMemberUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Member Update<br/>
        /// [BETA]<br/>
        /// Update team member budgets and team member role
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamMemberUpdateResponse>> TeamMemberUpdateTeamMemberUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TeamMemberUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Member Update<br/>
        /// [BETA]<br/>
        /// Update team member budgets and team member role
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="teamId"></param>
        /// <param name="maxBudgetInTeam"></param>
        /// <param name="role"></param>
        /// <param name="tpmLimit">
        /// Tokens per minute limit for this team member
        /// </param>
        /// <param name="rpmLimit">
        /// Requests per minute limit for this team member
        /// </param>
        /// <param name="budgetDuration">
        /// Duration after which this team member's budget resets (e.g. '1h', '24h', '7d', '30d'). If not set, the budget never resets.
        /// </param>
        /// <param name="allowedModels">
        /// List of models this team member can access. Pass an empty list to remove per-member model restrictions.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamMemberUpdateResponse> TeamMemberUpdateTeamMemberUpdatePostAsync(
            string teamId,
            string? userId = default,
            string? userEmail = default,
            double? maxBudgetInTeam = default,
            global::Loud.Technology.LiteLLM.Sdk.TeamMemberUpdateRequestRole2? role = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
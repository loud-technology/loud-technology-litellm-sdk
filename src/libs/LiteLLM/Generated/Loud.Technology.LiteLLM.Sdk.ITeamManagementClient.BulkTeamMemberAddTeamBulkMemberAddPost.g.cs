#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Bulk Team Member Add<br/>
        /// Bulk add multiple members to a team at once.<br/>
        /// This endpoint reuses the same logic as /team/member_add but provides a bulk-friendly response format.<br/>
        /// Parameters:<br/>
        /// - team_id: str - The ID of the team to add members to<br/>
        /// - members: List[Member] - List of members to add to the team<br/>
        /// - all_users: Optional[bool] - Flag to add all users on Proxy to the team<br/>
        /// - max_budget_in_team: Optional[float] - Maximum budget allocated to each user within the team<br/>
        /// Returns:<br/>
        /// - results: List of individual member addition results<br/>
        /// - total_requested: Total number of members requested for addition<br/>
        /// - successful_additions: Number of successful additions  <br/>
        /// - failed_additions: Number of failed additions<br/>
        /// - updated_team: The updated team object<br/>
        /// Example request:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/team/bulk_member_add'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "members": [<br/>
        ///         {<br/>
        ///             "user_id": "user1",<br/>
        ///             "role": "user"<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "user_email": "user2@example.com",<br/>
        ///             "role": "admin"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "max_budget_in_team": 100.0<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberAddResponse> BulkTeamMemberAddTeamBulkMemberAddPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberAddRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Team Member Add<br/>
        /// Bulk add multiple members to a team at once.<br/>
        /// This endpoint reuses the same logic as /team/member_add but provides a bulk-friendly response format.<br/>
        /// Parameters:<br/>
        /// - team_id: str - The ID of the team to add members to<br/>
        /// - members: List[Member] - List of members to add to the team<br/>
        /// - all_users: Optional[bool] - Flag to add all users on Proxy to the team<br/>
        /// - max_budget_in_team: Optional[float] - Maximum budget allocated to each user within the team<br/>
        /// Returns:<br/>
        /// - results: List of individual member addition results<br/>
        /// - total_requested: Total number of members requested for addition<br/>
        /// - successful_additions: Number of successful additions  <br/>
        /// - failed_additions: Number of failed additions<br/>
        /// - updated_team: The updated team object<br/>
        /// Example request:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/team/bulk_member_add'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "members": [<br/>
        ///         {<br/>
        ///             "user_id": "user1",<br/>
        ///             "role": "user"<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "user_email": "user2@example.com",<br/>
        ///             "role": "admin"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "max_budget_in_team": 100.0<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberAddResponse>> BulkTeamMemberAddTeamBulkMemberAddPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberAddRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Team Member Add<br/>
        /// Bulk add multiple members to a team at once.<br/>
        /// This endpoint reuses the same logic as /team/member_add but provides a bulk-friendly response format.<br/>
        /// Parameters:<br/>
        /// - team_id: str - The ID of the team to add members to<br/>
        /// - members: List[Member] - List of members to add to the team<br/>
        /// - all_users: Optional[bool] - Flag to add all users on Proxy to the team<br/>
        /// - max_budget_in_team: Optional[float] - Maximum budget allocated to each user within the team<br/>
        /// Returns:<br/>
        /// - results: List of individual member addition results<br/>
        /// - total_requested: Total number of members requested for addition<br/>
        /// - successful_additions: Number of successful additions  <br/>
        /// - failed_additions: Number of failed additions<br/>
        /// - updated_team: The updated team object<br/>
        /// Example request:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/team/bulk_member_add'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "members": [<br/>
        ///         {<br/>
        ///             "user_id": "user1",<br/>
        ///             "role": "user"<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "user_email": "user2@example.com",<br/>
        ///             "role": "admin"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "max_budget_in_team": 100.0<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="members"></param>
        /// <param name="allUsers">
        /// Default Value: false
        /// </param>
        /// <param name="maxBudgetInTeam"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkTeamMemberAddResponse> BulkTeamMemberAddTeamBulkMemberAddPostAsync(
            string teamId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>? members = default,
            bool? allUsers = default,
            double? maxBudgetInTeam = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
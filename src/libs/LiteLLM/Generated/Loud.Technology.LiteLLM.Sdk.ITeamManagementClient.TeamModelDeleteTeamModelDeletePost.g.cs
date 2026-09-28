#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Team Model Delete<br/>
        /// Remove models from a team's allowed model list. Only proxy admin or team admin can remove models.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The team to remove models from<br/>
        /// - models: List[str] - Required. List of models to remove from the team<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/model/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "models": ["gpt-4"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TeamModelDeleteTeamModelDeletePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TeamModelDeleteRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Model Delete<br/>
        /// Remove models from a team's allowed model list. Only proxy admin or team admin can remove models.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The team to remove models from<br/>
        /// - models: List[str] - Required. List of models to remove from the team<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/model/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "models": ["gpt-4"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TeamModelDeleteTeamModelDeletePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TeamModelDeleteRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Model Delete<br/>
        /// Remove models from a team's allowed model list. Only proxy admin or team admin can remove models.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The team to remove models from<br/>
        /// - models: List[str] - Required. List of models to remove from the team<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/model/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "models": ["gpt-4"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="models"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TeamModelDeleteTeamModelDeletePostAsync(
            string teamId,
            global::System.Collections.Generic.IList<string> models,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
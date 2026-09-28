#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Team Model Add<br/>
        /// Add models to a team's allowed model list. Only proxy admin or team admin can add models.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The team to add models to<br/>
        /// - models: List[str] - Required. List of models to add to the team<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/model/add'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "models": ["gpt-4", "claude-2"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TeamModelAddTeamModelAddPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TeamModelAddRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Model Add<br/>
        /// Add models to a team's allowed model list. Only proxy admin or team admin can add models.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The team to add models to<br/>
        /// - models: List[str] - Required. List of models to add to the team<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/model/add'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "models": ["gpt-4", "claude-2"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TeamModelAddTeamModelAddPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TeamModelAddRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Model Add<br/>
        /// Add models to a team's allowed model list. Only proxy admin or team admin can add models.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The team to add models to<br/>
        /// - models: List[str] - Required. List of models to add to the team<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/model/add'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "models": ["gpt-4", "claude-2"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="models"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TeamModelAddTeamModelAddPostAsync(
            string teamId,
            global::System.Collections.Generic.IList<string> models,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
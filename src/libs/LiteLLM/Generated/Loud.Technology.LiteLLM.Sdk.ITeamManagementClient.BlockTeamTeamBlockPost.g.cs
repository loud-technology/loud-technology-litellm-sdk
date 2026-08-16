#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Block Team<br/>
        /// Blocks all calls from keys with this team id.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The unique identifier of the team to block.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/block'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - The updated team record with blocked=True
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BlockTeamTeamBlockPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BlockTeamRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Block Team<br/>
        /// Blocks all calls from keys with this team id.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The unique identifier of the team to block.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/block'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - The updated team record with blocked=True
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> BlockTeamTeamBlockPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BlockTeamRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Block Team<br/>
        /// Blocks all calls from keys with this team id.<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The unique identifier of the team to block.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/block'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "team_id": "team-1234"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - The updated team record with blocked=True
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> BlockTeamTeamBlockPostAsync(
            string teamId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
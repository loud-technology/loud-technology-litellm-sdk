#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Team Info<br/>
        /// get info on team + related keys<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The unique identifier of the team to get info on.<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/team/info?team_id=your_team_id_here'     --header 'Authorization: Bearer your_api_key_here'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId">
        /// Team ID in the request parameters
        /// </param>
        /// <param name="keyLimit">
        /// Limit the number of keys returned
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TeamInfoTeamInfoGetAsync(
            string? teamId = default,
            int? keyLimit = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Team Info<br/>
        /// get info on team + related keys<br/>
        /// Parameters:<br/>
        /// - team_id: str - Required. The unique identifier of the team to get info on.<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/team/info?team_id=your_team_id_here'     --header 'Authorization: Bearer your_api_key_here'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId">
        /// Team ID in the request parameters
        /// </param>
        /// <param name="keyLimit">
        /// Limit the number of keys returned
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TeamInfoTeamInfoGetAsResponseAsync(
            string? teamId = default,
            int? keyLimit = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Delete Team<br/>
        /// delete team and associated team keys<br/>
        /// Parameters:<br/>
        /// - team_ids: List[str] - Required. List of team IDs to delete. Example: ["team-1234", "team-5678"]<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "team_ids": ["8d916b1c-510d-4894-a334-1c16a93344f5"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTeamTeamDeletePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.DeleteTeamRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Team<br/>
        /// delete team and associated team keys<br/>
        /// Parameters:<br/>
        /// - team_ids: List[str] - Required. List of team IDs to delete. Example: ["team-1234", "team-5678"]<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "team_ids": ["8d916b1c-510d-4894-a334-1c16a93344f5"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteTeamTeamDeletePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.DeleteTeamRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Team<br/>
        /// delete team and associated team keys<br/>
        /// Parameters:<br/>
        /// - team_ids: List[str] - Required. List of team IDs to delete. Example: ["team-1234", "team-5678"]<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/delete'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "team_ids": ["8d916b1c-510d-4894-a334-1c16a93344f5"]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="teamIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTeamTeamDeletePostAsync(
            global::System.Collections.Generic.IList<string> teamIds,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
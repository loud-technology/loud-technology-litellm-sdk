#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Delete Team Callback<br/>
        /// Remove a single callback from a team<br/>
        /// The team's other callbacks stay registered and keep firing. Use this instead of<br/>
        /// POST /team/{team_id}/disable_logging, which clears every callback on the team at once.<br/>
        /// Every entry registered under this callback_name is removed, across callback types, so a<br/>
        /// callback registered for both "success" and "failure" is deregistered by one call.<br/>
        /// Parameters:<br/>
        /// - team_id (str, required): The unique identifier for the team<br/>
        /// - callback_name (str, required): The name of the callback to remove, matched exactly as it was<br/>
        ///   registered with POST /team/{team_id}/callback (e.g. "langfuse", "langsmith", "gcs")<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X DELETE 'http://localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback/langsmith'         -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Covers callbacks registered through POST /team/{team_id}/callback and the Admin UI. Teams still<br/>
        /// on the deprecated callback_settings metadata shape hold no such entries, so this returns 404 for<br/>
        /// them; POST /team/{team_id}/disable_logging remains the way to clear those.<br/>
        /// Returns 404 if the team does not exist, or if callback_name is not registered for the team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="callbackName"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamCallbackDeleteResponse> DeleteTeamCallbackTeamTeamIdCallbackCallbackNameDeleteAsync(
            string teamId,
            string callbackName,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Team Callback<br/>
        /// Remove a single callback from a team<br/>
        /// The team's other callbacks stay registered and keep firing. Use this instead of<br/>
        /// POST /team/{team_id}/disable_logging, which clears every callback on the team at once.<br/>
        /// Every entry registered under this callback_name is removed, across callback types, so a<br/>
        /// callback registered for both "success" and "failure" is deregistered by one call.<br/>
        /// Parameters:<br/>
        /// - team_id (str, required): The unique identifier for the team<br/>
        /// - callback_name (str, required): The name of the callback to remove, matched exactly as it was<br/>
        ///   registered with POST /team/{team_id}/callback (e.g. "langfuse", "langsmith", "gcs")<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X DELETE 'http://localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback/langsmith'         -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Covers callbacks registered through POST /team/{team_id}/callback and the Admin UI. Teams still<br/>
        /// on the deprecated callback_settings metadata shape hold no such entries, so this returns 404 for<br/>
        /// them; POST /team/{team_id}/disable_logging remains the way to clear those.<br/>
        /// Returns 404 if the team does not exist, or if callback_name is not registered for the team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="callbackName"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamCallbackDeleteResponse>> DeleteTeamCallbackTeamTeamIdCallbackCallbackNameDeleteAsResponseAsync(
            string teamId,
            string callbackName,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
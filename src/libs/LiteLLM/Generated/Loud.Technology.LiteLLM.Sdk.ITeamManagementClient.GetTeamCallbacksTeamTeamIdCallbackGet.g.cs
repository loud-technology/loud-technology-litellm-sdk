#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Get Team Callbacks<br/>
        /// Get the success/failure callbacks and variables for a team<br/>
        /// Parameters:<br/>
        /// - team_id (str, required): The unique identifier for the team<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback'         -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// This will return the callback settings for the team with id dbe2f686-a686-4896-864a-4c3924458709<br/>
        /// Covers callbacks registered through POST /team/{team_id}/callback and the Admin UI as well as<br/>
        /// teams still on the deprecated callback_settings shape, resolved from the team's stored metadata<br/>
        /// with the same precedence used at request time. A key-level logging config overrides the team's<br/>
        /// at request time and is not reflected here. Credential-bearing callback_vars are returned masked<br/>
        /// as `***REDACTED***`<br/>
        /// Returns {<br/>
        ///         "status": "success",<br/>
        ///         "data": {<br/>
        ///             "team_id": team_id,<br/>
        ///             "success_callbacks": team_callback_settings_obj.success_callback,<br/>
        ///             "failure_callbacks": team_callback_settings_obj.failure_callback,<br/>
        ///             "callback_vars": team_callback_settings_obj.callback_vars,<br/>
        ///         },<br/>
        ///     }
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetTeamCallbacksTeamTeamIdCallbackGetAsync(
            string teamId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Team Callbacks<br/>
        /// Get the success/failure callbacks and variables for a team<br/>
        /// Parameters:<br/>
        /// - team_id (str, required): The unique identifier for the team<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback'         -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// This will return the callback settings for the team with id dbe2f686-a686-4896-864a-4c3924458709<br/>
        /// Covers callbacks registered through POST /team/{team_id}/callback and the Admin UI as well as<br/>
        /// teams still on the deprecated callback_settings shape, resolved from the team's stored metadata<br/>
        /// with the same precedence used at request time. A key-level logging config overrides the team's<br/>
        /// at request time and is not reflected here. Credential-bearing callback_vars are returned masked<br/>
        /// as `***REDACTED***`<br/>
        /// Returns {<br/>
        ///         "status": "success",<br/>
        ///         "data": {<br/>
        ///             "team_id": team_id,<br/>
        ///             "success_callbacks": team_callback_settings_obj.success_callback,<br/>
        ///             "failure_callbacks": team_callback_settings_obj.failure_callback,<br/>
        ///             "callback_vars": team_callback_settings_obj.callback_vars,<br/>
        ///         },<br/>
        ///     }
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetTeamCallbacksTeamTeamIdCallbackGetAsResponseAsync(
            string teamId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
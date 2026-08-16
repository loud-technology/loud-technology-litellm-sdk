#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Add Team Callbacks<br/>
        /// Add a success/failure callback to a team<br/>
        /// Use this if if you want different teams to have different success/failure callbacks<br/>
        /// Parameters:<br/>
        /// - callback_name (Literal["langfuse", "langsmith", "gcs"], required): The name of the callback to add<br/>
        /// - callback_type (Literal["success", "failure", "success_and_failure"], required): The type of callback to add. One of:<br/>
        ///     - "success": Callback for successful LLM calls<br/>
        ///     - "failure": Callback for failed LLM calls<br/>
        ///     - "success_and_failure": Callback for both successful and failed LLM calls<br/>
        /// - callback_vars (StandardCallbackDynamicParams, required): A dictionary of variables to pass to the callback<br/>
        ///     - langfuse_public_key: The public key for the Langfuse callback<br/>
        ///     - langfuse_secret_key: The secret key for the Langfuse callback<br/>
        ///     - langfuse_secret: The secret for the Langfuse callback<br/>
        ///     - langfuse_host: The host for the Langfuse callback<br/>
        ///     - gcs_bucket_name: The name of the GCS bucket<br/>
        ///     - gcs_path_service_account: The path to the GCS service account<br/>
        ///     - langsmith_api_key: The API key for the Langsmith callback<br/>
        ///     - langsmith_project: The project for the Langsmith callback<br/>
        ///     - langsmith_base_url: The base URL for the Langsmith callback<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST 'http:/localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///     "callback_name": "langfuse",<br/>
        ///     "callback_type": "success",<br/>
        ///     "callback_vars": {"langfuse_public_key": "pk-lf-xxxx1", "langfuse_secret_key": "sk-xxxxx"}<br/>
        ///     <br/>
        /// }'<br/>
        /// ```<br/>
        /// This means for the team where team_id = dbe2f686-a686-4896-864a-4c3924458709, all LLM calls will be logged to langfuse using the public key pk-lf-xxxx1 and the secret key sk-xxxxx
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddTeamCallbacksTeamTeamIdCallbackPostAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallback request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Team Callbacks<br/>
        /// Add a success/failure callback to a team<br/>
        /// Use this if if you want different teams to have different success/failure callbacks<br/>
        /// Parameters:<br/>
        /// - callback_name (Literal["langfuse", "langsmith", "gcs"], required): The name of the callback to add<br/>
        /// - callback_type (Literal["success", "failure", "success_and_failure"], required): The type of callback to add. One of:<br/>
        ///     - "success": Callback for successful LLM calls<br/>
        ///     - "failure": Callback for failed LLM calls<br/>
        ///     - "success_and_failure": Callback for both successful and failed LLM calls<br/>
        /// - callback_vars (StandardCallbackDynamicParams, required): A dictionary of variables to pass to the callback<br/>
        ///     - langfuse_public_key: The public key for the Langfuse callback<br/>
        ///     - langfuse_secret_key: The secret key for the Langfuse callback<br/>
        ///     - langfuse_secret: The secret for the Langfuse callback<br/>
        ///     - langfuse_host: The host for the Langfuse callback<br/>
        ///     - gcs_bucket_name: The name of the GCS bucket<br/>
        ///     - gcs_path_service_account: The path to the GCS service account<br/>
        ///     - langsmith_api_key: The API key for the Langsmith callback<br/>
        ///     - langsmith_project: The project for the Langsmith callback<br/>
        ///     - langsmith_base_url: The base URL for the Langsmith callback<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST 'http:/localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///     "callback_name": "langfuse",<br/>
        ///     "callback_type": "success",<br/>
        ///     "callback_vars": {"langfuse_public_key": "pk-lf-xxxx1", "langfuse_secret_key": "sk-xxxxx"}<br/>
        ///     <br/>
        /// }'<br/>
        /// ```<br/>
        /// This means for the team where team_id = dbe2f686-a686-4896-864a-4c3924458709, all LLM calls will be logged to langfuse using the public key pk-lf-xxxx1 and the secret key sk-xxxxx
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AddTeamCallbacksTeamTeamIdCallbackPostAsResponseAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallback request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Team Callbacks<br/>
        /// Add a success/failure callback to a team<br/>
        /// Use this if if you want different teams to have different success/failure callbacks<br/>
        /// Parameters:<br/>
        /// - callback_name (Literal["langfuse", "langsmith", "gcs"], required): The name of the callback to add<br/>
        /// - callback_type (Literal["success", "failure", "success_and_failure"], required): The type of callback to add. One of:<br/>
        ///     - "success": Callback for successful LLM calls<br/>
        ///     - "failure": Callback for failed LLM calls<br/>
        ///     - "success_and_failure": Callback for both successful and failed LLM calls<br/>
        /// - callback_vars (StandardCallbackDynamicParams, required): A dictionary of variables to pass to the callback<br/>
        ///     - langfuse_public_key: The public key for the Langfuse callback<br/>
        ///     - langfuse_secret_key: The secret key for the Langfuse callback<br/>
        ///     - langfuse_secret: The secret for the Langfuse callback<br/>
        ///     - langfuse_host: The host for the Langfuse callback<br/>
        ///     - gcs_bucket_name: The name of the GCS bucket<br/>
        ///     - gcs_path_service_account: The path to the GCS service account<br/>
        ///     - langsmith_api_key: The API key for the Langsmith callback<br/>
        ///     - langsmith_project: The project for the Langsmith callback<br/>
        ///     - langsmith_base_url: The base URL for the Langsmith callback<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST 'http:/localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///     "callback_name": "langfuse",<br/>
        ///     "callback_type": "success",<br/>
        ///     "callback_vars": {"langfuse_public_key": "pk-lf-xxxx1", "langfuse_secret_key": "sk-xxxxx"}<br/>
        ///     <br/>
        /// }'<br/>
        /// ```<br/>
        /// This means for the team where team_id = dbe2f686-a686-4896-864a-4c3924458709, all LLM calls will be logged to langfuse using the public key pk-lf-xxxx1 and the secret key sk-xxxxx
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="callbackName"></param>
        /// <param name="callbackType">
        /// Default Value: success_and_failure
        /// </param>
        /// <param name="callbackVars"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddTeamCallbacksTeamTeamIdCallbackPostAsync(
            string teamId,
            string callbackName,
            global::System.Collections.Generic.Dictionary<string, string> callbackVars,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallbackCallbackType2? callbackType = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
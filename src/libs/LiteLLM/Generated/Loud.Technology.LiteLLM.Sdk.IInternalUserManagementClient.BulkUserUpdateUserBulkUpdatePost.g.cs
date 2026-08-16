#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IInternalUserManagementClient
    {
        /// <summary>
        /// Bulk User Update<br/>
        /// Bulk update multiple users at once.<br/>
        /// This endpoint allows updating multiple users in a single request. Each user update<br/>
        /// is processed independently - if some updates fail, others will still succeed.<br/>
        /// Parameters:<br/>
        /// - users: Optional[List[UpdateUserRequest]] - List of specific user update requests<br/>
        /// - all_users: Optional[bool] - Set to true to update all users in the system<br/>
        /// - user_updates: Optional[UpdateUserRequest] - Updates to apply when all_users=True<br/>
        /// Returns:<br/>
        /// - results: List of individual update results<br/>
        /// - total_requested: Total number of users requested for update<br/>
        /// - successful_updates: Number of successful updates<br/>
        /// - failed_updates: Number of failed updates<br/>
        /// Example request for specific users:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/user/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "users": [<br/>
        ///         {<br/>
        ///             "user_id": "user1",<br/>
        ///             "user_role": "internal_user",<br/>
        ///             "max_budget": 100.0<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "user_email": "user2@example.com", <br/>
        ///             "user_role": "internal_user_viewer",<br/>
        ///             "max_budget": 50.0<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Example request for all users:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/user/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "all_users": true,<br/>
        ///     "user_updates": {<br/>
        ///         "user_role": "internal_user",<br/>
        ///         "max_budget": 50.0<br/>
        ///     }<br/>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateUserResponse> BulkUserUpdateUserBulkUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkUpdateUserRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk User Update<br/>
        /// Bulk update multiple users at once.<br/>
        /// This endpoint allows updating multiple users in a single request. Each user update<br/>
        /// is processed independently - if some updates fail, others will still succeed.<br/>
        /// Parameters:<br/>
        /// - users: Optional[List[UpdateUserRequest]] - List of specific user update requests<br/>
        /// - all_users: Optional[bool] - Set to true to update all users in the system<br/>
        /// - user_updates: Optional[UpdateUserRequest] - Updates to apply when all_users=True<br/>
        /// Returns:<br/>
        /// - results: List of individual update results<br/>
        /// - total_requested: Total number of users requested for update<br/>
        /// - successful_updates: Number of successful updates<br/>
        /// - failed_updates: Number of failed updates<br/>
        /// Example request for specific users:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/user/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "users": [<br/>
        ///         {<br/>
        ///             "user_id": "user1",<br/>
        ///             "user_role": "internal_user",<br/>
        ///             "max_budget": 100.0<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "user_email": "user2@example.com", <br/>
        ///             "user_role": "internal_user_viewer",<br/>
        ///             "max_budget": 50.0<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Example request for all users:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/user/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "all_users": true,<br/>
        ///     "user_updates": {<br/>
        ///         "user_role": "internal_user",<br/>
        ///         "max_budget": 50.0<br/>
        ///     }<br/>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateUserResponse>> BulkUserUpdateUserBulkUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkUpdateUserRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk User Update<br/>
        /// Bulk update multiple users at once.<br/>
        /// This endpoint allows updating multiple users in a single request. Each user update<br/>
        /// is processed independently - if some updates fail, others will still succeed.<br/>
        /// Parameters:<br/>
        /// - users: Optional[List[UpdateUserRequest]] - List of specific user update requests<br/>
        /// - all_users: Optional[bool] - Set to true to update all users in the system<br/>
        /// - user_updates: Optional[UpdateUserRequest] - Updates to apply when all_users=True<br/>
        /// Returns:<br/>
        /// - results: List of individual update results<br/>
        /// - total_requested: Total number of users requested for update<br/>
        /// - successful_updates: Number of successful updates<br/>
        /// - failed_updates: Number of failed updates<br/>
        /// Example request for specific users:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/user/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "users": [<br/>
        ///         {<br/>
        ///             "user_id": "user1",<br/>
        ///             "user_role": "internal_user",<br/>
        ///             "max_budget": 100.0<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "user_email": "user2@example.com", <br/>
        ///             "user_role": "internal_user_viewer",<br/>
        ///             "max_budget": 50.0<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Example request for all users:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/user/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "all_users": true,<br/>
        ///     "user_updates": {<br/>
        ///         "user_role": "internal_user",<br/>
        ///         "max_budget": 50.0<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="users"></param>
        /// <param name="allUsers">
        /// Default Value: false
        /// </param>
        /// <param name="userUpdates"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateUserResponse> BulkUserUpdateUserBulkUpdatePostAsync(
            string? litellmChangedBy = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest>? users = default,
            bool? allUsers = default,
            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequestNoUserIDorEmail? userUpdates = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
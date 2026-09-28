#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IInternalUserManagementClient
    {
        /// <summary>
        /// Bulk Create Users Route<br/>
        /// Create up to 500 internal users in one request, optionally adding each one to teams.<br/>
        /// Every entry in `users` takes the same fields as `/user/new`, with two differences: `auto_create_key`<br/>
        /// defaults to `false` (opt in per user to also get a virtual key back) and `send_invite_email` is not<br/>
        /// supported. Unknown fields are rejected with 422. Rows are validated together (duplicate ids or emails,<br/>
        /// unknown teams, roles the caller may not grant), inserted in one statement, and each referenced team is<br/>
        /// written once for all of its new members.<br/>
        /// Rows fail independently: a bad row is reported in `data` with `success: false` and an `error`, and the<br/>
        /// other rows still get created. A user that was created but could not be added to one of its teams is<br/>
        /// reported with `success: true`, `teams` listing where they did land, and `error` naming the failed team.<br/>
        /// The whole request is refused with a 403 problem document only if creating the valid rows would exceed<br/>
        /// the license seat limit.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST "http://localhost:4000/management/v1/users/bulk" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -H "Authorization: Bearer sk-1234" \<br/>
        /// -d '{<br/>
        ///     "users": [<br/>
        ///         {"user_email": "a@example.com", "user_role": "internal_user", "teams": ["team-1"]},<br/>
        ///         {"user_email": "b@example.com", "user_role": "internal_user", "auto_create_key": true}<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns `data` (one entry per input row, in order, with `user_id`, `user_email`, `success`, `teams`,<br/>
        /// `key`, `error`) and `meta` with `total_requested`, `created` and `failed`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse> BulkCreateUsersRouteManagementV1UsersBulkPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkNewUserRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Create Users Route<br/>
        /// Create up to 500 internal users in one request, optionally adding each one to teams.<br/>
        /// Every entry in `users` takes the same fields as `/user/new`, with two differences: `auto_create_key`<br/>
        /// defaults to `false` (opt in per user to also get a virtual key back) and `send_invite_email` is not<br/>
        /// supported. Unknown fields are rejected with 422. Rows are validated together (duplicate ids or emails,<br/>
        /// unknown teams, roles the caller may not grant), inserted in one statement, and each referenced team is<br/>
        /// written once for all of its new members.<br/>
        /// Rows fail independently: a bad row is reported in `data` with `success: false` and an `error`, and the<br/>
        /// other rows still get created. A user that was created but could not be added to one of its teams is<br/>
        /// reported with `success: true`, `teams` listing where they did land, and `error` naming the failed team.<br/>
        /// The whole request is refused with a 403 problem document only if creating the valid rows would exceed<br/>
        /// the license seat limit.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST "http://localhost:4000/management/v1/users/bulk" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -H "Authorization: Bearer sk-1234" \<br/>
        /// -d '{<br/>
        ///     "users": [<br/>
        ///         {"user_email": "a@example.com", "user_role": "internal_user", "teams": ["team-1"]},<br/>
        ///         {"user_email": "b@example.com", "user_role": "internal_user", "auto_create_key": true}<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns `data` (one entry per input row, in order, with `user_id`, `user_email`, `success`, `teams`,<br/>
        /// `key`, `error`) and `meta` with `total_requested`, `created` and `failed`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse>> BulkCreateUsersRouteManagementV1UsersBulkPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkNewUserRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Create Users Route<br/>
        /// Create up to 500 internal users in one request, optionally adding each one to teams.<br/>
        /// Every entry in `users` takes the same fields as `/user/new`, with two differences: `auto_create_key`<br/>
        /// defaults to `false` (opt in per user to also get a virtual key back) and `send_invite_email` is not<br/>
        /// supported. Unknown fields are rejected with 422. Rows are validated together (duplicate ids or emails,<br/>
        /// unknown teams, roles the caller may not grant), inserted in one statement, and each referenced team is<br/>
        /// written once for all of its new members.<br/>
        /// Rows fail independently: a bad row is reported in `data` with `success: false` and an `error`, and the<br/>
        /// other rows still get created. A user that was created but could not be added to one of its teams is<br/>
        /// reported with `success: true`, `teams` listing where they did land, and `error` naming the failed team.<br/>
        /// The whole request is refused with a 403 problem document only if creating the valid rows would exceed<br/>
        /// the license seat limit.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST "http://localhost:4000/management/v1/users/bulk" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -H "Authorization: Bearer sk-1234" \<br/>
        /// -d '{<br/>
        ///     "users": [<br/>
        ///         {"user_email": "a@example.com", "user_role": "internal_user", "teams": ["team-1"]},<br/>
        ///         {"user_email": "b@example.com", "user_role": "internal_user", "auto_create_key": true}<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns `data` (one entry per input row, in order, with `user_id`, `user_email`, `success`, `teams`,<br/>
        /// `key`, `error`) and `meta` with `total_requested`, `created` and `failed`.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse> BulkCreateUsersRouteManagementV1UsersBulkPostAsync(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserItem> users,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
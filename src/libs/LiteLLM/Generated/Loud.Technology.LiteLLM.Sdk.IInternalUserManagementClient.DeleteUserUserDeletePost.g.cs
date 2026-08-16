#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IInternalUserManagementClient
    {
        /// <summary>
        /// Delete User<br/>
        /// delete user and associated user keys<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/user/delete' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data-raw '{<br/>
        ///     "user_ids": ["45e3e396-ee08-4a61-a88e-16b3ce7e0849"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - user_ids: List[str] - The list of user id's to be deleted.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteUserUserDeletePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.DeleteUserRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete User<br/>
        /// delete user and associated user keys<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/user/delete' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data-raw '{<br/>
        ///     "user_ids": ["45e3e396-ee08-4a61-a88e-16b3ce7e0849"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - user_ids: List[str] - The list of user id's to be deleted.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteUserUserDeletePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.DeleteUserRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete User<br/>
        /// delete user and associated user keys<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/user/delete' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data-raw '{<br/>
        ///     "user_ids": ["45e3e396-ee08-4a61-a88e-16b3ce7e0849"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - user_ids: List[str] - The list of user id's to be deleted.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="userIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteUserUserDeletePostAsync(
            global::System.Collections.Generic.IList<string> userIds,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
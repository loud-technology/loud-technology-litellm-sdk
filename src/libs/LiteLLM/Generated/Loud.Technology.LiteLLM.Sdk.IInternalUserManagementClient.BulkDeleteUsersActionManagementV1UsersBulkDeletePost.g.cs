#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IInternalUserManagementClient
    {
        /// <summary>
        /// Bulk Delete Users Action<br/>
        /// Delete up to 500 users in one call, taking each out of every team it belongs to.<br/>
        /// Same authorization as `/user/delete`: proxy admins may delete anyone, org admins<br/>
        /// only users inside organizations they administer. Unknown body fields are a 422.<br/>
        /// `data` holds one result per requested `user_id`, in request order. A row is<br/>
        /// `success: false` with an `error` when the id is unknown, repeated in the request,<br/>
        /// or outside the caller's scope. Rows that pass those checks are deleted together,<br/>
        /// in one transaction, so either all of them go or none does.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/users/bulk_delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"user_ids": ["user-1", "user-2"]}'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// Who the caller is acting for; recorded on the audit log entries this call writes.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkDeleteUsersResponse> BulkDeleteUsersActionManagementV1UsersBulkDeletePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkDeleteUserRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Delete Users Action<br/>
        /// Delete up to 500 users in one call, taking each out of every team it belongs to.<br/>
        /// Same authorization as `/user/delete`: proxy admins may delete anyone, org admins<br/>
        /// only users inside organizations they administer. Unknown body fields are a 422.<br/>
        /// `data` holds one result per requested `user_id`, in request order. A row is<br/>
        /// `success: false` with an `error` when the id is unknown, repeated in the request,<br/>
        /// or outside the caller's scope. Rows that pass those checks are deleted together,<br/>
        /// in one transaction, so either all of them go or none does.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/users/bulk_delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"user_ids": ["user-1", "user-2"]}'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// Who the caller is acting for; recorded on the audit log entries this call writes.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkDeleteUsersResponse>> BulkDeleteUsersActionManagementV1UsersBulkDeletePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkDeleteUserRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Delete Users Action<br/>
        /// Delete up to 500 users in one call, taking each out of every team it belongs to.<br/>
        /// Same authorization as `/user/delete`: proxy admins may delete anyone, org admins<br/>
        /// only users inside organizations they administer. Unknown body fields are a 422.<br/>
        /// `data` holds one result per requested `user_id`, in request order. A row is<br/>
        /// `success: false` with an `error` when the id is unknown, repeated in the request,<br/>
        /// or outside the caller's scope. Rows that pass those checks are deleted together,<br/>
        /// in one transaction, so either all of them go or none does.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/management/v1/users/bulk_delete'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{"user_ids": ["user-1", "user-2"]}'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// Who the caller is acting for; recorded on the audit log entries this call writes.
        /// </param>
        /// <param name="userIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkDeleteUsersResponse> BulkDeleteUsersActionManagementV1UsersBulkDeletePostAsync(
            global::System.Collections.Generic.IList<string> userIds,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
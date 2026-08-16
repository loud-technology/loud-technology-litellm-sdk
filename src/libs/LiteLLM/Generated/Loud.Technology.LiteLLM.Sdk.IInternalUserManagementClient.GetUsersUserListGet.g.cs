#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IInternalUserManagementClient
    {
        /// <summary>
        /// Get Users<br/>
        /// Get a paginated list of users with filtering and sorting options.<br/>
        /// Parameters:<br/>
        ///     role: Optional[str]<br/>
        ///         Filter users by role. Can be one of:<br/>
        ///         - proxy_admin<br/>
        ///         - proxy_admin_viewer<br/>
        ///         - internal_user<br/>
        ///         - internal_user_viewer<br/>
        ///     user_ids: Optional[str]<br/>
        ///         Get list of users by user_ids. Comma separated list of user_ids.<br/>
        ///     sso_ids: Optional[str]<br/>
        ///         Get list of users by sso_ids. Comma separated list of sso_ids.<br/>
        ///     user_email: Optional[str]<br/>
        ///         Filter users by partial email match<br/>
        ///     team: Optional[str]<br/>
        ///         Filter users by team id. Will match if user has this team in their teams array.<br/>
        ///     page: int<br/>
        ///         The page number to return<br/>
        ///     page_size: int<br/>
        ///         The number of items per page<br/>
        ///     sort_by: Optional[str]<br/>
        ///         Column to sort by (e.g. 'user_id', 'user_email', 'created_at', 'spend')<br/>
        ///     sort_order: Optional[str]<br/>
        ///         Sort order ('asc' or 'desc')
        /// </summary>
        /// <param name="role">
        /// Filter users by role
        /// </param>
        /// <param name="userIds">
        /// Get list of users by user_ids
        /// </param>
        /// <param name="ssoUserIds">
        /// Get list of users by sso_user_id
        /// </param>
        /// <param name="userEmail">
        /// Filter users by partial email match
        /// </param>
        /// <param name="team">
        /// Filter users by team id
        /// </param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'user_id', 'user_email', 'created_at', 'spend')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="organizationIds">
        /// Filter users by organization membership. Comma-separated list of org IDs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.UserListResponse> GetUsersUserListGetAsync(
            string? role = default,
            string? userIds = default,
            string? ssoUserIds = default,
            string? userEmail = default,
            string? team = default,
            int? page = default,
            int? pageSize = default,
            string? sortBy = default,
            string? sortOrder = default,
            string? organizationIds = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Users<br/>
        /// Get a paginated list of users with filtering and sorting options.<br/>
        /// Parameters:<br/>
        ///     role: Optional[str]<br/>
        ///         Filter users by role. Can be one of:<br/>
        ///         - proxy_admin<br/>
        ///         - proxy_admin_viewer<br/>
        ///         - internal_user<br/>
        ///         - internal_user_viewer<br/>
        ///     user_ids: Optional[str]<br/>
        ///         Get list of users by user_ids. Comma separated list of user_ids.<br/>
        ///     sso_ids: Optional[str]<br/>
        ///         Get list of users by sso_ids. Comma separated list of sso_ids.<br/>
        ///     user_email: Optional[str]<br/>
        ///         Filter users by partial email match<br/>
        ///     team: Optional[str]<br/>
        ///         Filter users by team id. Will match if user has this team in their teams array.<br/>
        ///     page: int<br/>
        ///         The page number to return<br/>
        ///     page_size: int<br/>
        ///         The number of items per page<br/>
        ///     sort_by: Optional[str]<br/>
        ///         Column to sort by (e.g. 'user_id', 'user_email', 'created_at', 'spend')<br/>
        ///     sort_order: Optional[str]<br/>
        ///         Sort order ('asc' or 'desc')
        /// </summary>
        /// <param name="role">
        /// Filter users by role
        /// </param>
        /// <param name="userIds">
        /// Get list of users by user_ids
        /// </param>
        /// <param name="ssoUserIds">
        /// Get list of users by sso_user_id
        /// </param>
        /// <param name="userEmail">
        /// Filter users by partial email match
        /// </param>
        /// <param name="team">
        /// Filter users by team id
        /// </param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'user_id', 'user_email', 'created_at', 'spend')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="organizationIds">
        /// Filter users by organization membership. Comma-separated list of org IDs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.UserListResponse>> GetUsersUserListGetAsResponseAsync(
            string? role = default,
            string? userIds = default,
            string? ssoUserIds = default,
            string? userEmail = default,
            string? team = default,
            int? page = default,
            int? pageSize = default,
            string? sortBy = default,
            string? sortOrder = default,
            string? organizationIds = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
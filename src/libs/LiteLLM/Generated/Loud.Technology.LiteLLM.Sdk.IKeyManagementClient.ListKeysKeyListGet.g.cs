#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// List Keys<br/>
        /// List all keys for a given user / team / organization.<br/>
        /// Parameters:<br/>
        ///     expand: Optional[List[str]] - Expand related objects (e.g. 'user' to include user information)<br/>
        ///     status: Optional[str] - Filter by status. Currently supports "deleted" to query deleted keys.<br/>
        /// Returns:<br/>
        ///     {<br/>
        ///         "keys": List[str] or List[UserAPIKeyAuth],<br/>
        ///         "total_count": int,<br/>
        ///         "current_page": int,<br/>
        ///         "total_pages": int,<br/>
        ///     }<br/>
        /// When expand includes "user", each key object will include a "user" field with the associated user object.<br/>
        /// Note: When expand=user is specified, full key objects are returned regardless of the return_full_object parameter.
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="userId">
        /// Filter keys by user ID. Exact match by default; set substring_matching=true (admin only) for case-insensitive substring matching.
        /// </param>
        /// <param name="teamId">
        /// Filter keys by team ID
        /// </param>
        /// <param name="organizationId">
        /// Filter keys by organization ID
        /// </param>
        /// <param name="keyHash">
        /// Filter keys by key hash
        /// </param>
        /// <param name="keyAlias">
        /// Filter keys by key alias. Exact match by default; set substring_matching=true (admin only) for case-insensitive substring matching.
        /// </param>
        /// <param name="returnFullObject">
        /// Return full key object<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTeamKeys">
        /// Include all keys for teams that user is an admin of.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeCreatedByKeys">
        /// Include keys created by the user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'user_id', 'created_at', 'spend')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="expand">
        /// Expand related objects (e.g. 'user')
        /// </param>
        /// <param name="status">
        /// Filter by status (e.g. 'deleted')
        /// </param>
        /// <param name="projectId">
        /// Filter keys by project ID
        /// </param>
        /// <param name="accessGroupId">
        /// Filter keys by access group ID
        /// </param>
        /// <param name="agentId">
        /// Filter keys by agent ID
        /// </param>
        /// <param name="substringMatching">
        /// If true (proxy admins only), match user_id/key_alias as case-insensitive substrings instead of exact values. Defaults to false: /key/list matched these exactly before substring search was added, and an exact user_id/key_alias filter must never return another user's keys.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expires">
        /// Filter keys by expiration. 'expired' returns keys whose expires is in the past; 'active' returns keys that never expire or expire in the future. Omit to return keys regardless of expiration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.KeyListResponseObject> ListKeysKeyListGetAsync(
            int? page = default,
            int? size = default,
            string? userId = default,
            string? teamId = default,
            string? organizationId = default,
            string? keyHash = default,
            string? keyAlias = default,
            bool? returnFullObject = default,
            bool? includeTeamKeys = default,
            bool? includeCreatedByKeys = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            string? status = default,
            string? projectId = default,
            string? accessGroupId = default,
            string? agentId = default,
            bool? substringMatching = default,
            string? expires = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Keys<br/>
        /// List all keys for a given user / team / organization.<br/>
        /// Parameters:<br/>
        ///     expand: Optional[List[str]] - Expand related objects (e.g. 'user' to include user information)<br/>
        ///     status: Optional[str] - Filter by status. Currently supports "deleted" to query deleted keys.<br/>
        /// Returns:<br/>
        ///     {<br/>
        ///         "keys": List[str] or List[UserAPIKeyAuth],<br/>
        ///         "total_count": int,<br/>
        ///         "current_page": int,<br/>
        ///         "total_pages": int,<br/>
        ///     }<br/>
        /// When expand includes "user", each key object will include a "user" field with the associated user object.<br/>
        /// Note: When expand=user is specified, full key objects are returned regardless of the return_full_object parameter.
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="userId">
        /// Filter keys by user ID. Exact match by default; set substring_matching=true (admin only) for case-insensitive substring matching.
        /// </param>
        /// <param name="teamId">
        /// Filter keys by team ID
        /// </param>
        /// <param name="organizationId">
        /// Filter keys by organization ID
        /// </param>
        /// <param name="keyHash">
        /// Filter keys by key hash
        /// </param>
        /// <param name="keyAlias">
        /// Filter keys by key alias. Exact match by default; set substring_matching=true (admin only) for case-insensitive substring matching.
        /// </param>
        /// <param name="returnFullObject">
        /// Return full key object<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTeamKeys">
        /// Include all keys for teams that user is an admin of.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeCreatedByKeys">
        /// Include keys created by the user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'user_id', 'created_at', 'spend')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="expand">
        /// Expand related objects (e.g. 'user')
        /// </param>
        /// <param name="status">
        /// Filter by status (e.g. 'deleted')
        /// </param>
        /// <param name="projectId">
        /// Filter keys by project ID
        /// </param>
        /// <param name="accessGroupId">
        /// Filter keys by access group ID
        /// </param>
        /// <param name="agentId">
        /// Filter keys by agent ID
        /// </param>
        /// <param name="substringMatching">
        /// If true (proxy admins only), match user_id/key_alias as case-insensitive substrings instead of exact values. Defaults to false: /key/list matched these exactly before substring search was added, and an exact user_id/key_alias filter must never return another user's keys.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expires">
        /// Filter keys by expiration. 'expired' returns keys whose expires is in the past; 'active' returns keys that never expire or expire in the future. Omit to return keys regardless of expiration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.KeyListResponseObject>> ListKeysKeyListGetAsResponseAsync(
            int? page = default,
            int? size = default,
            string? userId = default,
            string? teamId = default,
            string? organizationId = default,
            string? keyHash = default,
            string? keyAlias = default,
            bool? returnFullObject = default,
            bool? includeTeamKeys = default,
            bool? includeCreatedByKeys = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            string? status = default,
            string? projectId = default,
            string? accessGroupId = default,
            string? agentId = default,
            bool? substringMatching = default,
            string? expires = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
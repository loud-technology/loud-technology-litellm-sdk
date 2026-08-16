#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// List Team V2<br/>
        /// Get a paginated list of teams with filtering and sorting options.<br/>
        /// Parameters:<br/>
        ///     user_id: Optional[str]<br/>
        ///         Only return teams which this user belongs to<br/>
        ///     organization_id: Optional[str]<br/>
        ///         Only return teams which belong to this organization<br/>
        ///     team_id: Optional[str]<br/>
        ///         Filter teams by exact team_id match<br/>
        ///     team_alias: Optional[str]<br/>
        ///         Filter teams by partial team_alias match<br/>
        ///     page: int<br/>
        ///         The page number to return<br/>
        ///     page_size: int<br/>
        ///         The number of items per page<br/>
        ///     sort_by: Optional[str]<br/>
        ///         Column to sort by (e.g. 'team_id', 'team_alias', 'created_at')<br/>
        ///     sort_order: str<br/>
        ///         Sort order ('asc' or 'desc')<br/>
        ///     status: Optional[str]<br/>
        ///         Filter by status. Currently supports "deleted" to query deleted teams.
        /// </summary>
        /// <param name="userId">
        /// Only return teams which this 'user_id' belongs to
        /// </param>
        /// <param name="organizationId">
        /// Only return teams which this 'organization_id' belongs to
        /// </param>
        /// <param name="teamId">
        /// Only return teams which this 'team_id' belongs to
        /// </param>
        /// <param name="teamAlias">
        /// Only return teams which this 'team_alias' belongs to. Supports partial matching.
        /// </param>
        /// <param name="search">
        /// Combined search: matches teams whose 'team_id' matches the value OR whose 'team_alias' contains it (case-insensitive).
        /// </param>
        /// <param name="searchTeamIdMatch">
        /// How 'search' matches 'team_id': 'exact' (default) or 'prefix' for a case-sensitive prefix match.<br/>
        /// Default Value: exact
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of teams per page<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'team_id', 'team_alias', 'created_at')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="status">
        /// Filter by status (e.g. 'deleted')
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamListResponse> ListTeamV2V2TeamListGetAsync(
            string? userId = default,
            string? organizationId = default,
            string? teamId = default,
            string? teamAlias = default,
            string? search = default,
            global::Loud.Technology.LiteLLM.Sdk.ListTeamV2V2TeamListGetSearchTeamIdMatch? searchTeamIdMatch = default,
            int? page = default,
            int? pageSize = default,
            string? sortBy = default,
            string? sortOrder = default,
            string? status = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Team V2<br/>
        /// Get a paginated list of teams with filtering and sorting options.<br/>
        /// Parameters:<br/>
        ///     user_id: Optional[str]<br/>
        ///         Only return teams which this user belongs to<br/>
        ///     organization_id: Optional[str]<br/>
        ///         Only return teams which belong to this organization<br/>
        ///     team_id: Optional[str]<br/>
        ///         Filter teams by exact team_id match<br/>
        ///     team_alias: Optional[str]<br/>
        ///         Filter teams by partial team_alias match<br/>
        ///     page: int<br/>
        ///         The page number to return<br/>
        ///     page_size: int<br/>
        ///         The number of items per page<br/>
        ///     sort_by: Optional[str]<br/>
        ///         Column to sort by (e.g. 'team_id', 'team_alias', 'created_at')<br/>
        ///     sort_order: str<br/>
        ///         Sort order ('asc' or 'desc')<br/>
        ///     status: Optional[str]<br/>
        ///         Filter by status. Currently supports "deleted" to query deleted teams.
        /// </summary>
        /// <param name="userId">
        /// Only return teams which this 'user_id' belongs to
        /// </param>
        /// <param name="organizationId">
        /// Only return teams which this 'organization_id' belongs to
        /// </param>
        /// <param name="teamId">
        /// Only return teams which this 'team_id' belongs to
        /// </param>
        /// <param name="teamAlias">
        /// Only return teams which this 'team_alias' belongs to. Supports partial matching.
        /// </param>
        /// <param name="search">
        /// Combined search: matches teams whose 'team_id' matches the value OR whose 'team_alias' contains it (case-insensitive).
        /// </param>
        /// <param name="searchTeamIdMatch">
        /// How 'search' matches 'team_id': 'exact' (default) or 'prefix' for a case-sensitive prefix match.<br/>
        /// Default Value: exact
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of teams per page<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'team_id', 'team_alias', 'created_at')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="status">
        /// Filter by status (e.g. 'deleted')
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamListResponse>> ListTeamV2V2TeamListGetAsResponseAsync(
            string? userId = default,
            string? organizationId = default,
            string? teamId = default,
            string? teamAlias = default,
            string? search = default,
            global::Loud.Technology.LiteLLM.Sdk.ListTeamV2V2TeamListGetSearchTeamIdMatch? searchTeamIdMatch = default,
            int? page = default,
            int? pageSize = default,
            string? sortBy = default,
            string? sortOrder = default,
            string? status = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
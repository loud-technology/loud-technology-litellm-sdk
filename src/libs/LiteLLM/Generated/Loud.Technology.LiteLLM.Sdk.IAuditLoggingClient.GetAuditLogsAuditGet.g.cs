#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAuditLoggingClient
    {
        /// <summary>
        /// Get Audit Logs<br/>
        /// Get all audit logs with filtering and pagination.<br/>
        /// Returns a paginated response of audit logs matching the specified filters.<br/>
        /// Note: object_team_id and object_key_hash use Prisma JSON path filtering,<br/>
        /// which requires PostgreSQL.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="changedBy">
        /// Filter by user or system that performed the action
        /// </param>
        /// <param name="changedByApiKey">
        /// Filter by API key hash that performed the action
        /// </param>
        /// <param name="action">
        /// Filter by action type (create, update, delete)
        /// </param>
        /// <param name="tableName">
        /// Filter by table name that was modified
        /// </param>
        /// <param name="objectId">
        /// Filter by ID of the object that was modified
        /// </param>
        /// <param name="startDate">
        /// Filter logs after this date
        /// </param>
        /// <param name="endDate">
        /// Filter logs before this date
        /// </param>
        /// <param name="objectTeamId">
        /// Filter by team_id present in before_value or updated_values JSON (PostgreSQL only)
        /// </param>
        /// <param name="objectKeyHash">
        /// Filter by token (key hash) present in before_value or updated_values JSON (PostgreSQL only)
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'updated_at', 'action', 'table_name')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PaginatedAuditLogResponse> GetAuditLogsAuditGetAsync(
            int? page = default,
            int? pageSize = default,
            string? changedBy = default,
            string? changedByApiKey = default,
            string? action = default,
            string? tableName = default,
            string? objectId = default,
            string? startDate = default,
            string? endDate = default,
            string? objectTeamId = default,
            string? objectKeyHash = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Audit Logs<br/>
        /// Get all audit logs with filtering and pagination.<br/>
        /// Returns a paginated response of audit logs matching the specified filters.<br/>
        /// Note: object_team_id and object_key_hash use Prisma JSON path filtering,<br/>
        /// which requires PostgreSQL.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="changedBy">
        /// Filter by user or system that performed the action
        /// </param>
        /// <param name="changedByApiKey">
        /// Filter by API key hash that performed the action
        /// </param>
        /// <param name="action">
        /// Filter by action type (create, update, delete)
        /// </param>
        /// <param name="tableName">
        /// Filter by table name that was modified
        /// </param>
        /// <param name="objectId">
        /// Filter by ID of the object that was modified
        /// </param>
        /// <param name="startDate">
        /// Filter logs after this date
        /// </param>
        /// <param name="endDate">
        /// Filter logs before this date
        /// </param>
        /// <param name="objectTeamId">
        /// Filter by team_id present in before_value or updated_values JSON (PostgreSQL only)
        /// </param>
        /// <param name="objectKeyHash">
        /// Filter by token (key hash) present in before_value or updated_values JSON (PostgreSQL only)
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'updated_at', 'action', 'table_name')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PaginatedAuditLogResponse>> GetAuditLogsAuditGetAsResponseAsync(
            int? page = default,
            int? pageSize = default,
            string? changedBy = default,
            string? changedByApiKey = default,
            string? action = default,
            string? tableName = default,
            string? objectId = default,
            string? startDate = default,
            string? endDate = default,
            string? objectTeamId = default,
            string? objectKeyHash = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
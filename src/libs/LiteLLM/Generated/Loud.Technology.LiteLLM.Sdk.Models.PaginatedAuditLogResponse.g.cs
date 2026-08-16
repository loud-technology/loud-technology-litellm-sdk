
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for paginated audit logs
    /// </summary>
    public sealed partial class PaginatedAuditLogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audit_logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AuditLogResponse> AuditLogs { get; set; }

        /// <summary>
        /// Total number of audit logs matching the filters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Current page number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Number of items per page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageSize { get; set; }

        /// <summary>
        /// Total number of pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedAuditLogResponse" /> class.
        /// </summary>
        /// <param name="auditLogs"></param>
        /// <param name="total">
        /// Total number of audit logs matching the filters
        /// </param>
        /// <param name="page">
        /// Current page number
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="totalPages">
        /// Total number of pages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedAuditLogResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AuditLogResponse> auditLogs,
            int total,
            int page,
            int pageSize,
            int totalPages)
        {
            this.AuditLogs = auditLogs ?? throw new global::System.ArgumentNullException(nameof(auditLogs));
            this.Total = total;
            this.Page = page;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedAuditLogResponse" /> class.
        /// </summary>
        public PaginatedAuditLogResponse()
        {
        }

    }
}
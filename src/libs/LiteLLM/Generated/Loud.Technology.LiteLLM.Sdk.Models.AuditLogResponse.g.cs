
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for a single audit log entry
    /// </summary>
    public sealed partial class AuditLogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChangedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_by_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChangedByApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_value")]
        public object? BeforeValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_values")]
        public object? UpdatedValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedAt"></param>
        /// <param name="changedBy"></param>
        /// <param name="changedByApiKey"></param>
        /// <param name="action"></param>
        /// <param name="tableName"></param>
        /// <param name="objectId"></param>
        /// <param name="beforeValue"></param>
        /// <param name="updatedValues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogResponse(
            string id,
            global::System.DateTime updatedAt,
            string changedBy,
            string changedByApiKey,
            string action,
            string tableName,
            string objectId,
            object? beforeValue,
            object? updatedValues)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UpdatedAt = updatedAt;
            this.ChangedBy = changedBy ?? throw new global::System.ArgumentNullException(nameof(changedBy));
            this.ChangedByApiKey = changedByApiKey ?? throw new global::System.ArgumentNullException(nameof(changedByApiKey));
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.TableName = tableName ?? throw new global::System.ArgumentNullException(nameof(tableName));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.BeforeValue = beforeValue;
            this.UpdatedValues = updatedValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogResponse" /> class.
        /// </summary>
        public AuditLogResponse()
        {
        }

    }
}
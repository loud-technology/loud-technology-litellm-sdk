
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiteLLMToolTableRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public object? Assignments { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_count")]
        public int? CallCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Default Value: untrusted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LiteLLMToolTableRowInputPolicyJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMToolTableRowInputPolicy? InputPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_alias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hash")]
        public string? KeyHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// Default Value: untrusted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LiteLLMToolTableRowOutputPolicyJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMToolTableRowOutputPolicy? OutputPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMToolTableRow" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="toolName"></param>
        /// <param name="assignments"></param>
        /// <param name="callCount">
        /// Default Value: 0
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="inputPolicy">
        /// Default Value: untrusted
        /// </param>
        /// <param name="keyAlias"></param>
        /// <param name="keyHash"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="origin"></param>
        /// <param name="outputPolicy">
        /// Default Value: untrusted
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="userAgent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMToolTableRow(
            string toolId,
            string toolName,
            object? assignments,
            int? callCount,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMToolTableRowInputPolicy? inputPolicy,
            string? keyAlias,
            string? keyHash,
            global::System.DateTime? lastUsedAt,
            string? origin,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMToolTableRowOutputPolicy? outputPolicy,
            string? teamId,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            string? userAgent)
        {
            this.Assignments = assignments;
            this.CallCount = callCount;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.InputPolicy = inputPolicy;
            this.KeyAlias = keyAlias;
            this.KeyHash = keyHash;
            this.LastUsedAt = lastUsedAt;
            this.Origin = origin;
            this.OutputPolicy = outputPolicy;
            this.TeamId = teamId;
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.UserAgent = userAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMToolTableRow" /> class.
        /// </summary>
        public LiteLLMToolTableRow()
        {
        }

    }
}
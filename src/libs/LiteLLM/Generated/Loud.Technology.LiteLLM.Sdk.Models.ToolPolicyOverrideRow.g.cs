
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolPolicyOverrideRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Default Value: blocked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ToolPolicyOverrideRowInputPolicyJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.ToolPolicyOverrideRowInputPolicy? InputPolicy { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("override_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OverrideId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPolicyOverrideRow" /> class.
        /// </summary>
        /// <param name="overrideId"></param>
        /// <param name="toolName"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputPolicy">
        /// Default Value: blocked
        /// </param>
        /// <param name="keyAlias"></param>
        /// <param name="keyHash"></param>
        /// <param name="teamId"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPolicyOverrideRow(
            string overrideId,
            string toolName,
            global::System.DateTime? createdAt,
            global::Loud.Technology.LiteLLM.Sdk.ToolPolicyOverrideRowInputPolicy? inputPolicy,
            string? keyAlias,
            string? keyHash,
            string? teamId,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.InputPolicy = inputPolicy;
            this.KeyAlias = keyAlias;
            this.KeyHash = keyHash;
            this.OverrideId = overrideId ?? throw new global::System.ArgumentNullException(nameof(overrideId));
            this.TeamId = teamId;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPolicyOverrideRow" /> class.
        /// </summary>
        public ToolPolicyOverrideRow()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryCreateRequest
    {
        /// <summary>
        /// Memory key (acts as the namespace in the URL).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Memory content. Typically markdown/text for LLM context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Optional JSON metadata (tags, structured fields).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Scope to this user. Defaults to the caller's user_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Scope to this team. Defaults to the caller's team_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryCreateRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// Memory key (acts as the namespace in the URL).
        /// </param>
        /// <param name="value">
        /// Memory content. Typically markdown/text for LLM context.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON metadata (tags, structured fields).
        /// </param>
        /// <param name="userId">
        /// Scope to this user. Defaults to the caller's user_id.
        /// </param>
        /// <param name="teamId">
        /// Scope to this team. Defaults to the caller's team_id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoryCreateRequest(
            string key,
            string value,
            object? metadata,
            string? userId,
            string? teamId)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Metadata = metadata;
            this.UserId = userId;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryCreateRequest" /> class.
        /// </summary>
        public MemoryCreateRequest()
        {
        }

    }
}
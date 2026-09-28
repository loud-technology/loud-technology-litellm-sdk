
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One user's stored credential for an MCP server, as an admin sees it. Never carries the secret.
    /// </summary>
    public sealed partial class MCPServerUserCredentialListItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_at")]
        public string? ConnectedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.MCPServerUserCredentialListItemCredentialTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.MCPServerUserCredentialListItemCredentialType CredentialType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerUserCredentialListItem" /> class.
        /// </summary>
        /// <param name="credentialType"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
        /// <param name="connectedAt"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerUserCredentialListItem(
            global::Loud.Technology.LiteLLM.Sdk.MCPServerUserCredentialListItemCredentialType credentialType,
            string updatedAt,
            string userId,
            string? connectedAt,
            string? expiresAt)
        {
            this.ConnectedAt = connectedAt;
            this.CredentialType = credentialType;
            this.ExpiresAt = expiresAt;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerUserCredentialListItem" /> class.
        /// </summary>
        public MCPServerUserCredentialListItem()
        {
        }

    }
}
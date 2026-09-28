
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One entry in the /user-credentials list.
    /// </summary>
    public sealed partial class MCPUserCredentialListItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_at")]
        public string? ConnectedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_credential")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCredential { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserCredentialListItem" /> class.
        /// </summary>
        /// <param name="credentialType"></param>
        /// <param name="hasCredential"></param>
        /// <param name="serverId"></param>
        /// <param name="alias"></param>
        /// <param name="connectedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="serverName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPUserCredentialListItem(
            string credentialType,
            bool hasCredential,
            string serverId,
            string? alias,
            string? connectedAt,
            string? expiresAt,
            string? serverName)
        {
            this.Alias = alias;
            this.ConnectedAt = connectedAt;
            this.CredentialType = credentialType ?? throw new global::System.ArgumentNullException(nameof(credentialType));
            this.ExpiresAt = expiresAt;
            this.HasCredential = hasCredential;
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
            this.ServerName = serverName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserCredentialListItem" /> class.
        /// </summary>
        public MCPUserCredentialListItem()
        {
        }

    }
}
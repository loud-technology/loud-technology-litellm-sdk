
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Metadata for a key
    /// </summary>
    public sealed partial class KeyMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_alias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_exists")]
        public bool? KeyExists { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyMetadata" /> class.
        /// </summary>
        /// <param name="keyAlias"></param>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="keyExists"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyMetadata(
            string? keyAlias,
            string? teamId,
            string? userId,
            string? userEmail,
            bool? keyExists)
        {
            this.KeyAlias = keyAlias;
            this.TeamId = teamId;
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.KeyExists = keyExists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyMetadata" /> class.
        /// </summary>
        public KeyMetadata()
        {
        }

    }
}
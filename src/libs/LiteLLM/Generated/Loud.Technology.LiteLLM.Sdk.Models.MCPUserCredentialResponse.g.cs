
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPUserCredentialResponse
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserCredentialResponse" /> class.
        /// </summary>
        /// <param name="hasCredential"></param>
        /// <param name="serverId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPUserCredentialResponse(
            bool hasCredential,
            string serverId)
        {
            this.HasCredential = hasCredential;
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserCredentialResponse" /> class.
        /// </summary>
        public MCPUserCredentialResponse()
        {
        }

    }
}
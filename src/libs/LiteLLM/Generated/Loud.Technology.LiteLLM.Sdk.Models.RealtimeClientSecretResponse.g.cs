
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response from POST /v1/realtime/client_secrets.<br/>
    /// Both the top-level `value` and `session.client_secret.value`<br/>
    /// will contain the encrypted token instead of the raw ephemeral key.<br/>
    /// The `session` field is kept as a raw dict so unknown fields pass through.
    /// </summary>
    public sealed partial class RealtimeClientSecretResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public object? Session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientSecretResponse" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expiresAt"></param>
        /// <param name="session"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientSecretResponse(
            string value,
            int? expiresAt,
            object? session)
        {
            this.ExpiresAt = expiresAt;
            this.Session = session;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientSecretResponse" /> class.
        /// </summary>
        public RealtimeClientSecretResponse()
        {
        }

    }
}
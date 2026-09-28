
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One live stateful Streamable HTTP session held by this proxy worker.
    /// </summary>
    public sealed partial class MCPGatewaySession
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_name")]
        public string? ClientName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IdleSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_flight_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InFlightRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_alias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionIdPrefix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_alias")]
        public string? TeamAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPGatewaySession" /> class.
        /// </summary>
        /// <param name="idleSeconds"></param>
        /// <param name="inFlightRequests"></param>
        /// <param name="sessionIdPrefix"></param>
        /// <param name="clientIp"></param>
        /// <param name="clientName"></param>
        /// <param name="clientVersion"></param>
        /// <param name="keyAlias"></param>
        /// <param name="teamAlias"></param>
        /// <param name="teamId"></param>
        /// <param name="userEmail"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPGatewaySession(
            double idleSeconds,
            int inFlightRequests,
            string sessionIdPrefix,
            string? clientIp,
            string? clientName,
            string? clientVersion,
            string? keyAlias,
            string? teamAlias,
            string? teamId,
            string? userEmail,
            string? userId)
        {
            this.ClientIp = clientIp;
            this.ClientName = clientName;
            this.ClientVersion = clientVersion;
            this.IdleSeconds = idleSeconds;
            this.InFlightRequests = inFlightRequests;
            this.KeyAlias = keyAlias;
            this.SessionIdPrefix = sessionIdPrefix ?? throw new global::System.ArgumentNullException(nameof(sessionIdPrefix));
            this.TeamAlias = teamAlias;
            this.TeamId = teamId;
            this.UserEmail = userEmail;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPGatewaySession" /> class.
        /// </summary>
        public MCPGatewaySession()
        {
        }

    }
}
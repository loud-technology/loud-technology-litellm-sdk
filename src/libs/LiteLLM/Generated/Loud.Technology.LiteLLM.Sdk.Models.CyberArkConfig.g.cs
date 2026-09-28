
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for CyberArk Conjur secret manager integration.
    /// </summary>
    public sealed partial class CyberArkConfig
    {
        /// <summary>
        /// Path to the client TLS certificate for certificate-based authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_cert")]
        public string? ClientCert { get; set; }

        /// <summary>
        /// Path to the client TLS private key for certificate-based authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// The Conjur organization account name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyberark_account")]
        public string? CyberarkAccount { get; set; }

        /// <summary>
        /// The address of the CyberArk Conjur server (e.g., https://conjur.example.com)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyberark_api_base")]
        public string? CyberarkApiBase { get; set; }

        /// <summary>
        /// API key for Conjur API-key authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyberark_api_key")]
        public string? CyberarkApiKey { get; set; }

        /// <summary>
        /// The Conjur username (login) to authenticate as
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cyberark_username")]
        public string? CyberarkUsername { get; set; }

        /// <summary>
        /// Auth token cache TTL in seconds (default: 300)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_interval")]
        public string? RefreshInterval { get; set; }

        /// <summary>
        /// Set to false to disable SSL verification (e.g., for self-signed certificates)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssl_verify")]
        public string? SslVerify { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CyberArkConfig" /> class.
        /// </summary>
        /// <param name="clientCert">
        /// Path to the client TLS certificate for certificate-based authentication
        /// </param>
        /// <param name="clientKey">
        /// Path to the client TLS private key for certificate-based authentication
        /// </param>
        /// <param name="cyberarkAccount">
        /// The Conjur organization account name
        /// </param>
        /// <param name="cyberarkApiBase">
        /// The address of the CyberArk Conjur server (e.g., https://conjur.example.com)
        /// </param>
        /// <param name="cyberarkApiKey">
        /// API key for Conjur API-key authentication
        /// </param>
        /// <param name="cyberarkUsername">
        /// The Conjur username (login) to authenticate as
        /// </param>
        /// <param name="refreshInterval">
        /// Auth token cache TTL in seconds (default: 300)
        /// </param>
        /// <param name="sslVerify">
        /// Set to false to disable SSL verification (e.g., for self-signed certificates)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CyberArkConfig(
            string? clientCert,
            string? clientKey,
            string? cyberarkAccount,
            string? cyberarkApiBase,
            string? cyberarkApiKey,
            string? cyberarkUsername,
            string? refreshInterval,
            string? sslVerify)
        {
            this.ClientCert = clientCert;
            this.ClientKey = clientKey;
            this.CyberarkAccount = cyberarkAccount;
            this.CyberarkApiBase = cyberarkApiBase;
            this.CyberarkApiKey = cyberarkApiKey;
            this.CyberarkUsername = cyberarkUsername;
            this.RefreshInterval = refreshInterval;
            this.SslVerify = sslVerify;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CyberArkConfig" /> class.
        /// </summary>
        public CyberArkConfig()
        {
        }

    }
}
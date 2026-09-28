
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for Hashicorp Vault secret manager integration.
    /// </summary>
    public sealed partial class HashicorpVaultConfig
    {
        /// <summary>
        /// Mount path for the AppRole auth method (default: approle)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approle_mount_path")]
        public string? ApproleMountPath { get; set; }

        /// <summary>
        /// Role ID for Vault AppRole authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approle_role_id")]
        public string? ApproleRoleId { get; set; }

        /// <summary>
        /// Secret ID for Vault AppRole authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approle_secret_id")]
        public string? ApproleSecretId { get; set; }

        /// <summary>
        /// Path to the client TLS certificate for Vault
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_cert")]
        public string? ClientCert { get; set; }

        /// <summary>
        /// Path to the client TLS private key for Vault
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// The address of the Vault server (e.g., https://vault.example.com:8200)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_addr")]
        public string? VaultAddr { get; set; }

        /// <summary>
        /// Certificate role name for TLS cert authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_cert_role")]
        public string? VaultCertRole { get; set; }

        /// <summary>
        /// Namespace for AppRole and TLS cert login (X-Vault-Namespace header); falls back to vault_namespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_login_namespace")]
        public string? VaultLoginNamespace { get; set; }

        /// <summary>
        /// KV engine mount name (default: secret)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_mount_name")]
        public string? VaultMountName { get; set; }

        /// <summary>
        /// Vault namespace used for both login and secret operations unless overridden below
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_namespace")]
        public string? VaultNamespace { get; set; }

        /// <summary>
        /// Optional path prefix for secrets (e.g., myapp -&gt; secret/data/myapp/{secret_name})
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_path_prefix")]
        public string? VaultPathPrefix { get; set; }

        /// <summary>
        /// Namespace for secret reads and writes (URL path segment); falls back to vault_namespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_secret_namespace")]
        public string? VaultSecretNamespace { get; set; }

        /// <summary>
        /// Token for Vault token-based authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_token")]
        public string? VaultToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HashicorpVaultConfig" /> class.
        /// </summary>
        /// <param name="approleMountPath">
        /// Mount path for the AppRole auth method (default: approle)
        /// </param>
        /// <param name="approleRoleId">
        /// Role ID for Vault AppRole authentication
        /// </param>
        /// <param name="approleSecretId">
        /// Secret ID for Vault AppRole authentication
        /// </param>
        /// <param name="clientCert">
        /// Path to the client TLS certificate for Vault
        /// </param>
        /// <param name="clientKey">
        /// Path to the client TLS private key for Vault
        /// </param>
        /// <param name="vaultAddr">
        /// The address of the Vault server (e.g., https://vault.example.com:8200)
        /// </param>
        /// <param name="vaultCertRole">
        /// Certificate role name for TLS cert authentication
        /// </param>
        /// <param name="vaultLoginNamespace">
        /// Namespace for AppRole and TLS cert login (X-Vault-Namespace header); falls back to vault_namespace
        /// </param>
        /// <param name="vaultMountName">
        /// KV engine mount name (default: secret)
        /// </param>
        /// <param name="vaultNamespace">
        /// Vault namespace used for both login and secret operations unless overridden below
        /// </param>
        /// <param name="vaultPathPrefix">
        /// Optional path prefix for secrets (e.g., myapp -&gt; secret/data/myapp/{secret_name})
        /// </param>
        /// <param name="vaultSecretNamespace">
        /// Namespace for secret reads and writes (URL path segment); falls back to vault_namespace
        /// </param>
        /// <param name="vaultToken">
        /// Token for Vault token-based authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HashicorpVaultConfig(
            string? approleMountPath,
            string? approleRoleId,
            string? approleSecretId,
            string? clientCert,
            string? clientKey,
            string? vaultAddr,
            string? vaultCertRole,
            string? vaultLoginNamespace,
            string? vaultMountName,
            string? vaultNamespace,
            string? vaultPathPrefix,
            string? vaultSecretNamespace,
            string? vaultToken)
        {
            this.ApproleMountPath = approleMountPath;
            this.ApproleRoleId = approleRoleId;
            this.ApproleSecretId = approleSecretId;
            this.ClientCert = clientCert;
            this.ClientKey = clientKey;
            this.VaultAddr = vaultAddr;
            this.VaultCertRole = vaultCertRole;
            this.VaultLoginNamespace = vaultLoginNamespace;
            this.VaultMountName = vaultMountName;
            this.VaultNamespace = vaultNamespace;
            this.VaultPathPrefix = vaultPathPrefix;
            this.VaultSecretNamespace = vaultSecretNamespace;
            this.VaultToken = vaultToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HashicorpVaultConfig" /> class.
        /// </summary>
        public HashicorpVaultConfig()
        {
        }

    }
}
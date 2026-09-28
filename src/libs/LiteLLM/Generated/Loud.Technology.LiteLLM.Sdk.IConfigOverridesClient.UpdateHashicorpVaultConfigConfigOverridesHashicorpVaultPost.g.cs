#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IConfigOverridesClient
    {
        /// <summary>
        /// Update Hashicorp Vault Config<br/>
        /// Update Hashicorp Vault secret manager configuration.<br/>
        /// Sets environment variables, encrypts sensitive fields, and stores in DB.<br/>
        /// Reinitializes the secret manager on this pod.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateHashicorpVaultConfigConfigOverridesHashicorpVaultPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.HashicorpVaultConfig request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Hashicorp Vault Config<br/>
        /// Update Hashicorp Vault secret manager configuration.<br/>
        /// Sets environment variables, encrypts sensitive fields, and stores in DB.<br/>
        /// Reinitializes the secret manager on this pod.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateHashicorpVaultConfigConfigOverridesHashicorpVaultPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.HashicorpVaultConfig request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Hashicorp Vault Config<br/>
        /// Update Hashicorp Vault secret manager configuration.<br/>
        /// Sets environment variables, encrypts sensitive fields, and stores in DB.<br/>
        /// Reinitializes the secret manager on this pod.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateHashicorpVaultConfigConfigOverridesHashicorpVaultPostAsync(
            string? litellmChangedBy = default,
            string? approleMountPath = default,
            string? approleRoleId = default,
            string? approleSecretId = default,
            string? clientCert = default,
            string? clientKey = default,
            string? vaultAddr = default,
            string? vaultCertRole = default,
            string? vaultLoginNamespace = default,
            string? vaultMountName = default,
            string? vaultNamespace = default,
            string? vaultPathPrefix = default,
            string? vaultSecretNamespace = default,
            string? vaultToken = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IConfigOverridesClient
    {
        /// <summary>
        /// Update Cyberark Config<br/>
        /// Update CyberArk Conjur secret manager configuration.<br/>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> UpdateCyberarkConfigConfigOverridesCyberarkPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CyberArkConfig request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cyberark Config<br/>
        /// Update CyberArk Conjur secret manager configuration.<br/>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, string>>> UpdateCyberarkConfigConfigOverridesCyberarkPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CyberArkConfig request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cyberark Config<br/>
        /// Update CyberArk Conjur secret manager configuration.<br/>
        /// Sets environment variables, encrypts sensitive fields, and stores in DB.<br/>
        /// Reinitializes the secret manager on this pod.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> UpdateCyberarkConfigConfigOverridesCyberarkPostAsync(
            string? litellmChangedBy = default,
            string? clientCert = default,
            string? clientKey = default,
            string? cyberarkAccount = default,
            string? cyberarkApiBase = default,
            string? cyberarkApiKey = default,
            string? cyberarkUsername = default,
            string? refreshInterval = default,
            string? sslVerify = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
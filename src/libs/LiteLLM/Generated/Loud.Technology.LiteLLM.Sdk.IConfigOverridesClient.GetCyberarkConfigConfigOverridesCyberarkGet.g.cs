#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IConfigOverridesClient
    {
        /// <summary>
        /// Get Cyberark Config<br/>
        /// Get current CyberArk Conjur configuration.<br/>
        /// Returns decrypted values from DB, or falls back to current env vars.<br/>
        /// Sensitive fields are masked before leaving the server.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ConfigOverrideSettingsResponse> GetCyberarkConfigConfigOverridesCyberarkGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Cyberark Config<br/>
        /// Get current CyberArk Conjur configuration.<br/>
        /// Returns decrypted values from DB, or falls back to current env vars.<br/>
        /// Sensitive fields are masked before leaving the server.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ConfigOverrideSettingsResponse>> GetCyberarkConfigConfigOverridesCyberarkGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
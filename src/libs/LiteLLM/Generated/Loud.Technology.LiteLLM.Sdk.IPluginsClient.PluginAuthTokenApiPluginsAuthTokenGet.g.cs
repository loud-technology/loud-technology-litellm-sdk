#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPluginsClient
    {
        /// <summary>
        /// Plugin Auth Token<br/>
        /// Issue a short-lived, audience-scoped plugin session claim.<br/>
        /// The claim contains {user_id, user_role, plugin, exp}.  It does NOT<br/>
        /// contain the caller's litellm bearer token — a compromised plugin can<br/>
        /// only learn the caller's identity, not impersonate them against the proxy.<br/>
        /// Encrypted with a key derived from HMAC(LITELLM_SALT_KEY, plugin_name),<br/>
        /// so each plugin holds only its own key and cannot forge claims for others.<br/>
        /// Requires LITELLM_SALT_KEY to be set; returns 503 otherwise.
        /// </summary>
        /// <param name="pluginName">
        /// Default Value: litellm-platform-plugin
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PluginAuthTokenApiPluginsAuthTokenGetAsync(
            string? pluginName = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Plugin Auth Token<br/>
        /// Issue a short-lived, audience-scoped plugin session claim.<br/>
        /// The claim contains {user_id, user_role, plugin, exp}.  It does NOT<br/>
        /// contain the caller's litellm bearer token — a compromised plugin can<br/>
        /// only learn the caller's identity, not impersonate them against the proxy.<br/>
        /// Encrypted with a key derived from HMAC(LITELLM_SALT_KEY, plugin_name),<br/>
        /// so each plugin holds only its own key and cannot forge claims for others.<br/>
        /// Requires LITELLM_SALT_KEY to be set; returns 503 otherwise.
        /// </summary>
        /// <param name="pluginName">
        /// Default Value: litellm-platform-plugin
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> PluginAuthTokenApiPluginsAuthTokenGetAsResponseAsync(
            string? pluginName = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
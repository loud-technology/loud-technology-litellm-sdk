#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPluginsClient
    {
        /// <summary>
        /// List Plugins<br/>
        /// Return registered plugins for authenticated UI callers.<br/>
        /// plugin_key is never returned — the browser never needs it (the proxy injects<br/>
        /// it server-side from the registry), and exposing it here would leak the<br/>
        /// credential into React state and DevTools.  Admin key management goes through<br/>
        /// the redacted /config/field/info path instead.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>> ListPluginsApiPluginsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Plugins<br/>
        /// Return registered plugins for authenticated UI callers.<br/>
        /// plugin_key is never returned — the browser never needs it (the proxy injects<br/>
        /// it server-side from the registry), and exposing it here would leak the<br/>
        /// credential into React state and DevTools.  Admin key management goes through<br/>
        /// the redacted /config/field/info path instead.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>>> ListPluginsApiPluginsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
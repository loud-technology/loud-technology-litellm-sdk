#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVantageClient
    {
        /// <summary>
        /// Get Vantage Settings<br/>
        /// View current Vantage settings.<br/>
        /// Returns the current Vantage configuration with the API key masked for security.<br/>
        /// Only admin users (Proxy Admin or Admin Viewer) can view Vantage settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.VantageSettingsView> GetVantageSettingsVantageSettingsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Vantage Settings<br/>
        /// View current Vantage settings.<br/>
        /// Returns the current Vantage configuration with the API key masked for security.<br/>
        /// Only admin users (Proxy Admin or Admin Viewer) can view Vantage settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.VantageSettingsView>> GetVantageSettingsVantageSettingsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
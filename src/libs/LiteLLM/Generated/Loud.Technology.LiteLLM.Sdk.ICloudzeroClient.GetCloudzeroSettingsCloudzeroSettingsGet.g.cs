#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICloudzeroClient
    {
        /// <summary>
        /// Get Cloudzero Settings<br/>
        /// View current CloudZero settings.<br/>
        /// Returns the current CloudZero configuration with the API key masked for security.<br/>
        /// Only the first 4 and last 4 characters of the API key are shown.<br/>
        /// Returns null/empty values when settings are not configured (consistent with other settings endpoints).<br/>
        /// Only admin users (Proxy Admin or Admin Viewer) can view CloudZero settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroSettingsView> GetCloudzeroSettingsCloudzeroSettingsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Cloudzero Settings<br/>
        /// View current CloudZero settings.<br/>
        /// Returns the current CloudZero configuration with the API key masked for security.<br/>
        /// Only the first 4 and last 4 characters of the API key are shown.<br/>
        /// Returns null/empty values when settings are not configured (consistent with other settings endpoints).<br/>
        /// Only admin users (Proxy Admin or Admin Viewer) can view CloudZero settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CloudZeroSettingsView>> GetCloudzeroSettingsCloudzeroSettingsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IUiThemeSettingsClient
    {
        /// <summary>
        /// Update Ui Theme Settings<br/>
        /// Update UI theme configuration.<br/>
        /// Updates logo settings for the admin UI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUiThemeSettingsUpdateUiThemeSettingsPatchAsync(

            global::Loud.Technology.LiteLLM.Sdk.UIThemeConfig request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Ui Theme Settings<br/>
        /// Update UI theme configuration.<br/>
        /// Updates logo settings for the admin UI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateUiThemeSettingsUpdateUiThemeSettingsPatchAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UIThemeConfig request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Ui Theme Settings<br/>
        /// Update UI theme configuration.<br/>
        /// Updates logo settings for the admin UI.
        /// </summary>
        /// <param name="logoUrl">
        /// URL or path to custom logo image. Can be a local file path or HTTP/HTTPS URL
        /// </param>
        /// <param name="faviconUrl">
        /// URL to custom favicon image. Must be an HTTP/HTTPS URL to a .ico, .png, or .svg file
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUiThemeSettingsUpdateUiThemeSettingsPatchAsync(
            string? logoUrl = default,
            string? faviconUrl = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
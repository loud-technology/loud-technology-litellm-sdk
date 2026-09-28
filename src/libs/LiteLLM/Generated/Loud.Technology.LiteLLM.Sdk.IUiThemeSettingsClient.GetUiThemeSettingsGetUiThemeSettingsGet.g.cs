#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IUiThemeSettingsClient
    {
        /// <summary>
        /// Get Ui Theme Settings<br/>
        /// Get UI theme configuration from the litellm_settings.<br/>
        /// Returns current logo settings for UI customization.<br/>
        /// Note: This endpoint is public (no authentication required) so all users can see custom branding.<br/>
        /// Only the /update/ui_theme_settings endpoint requires authentication for admins to change settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.UIThemeSettingsResponse> GetUiThemeSettingsGetUiThemeSettingsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Ui Theme Settings<br/>
        /// Get UI theme configuration from the litellm_settings.<br/>
        /// Returns current logo settings for UI customization.<br/>
        /// Note: This endpoint is public (no authentication required) so all users can see custom branding.<br/>
        /// Only the /update/ui_theme_settings endpoint requires authentication for admins to change settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.UIThemeSettingsResponse>> GetUiThemeSettingsGetUiThemeSettingsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
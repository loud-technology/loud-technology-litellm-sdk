#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IUiThemeSettingsClient
    {
        /// <summary>
        /// Upload Logo<br/>
        /// Upload a custom logo for the admin UI.<br/>
        /// Accepts image files (PNG, JPG, JPEG, SVG) and stores them for use in the UI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UploadLogoUploadLogoPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyUploadLogoUploadLogoPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Logo<br/>
        /// Upload a custom logo for the admin UI.<br/>
        /// Accepts image files (PNG, JPG, JPEG, SVG) and stores them for use in the UI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UploadLogoUploadLogoPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyUploadLogoUploadLogoPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Logo<br/>
        /// Upload a custom logo for the admin UI.<br/>
        /// Accepts image files (PNG, JPG, JPEG, SVG) and stores them for use in the UI.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UploadLogoUploadLogoPostAsync(
            byte[] file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Logo<br/>
        /// Upload a custom logo for the admin UI.<br/>
        /// Accepts image files (PNG, JPG, JPEG, SVG) and stores them for use in the UI.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UploadLogoUploadLogoPostAsync(
            global::System.IO.Stream file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Logo<br/>
        /// Upload a custom logo for the admin UI.<br/>
        /// Accepts image files (PNG, JPG, JPEG, SVG) and stores them for use in the UI.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UploadLogoUploadLogoPostAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
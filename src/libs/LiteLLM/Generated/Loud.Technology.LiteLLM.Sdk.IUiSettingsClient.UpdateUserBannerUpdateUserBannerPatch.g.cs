#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IUiSettingsClient
    {
        /// <summary>
        /// Update User Banner<br/>
        /// Publish, edit, or unpublish the dashboard banner.<br/>
        /// Only proxy admins are allowed to modify it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.UpdateUserBannerResponse> UpdateUserBannerUpdateUserBannerPatchAsync(

            global::Loud.Technology.LiteLLM.Sdk.UserBannerUpdate request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update User Banner<br/>
        /// Publish, edit, or unpublish the dashboard banner.<br/>
        /// Only proxy admins are allowed to modify it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.UpdateUserBannerResponse>> UpdateUserBannerUpdateUserBannerPatchAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UserBannerUpdate request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update User Banner<br/>
        /// Publish, edit, or unpublish the dashboard banner.<br/>
        /// Only proxy admins are allowed to modify it.
        /// </summary>
        /// <param name="enabled">
        /// If true, the banner is shown to all authenticated dashboard users.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="message">
        /// Banner text shown to dashboard users. Markdown is supported.
        /// </param>
        /// <param name="severity">
        /// Visual style of the banner.<br/>
        /// Default Value: info
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.UpdateUserBannerResponse> UpdateUserBannerUpdateUserBannerPatchAsync(
            bool? enabled = default,
            string? message = default,
            global::Loud.Technology.LiteLLM.Sdk.UserBannerUpdateSeverity? severity = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
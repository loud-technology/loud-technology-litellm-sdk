#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IUiSettingsClient
    {
        /// <summary>
        /// Latest Release Info<br/>
        /// Latest stable LiteLLM GitHub release with its PR count split into new features, bug fixes and other updates.<br/>
        /// Returns null when GitHub can't be reached so the dashboard upgrade banner simply doesn't render.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LatestReleaseInfo> LatestReleaseInfoGetLatestReleaseInfoGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Latest Release Info<br/>
        /// Latest stable LiteLLM GitHub release with its PR count split into new features, bug fixes and other updates.<br/>
        /// Returns null when GitHub can't be reached so the dashboard upgrade banner simply doesn't render.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LatestReleaseInfo>> LatestReleaseInfoGetLatestReleaseInfoGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICloudzeroClient
    {
        /// <summary>
        /// Delete Cloudzero Settings<br/>
        /// Delete CloudZero settings from the database.<br/>
        /// This endpoint removes the CloudZero configuration (API key, connection ID, timezone)<br/>
        /// from the proxy database. Only the CloudZero settings entry will be deleted;<br/>
        /// other configuration values in the database will remain unchanged.<br/>
        /// Only admin users can delete CloudZero settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitResponse> DeleteCloudzeroSettingsCloudzeroDeleteDeleteAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Cloudzero Settings<br/>
        /// Delete CloudZero settings from the database.<br/>
        /// This endpoint removes the CloudZero configuration (API key, connection ID, timezone)<br/>
        /// from the proxy database. Only the CloudZero settings entry will be deleted;<br/>
        /// other configuration values in the database will remain unchanged.<br/>
        /// Only admin users can delete CloudZero settings.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitResponse>> DeleteCloudzeroSettingsCloudzeroDeleteDeleteAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
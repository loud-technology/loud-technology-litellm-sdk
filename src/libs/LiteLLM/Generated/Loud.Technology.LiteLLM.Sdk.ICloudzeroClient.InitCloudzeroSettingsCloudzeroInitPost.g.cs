#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICloudzeroClient
    {
        /// <summary>
        /// Init Cloudzero Settings<br/>
        /// Initialize CloudZero settings and store in the database.<br/>
        /// This endpoint stores the CloudZero API key, connection ID, and timezone configuration<br/>
        /// in the proxy database for use by the CloudZero logger.<br/>
        /// Parameters:<br/>
        /// - api_key: CloudZero API key for authentication<br/>
        /// - connection_id: CloudZero connection ID for data submission<br/>
        /// - timezone: Timezone for date handling (default: UTC)<br/>
        /// Only admin users can configure CloudZero settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitResponse> InitCloudzeroSettingsCloudzeroInitPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Cloudzero Settings<br/>
        /// Initialize CloudZero settings and store in the database.<br/>
        /// This endpoint stores the CloudZero API key, connection ID, and timezone configuration<br/>
        /// in the proxy database for use by the CloudZero logger.<br/>
        /// Parameters:<br/>
        /// - api_key: CloudZero API key for authentication<br/>
        /// - connection_id: CloudZero connection ID for data submission<br/>
        /// - timezone: Timezone for date handling (default: UTC)<br/>
        /// Only admin users can configure CloudZero settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitResponse>> InitCloudzeroSettingsCloudzeroInitPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Init Cloudzero Settings<br/>
        /// Initialize CloudZero settings and store in the database.<br/>
        /// This endpoint stores the CloudZero API key, connection ID, and timezone configuration<br/>
        /// in the proxy database for use by the CloudZero logger.<br/>
        /// Parameters:<br/>
        /// - api_key: CloudZero API key for authentication<br/>
        /// - connection_id: CloudZero connection ID for data submission<br/>
        /// - timezone: Timezone for date handling (default: UTC)<br/>
        /// Only admin users can configure CloudZero settings.
        /// </summary>
        /// <param name="apiKey">
        /// CloudZero API key for authentication
        /// </param>
        /// <param name="connectionId">
        /// CloudZero connection ID for data submission
        /// </param>
        /// <param name="timezone">
        /// Timezone for date handling (default: UTC)<br/>
        /// Default Value: UTC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitResponse> InitCloudzeroSettingsCloudzeroInitPostAsync(
            string apiKey,
            string connectionId,
            string? timezone = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
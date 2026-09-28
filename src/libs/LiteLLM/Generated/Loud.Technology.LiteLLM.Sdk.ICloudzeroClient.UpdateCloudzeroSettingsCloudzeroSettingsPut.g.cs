#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICloudzeroClient
    {
        /// <summary>
        /// Update Cloudzero Settings<br/>
        /// Update existing CloudZero settings.<br/>
        /// Allows updating individual CloudZero configuration fields without requiring all fields.<br/>
        /// Only provided fields will be updated; others will remain unchanged.<br/>
        /// Parameters:<br/>
        /// - api_key: (Optional) New CloudZero API key for authentication<br/>
        /// - connection_id: (Optional) New CloudZero connection ID for data submission<br/>
        /// - timezone: (Optional) New timezone for date handling<br/>
        /// Only admin users can update CloudZero settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitResponse> UpdateCloudzeroSettingsCloudzeroSettingsPutAsync(

            global::Loud.Technology.LiteLLM.Sdk.CloudZeroSettingsUpdate request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cloudzero Settings<br/>
        /// Update existing CloudZero settings.<br/>
        /// Allows updating individual CloudZero configuration fields without requiring all fields.<br/>
        /// Only provided fields will be updated; others will remain unchanged.<br/>
        /// Parameters:<br/>
        /// - api_key: (Optional) New CloudZero API key for authentication<br/>
        /// - connection_id: (Optional) New CloudZero connection ID for data submission<br/>
        /// - timezone: (Optional) New timezone for date handling<br/>
        /// Only admin users can update CloudZero settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitResponse>> UpdateCloudzeroSettingsCloudzeroSettingsPutAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CloudZeroSettingsUpdate request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cloudzero Settings<br/>
        /// Update existing CloudZero settings.<br/>
        /// Allows updating individual CloudZero configuration fields without requiring all fields.<br/>
        /// Only provided fields will be updated; others will remain unchanged.<br/>
        /// Parameters:<br/>
        /// - api_key: (Optional) New CloudZero API key for authentication<br/>
        /// - connection_id: (Optional) New CloudZero connection ID for data submission<br/>
        /// - timezone: (Optional) New timezone for date handling<br/>
        /// Only admin users can update CloudZero settings.
        /// </summary>
        /// <param name="apiKey">
        /// New CloudZero API key for authentication
        /// </param>
        /// <param name="connectionId">
        /// New CloudZero connection ID for data submission
        /// </param>
        /// <param name="timezone">
        /// New timezone for date handling
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroInitResponse> UpdateCloudzeroSettingsCloudzeroSettingsPutAsync(
            string? apiKey = default,
            string? connectionId = default,
            string? timezone = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
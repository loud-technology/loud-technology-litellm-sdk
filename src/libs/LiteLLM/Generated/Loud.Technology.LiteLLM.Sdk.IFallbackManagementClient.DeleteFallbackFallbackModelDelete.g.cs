#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IFallbackManagementClient
    {
        /// <summary>
        /// Delete Fallback<br/>
        /// Delete fallback configuration for a specific model.<br/>
        /// **Parameters:**<br/>
        /// - `model`: The model name to delete fallbacks for<br/>
        /// - `fallback_type`: Type of fallback to delete (query parameter)<br/>
        /// **Example:**<br/>
        /// ```<br/>
        /// DELETE /fallback/gpt-3.5-turbo?fallback_type=general<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fallbackType">
        /// Default Value: general
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.FallbackDeleteResponse> DeleteFallbackFallbackModelDeleteAsync(
            string model,
            global::Loud.Technology.LiteLLM.Sdk.DeleteFallbackFallbackModelDeleteFallbackType? fallbackType = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Fallback<br/>
        /// Delete fallback configuration for a specific model.<br/>
        /// **Parameters:**<br/>
        /// - `model`: The model name to delete fallbacks for<br/>
        /// - `fallback_type`: Type of fallback to delete (query parameter)<br/>
        /// **Example:**<br/>
        /// ```<br/>
        /// DELETE /fallback/gpt-3.5-turbo?fallback_type=general<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fallbackType">
        /// Default Value: general
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.FallbackDeleteResponse>> DeleteFallbackFallbackModelDeleteAsResponseAsync(
            string model,
            global::Loud.Technology.LiteLLM.Sdk.DeleteFallbackFallbackModelDeleteFallbackType? fallbackType = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
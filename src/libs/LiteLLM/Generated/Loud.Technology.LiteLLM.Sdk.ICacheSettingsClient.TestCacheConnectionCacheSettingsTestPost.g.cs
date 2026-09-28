#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICacheSettingsClient
    {
        /// <summary>
        /// Test Cache Connection<br/>
        /// Test cache connection with provided credentials.<br/>
        /// Creates a temporary cache instance and uses its test_connection method<br/>
        /// to verify the credentials work without affecting global state.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CacheTestResponse> TestCacheConnectionCacheSettingsTestPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CacheTestRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Cache Connection<br/>
        /// Test cache connection with provided credentials.<br/>
        /// Creates a temporary cache instance and uses its test_connection method<br/>
        /// to verify the credentials work without affecting global state.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CacheTestResponse>> TestCacheConnectionCacheSettingsTestPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CacheTestRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Cache Connection<br/>
        /// Test cache connection with provided credentials.<br/>
        /// Creates a temporary cache instance and uses its test_connection method<br/>
        /// to verify the credentials work without affecting global state.
        /// </summary>
        /// <param name="cacheSettings">
        /// Cache settings to test connection with
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CacheTestResponse> TestCacheConnectionCacheSettingsTestPostAsync(
            object cacheSettings,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
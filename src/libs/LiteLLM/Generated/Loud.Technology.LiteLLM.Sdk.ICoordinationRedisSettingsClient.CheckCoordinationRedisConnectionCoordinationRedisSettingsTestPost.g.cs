#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICoordinationRedisSettingsClient
    {
        /// <summary>
        /// Check Coordination Redis Connection<br/>
        /// Test a coordination Redis connection with the provided credentials.<br/>
        /// Parameters:<br/>
        /// - settings: dict - Redis connection params to test. Credential fields sent back as `***REDACTED***` fall back to the saved value<br/>
        /// Builds a throwaway client (never touching global state) and pings it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisTestResponse> CheckCoordinationRedisConnectionCoordinationRedisSettingsTestPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Coordination Redis Connection<br/>
        /// Test a coordination Redis connection with the provided credentials.<br/>
        /// Parameters:<br/>
        /// - settings: dict - Redis connection params to test. Credential fields sent back as `***REDACTED***` fall back to the saved value<br/>
        /// Builds a throwaway client (never touching global state) and pings it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisTestResponse>> CheckCoordinationRedisConnectionCoordinationRedisSettingsTestPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Coordination Redis Connection<br/>
        /// Test a coordination Redis connection with the provided credentials.<br/>
        /// Parameters:<br/>
        /// - settings: dict - Redis connection params to test. Credential fields sent back as `***REDACTED***` fall back to the saved value<br/>
        /// Builds a throwaway client (never touching global state) and pings it.
        /// </summary>
        /// <param name="settings">
        /// Coordination Redis connection params
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisTestResponse> CheckCoordinationRedisConnectionCoordinationRedisSettingsTestPostAsync(
            object settings,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
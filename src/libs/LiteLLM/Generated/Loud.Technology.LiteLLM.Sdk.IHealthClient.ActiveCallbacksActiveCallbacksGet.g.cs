#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Active Callbacks<br/>
        /// Returns a list of litellm level settings<br/>
        /// This is useful for debugging and ensuring the proxy server is configured correctly.<br/>
        /// Response schema:<br/>
        /// ```<br/>
        /// {<br/>
        ///     "alerting": _alerting,<br/>
        ///     "litellm.callbacks": litellm_callbacks,<br/>
        ///     "litellm.input_callback": litellm_input_callbacks,<br/>
        ///     "litellm.failure_callback": litellm_failure_callbacks,<br/>
        ///     "litellm.success_callback": litellm_success_callbacks,<br/>
        ///     "litellm._async_success_callback": litellm_async_success_callbacks,<br/>
        ///     "litellm._async_failure_callback": litellm_async_failure_callbacks,<br/>
        ///     "litellm._async_input_callback": litellm_async_input_callbacks,<br/>
        ///     "all_litellm_callbacks": all_litellm_callbacks,<br/>
        ///     "num_callbacks": len(all_litellm_callbacks),<br/>
        ///     "num_alerting": _num_alerting,<br/>
        ///     "litellm.request_timeout": litellm.request_timeout,<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActiveCallbacksActiveCallbacksGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Active Callbacks<br/>
        /// Returns a list of litellm level settings<br/>
        /// This is useful for debugging and ensuring the proxy server is configured correctly.<br/>
        /// Response schema:<br/>
        /// ```<br/>
        /// {<br/>
        ///     "alerting": _alerting,<br/>
        ///     "litellm.callbacks": litellm_callbacks,<br/>
        ///     "litellm.input_callback": litellm_input_callbacks,<br/>
        ///     "litellm.failure_callback": litellm_failure_callbacks,<br/>
        ///     "litellm.success_callback": litellm_success_callbacks,<br/>
        ///     "litellm._async_success_callback": litellm_async_success_callbacks,<br/>
        ///     "litellm._async_failure_callback": litellm_async_failure_callbacks,<br/>
        ///     "litellm._async_input_callback": litellm_async_input_callbacks,<br/>
        ///     "all_litellm_callbacks": all_litellm_callbacks,<br/>
        ///     "num_callbacks": len(all_litellm_callbacks),<br/>
        ///     "num_alerting": _num_alerting,<br/>
        ///     "litellm.request_timeout": litellm.request_timeout,<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ActiveCallbacksActiveCallbacksGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpDiscoverableClient
    {
        /// <summary>
        /// Callback<br/>
        /// OAuth 2.0 authorization response handler for MCP loopback clients.<br/>
        /// Accepts either:<br/>
        /// - A successful authorization response (``code`` + ``state``), which is<br/>
        ///   forwarded back to the validated client ``redirect_uri`` with the<br/>
        ///   original (un-wrapped) ``state``.<br/>
        /// - An error response (``error``[+``error_description``/``error_uri``]), per<br/>
        ///   RFC 6749 §4.1.2.1. When ``state`` is present and decodes to a trusted<br/>
        ///   ``redirect_uri``, the error params are propagated back to the client so<br/>
        ///   its OAuth library can surface them. Otherwise we render an HTML error<br/>
        ///   page so the user is not left on an opaque 422 / blank screen.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
        /// <param name="errorUri"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CallbackCallbackGetAsync(
            string? code = default,
            string? state = default,
            string? error = default,
            string? errorDescription = default,
            string? errorUri = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Callback<br/>
        /// OAuth 2.0 authorization response handler for MCP loopback clients.<br/>
        /// Accepts either:<br/>
        /// - A successful authorization response (``code`` + ``state``), which is<br/>
        ///   forwarded back to the validated client ``redirect_uri`` with the<br/>
        ///   original (un-wrapped) ``state``.<br/>
        /// - An error response (``error``[+``error_description``/``error_uri``]), per<br/>
        ///   RFC 6749 §4.1.2.1. When ``state`` is present and decodes to a trusted<br/>
        ///   ``redirect_uri``, the error params are propagated back to the client so<br/>
        ///   its OAuth library can surface them. Otherwise we render an HTML error<br/>
        ///   page so the user is not left on an opaque 422 / blank screen.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
        /// <param name="errorUri"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CallbackCallbackGetAsResponseAsync(
            string? code = default,
            string? state = default,
            string? error = default,
            string? errorDescription = default,
            string? errorUri = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
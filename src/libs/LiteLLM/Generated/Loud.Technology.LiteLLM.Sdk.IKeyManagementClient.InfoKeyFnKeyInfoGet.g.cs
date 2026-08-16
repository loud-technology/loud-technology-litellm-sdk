#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Info Key Fn<br/>
        /// Retrieve information about a key.<br/>
        /// Parameters:<br/>
        ///     key: Optional[str] = Query parameter representing the key in the request<br/>
        ///     user_api_key_dict: UserAPIKeyAuth = Dependency representing the user's API key<br/>
        /// Returns:<br/>
        ///     Dict containing the key and its associated information<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info?key=sk-test-example-key-123" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Curl - if no key is passed, it will use the Key Passed in Authorization Header<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info" -H "Authorization: Bearer sk-test-example-key-123"<br/>
        /// ```
        /// </summary>
        /// <param name="key">
        /// Key in the request parameters
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InfoKeyFnKeyInfoGetAsync(
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info Key Fn<br/>
        /// Retrieve information about a key.<br/>
        /// Parameters:<br/>
        ///     key: Optional[str] = Query parameter representing the key in the request<br/>
        ///     user_api_key_dict: UserAPIKeyAuth = Dependency representing the user's API key<br/>
        /// Returns:<br/>
        ///     Dict containing the key and its associated information<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info?key=sk-test-example-key-123" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Curl - if no key is passed, it will use the Key Passed in Authorization Header<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info" -H "Authorization: Bearer sk-test-example-key-123"<br/>
        /// ```
        /// </summary>
        /// <param name="key">
        /// Key in the request parameters
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> InfoKeyFnKeyInfoGetAsResponseAsync(
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
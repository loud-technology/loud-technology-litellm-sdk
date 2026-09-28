#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Key Health<br/>
        /// Check the health of the key<br/>
        /// Checks:<br/>
        /// - If key based logging is configured correctly - sends a test log<br/>
        /// Usage <br/>
        /// Pass the key in the request header<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/key/health"      -H "Authorization: Bearer sk-1234"      -H "Content-Type: application/json"<br/>
        /// ```<br/>
        /// Response when logging callbacks are setup correctly:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "key": "healthy",<br/>
        ///   "logging_callbacks": {<br/>
        ///     "callbacks": [<br/>
        ///       "gcs_bucket"<br/>
        ///     ],<br/>
        ///     "status": "healthy",<br/>
        ///     "details": "No logger exceptions triggered, system is healthy. Manually check if logs were sent to ['gcs_bucket']"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Response when logging callbacks are not setup correctly:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "key": "unhealthy",<br/>
        ///   "logging_callbacks": {<br/>
        ///     "callbacks": [<br/>
        ///       "gcs_bucket"<br/>
        ///     ],<br/>
        ///     "status": "unhealthy",<br/>
        ///     "details": "Logger exceptions triggered, system is unhealthy: Failed to load vertex credentials. Check to see if credentials containing partial/invalid information."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.KeyHealthResponse> KeyHealthKeyHealthPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Key Health<br/>
        /// Check the health of the key<br/>
        /// Checks:<br/>
        /// - If key based logging is configured correctly - sends a test log<br/>
        /// Usage <br/>
        /// Pass the key in the request header<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/key/health"      -H "Authorization: Bearer sk-1234"      -H "Content-Type: application/json"<br/>
        /// ```<br/>
        /// Response when logging callbacks are setup correctly:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "key": "healthy",<br/>
        ///   "logging_callbacks": {<br/>
        ///     "callbacks": [<br/>
        ///       "gcs_bucket"<br/>
        ///     ],<br/>
        ///     "status": "healthy",<br/>
        ///     "details": "No logger exceptions triggered, system is healthy. Manually check if logs were sent to ['gcs_bucket']"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Response when logging callbacks are not setup correctly:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "key": "unhealthy",<br/>
        ///   "logging_callbacks": {<br/>
        ///     "callbacks": [<br/>
        ///       "gcs_bucket"<br/>
        ///     ],<br/>
        ///     "status": "unhealthy",<br/>
        ///     "details": "Logger exceptions triggered, system is unhealthy: Failed to load vertex credentials. Check to see if credentials containing partial/invalid information."<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.KeyHealthResponse>> KeyHealthKeyHealthPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
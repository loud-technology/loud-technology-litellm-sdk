#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISearchToolsClient
    {
        /// <summary>
        /// Test Search Tool Connection<br/>
        /// Test connection to a search provider with the given configuration.<br/>
        /// Makes a simple test search query to verify the API key and configuration are valid.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/search_tools/test_connection" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "litellm_params": {<br/>
        ///             "search_provider": "perplexity",<br/>
        ///             "api_key": "sk-..."<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response (Success):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "status": "success",<br/>
        ///     "message": "Successfully connected to perplexity search provider",<br/>
        ///     "test_query": "test",<br/>
        ///     "results_count": 5<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Response (Failure):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "status": "error",<br/>
        ///     "message": "Authentication failed: Invalid API key",<br/>
        ///     "error_type": "AuthenticationError"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestSearchToolConnectionSearchToolsTestConnectionPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TestSearchToolConnectionRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Search Tool Connection<br/>
        /// Test connection to a search provider with the given configuration.<br/>
        /// Makes a simple test search query to verify the API key and configuration are valid.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/search_tools/test_connection" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "litellm_params": {<br/>
        ///             "search_provider": "perplexity",<br/>
        ///             "api_key": "sk-..."<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response (Success):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "status": "success",<br/>
        ///     "message": "Successfully connected to perplexity search provider",<br/>
        ///     "test_query": "test",<br/>
        ///     "results_count": 5<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Response (Failure):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "status": "error",<br/>
        ///     "message": "Authentication failed: Invalid API key",<br/>
        ///     "error_type": "AuthenticationError"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestSearchToolConnectionSearchToolsTestConnectionPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TestSearchToolConnectionRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Search Tool Connection<br/>
        /// Test connection to a search provider with the given configuration.<br/>
        /// Makes a simple test search query to verify the API key and configuration are valid.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/search_tools/test_connection" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "litellm_params": {<br/>
        ///             "search_provider": "perplexity",<br/>
        ///             "api_key": "sk-..."<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response (Success):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "status": "success",<br/>
        ///     "message": "Successfully connected to perplexity search provider",<br/>
        ///     "test_query": "test",<br/>
        ///     "results_count": 5<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Response (Failure):<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "status": "error",<br/>
        ///     "message": "Authentication failed: Invalid API key",<br/>
        ///     "error_type": "AuthenticationError"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="litellmParams"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TestSearchToolConnectionSearchToolsTestConnectionPostAsync(
            object litellmParams,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISearchToolsClient
    {
        /// <summary>
        /// Get Search Tool Info<br/>
        /// Get detailed information about a specific search tool by ID.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/search_tools/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "search_tool_name": "litellm-search",<br/>
        ///     "litellm_params": {<br/>
        ///         "search_provider": "perplexity",<br/>
        ///         "api_key": "sk-***"<br/>
        ///     },<br/>
        ///     "search_tool_info": {<br/>
        ///         "description": "Perplexity search tool"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSearchToolInfoSearchToolsSearchToolIdGetAsync(
            string searchToolId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Search Tool Info<br/>
        /// Get detailed information about a specific search tool by ID.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/search_tools/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "search_tool_name": "litellm-search",<br/>
        ///     "litellm_params": {<br/>
        ///         "search_provider": "perplexity",<br/>
        ///         "api_key": "sk-***"<br/>
        ///     },<br/>
        ///     "search_tool_info": {<br/>
        ///         "description": "Perplexity search tool"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetSearchToolInfoSearchToolsSearchToolIdGetAsResponseAsync(
            string searchToolId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
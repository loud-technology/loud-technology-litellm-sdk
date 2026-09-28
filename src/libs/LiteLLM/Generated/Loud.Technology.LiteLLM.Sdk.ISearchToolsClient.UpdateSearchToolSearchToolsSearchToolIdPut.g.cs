#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISearchToolsClient
    {
        /// <summary>
        /// Update Search Tool<br/>
        /// Update an existing search tool.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/search_tools/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "search_tool": {<br/>
        ///             "search_tool_name": "updated-search",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "perplexity",<br/>
        ///                 "api_key": "sk-new-key"<br/>
        ///             },<br/>
        ///             "search_tool_info": {<br/>
        ///                 "description": "Updated search tool"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "search_tool_name": "updated-search",<br/>
        ///     "litellm_params": {<br/>
        ///         "search_provider": "perplexity",<br/>
        ///         "api_key": "sk-new-key"<br/>
        ///     },<br/>
        ///     "search_tool_info": {<br/>
        ///         "description": "Updated search tool"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T13:45:12.345Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateSearchToolSearchToolsSearchToolIdPutAsync(
            string searchToolId,

            global::Loud.Technology.LiteLLM.Sdk.UpdateSearchToolRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Search Tool<br/>
        /// Update an existing search tool.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/search_tools/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "search_tool": {<br/>
        ///             "search_tool_name": "updated-search",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "perplexity",<br/>
        ///                 "api_key": "sk-new-key"<br/>
        ///             },<br/>
        ///             "search_tool_info": {<br/>
        ///                 "description": "Updated search tool"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "search_tool_name": "updated-search",<br/>
        ///     "litellm_params": {<br/>
        ///         "search_provider": "perplexity",<br/>
        ///         "api_key": "sk-new-key"<br/>
        ///     },<br/>
        ///     "search_tool_info": {<br/>
        ///         "description": "Updated search tool"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T13:45:12.345Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateSearchToolSearchToolsSearchToolIdPutAsResponseAsync(
            string searchToolId,

            global::Loud.Technology.LiteLLM.Sdk.UpdateSearchToolRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Search Tool<br/>
        /// Update an existing search tool.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/search_tools/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "search_tool": {<br/>
        ///             "search_tool_name": "updated-search",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "perplexity",<br/>
        ///                 "api_key": "sk-new-key"<br/>
        ///             },<br/>
        ///             "search_tool_info": {<br/>
        ///                 "description": "Updated search tool"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "search_tool_name": "updated-search",<br/>
        ///     "litellm_params": {<br/>
        ///         "search_provider": "perplexity",<br/>
        ///         "api_key": "sk-new-key"<br/>
        ///     },<br/>
        ///     "search_tool_info": {<br/>
        ///         "description": "Updated search tool"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T13:45:12.345Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolId"></param>
        /// <param name="searchTool">
        /// Search tool configuration.<br/>
        /// Example:<br/>
        ///     {<br/>
        ///         "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///         "search_tool_name": "litellm-search",<br/>
        ///         "litellm_params": {<br/>
        ///             "search_provider": "perplexity",<br/>
        ///             "api_key": "sk-..."<br/>
        ///         },<br/>
        ///         "search_tool_info": {<br/>
        ///             "description": "Perplexity search tool"<br/>
        ///         }<br/>
        ///     }
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateSearchToolSearchToolsSearchToolIdPutAsync(
            string searchToolId,
            global::Loud.Technology.LiteLLM.Sdk.SearchTool searchTool,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
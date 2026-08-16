#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISearchToolsClient
    {
        /// <summary>
        /// List Search Tools<br/>
        /// List all search tools that are available in the database and config file.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/search_tools/list" -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tools": [<br/>
        ///         {<br/>
        ///             "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///             "search_tool_name": "litellm-search",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "perplexity",<br/>
        ///                 "api_key": "sk-***",<br/>
        ///                 "api_base": "https://api.perplexity.ai"<br/>
        ///             },<br/>
        ///             "search_tool_info": {<br/>
        ///                 "description": "Perplexity search tool"<br/>
        ///             },<br/>
        ///             "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///             "updated_at": "2023-11-09T12:34:56.789Z",<br/>
        ///             "is_from_config": false<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "search_tool_name": "config-search-tool",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "tavily",<br/>
        ///                 "api_key": "tvly-***"<br/>
        ///             },<br/>
        ///             "is_from_config": true<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListSearchToolsResponse> ListSearchToolsSearchToolsListGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Search Tools<br/>
        /// List all search tools that are available in the database and config file.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/search_tools/list" -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "search_tools": [<br/>
        ///         {<br/>
        ///             "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///             "search_tool_name": "litellm-search",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "perplexity",<br/>
        ///                 "api_key": "sk-***",<br/>
        ///                 "api_base": "https://api.perplexity.ai"<br/>
        ///             },<br/>
        ///             "search_tool_info": {<br/>
        ///                 "description": "Perplexity search tool"<br/>
        ///             },<br/>
        ///             "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///             "updated_at": "2023-11-09T12:34:56.789Z",<br/>
        ///             "is_from_config": false<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "search_tool_name": "config-search-tool",<br/>
        ///             "litellm_params": {<br/>
        ///                 "search_provider": "tavily",<br/>
        ///                 "api_key": "tvly-***"<br/>
        ///             },<br/>
        ///             "is_from_config": true<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListSearchToolsResponse>> ListSearchToolsSearchToolsListGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
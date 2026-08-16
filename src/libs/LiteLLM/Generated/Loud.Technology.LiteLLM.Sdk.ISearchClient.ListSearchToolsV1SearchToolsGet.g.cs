#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// List Search Tools<br/>
        /// List all available search tools configured in the router.<br/>
        /// This endpoint returns the search tools that are currently loaded and available<br/>
        /// for use with the /v1/search endpoint.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v1/search/tools"         -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "object": "list",<br/>
        ///     "data": [<br/>
        ///         {<br/>
        ///             "search_tool_name": "litellm-search",<br/>
        ///             "search_provider": "perplexity",<br/>
        ///             "description": "Perplexity search tool"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListSearchToolsV1SearchToolsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Search Tools<br/>
        /// List all available search tools configured in the router.<br/>
        /// This endpoint returns the search tools that are currently loaded and available<br/>
        /// for use with the /v1/search endpoint.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v1/search/tools"         -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "object": "list",<br/>
        ///     "data": [<br/>
        ///         {<br/>
        ///             "search_tool_name": "litellm-search",<br/>
        ///             "search_provider": "perplexity",<br/>
        ///             "description": "Perplexity search tool"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListSearchToolsV1SearchToolsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search<br/>
        /// Search endpoint for performing web searches.<br/>
        /// Follows the Perplexity Search API spec:<br/>
        /// https://docs.perplexity.ai/api-reference/search-post<br/>
        /// The search_tool_name can be passed either:<br/>
        /// 1. In the URL path: /v1/search/{search_tool_name}<br/>
        /// 2. In the request body: {"search_tool_name": "..."}<br/>
        /// Example with search_tool_name in URL (recommended - keeps body Perplexity-compatible):<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/search/litellm-search"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "query": "latest AI developments 2024",<br/>
        ///         "max_results": 5,<br/>
        ///         "search_domain_filter": ["arxiv.org", "nature.com"],<br/>
        ///         "country": "US"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example with search_tool_name in body:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/search"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "search_tool_name": "litellm-search",<br/>
        ///         "query": "latest AI developments 2024",<br/>
        ///         "max_results": 5,<br/>
        ///         "search_domain_filter": ["arxiv.org", "nature.com"],<br/>
        ///         "country": "US"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Request Body Parameters (when search_tool_name not in URL):<br/>
        /// - search_tool_name (str, required if not in URL): Name of the search tool configured in router<br/>
        /// - query (str or list[str], required): Search query<br/>
        /// - max_results (int, optional): Maximum number of results (1-20), default 10<br/>
        /// - search_domain_filter (list[str], optional): List of domains to filter (max 20)<br/>
        /// - max_tokens_per_page (int, optional): Max tokens per page, default 1024<br/>
        /// - country (str, optional): Country code filter (e.g., 'US', 'GB', 'DE')<br/>
        /// When using URL path parameter, only Perplexity-compatible parameters are needed in body:<br/>
        /// - query (str or list[str], required): Search query<br/>
        /// - max_results (int, optional): Maximum number of results (1-20), default 10<br/>
        /// - search_domain_filter (list[str], optional): List of domains to filter (max 20)<br/>
        /// - max_tokens_per_page (int, optional): Max tokens per page, default 1024<br/>
        /// - country (str, optional): Country code filter (e.g., 'US', 'GB', 'DE')<br/>
        /// Response follows Perplexity Search API format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "object": "search",<br/>
        ///     "results": [<br/>
        ///         {<br/>
        ///             "title": "Result title",<br/>
        ///             "url": "https://example.com",<br/>
        ///             "snippet": "Result snippet...",<br/>
        ///             "date": "2024-01-01",<br/>
        ///             "last_updated": "2024-01-01"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SearchSearchSearchToolNamePostAsync(
            string? searchToolName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search<br/>
        /// Search endpoint for performing web searches.<br/>
        /// Follows the Perplexity Search API spec:<br/>
        /// https://docs.perplexity.ai/api-reference/search-post<br/>
        /// The search_tool_name can be passed either:<br/>
        /// 1. In the URL path: /v1/search/{search_tool_name}<br/>
        /// 2. In the request body: {"search_tool_name": "..."}<br/>
        /// Example with search_tool_name in URL (recommended - keeps body Perplexity-compatible):<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/search/litellm-search"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "query": "latest AI developments 2024",<br/>
        ///         "max_results": 5,<br/>
        ///         "search_domain_filter": ["arxiv.org", "nature.com"],<br/>
        ///         "country": "US"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example with search_tool_name in body:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/search"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "search_tool_name": "litellm-search",<br/>
        ///         "query": "latest AI developments 2024",<br/>
        ///         "max_results": 5,<br/>
        ///         "search_domain_filter": ["arxiv.org", "nature.com"],<br/>
        ///         "country": "US"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Request Body Parameters (when search_tool_name not in URL):<br/>
        /// - search_tool_name (str, required if not in URL): Name of the search tool configured in router<br/>
        /// - query (str or list[str], required): Search query<br/>
        /// - max_results (int, optional): Maximum number of results (1-20), default 10<br/>
        /// - search_domain_filter (list[str], optional): List of domains to filter (max 20)<br/>
        /// - max_tokens_per_page (int, optional): Max tokens per page, default 1024<br/>
        /// - country (str, optional): Country code filter (e.g., 'US', 'GB', 'DE')<br/>
        /// When using URL path parameter, only Perplexity-compatible parameters are needed in body:<br/>
        /// - query (str or list[str], required): Search query<br/>
        /// - max_results (int, optional): Maximum number of results (1-20), default 10<br/>
        /// - search_domain_filter (list[str], optional): List of domains to filter (max 20)<br/>
        /// - max_tokens_per_page (int, optional): Max tokens per page, default 1024<br/>
        /// - country (str, optional): Country code filter (e.g., 'US', 'GB', 'DE')<br/>
        /// Response follows Perplexity Search API format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "object": "search",<br/>
        ///     "results": [<br/>
        ///         {<br/>
        ///             "title": "Result title",<br/>
        ///             "url": "https://example.com",<br/>
        ///             "snippet": "Result snippet...",<br/>
        ///             "date": "2024-01-01",<br/>
        ///             "last_updated": "2024-01-01"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> SearchSearchSearchToolNamePostAsResponseAsync(
            string? searchToolName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISearchToolsClient
    {
        /// <summary>
        /// Delete Search Tool<br/>
        /// Delete a search tool.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/search_tools/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "message": "Search tool 123e4567-e89b-12d3-a456-426614174000 deleted successfully",<br/>
        ///     "search_tool_name": "litellm-search"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteSearchToolSearchToolsSearchToolIdDeleteAsync(
            string searchToolId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Search Tool<br/>
        /// Delete a search tool.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/search_tools/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "message": "Search tool 123e4567-e89b-12d3-a456-426614174000 deleted successfully",<br/>
        ///     "search_tool_name": "litellm-search"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="searchToolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteSearchToolSearchToolsSearchToolIdDeleteAsResponseAsync(
            string searchToolId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
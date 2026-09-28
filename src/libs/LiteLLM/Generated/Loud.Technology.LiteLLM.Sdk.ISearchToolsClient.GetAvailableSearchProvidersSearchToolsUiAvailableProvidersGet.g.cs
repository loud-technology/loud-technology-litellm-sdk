#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISearchToolsClient
    {
        /// <summary>
        /// Get Available Search Providers<br/>
        /// Get the list of available search providers with their configuration fields.<br/>
        /// Auto-discovers search providers and their UI-friendly names from transformation configs.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/search_tools/ui/available_providers" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "providers": [<br/>
        ///         {<br/>
        ///             "provider_name": "perplexity",<br/>
        ///             "ui_friendly_name": "Perplexity"<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "provider_name": "tavily",<br/>
        ///             "ui_friendly_name": "Tavily"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAvailableSearchProvidersSearchToolsUiAvailableProvidersGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Available Search Providers<br/>
        /// Get the list of available search providers with their configuration fields.<br/>
        /// Auto-discovers search providers and their UI-friendly names from transformation configs.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/search_tools/ui/available_providers" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "providers": [<br/>
        ///         {<br/>
        ///             "provider_name": "perplexity",<br/>
        ///             "ui_friendly_name": "Perplexity"<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "provider_name": "tavily",<br/>
        ///             "ui_friendly_name": "Tavily"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetAvailableSearchProvidersSearchToolsUiAvailableProvidersGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
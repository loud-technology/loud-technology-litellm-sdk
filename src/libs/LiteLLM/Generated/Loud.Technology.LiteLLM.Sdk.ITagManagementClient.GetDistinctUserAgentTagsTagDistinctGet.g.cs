#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Get Distinct User Agent Tags<br/>
        /// Get all distinct user agent tags up to a maximum of {MAX_TAGS} tags.<br/>
        /// This endpoint returns all unique user agent tags found in the database,<br/>
        /// sorted by frequency of usage.<br/>
        /// Returns:<br/>
        ///     DistinctTagsResponse: List of distinct user agent tags
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.DistinctTagsResponse> GetDistinctUserAgentTagsTagDistinctGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Distinct User Agent Tags<br/>
        /// Get all distinct user agent tags up to a maximum of {MAX_TAGS} tags.<br/>
        /// This endpoint returns all unique user agent tags found in the database,<br/>
        /// sorted by frequency of usage.<br/>
        /// Returns:<br/>
        ///     DistinctTagsResponse: List of distinct user agent tags
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.DistinctTagsResponse>> GetDistinctUserAgentTagsTagDistinctGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
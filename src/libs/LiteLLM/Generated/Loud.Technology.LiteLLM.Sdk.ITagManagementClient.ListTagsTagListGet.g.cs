#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// List Tags<br/>
        /// List all available tags with their budget information.
        /// </summary>
        /// <param name="startDate">
        /// Optional start date (YYYY-MM-DD). When provided together with end_date, dynamic tags are limited to those active in the window. Stored tags are always returned.
        /// </param>
        /// <param name="endDate">
        /// Optional end date (YYYY-MM-DD). Must be given with start_date.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListTagsTagListGetAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tags<br/>
        /// List all available tags with their budget information.
        /// </summary>
        /// <param name="startDate">
        /// Optional start date (YYYY-MM-DD). When provided together with end_date, dynamic tags are limited to those active in the window. Stored tags are always returned.
        /// </param>
        /// <param name="endDate">
        /// Optional end date (YYYY-MM-DD). Must be given with start_date.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListTagsTagListGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
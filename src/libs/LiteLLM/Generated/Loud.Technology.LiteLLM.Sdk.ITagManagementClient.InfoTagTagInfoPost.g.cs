#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITagManagementClient
    {
        /// <summary>
        /// Info Tag<br/>
        /// Get information about specific tags.<br/>
        /// Parameters:<br/>
        /// - names: List[str] - List of tag names to get information for
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InfoTagTagInfoPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TagInfoRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info Tag<br/>
        /// Get information about specific tags.<br/>
        /// Parameters:<br/>
        /// - names: List[str] - List of tag names to get information for
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> InfoTagTagInfoPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TagInfoRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info Tag<br/>
        /// Get information about specific tags.<br/>
        /// Parameters:<br/>
        /// - names: List[str] - List of tag names to get information for
        /// </summary>
        /// <param name="names"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> InfoTagTagInfoPostAsync(
            global::System.Collections.Generic.IList<string> names,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
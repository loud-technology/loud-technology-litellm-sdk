#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVantageClient
    {
        /// <summary>
        /// Vantage Dry Run Export<br/>
        /// Perform a dry run export using the Vantage logger.<br/>
        /// Returns the data that would be exported without actually sending it to Vantage.<br/>
        /// Parameters:<br/>
        /// - limit: Limit on number of records to preview (default: 500)<br/>
        /// Only admin users can perform Vantage exports.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.VantageExportResponse> VantageDryRunExportVantageDryRunPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.VantageDryRunRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vantage Dry Run Export<br/>
        /// Perform a dry run export using the Vantage logger.<br/>
        /// Returns the data that would be exported without actually sending it to Vantage.<br/>
        /// Parameters:<br/>
        /// - limit: Limit on number of records to preview (default: 500)<br/>
        /// Only admin users can perform Vantage exports.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.VantageExportResponse>> VantageDryRunExportVantageDryRunPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.VantageDryRunRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Vantage Dry Run Export<br/>
        /// Perform a dry run export using the Vantage logger.<br/>
        /// Returns the data that would be exported without actually sending it to Vantage.<br/>
        /// Parameters:<br/>
        /// - limit: Limit on number of records to preview (default: 500)<br/>
        /// Only admin users can perform Vantage exports.
        /// </summary>
        /// <param name="limit">
        /// Limit on number of records to preview (default: 500)<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.VantageExportResponse> VantageDryRunExportVantageDryRunPostAsync(
            int? limit = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
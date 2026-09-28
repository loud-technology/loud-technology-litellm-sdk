#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICloudzeroClient
    {
        /// <summary>
        /// Cloudzero Dry Run Export<br/>
        /// Perform a dry run export using the CloudZero logger.<br/>
        /// This endpoint uses the CloudZero logger to perform a dry run export,<br/>
        /// which returns the data that would be exported without actually sending it to CloudZero.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to process (default: 10000)<br/>
        /// Returns:<br/>
        /// - usage_data: Sample of the raw usage data (first 50 records)<br/>
        /// - cbf_data: CloudZero CBF formatted data ready for export<br/>
        /// - summary: Statistics including total cost, tokens, and record counts<br/>
        /// Only admin users can perform CloudZero exports.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportResponse> CloudzeroDryRunExportCloudzeroDryRunPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cloudzero Dry Run Export<br/>
        /// Perform a dry run export using the CloudZero logger.<br/>
        /// This endpoint uses the CloudZero logger to perform a dry run export,<br/>
        /// which returns the data that would be exported without actually sending it to CloudZero.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to process (default: 10000)<br/>
        /// Returns:<br/>
        /// - usage_data: Sample of the raw usage data (first 50 records)<br/>
        /// - cbf_data: CloudZero CBF formatted data ready for export<br/>
        /// - summary: Statistics including total cost, tokens, and record counts<br/>
        /// Only admin users can perform CloudZero exports.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportResponse>> CloudzeroDryRunExportCloudzeroDryRunPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cloudzero Dry Run Export<br/>
        /// Perform a dry run export using the CloudZero logger.<br/>
        /// This endpoint uses the CloudZero logger to perform a dry run export,<br/>
        /// which returns the data that would be exported without actually sending it to CloudZero.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to process (default: 10000)<br/>
        /// Returns:<br/>
        /// - usage_data: Sample of the raw usage data (first 50 records)<br/>
        /// - cbf_data: CloudZero CBF formatted data ready for export<br/>
        /// - summary: Statistics including total cost, tokens, and record counts<br/>
        /// Only admin users can perform CloudZero exports.
        /// </summary>
        /// <param name="endTimeUtc">
        /// End time for data export in UTC
        /// </param>
        /// <param name="limit">
        /// Optional limit on number of records to export
        /// </param>
        /// <param name="operation">
        /// CloudZero operation type (replace_hourly or sum)<br/>
        /// Default Value: replace_hourly
        /// </param>
        /// <param name="startTimeUtc">
        /// Start time for data export in UTC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportResponse> CloudzeroDryRunExportCloudzeroDryRunPostAsync(
            global::System.DateTime? endTimeUtc = default,
            int? limit = default,
            string? operation = default,
            global::System.DateTime? startTimeUtc = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
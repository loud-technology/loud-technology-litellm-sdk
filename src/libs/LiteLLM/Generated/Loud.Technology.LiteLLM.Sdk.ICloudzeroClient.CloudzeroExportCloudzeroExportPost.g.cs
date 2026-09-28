#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICloudzeroClient
    {
        /// <summary>
        /// Cloudzero Export<br/>
        /// Perform an actual export using the CloudZero logger.<br/>
        /// This endpoint uses the CloudZero logger to export usage data to CloudZero AnyCost API.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to export<br/>
        /// - operation: CloudZero operation type ("replace_hourly" or "sum", default: "replace_hourly")<br/>
        /// Only admin users can perform CloudZero exports.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportResponse> CloudzeroExportCloudzeroExportPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cloudzero Export<br/>
        /// Perform an actual export using the CloudZero logger.<br/>
        /// This endpoint uses the CloudZero logger to export usage data to CloudZero AnyCost API.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to export<br/>
        /// - operation: CloudZero operation type ("replace_hourly" or "sum", default: "replace_hourly")<br/>
        /// Only admin users can perform CloudZero exports.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportResponse>> CloudzeroExportCloudzeroExportPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cloudzero Export<br/>
        /// Perform an actual export using the CloudZero logger.<br/>
        /// This endpoint uses the CloudZero logger to export usage data to CloudZero AnyCost API.<br/>
        /// Parameters:<br/>
        /// - limit: Optional limit on number of records to export<br/>
        /// - operation: CloudZero operation type ("replace_hourly" or "sum", default: "replace_hourly")<br/>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CloudZeroExportResponse> CloudzeroExportCloudzeroExportPostAsync(
            global::System.DateTime? endTimeUtc = default,
            int? limit = default,
            string? operation = default,
            global::System.DateTime? startTimeUtc = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for CloudZero export operations
    /// </summary>
    public sealed partial class CloudZeroExportRequest
    {
        /// <summary>
        /// End time for data export in UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_utc")]
        public global::System.DateTime? EndTimeUtc { get; set; }

        /// <summary>
        /// Optional limit on number of records to export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// CloudZero operation type (replace_hourly or sum)<br/>
        /// Default Value: replace_hourly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public string? Operation { get; set; }

        /// <summary>
        /// Start time for data export in UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_utc")]
        public global::System.DateTime? StartTimeUtc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroExportRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudZeroExportRequest(
            global::System.DateTime? endTimeUtc,
            int? limit,
            string? operation,
            global::System.DateTime? startTimeUtc)
        {
            this.EndTimeUtc = endTimeUtc;
            this.Limit = limit;
            this.Operation = operation;
            this.StartTimeUtc = startTimeUtc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroExportRequest" /> class.
        /// </summary>
        public CloudZeroExportRequest()
        {
        }

    }
}
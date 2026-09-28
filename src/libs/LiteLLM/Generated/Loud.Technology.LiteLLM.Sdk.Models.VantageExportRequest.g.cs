
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for Vantage export operations (actual export, no default limit)
    /// </summary>
    public sealed partial class VantageExportRequest
    {
        /// <summary>
        /// End time for data export in UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_utc")]
        public global::System.DateTime? EndTimeUtc { get; set; }

        /// <summary>
        /// Optional limit on number of records to export (default: no limit)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

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
        /// Initializes a new instance of the <see cref="VantageExportRequest" /> class.
        /// </summary>
        /// <param name="endTimeUtc">
        /// End time for data export in UTC
        /// </param>
        /// <param name="limit">
        /// Optional limit on number of records to export (default: no limit)
        /// </param>
        /// <param name="startTimeUtc">
        /// Start time for data export in UTC
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VantageExportRequest(
            global::System.DateTime? endTimeUtc,
            int? limit,
            global::System.DateTime? startTimeUtc)
        {
            this.EndTimeUtc = endTimeUtc;
            this.Limit = limit;
            this.StartTimeUtc = startTimeUtc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageExportRequest" /> class.
        /// </summary>
        public VantageExportRequest()
        {
        }

    }
}
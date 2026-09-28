
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for CloudZero export operations
    /// </summary>
    public sealed partial class CloudZeroExportResponse
    {
        /// <summary>
        /// Dry run data including usage data and CBF transformed data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run_data")]
        public object? DryRunData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records_exported")]
        public int? RecordsExported { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Summary statistics for dry run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public object? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroExportResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="status"></param>
        /// <param name="dryRunData">
        /// Dry run data including usage data and CBF transformed data
        /// </param>
        /// <param name="recordsExported"></param>
        /// <param name="summary">
        /// Summary statistics for dry run
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudZeroExportResponse(
            string message,
            string status,
            object? dryRunData,
            int? recordsExported,
            object? summary)
        {
            this.DryRunData = dryRunData;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RecordsExported = recordsExported;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroExportResponse" /> class.
        /// </summary>
        public CloudZeroExportResponse()
        {
        }

    }
}
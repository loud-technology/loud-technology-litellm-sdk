
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for Vantage export operations
    /// </summary>
    public sealed partial class VantageExportResponse
    {
        /// <summary>
        /// Dry run data including usage data and FOCUS transformed data
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
        /// Initializes a new instance of the <see cref="VantageExportResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="status"></param>
        /// <param name="dryRunData">
        /// Dry run data including usage data and FOCUS transformed data
        /// </param>
        /// <param name="summary">
        /// Summary statistics for dry run
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VantageExportResponse(
            string message,
            string status,
            object? dryRunData,
            object? summary)
        {
            this.DryRunData = dryRunData;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageExportResponse" /> class.
        /// </summary>
        public VantageExportResponse()
        {
        }

    }
}
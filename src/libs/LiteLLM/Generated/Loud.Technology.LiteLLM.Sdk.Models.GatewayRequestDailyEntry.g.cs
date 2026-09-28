
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GatewayRequestDailyEntry
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_requests")]
        public int? SuccessfulRequests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_requests")]
        public int? FailedRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayRequestDailyEntry" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="successfulRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="failedRequests">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayRequestDailyEntry(
            string date,
            int? successfulRequests,
            int? failedRequests)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.SuccessfulRequests = successfulRequests;
            this.FailedRequests = failedRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayRequestDailyEntry" /> class.
        /// </summary>
        public GatewayRequestDailyEntry()
        {
        }

    }
}
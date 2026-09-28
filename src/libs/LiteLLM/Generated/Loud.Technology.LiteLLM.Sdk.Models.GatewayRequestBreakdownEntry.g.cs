
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GatewayRequestBreakdownEntry
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Route { get; set; }

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
        /// Initializes a new instance of the <see cref="GatewayRequestBreakdownEntry" /> class.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="route"></param>
        /// <param name="successfulRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="failedRequests">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayRequestBreakdownEntry(
            string category,
            string route,
            int? successfulRequests,
            int? failedRequests)
        {
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.SuccessfulRequests = successfulRequests;
            this.FailedRequests = failedRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayRequestBreakdownEntry" /> class.
        /// </summary>
        public GatewayRequestBreakdownEntry()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for GET /gateway/daily/activity.
    /// </summary>
    public sealed partial class GatewayRequestActivityResponse
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_successful_requests")]
        public int? TotalSuccessfulRequests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_failed_requests")]
        public int? TotalFailedRequests { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_date")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GatewayRequestDailyEntry>? ByDate { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_route")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GatewayRequestBreakdownEntry>? ByRoute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayRequestActivityResponse" /> class.
        /// </summary>
        /// <param name="totalSuccessfulRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="totalFailedRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="byDate">
        /// Default Value: []
        /// </param>
        /// <param name="byRoute">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayRequestActivityResponse(
            int? totalSuccessfulRequests,
            int? totalFailedRequests,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GatewayRequestDailyEntry>? byDate,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GatewayRequestBreakdownEntry>? byRoute)
        {
            this.TotalSuccessfulRequests = totalSuccessfulRequests;
            this.TotalFailedRequests = totalFailedRequests;
            this.ByDate = byDate;
            this.ByRoute = byRoute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayRequestActivityResponse" /> class.
        /// </summary>
        public GatewayRequestActivityResponse()
        {
        }

    }
}
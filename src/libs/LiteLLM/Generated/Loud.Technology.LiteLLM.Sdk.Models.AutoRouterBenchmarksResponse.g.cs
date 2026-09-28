
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Benchmarks for the auto-router dashboard, aggregated from the per-session rollup.
    /// </summary>
    public sealed partial class AutoRouterBenchmarksResponse
    {
        /// <summary>
        /// Window start day, YYYY-MM-DD UTC, inclusive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDate { get; set; }

        /// <summary>
        /// Window end day, YYYY-MM-DD UTC, inclusive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDate { get; set; }

        /// <summary>
        /// How many groups this response carries. Every auto-router configured on the proxy counts, whether or not it served anything in the window. To count only the routers that did serve traffic, filter `groups` to the entries whose `sessions` is above zero
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routers_in_scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RoutersInScope { get; set; }

        /// <summary>
        /// Session-shape and savings aggregates over auto-routed traffic in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AutoRouterBenchmarkTotals Totals { get; set; }

        /// <summary>
        /// One entry per auto-router, listed from the model registry rather than from the rollup, so a router appears as soon as it is configured and reads zero until it serves traffic. Semantic auto-routers are absent: they record no routing decision, so no session can ever be attributed to them
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AutoRouterBenchmarkGroup> Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterBenchmarksResponse" /> class.
        /// </summary>
        /// <param name="startDate">
        /// Window start day, YYYY-MM-DD UTC, inclusive
        /// </param>
        /// <param name="endDate">
        /// Window end day, YYYY-MM-DD UTC, inclusive
        /// </param>
        /// <param name="routersInScope">
        /// How many groups this response carries. Every auto-router configured on the proxy counts, whether or not it served anything in the window. To count only the routers that did serve traffic, filter `groups` to the entries whose `sessions` is above zero
        /// </param>
        /// <param name="totals">
        /// Session-shape and savings aggregates over auto-routed traffic in the window.
        /// </param>
        /// <param name="groups">
        /// One entry per auto-router, listed from the model registry rather than from the rollup, so a router appears as soon as it is configured and reads zero until it serves traffic. Semantic auto-routers are absent: they record no routing decision, so no session can ever be attributed to them
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterBenchmarksResponse(
            string startDate,
            string endDate,
            int routersInScope,
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterBenchmarkTotals totals,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AutoRouterBenchmarkGroup> groups)
        {
            this.StartDate = startDate ?? throw new global::System.ArgumentNullException(nameof(startDate));
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.RoutersInScope = routersInScope;
            this.Totals = totals ?? throw new global::System.ArgumentNullException(nameof(totals));
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterBenchmarksResponse" /> class.
        /// </summary>
        public AutoRouterBenchmarksResponse()
        {
        }

    }
}
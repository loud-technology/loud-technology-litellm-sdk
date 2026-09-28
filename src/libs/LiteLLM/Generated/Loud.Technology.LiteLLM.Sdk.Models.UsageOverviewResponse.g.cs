
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageOverviewResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UsageChartPoint> Chart { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PassRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UsageOverviewRow> Rows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBlocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalBlocked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUntrackedUsageUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> TotalUntrackedUsageUnits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUsageUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> TotalUsageUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOverviewResponse" /> class.
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="passRate"></param>
        /// <param name="rows"></param>
        /// <param name="totalBlocked"></param>
        /// <param name="totalRequests"></param>
        /// <param name="totalUntrackedUsageUnits"></param>
        /// <param name="totalUsageUnits"></param>
        /// <param name="totalCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageOverviewResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UsageChartPoint> chart,
            double passRate,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UsageOverviewRow> rows,
            int totalBlocked,
            int totalRequests,
            global::System.Collections.Generic.Dictionary<string, int> totalUntrackedUsageUnits,
            global::System.Collections.Generic.Dictionary<string, int> totalUsageUnits,
            double? totalCost)
        {
            this.Chart = chart ?? throw new global::System.ArgumentNullException(nameof(chart));
            this.PassRate = passRate;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.TotalBlocked = totalBlocked;
            this.TotalCost = totalCost;
            this.TotalRequests = totalRequests;
            this.TotalUntrackedUsageUnits = totalUntrackedUsageUnits ?? throw new global::System.ArgumentNullException(nameof(totalUntrackedUsageUnits));
            this.TotalUsageUnits = totalUsageUnits ?? throw new global::System.ArgumentNullException(nameof(totalUsageUnits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOverviewResponse" /> class.
        /// </summary>
        public UsageOverviewResponse()
        {
        }

    }
}
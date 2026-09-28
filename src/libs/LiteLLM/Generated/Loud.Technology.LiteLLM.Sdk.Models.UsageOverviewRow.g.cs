
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageOverviewRow
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgLatency")]
        public double? AvgLatency { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgScore")]
        public double? AvgScore { get; set; }

        /// <summary>
        /// USD for the priced share of usageUnits over the window; null when no unit was priced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FailRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestsEvaluated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestsEvaluated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Trend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The share of usageUnits that cost leaves out: units recorded with no known price, per counter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("untrackedUsageUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> UntrackedUsageUnits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> UsageUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOverviewRow" /> class.
        /// </summary>
        /// <param name="failRate"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="requestsEvaluated"></param>
        /// <param name="status"></param>
        /// <param name="trend"></param>
        /// <param name="type"></param>
        /// <param name="untrackedUsageUnits">
        /// The share of usageUnits that cost leaves out: units recorded with no known price, per counter
        /// </param>
        /// <param name="usageUnits"></param>
        /// <param name="avgLatency"></param>
        /// <param name="avgScore"></param>
        /// <param name="cost">
        /// USD for the priced share of usageUnits over the window; null when no unit was priced
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageOverviewRow(
            double failRate,
            string id,
            string name,
            string provider,
            int requestsEvaluated,
            string status,
            string trend,
            string type,
            global::System.Collections.Generic.Dictionary<string, int> untrackedUsageUnits,
            global::System.Collections.Generic.Dictionary<string, int> usageUnits,
            double? avgLatency,
            double? avgScore,
            double? cost)
        {
            this.AvgLatency = avgLatency;
            this.AvgScore = avgScore;
            this.Cost = cost;
            this.FailRate = failRate;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.RequestsEvaluated = requestsEvaluated;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Trend = trend ?? throw new global::System.ArgumentNullException(nameof(trend));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UntrackedUsageUnits = untrackedUsageUnits ?? throw new global::System.ArgumentNullException(nameof(untrackedUsageUnits));
            this.UsageUnits = usageUnits ?? throw new global::System.ArgumentNullException(nameof(usageUnits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOverviewRow" /> class.
        /// </summary>
        public UsageOverviewRow()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageDetailResponse
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_by_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CostByKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_by_team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CostByTeam { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_by_unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CostByUnit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FailRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("time_series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UsageChartPoint> TimeSeries { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("untracked_usage_units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> UntrackedUsageUnits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("untracked_usage_units_by_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> UntrackedUsageUnitsByKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("untracked_usage_units_by_team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> UntrackedUsageUnitsByTeam { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> UsageUnits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_units_by_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> UsageUnitsByKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_units_by_team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> UsageUnitsByTeam { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_units_daily")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UsageUnitsDailyPoint> UsageUnitsDaily { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetailResponse" /> class.
        /// </summary>
        /// <param name="costByKey"></param>
        /// <param name="costByTeam"></param>
        /// <param name="costByUnit"></param>
        /// <param name="failRate"></param>
        /// <param name="guardrailId"></param>
        /// <param name="guardrailName"></param>
        /// <param name="provider"></param>
        /// <param name="requestsEvaluated"></param>
        /// <param name="status"></param>
        /// <param name="timeSeries"></param>
        /// <param name="trend"></param>
        /// <param name="type"></param>
        /// <param name="untrackedUsageUnits"></param>
        /// <param name="untrackedUsageUnitsByKey"></param>
        /// <param name="untrackedUsageUnitsByTeam"></param>
        /// <param name="usageUnits"></param>
        /// <param name="usageUnitsByKey"></param>
        /// <param name="usageUnitsByTeam"></param>
        /// <param name="usageUnitsDaily"></param>
        /// <param name="avgLatency"></param>
        /// <param name="avgScore"></param>
        /// <param name="cost"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageDetailResponse(
            object costByKey,
            object costByTeam,
            object costByUnit,
            double failRate,
            string guardrailId,
            string guardrailName,
            string provider,
            int requestsEvaluated,
            string status,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UsageChartPoint> timeSeries,
            string trend,
            string type,
            global::System.Collections.Generic.Dictionary<string, int> untrackedUsageUnits,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> untrackedUsageUnitsByKey,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> untrackedUsageUnitsByTeam,
            global::System.Collections.Generic.Dictionary<string, int> usageUnits,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> usageUnitsByKey,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> usageUnitsByTeam,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UsageUnitsDailyPoint> usageUnitsDaily,
            double? avgLatency,
            double? avgScore,
            double? cost,
            string? description)
        {
            this.AvgLatency = avgLatency;
            this.AvgScore = avgScore;
            this.Cost = cost;
            this.CostByKey = costByKey ?? throw new global::System.ArgumentNullException(nameof(costByKey));
            this.CostByTeam = costByTeam ?? throw new global::System.ArgumentNullException(nameof(costByTeam));
            this.CostByUnit = costByUnit ?? throw new global::System.ArgumentNullException(nameof(costByUnit));
            this.Description = description;
            this.FailRate = failRate;
            this.GuardrailId = guardrailId ?? throw new global::System.ArgumentNullException(nameof(guardrailId));
            this.GuardrailName = guardrailName ?? throw new global::System.ArgumentNullException(nameof(guardrailName));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.RequestsEvaluated = requestsEvaluated;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
            this.Trend = trend ?? throw new global::System.ArgumentNullException(nameof(trend));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UntrackedUsageUnits = untrackedUsageUnits ?? throw new global::System.ArgumentNullException(nameof(untrackedUsageUnits));
            this.UntrackedUsageUnitsByKey = untrackedUsageUnitsByKey ?? throw new global::System.ArgumentNullException(nameof(untrackedUsageUnitsByKey));
            this.UntrackedUsageUnitsByTeam = untrackedUsageUnitsByTeam ?? throw new global::System.ArgumentNullException(nameof(untrackedUsageUnitsByTeam));
            this.UsageUnits = usageUnits ?? throw new global::System.ArgumentNullException(nameof(usageUnits));
            this.UsageUnitsByKey = usageUnitsByKey ?? throw new global::System.ArgumentNullException(nameof(usageUnitsByKey));
            this.UsageUnitsByTeam = usageUnitsByTeam ?? throw new global::System.ArgumentNullException(nameof(usageUnitsByTeam));
            this.UsageUnitsDaily = usageUnitsDaily ?? throw new global::System.ArgumentNullException(nameof(usageUnitsDaily));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetailResponse" /> class.
        /// </summary>
        public UsageDetailResponse()
        {
        }

    }
}
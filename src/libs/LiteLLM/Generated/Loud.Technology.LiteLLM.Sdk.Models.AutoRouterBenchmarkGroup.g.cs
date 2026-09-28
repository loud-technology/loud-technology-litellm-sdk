
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One auto-router's slice of the benchmarks.
    /// </summary>
    public sealed partial class AutoRouterBenchmarkGroup
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sessions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Turns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_turns_per_session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTurnsPerSession { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_session_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgSessionSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_tokens_per_session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTokensPerSession { get; set; }

        /// <summary>
        /// What the routed traffic actually cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Spend { get; set; }

        /// <summary>
        /// Recorded LLM classifier cost already included in spend; null when any session turns predate subtotal recording, and zero for an empty window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_cost")]
        public double? ClassifierCost { get; set; }

        /// <summary>
        /// Turns covered by the current savings estimator; legacy estimates are excluded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("savings_estimated_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SavingsEstimatedTurns { get; set; }

        /// <summary>
        /// Actual spend, including classifier cost, for covered turns only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("savings_estimated_actual_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SavingsEstimatedActualSpend { get; set; }

        /// <summary>
        /// Signed savings for covered turns only; null when traffic has no current estimates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_spend")]
        public double? SavedSpend { get; set; }

        /// <summary>
        /// Estimated single-model cost for covered turns only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_spend")]
        public double? BaselineSpend { get; set; }

        /// <summary>
        /// Covered savings over covered baseline spend, as a percentage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_pct")]
        public double? SavedPct { get; set; }

        /// <summary>
        /// Average session savings; unavailable unless every turn is covered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_per_session")]
        public double? SavedPerSession { get; set; }

        /// <summary>
        /// Prompt-caching behaviour of auto-routed turns, bucketed by what the router did.<br/>
        /// Every in-order turn falls in exactly one bucket: the session stayed on the same model,<br/>
        /// visited a model for the first time (cold by design), or returned to a model it had<br/>
        /// already used. Out-of-order turns (cross-pod flush races) are counted but not bucketed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AutoRouterCacheStats Cache { get; set; }

        /// <summary>
        /// The auto-router alias requests were sent to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RouterName { get; set; }

        /// <summary>
        /// complexity, adaptive or quality
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RouterType { get; set; }

        /// <summary>
        /// Turns per tier, keyed by the tier name the routing decision recorded at request time (never re-derived at read time, since the tier-to-model mapping is mutable config). Tier names are scoped to this group's router_type and are not comparable across types: a complexity router reports 'SIMPLE'/'MEDIUM'/'COMPLEX'/'REASONING', a quality router reports its numeric quality tier, and an adaptive router records no tier at all. Turns no tier served (the classifier fell back to default_model) are absent rather than pooled under a sentinel key, so the values may sum to less than turns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_turns")]
        public global::System.Collections.Generic.Dictionary<string, int>? TierTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterBenchmarkGroup" /> class.
        /// </summary>
        /// <param name="sessions"></param>
        /// <param name="turns"></param>
        /// <param name="avgTurnsPerSession"></param>
        /// <param name="avgSessionSeconds"></param>
        /// <param name="avgTokensPerSession"></param>
        /// <param name="spend">
        /// What the routed traffic actually cost
        /// </param>
        /// <param name="savingsEstimatedTurns">
        /// Turns covered by the current savings estimator; legacy estimates are excluded
        /// </param>
        /// <param name="savingsEstimatedActualSpend">
        /// Actual spend, including classifier cost, for covered turns only
        /// </param>
        /// <param name="cache">
        /// Prompt-caching behaviour of auto-routed turns, bucketed by what the router did.<br/>
        /// Every in-order turn falls in exactly one bucket: the session stayed on the same model,<br/>
        /// visited a model for the first time (cold by design), or returned to a model it had<br/>
        /// already used. Out-of-order turns (cross-pod flush races) are counted but not bucketed.
        /// </param>
        /// <param name="routerName">
        /// The auto-router alias requests were sent to
        /// </param>
        /// <param name="routerType">
        /// complexity, adaptive or quality
        /// </param>
        /// <param name="classifierCost">
        /// Recorded LLM classifier cost already included in spend; null when any session turns predate subtotal recording, and zero for an empty window
        /// </param>
        /// <param name="savedSpend">
        /// Signed savings for covered turns only; null when traffic has no current estimates
        /// </param>
        /// <param name="baselineSpend">
        /// Estimated single-model cost for covered turns only
        /// </param>
        /// <param name="savedPct">
        /// Covered savings over covered baseline spend, as a percentage
        /// </param>
        /// <param name="savedPerSession">
        /// Average session savings; unavailable unless every turn is covered
        /// </param>
        /// <param name="tierTurns">
        /// Turns per tier, keyed by the tier name the routing decision recorded at request time (never re-derived at read time, since the tier-to-model mapping is mutable config). Tier names are scoped to this group's router_type and are not comparable across types: a complexity router reports 'SIMPLE'/'MEDIUM'/'COMPLEX'/'REASONING', a quality router reports its numeric quality tier, and an adaptive router records no tier at all. Turns no tier served (the classifier fell back to default_model) are absent rather than pooled under a sentinel key, so the values may sum to less than turns
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterBenchmarkGroup(
            int sessions,
            int turns,
            double avgTurnsPerSession,
            double avgSessionSeconds,
            double avgTokensPerSession,
            double spend,
            int savingsEstimatedTurns,
            double savingsEstimatedActualSpend,
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterCacheStats cache,
            string routerName,
            string routerType,
            double? classifierCost,
            double? savedSpend,
            double? baselineSpend,
            double? savedPct,
            double? savedPerSession,
            global::System.Collections.Generic.Dictionary<string, int>? tierTurns)
        {
            this.Sessions = sessions;
            this.Turns = turns;
            this.AvgTurnsPerSession = avgTurnsPerSession;
            this.AvgSessionSeconds = avgSessionSeconds;
            this.AvgTokensPerSession = avgTokensPerSession;
            this.Spend = spend;
            this.ClassifierCost = classifierCost;
            this.SavingsEstimatedTurns = savingsEstimatedTurns;
            this.SavingsEstimatedActualSpend = savingsEstimatedActualSpend;
            this.SavedSpend = savedSpend;
            this.BaselineSpend = baselineSpend;
            this.SavedPct = savedPct;
            this.SavedPerSession = savedPerSession;
            this.Cache = cache ?? throw new global::System.ArgumentNullException(nameof(cache));
            this.RouterName = routerName ?? throw new global::System.ArgumentNullException(nameof(routerName));
            this.RouterType = routerType ?? throw new global::System.ArgumentNullException(nameof(routerType));
            this.TierTurns = tierTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterBenchmarkGroup" /> class.
        /// </summary>
        public AutoRouterBenchmarkGroup()
        {
        }

    }
}
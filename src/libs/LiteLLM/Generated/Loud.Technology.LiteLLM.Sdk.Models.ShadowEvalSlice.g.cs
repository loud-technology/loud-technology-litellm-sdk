
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Judge outcomes for one slice of a job's verdicts: a router tier, one of the<br/>
    /// models that served the real arm, or one scoped target (embedded on that target's<br/>
    /// own entry, so slices never need re-joining to a target by id).
    /// </summary>
    public sealed partial class ShadowEvalSlice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Group { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TurnCount { get; set; }

        /// <summary>
        /// Share of judged turns the real arm won, meaning the response the caller actually received: the key's own model in forward mode, the router's pick in reverse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("real_win_rate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RealWinRatePct { get; set; }

        /// <summary>
        /// Share of judged turns the shadow arm won, meaning the duplicated response nobody was served: the router's pick in forward mode, baseline_model in reverse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow_win_rate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ShadowWinRatePct { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tie_rate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TieRatePct { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_judge_confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgJudgeConfidence { get; set; }

        /// <summary>
        /// USD the real arm billed on this slice's judged turns, completion plus its own routing classifier when it routed, excluding turns litellm's response cache served for free<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("real_spend")]
        public double? RealSpend { get; set; }

        /// <summary>
        /// USD the shadow arm billed on the same turns, completion plus its own routing classifier, excluding the judge and the same cache-served turns, so the two spends compare like for like<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow_spend")]
        public double? ShadowSpend { get; set; }

        /// <summary>
        /// Judged turns litellm's response cache served, excluded from both spends: an adopted router would be served by the same cache, so those turns cost the same either way<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_hit_turns")]
        public int? CacheHitTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowEvalSlice" /> class.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="turnCount"></param>
        /// <param name="realWinRatePct">
        /// Share of judged turns the real arm won, meaning the response the caller actually received: the key's own model in forward mode, the router's pick in reverse
        /// </param>
        /// <param name="shadowWinRatePct">
        /// Share of judged turns the shadow arm won, meaning the duplicated response nobody was served: the router's pick in forward mode, baseline_model in reverse
        /// </param>
        /// <param name="tieRatePct"></param>
        /// <param name="avgJudgeConfidence"></param>
        /// <param name="realSpend">
        /// USD the real arm billed on this slice's judged turns, completion plus its own routing classifier when it routed, excluding turns litellm's response cache served for free<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="shadowSpend">
        /// USD the shadow arm billed on the same turns, completion plus its own routing classifier, excluding the judge and the same cache-served turns, so the two spends compare like for like<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="cacheHitTurns">
        /// Judged turns litellm's response cache served, excluded from both spends: an adopted router would be served by the same cache, so those turns cost the same either way<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShadowEvalSlice(
            string group,
            int turnCount,
            double realWinRatePct,
            double shadowWinRatePct,
            double tieRatePct,
            double avgJudgeConfidence,
            double? realSpend,
            double? shadowSpend,
            int? cacheHitTurns)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.TurnCount = turnCount;
            this.RealWinRatePct = realWinRatePct;
            this.ShadowWinRatePct = shadowWinRatePct;
            this.TieRatePct = tieRatePct;
            this.AvgJudgeConfidence = avgJudgeConfidence;
            this.RealSpend = realSpend;
            this.ShadowSpend = shadowSpend;
            this.CacheHitTurns = cacheHitTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowEvalSlice" /> class.
        /// </summary>
        public ShadowEvalSlice()
        {
        }

    }
}
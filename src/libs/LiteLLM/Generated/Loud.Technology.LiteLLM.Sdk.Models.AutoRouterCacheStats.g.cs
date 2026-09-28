
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Prompt-caching behaviour of auto-routed turns, bucketed by what the router did.<br/>
    /// Every in-order turn falls in exactly one bucket: the session stayed on the same model,<br/>
    /// visited a model for the first time (cold by design), or returned to a model it had<br/>
    /// already used. Out-of-order turns (cross-pod flush races) are counted but not bucketed.
    /// </summary>
    public sealed partial class AutoRouterCacheStats
    {
        /// <summary>
        /// Share of turns that carried cache telemetry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CoveragePct { get; set; }

        /// <summary>
        /// All cache hits over telemetry-bearing turns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hit_rate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HitRatePct { get; set; }

        /// <summary>
        /// One prompt-caching bucket of turns, with how often those turns hit the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("same_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AutoRouterCacheBucket SameModel { get; set; }

        /// <summary>
        /// One prompt-caching bucket of turns, with how often those turns hit the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_visit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AutoRouterCacheBucket FirstVisit { get; set; }

        /// <summary>
        /// One prompt-caching bucket of turns, with how often those turns hit the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_to_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AutoRouterCacheBucket ReturnToTier { get; set; }

        /// <summary>
        /// Turns that arrived out of order and were not bucketed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unordered_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnorderedTurns { get; set; }

        /// <summary>
        /// Return-to-tier misses where the model's recorded cache TTL had lapsed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_misses_expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReturnMissesExpired { get; set; }

        /// <summary>
        /// Return-to-tier misses inside the recorded TTL: the prefix changed or the provider evicted the entry early; billing telemetry cannot distinguish the two
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_misses_within_ttl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReturnMissesWithinTtl { get; set; }

        /// <summary>
        /// Return-to-tier misses with no recorded TTL to attribute against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_misses_unknown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReturnMissesUnknown { get; set; }

        /// <summary>
        /// Turns whose cache write used the five-minute TTL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_5m_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ttl5mTurns { get; set; }

        /// <summary>
        /// Turns whose cache write used the one-hour TTL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_1h_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ttl1hTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterCacheStats" /> class.
        /// </summary>
        /// <param name="coveragePct">
        /// Share of turns that carried cache telemetry
        /// </param>
        /// <param name="hitRatePct">
        /// All cache hits over telemetry-bearing turns
        /// </param>
        /// <param name="sameModel">
        /// One prompt-caching bucket of turns, with how often those turns hit the cache.
        /// </param>
        /// <param name="firstVisit">
        /// One prompt-caching bucket of turns, with how often those turns hit the cache.
        /// </param>
        /// <param name="returnToTier">
        /// One prompt-caching bucket of turns, with how often those turns hit the cache.
        /// </param>
        /// <param name="unorderedTurns">
        /// Turns that arrived out of order and were not bucketed
        /// </param>
        /// <param name="returnMissesExpired">
        /// Return-to-tier misses where the model's recorded cache TTL had lapsed
        /// </param>
        /// <param name="returnMissesWithinTtl">
        /// Return-to-tier misses inside the recorded TTL: the prefix changed or the provider evicted the entry early; billing telemetry cannot distinguish the two
        /// </param>
        /// <param name="returnMissesUnknown">
        /// Return-to-tier misses with no recorded TTL to attribute against
        /// </param>
        /// <param name="ttl5mTurns">
        /// Turns whose cache write used the five-minute TTL
        /// </param>
        /// <param name="ttl1hTurns">
        /// Turns whose cache write used the one-hour TTL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterCacheStats(
            double coveragePct,
            double hitRatePct,
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterCacheBucket sameModel,
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterCacheBucket firstVisit,
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterCacheBucket returnToTier,
            int unorderedTurns,
            int returnMissesExpired,
            int returnMissesWithinTtl,
            int returnMissesUnknown,
            int ttl5mTurns,
            int ttl1hTurns)
        {
            this.CoveragePct = coveragePct;
            this.HitRatePct = hitRatePct;
            this.SameModel = sameModel ?? throw new global::System.ArgumentNullException(nameof(sameModel));
            this.FirstVisit = firstVisit ?? throw new global::System.ArgumentNullException(nameof(firstVisit));
            this.ReturnToTier = returnToTier ?? throw new global::System.ArgumentNullException(nameof(returnToTier));
            this.UnorderedTurns = unorderedTurns;
            this.ReturnMissesExpired = returnMissesExpired;
            this.ReturnMissesWithinTtl = returnMissesWithinTtl;
            this.ReturnMissesUnknown = returnMissesUnknown;
            this.Ttl5mTurns = ttl5mTurns;
            this.Ttl1hTurns = ttl1hTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterCacheStats" /> class.
        /// </summary>
        public AutoRouterCacheStats()
        {
        }

    }
}
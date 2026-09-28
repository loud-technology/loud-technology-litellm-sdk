
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Stratified results of a shadow-eval job's verdicts so far.
    /// </summary>
    public sealed partial class ShadowEvalResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalSlice> ByTier { get; set; }

        /// <summary>
        /// Sliced by the model that served the real arm: the keys' incumbent models in forward mode, and in reverse the models the router itself picked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_current_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalSlice> ByCurrentModel { get; set; }

        /// <summary>
        /// One slice per router arm, grouped on the router name. Every arm of a multi-router job is judged against the same real responses over the same sampled requests, so these slices compare routers head-to-head: like-for-like win rates and spends on identical traffic. Verdicts from before arm stamping existed count toward the job's own router<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_router")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalSlice>? ByRouter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_shadow_win_rate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OverallShadowWinRatePct { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_tie_rate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OverallTieRatePct { get; set; }

        /// <summary>
        /// USD the real arm billed across all judged turns, cache-served turns excluded. A judged turn is one (request, router arm) verdict, so a multi-router job counts the real response once per arm it was judged against; per-router comparisons read by_router<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampled_real_spend")]
        public double? SampledRealSpend { get; set; }

        /// <summary>
        /// USD the shadow arms billed across the same turns, judge excluded, like for like<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampled_shadow_spend")]
        public double? SampledShadowSpend { get; set; }

        /// <summary>
        /// Eligible requests the sampling dice skipped, summed over legs: the judged rows stand for judged + this many requests. None for jobs from before the funnel existed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_sampled_count")]
        public int? NotSampledCount { get; set; }

        /// <summary>
        /// Sampled requests whose shape could not be judged (tool-final turn, empty text)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unjudgeable_count")]
        public int? UnjudgeableCount { get; set; }

        /// <summary>
        /// Sampled requests dropped by the per-pod concurrency cap, so quiet periods are overweighted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shed_count")]
        public int? ShedCount { get; set; }

        /// <summary>
        /// Sampled requests the pipeline declined to spend on: no database to record into, an over-budget key or team, or the eval budget unverifiable or already reached (the in-flight burst as a job crosses max_budget lands here rather than vanishing from coverage)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withheld_count")]
        public int? WithheldCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowEvalResult" /> class.
        /// </summary>
        /// <param name="byTier"></param>
        /// <param name="byCurrentModel">
        /// Sliced by the model that served the real arm: the keys' incumbent models in forward mode, and in reverse the models the router itself picked
        /// </param>
        /// <param name="overallShadowWinRatePct"></param>
        /// <param name="overallTieRatePct"></param>
        /// <param name="byRouter">
        /// One slice per router arm, grouped on the router name. Every arm of a multi-router job is judged against the same real responses over the same sampled requests, so these slices compare routers head-to-head: like-for-like win rates and spends on identical traffic. Verdicts from before arm stamping existed count toward the job's own router<br/>
        /// Default Value: []
        /// </param>
        /// <param name="sampledRealSpend">
        /// USD the real arm billed across all judged turns, cache-served turns excluded. A judged turn is one (request, router arm) verdict, so a multi-router job counts the real response once per arm it was judged against; per-router comparisons read by_router<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="sampledShadowSpend">
        /// USD the shadow arms billed across the same turns, judge excluded, like for like<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="notSampledCount">
        /// Eligible requests the sampling dice skipped, summed over legs: the judged rows stand for judged + this many requests. None for jobs from before the funnel existed
        /// </param>
        /// <param name="unjudgeableCount">
        /// Sampled requests whose shape could not be judged (tool-final turn, empty text)
        /// </param>
        /// <param name="shedCount">
        /// Sampled requests dropped by the per-pod concurrency cap, so quiet periods are overweighted
        /// </param>
        /// <param name="withheldCount">
        /// Sampled requests the pipeline declined to spend on: no database to record into, an over-budget key or team, or the eval budget unverifiable or already reached (the in-flight burst as a job crosses max_budget lands here rather than vanishing from coverage)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShadowEvalResult(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalSlice> byTier,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalSlice> byCurrentModel,
            double overallShadowWinRatePct,
            double overallTieRatePct,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalSlice>? byRouter,
            double? sampledRealSpend,
            double? sampledShadowSpend,
            int? notSampledCount,
            int? unjudgeableCount,
            int? shedCount,
            int? withheldCount)
        {
            this.ByTier = byTier ?? throw new global::System.ArgumentNullException(nameof(byTier));
            this.ByCurrentModel = byCurrentModel ?? throw new global::System.ArgumentNullException(nameof(byCurrentModel));
            this.ByRouter = byRouter;
            this.OverallShadowWinRatePct = overallShadowWinRatePct;
            this.OverallTieRatePct = overallTieRatePct;
            this.SampledRealSpend = sampledRealSpend;
            this.SampledShadowSpend = sampledShadowSpend;
            this.NotSampledCount = notSampledCount;
            this.UnjudgeableCount = unjudgeableCount;
            this.ShedCount = shedCount;
            this.WithheldCount = withheldCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowEvalResult" /> class.
        /// </summary>
        public ShadowEvalResult()
        {
        }

    }
}
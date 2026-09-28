
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One auto-routed session as its own key sees it: what the last turn ran on, and what the session cost<br/>
    /// against the router's savings baseline (the priciest model in its hardest tier).
    /// </summary>
    public sealed partial class AutoRouterSessionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The auto-router alias the session's requests were sent to
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
        /// Auto-routed turns the rollup has recorded for this session so far
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Turns { get; set; }

        /// <summary>
        /// The deployment model the most recent turn was routed to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastModel { get; set; }

        /// <summary>
        /// What the session's routed traffic actually cost, classifier calls included
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Spend { get; set; }

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
        /// Estimated savings for covered turns only, net of classifier cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_spend")]
        public double? SavedSpend { get; set; }

        /// <summary>
        /// Estimated single-model cost; unavailable unless every turn is covered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_spend")]
        public double? BaselineSpend { get; set; }

        /// <summary>
        /// Estimated single-model cost for covered turns only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("savings_estimated_baseline_spend")]
        public double? SavingsEstimatedBaselineSpend { get; set; }

        /// <summary>
        /// The savings baseline most covered turns were priced against, recorded turn by turn, so it still names the counterfactual after the router is reconfigured or removed. None when no turn recorded one: rows from before the baseline was recorded, and adaptive and quality routers, which derive no baseline and so report no savings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_model")]
        public string? BaselineModel { get; set; }

        /// <summary>
        /// Covered turns priced against each baseline model; more than one entry means the router's baseline changed mid-session and baseline_spend mixes both
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> BaselineModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="routerName">
        /// The auto-router alias the session's requests were sent to
        /// </param>
        /// <param name="routerType">
        /// complexity, adaptive or quality
        /// </param>
        /// <param name="turns">
        /// Auto-routed turns the rollup has recorded for this session so far
        /// </param>
        /// <param name="lastModel">
        /// The deployment model the most recent turn was routed to
        /// </param>
        /// <param name="spend">
        /// What the session's routed traffic actually cost, classifier calls included
        /// </param>
        /// <param name="savingsEstimatedTurns">
        /// Turns covered by the current savings estimator; legacy estimates are excluded
        /// </param>
        /// <param name="savingsEstimatedActualSpend">
        /// Actual spend, including classifier cost, for covered turns only
        /// </param>
        /// <param name="baselineModels">
        /// Covered turns priced against each baseline model; more than one entry means the router's baseline changed mid-session and baseline_spend mixes both
        /// </param>
        /// <param name="savedSpend">
        /// Estimated savings for covered turns only, net of classifier cost
        /// </param>
        /// <param name="baselineSpend">
        /// Estimated single-model cost; unavailable unless every turn is covered
        /// </param>
        /// <param name="savingsEstimatedBaselineSpend">
        /// Estimated single-model cost for covered turns only
        /// </param>
        /// <param name="baselineModel">
        /// The savings baseline most covered turns were priced against, recorded turn by turn, so it still names the counterfactual after the router is reconfigured or removed. None when no turn recorded one: rows from before the baseline was recorded, and adaptive and quality routers, which derive no baseline and so report no savings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterSessionResponse(
            string sessionId,
            string routerName,
            string routerType,
            int turns,
            string lastModel,
            double spend,
            int savingsEstimatedTurns,
            double savingsEstimatedActualSpend,
            global::System.Collections.Generic.Dictionary<string, int> baselineModels,
            double? savedSpend,
            double? baselineSpend,
            double? savingsEstimatedBaselineSpend,
            string? baselineModel)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.RouterName = routerName ?? throw new global::System.ArgumentNullException(nameof(routerName));
            this.RouterType = routerType ?? throw new global::System.ArgumentNullException(nameof(routerType));
            this.Turns = turns;
            this.LastModel = lastModel ?? throw new global::System.ArgumentNullException(nameof(lastModel));
            this.Spend = spend;
            this.SavingsEstimatedTurns = savingsEstimatedTurns;
            this.SavingsEstimatedActualSpend = savingsEstimatedActualSpend;
            this.SavedSpend = savedSpend;
            this.BaselineSpend = baselineSpend;
            this.SavingsEstimatedBaselineSpend = savingsEstimatedBaselineSpend;
            this.BaselineModel = baselineModel;
            this.BaselineModels = baselineModels ?? throw new global::System.ArgumentNullException(nameof(baselineModels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterSessionResponse" /> class.
        /// </summary>
        public AutoRouterSessionResponse()
        {
        }

    }
}
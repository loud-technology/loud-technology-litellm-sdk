
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Per-request provenance for a pre-routing strategy (auto-router) decision.
    /// </summary>
    public sealed partial class StandardLoggingRoutingDecision
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_model_name")]
        public string? RouterModelName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.StandardLoggingRoutingDecisionRouterTypeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.StandardLoggingRoutingDecisionRouterType? RouterType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routed_model")]
        public string? RoutedModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.StandardLoggingRoutingDecisionCauseJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.StandardLoggingRoutingDecisionCause? Cause { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_label")]
        public string? TierLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_type")]
        public string? RequestType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signals")]
        public global::System.Collections.Generic.IList<string>? Signals { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matched_keyword")]
        public string? MatchedKeyword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("escalation_keyword")]
        public string? EscalationKeyword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_model")]
        public string? ClassifierModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_cost")]
        public double? ClassifierCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_probabilities")]
        public global::System.Collections.Generic.Dictionary<string, double>? ClassifierProbabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_confidence")]
        public double? ClassifierConfidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heuristic_v2_forecast")]
        public global::Loud.Technology.LiteLLM.Sdk.StandardLoggingHeuristicV2Forecast? HeuristicV2Forecast { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_crux")]
        public string? ClassifierCrux { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_primary_rule")]
        public string? ClassifierPrimaryRule { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_capability_boundary")]
        public string? ClassifierCapabilityBoundary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_p_solve")]
        public double? ClassifierPSolve { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_calibrated_p_solve")]
        public double? ClassifierCalibratedPSolve { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_calibration_version")]
        public string? ClassifierCalibrationVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_efficient_p_solve")]
        public double? ClassifierEfficientPSolve { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_capable_p_solve")]
        public double? ClassifierCapablePSolve { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_calibrated_efficient_p_solve")]
        public double? ClassifierCalibratedEfficientPSolve { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_calibrated_capable_p_solve")]
        public double? ClassifierCalibratedCapablePSolve { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_max_quality_gap")]
        public double? ClassifierMaxQualityGap { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_prompt_version")]
        public string? ClassifierPromptVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_threshold")]
        public double? ClassifierThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("escalated")]
        public bool? Escalated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_escalated")]
        public bool? ContextEscalated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_escalation_original_tier")]
        public string? ContextEscalationOriginalTier { get; set; }

        /// <summary>
        /// Snapshot of the complexity scorer's tier boundaries at decision time, so a<br/>
        /// historical spend log row stays explainable after the router config changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_boundaries")]
        public global::Loud.Technology.LiteLLM.Sdk.StandardLoggingRoutingDecisionTierBoundaries? TierBoundaries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_override_min_score")]
        public double? ReasoningOverrideMinScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_continuing")]
        public bool? ConversationContinuing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("savings_baseline_model")]
        public string? SavingsBaselineModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("savings_baseline_deployment_id")]
        public string? SavingsBaselineDeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_litellm_params")]
        public object? TierLitellmParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardLoggingRoutingDecision" /> class.
        /// </summary>
        /// <param name="routerModelName"></param>
        /// <param name="routerType"></param>
        /// <param name="routedModel"></param>
        /// <param name="cause"></param>
        /// <param name="tier"></param>
        /// <param name="tierLabel"></param>
        /// <param name="requestType"></param>
        /// <param name="score"></param>
        /// <param name="signals"></param>
        /// <param name="matchedKeyword"></param>
        /// <param name="escalationKeyword"></param>
        /// <param name="classifierModel"></param>
        /// <param name="classifierCost"></param>
        /// <param name="classifierProbabilities"></param>
        /// <param name="classifierConfidence"></param>
        /// <param name="heuristicV2Forecast"></param>
        /// <param name="classifierCrux"></param>
        /// <param name="classifierPrimaryRule"></param>
        /// <param name="classifierCapabilityBoundary"></param>
        /// <param name="classifierPSolve"></param>
        /// <param name="classifierCalibratedPSolve"></param>
        /// <param name="classifierCalibrationVersion"></param>
        /// <param name="classifierEfficientPSolve"></param>
        /// <param name="classifierCapablePSolve"></param>
        /// <param name="classifierCalibratedEfficientPSolve"></param>
        /// <param name="classifierCalibratedCapablePSolve"></param>
        /// <param name="classifierMaxQualityGap"></param>
        /// <param name="classifierPromptVersion"></param>
        /// <param name="classifierThreshold"></param>
        /// <param name="escalated"></param>
        /// <param name="contextEscalated"></param>
        /// <param name="contextEscalationOriginalTier"></param>
        /// <param name="tierBoundaries">
        /// Snapshot of the complexity scorer's tier boundaries at decision time, so a<br/>
        /// historical spend log row stays explainable after the router config changes.
        /// </param>
        /// <param name="reasoningOverrideMinScore"></param>
        /// <param name="conversationContinuing"></param>
        /// <param name="savingsBaselineModel"></param>
        /// <param name="savingsBaselineDeploymentId"></param>
        /// <param name="tierLitellmParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StandardLoggingRoutingDecision(
            string? routerModelName,
            global::Loud.Technology.LiteLLM.Sdk.StandardLoggingRoutingDecisionRouterType? routerType,
            string? routedModel,
            global::Loud.Technology.LiteLLM.Sdk.StandardLoggingRoutingDecisionCause? cause,
            string? tier,
            string? tierLabel,
            string? requestType,
            double? score,
            global::System.Collections.Generic.IList<string>? signals,
            string? matchedKeyword,
            string? escalationKeyword,
            string? classifierModel,
            double? classifierCost,
            global::System.Collections.Generic.Dictionary<string, double>? classifierProbabilities,
            double? classifierConfidence,
            global::Loud.Technology.LiteLLM.Sdk.StandardLoggingHeuristicV2Forecast? heuristicV2Forecast,
            string? classifierCrux,
            string? classifierPrimaryRule,
            string? classifierCapabilityBoundary,
            double? classifierPSolve,
            double? classifierCalibratedPSolve,
            string? classifierCalibrationVersion,
            double? classifierEfficientPSolve,
            double? classifierCapablePSolve,
            double? classifierCalibratedEfficientPSolve,
            double? classifierCalibratedCapablePSolve,
            double? classifierMaxQualityGap,
            string? classifierPromptVersion,
            double? classifierThreshold,
            bool? escalated,
            bool? contextEscalated,
            string? contextEscalationOriginalTier,
            global::Loud.Technology.LiteLLM.Sdk.StandardLoggingRoutingDecisionTierBoundaries? tierBoundaries,
            double? reasoningOverrideMinScore,
            bool? conversationContinuing,
            string? savingsBaselineModel,
            string? savingsBaselineDeploymentId,
            object? tierLitellmParams)
        {
            this.RouterModelName = routerModelName;
            this.RouterType = routerType;
            this.RoutedModel = routedModel;
            this.Cause = cause;
            this.Tier = tier;
            this.TierLabel = tierLabel;
            this.RequestType = requestType;
            this.Score = score;
            this.Signals = signals;
            this.MatchedKeyword = matchedKeyword;
            this.EscalationKeyword = escalationKeyword;
            this.ClassifierModel = classifierModel;
            this.ClassifierCost = classifierCost;
            this.ClassifierProbabilities = classifierProbabilities;
            this.ClassifierConfidence = classifierConfidence;
            this.HeuristicV2Forecast = heuristicV2Forecast;
            this.ClassifierCrux = classifierCrux;
            this.ClassifierPrimaryRule = classifierPrimaryRule;
            this.ClassifierCapabilityBoundary = classifierCapabilityBoundary;
            this.ClassifierPSolve = classifierPSolve;
            this.ClassifierCalibratedPSolve = classifierCalibratedPSolve;
            this.ClassifierCalibrationVersion = classifierCalibrationVersion;
            this.ClassifierEfficientPSolve = classifierEfficientPSolve;
            this.ClassifierCapablePSolve = classifierCapablePSolve;
            this.ClassifierCalibratedEfficientPSolve = classifierCalibratedEfficientPSolve;
            this.ClassifierCalibratedCapablePSolve = classifierCalibratedCapablePSolve;
            this.ClassifierMaxQualityGap = classifierMaxQualityGap;
            this.ClassifierPromptVersion = classifierPromptVersion;
            this.ClassifierThreshold = classifierThreshold;
            this.Escalated = escalated;
            this.ContextEscalated = contextEscalated;
            this.ContextEscalationOriginalTier = contextEscalationOriginalTier;
            this.TierBoundaries = tierBoundaries;
            this.ReasoningOverrideMinScore = reasoningOverrideMinScore;
            this.ConversationContinuing = conversationContinuing;
            this.SavingsBaselineModel = savingsBaselineModel;
            this.SavingsBaselineDeploymentId = savingsBaselineDeploymentId;
            this.TierLitellmParams = tierLitellmParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardLoggingRoutingDecision" /> class.
        /// </summary>
        public StandardLoggingRoutingDecision()
        {
        }

    }
}
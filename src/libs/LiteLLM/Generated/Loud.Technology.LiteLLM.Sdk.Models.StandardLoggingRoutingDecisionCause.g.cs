
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum StandardLoggingRoutingDecisionCause
    {
        /// <summary>
        ///
        /// </summary>
        Bandit,
        /// <summary>
        ///
        /// </summary>
        CapabilityClassifier,
        /// <summary>
        ///
        /// </summary>
        CapabilityClassifierFallback,
        /// <summary>
        ///
        /// </summary>
        ClassifierFallback,
        /// <summary>
        ///
        /// </summary>
        ClassifierPlugin,
        /// <summary>
        ///
        /// </summary>
        DefaultFallback,
        /// <summary>
        ///
        /// </summary>
        DefaultModelFallback,
        /// <summary>
        ///
        /// </summary>
        HealthDefaultFallback,
        /// <summary>
        ///
        /// </summary>
        HealthFailover,
        /// <summary>
        ///
        /// </summary>
        HeuristicFirstShortCircuit,
        /// <summary>
        ///
        /// </summary>
        HeuristicScorer,
        /// <summary>
        ///
        /// </summary>
        HeuristicV2,
        /// <summary>
        ///
        /// </summary>
        Housekeeping,
        /// <summary>
        ///
        /// </summary>
        HybridShortCircuit,
        /// <summary>
        ///
        /// </summary>
        JevClassifier,
        /// <summary>
        ///
        /// </summary>
        Keyword,
        /// <summary>
        ///
        /// </summary>
        LiteralKeywordMatch,
        /// <summary>
        ///
        /// </summary>
        LlmClassifier,
        /// <summary>
        ///
        /// </summary>
        LlmV2Classifier,
        /// <summary>
        ///
        /// </summary>
        LlmV2Fallback,
        /// <summary>
        ///
        /// </summary>
        ModalityEscalation,
        /// <summary>
        ///
        /// </summary>
        ModalityPinOverride,
        /// <summary>
        ///
        /// </summary>
        PlanMode,
        /// <summary>
        ///
        /// </summary>
        QualityTier,
        /// <summary>
        ///
        /// </summary>
        ReasoningOverride,
        /// <summary>
        ///
        /// </summary>
        SemanticKeywordMatch,
        /// <summary>
        ///
        /// </summary>
        SessionAffinityEscalation,
        /// <summary>
        ///
        /// </summary>
        SessionAffinityPin,
        /// <summary>
        ///
        /// </summary>
        UserTurnContinuation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StandardLoggingRoutingDecisionCauseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StandardLoggingRoutingDecisionCause value)
        {
            return value switch
            {
                StandardLoggingRoutingDecisionCause.Bandit => "bandit",
                StandardLoggingRoutingDecisionCause.CapabilityClassifier => "capability_classifier",
                StandardLoggingRoutingDecisionCause.CapabilityClassifierFallback => "capability_classifier_fallback",
                StandardLoggingRoutingDecisionCause.ClassifierFallback => "classifier_fallback",
                StandardLoggingRoutingDecisionCause.ClassifierPlugin => "classifier_plugin",
                StandardLoggingRoutingDecisionCause.DefaultFallback => "default_fallback",
                StandardLoggingRoutingDecisionCause.DefaultModelFallback => "default_model_fallback",
                StandardLoggingRoutingDecisionCause.HealthDefaultFallback => "health_default_fallback",
                StandardLoggingRoutingDecisionCause.HealthFailover => "health_failover",
                StandardLoggingRoutingDecisionCause.HeuristicFirstShortCircuit => "heuristic_first_short_circuit",
                StandardLoggingRoutingDecisionCause.HeuristicScorer => "heuristic_scorer",
                StandardLoggingRoutingDecisionCause.HeuristicV2 => "heuristic_v2",
                StandardLoggingRoutingDecisionCause.Housekeeping => "housekeeping",
                StandardLoggingRoutingDecisionCause.HybridShortCircuit => "hybrid_short_circuit",
                StandardLoggingRoutingDecisionCause.JevClassifier => "jev_classifier",
                StandardLoggingRoutingDecisionCause.Keyword => "keyword",
                StandardLoggingRoutingDecisionCause.LiteralKeywordMatch => "literal_keyword_match",
                StandardLoggingRoutingDecisionCause.LlmClassifier => "llm_classifier",
                StandardLoggingRoutingDecisionCause.LlmV2Classifier => "llm_v2_classifier",
                StandardLoggingRoutingDecisionCause.LlmV2Fallback => "llm_v2_fallback",
                StandardLoggingRoutingDecisionCause.ModalityEscalation => "modality_escalation",
                StandardLoggingRoutingDecisionCause.ModalityPinOverride => "modality_pin_override",
                StandardLoggingRoutingDecisionCause.PlanMode => "plan_mode",
                StandardLoggingRoutingDecisionCause.QualityTier => "quality_tier",
                StandardLoggingRoutingDecisionCause.ReasoningOverride => "reasoning_override",
                StandardLoggingRoutingDecisionCause.SemanticKeywordMatch => "semantic_keyword_match",
                StandardLoggingRoutingDecisionCause.SessionAffinityEscalation => "session_affinity_escalation",
                StandardLoggingRoutingDecisionCause.SessionAffinityPin => "session_affinity_pin",
                StandardLoggingRoutingDecisionCause.UserTurnContinuation => "user_turn_continuation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StandardLoggingRoutingDecisionCause? ToEnum(string value)
        {
            return value switch
            {
                "bandit" => StandardLoggingRoutingDecisionCause.Bandit,
                "capability_classifier" => StandardLoggingRoutingDecisionCause.CapabilityClassifier,
                "capability_classifier_fallback" => StandardLoggingRoutingDecisionCause.CapabilityClassifierFallback,
                "classifier_fallback" => StandardLoggingRoutingDecisionCause.ClassifierFallback,
                "classifier_plugin" => StandardLoggingRoutingDecisionCause.ClassifierPlugin,
                "default_fallback" => StandardLoggingRoutingDecisionCause.DefaultFallback,
                "default_model_fallback" => StandardLoggingRoutingDecisionCause.DefaultModelFallback,
                "health_default_fallback" => StandardLoggingRoutingDecisionCause.HealthDefaultFallback,
                "health_failover" => StandardLoggingRoutingDecisionCause.HealthFailover,
                "heuristic_first_short_circuit" => StandardLoggingRoutingDecisionCause.HeuristicFirstShortCircuit,
                "heuristic_scorer" => StandardLoggingRoutingDecisionCause.HeuristicScorer,
                "heuristic_v2" => StandardLoggingRoutingDecisionCause.HeuristicV2,
                "housekeeping" => StandardLoggingRoutingDecisionCause.Housekeeping,
                "hybrid_short_circuit" => StandardLoggingRoutingDecisionCause.HybridShortCircuit,
                "jev_classifier" => StandardLoggingRoutingDecisionCause.JevClassifier,
                "keyword" => StandardLoggingRoutingDecisionCause.Keyword,
                "literal_keyword_match" => StandardLoggingRoutingDecisionCause.LiteralKeywordMatch,
                "llm_classifier" => StandardLoggingRoutingDecisionCause.LlmClassifier,
                "llm_v2_classifier" => StandardLoggingRoutingDecisionCause.LlmV2Classifier,
                "llm_v2_fallback" => StandardLoggingRoutingDecisionCause.LlmV2Fallback,
                "modality_escalation" => StandardLoggingRoutingDecisionCause.ModalityEscalation,
                "modality_pin_override" => StandardLoggingRoutingDecisionCause.ModalityPinOverride,
                "plan_mode" => StandardLoggingRoutingDecisionCause.PlanMode,
                "quality_tier" => StandardLoggingRoutingDecisionCause.QualityTier,
                "reasoning_override" => StandardLoggingRoutingDecisionCause.ReasoningOverride,
                "semantic_keyword_match" => StandardLoggingRoutingDecisionCause.SemanticKeywordMatch,
                "session_affinity_escalation" => StandardLoggingRoutingDecisionCause.SessionAffinityEscalation,
                "session_affinity_pin" => StandardLoggingRoutingDecisionCause.SessionAffinityPin,
                "user_turn_continuation" => StandardLoggingRoutingDecisionCause.UserTurnContinuation,
                _ => null,
            };
        }
    }
}
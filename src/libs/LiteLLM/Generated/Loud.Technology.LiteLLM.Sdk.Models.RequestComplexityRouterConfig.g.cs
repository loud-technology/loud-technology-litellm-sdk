
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The part of a complexity-router config a request can carry.<br/>
    /// `plugins` holds live RoutingPlugin objects, which no JSON body can express and which have no<br/>
    /// OpenAPI schema, so it is closed off here rather than left as an arbitrary-type field.
    /// </summary>
    public sealed partial class RequestComplexityRouterConfig
    {
        /// <summary>
        /// Mapping of complexity tiers to a model or model pool. A list is randomly picked from when adaptive=False, and used as a soft-floor home pool when adaptive=True
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiers")]
        public object? Tiers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_model_configs")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ComplexityTierModel>>? TierModelConfigs { get; set; }

        /// <summary>
        /// Add NON_REASONING as a fifth built-in tier below SIMPLE, for operational agent traffic that relays or reformats information rather than reasoning about it. Off by default: turning it on adds a rung to this router's ladder, a bullet to the LLM classifier's rubric, and a value the classifier may return, all of which move tier decisions and spend on an already-deployed router. Requires an LLM, Jev, or custom classifier plugin, since the heuristic scorers cannot produce the tier, and a model in `tiers` under the NON_REASONING key. Escalation still walks up from it, and it is never the savings baseline or a `heuristic_v2` prediction.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_non_reasoning_tier")]
        public bool? EnableNonReasoningTier { get; set; }

        /// <summary>
        /// Operator-defined tier set replacing the built-in SIMPLE/MEDIUM/COMPLEX/REASONING. Each entry's name becomes a value the LLM classifier can return and its description becomes that tier's rubric bullet; entries named after a built-in tier may omit the description and inherit the built-in criteria. List order is ascending severity and decides which tier wins when several keyword_tier_rules match. Requires classifier_type 'llm', 'jev' or 'custom', a fallback_tier, and `tiers` keys matching the defined names exactly. Escalation, adaptive selection, session affinity, plugins, tier_labels, and the calibration-example rubric presets are unavailable with a custom tier set: the first four are built on the built-in tier ladder, and the last two rename or exemplify tiers the set replaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_definitions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDefinition>? TierDefinitions { get; set; }

        /// <summary>
        /// Tier routed to when the LLM classifier fails (timeout, provider error, or an unparseable reply). Required with tier_definitions and must name a defined tier; the heuristic scorer cannot produce custom tiers, so this replaces the heuristic fallback for custom tier sets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_tier")]
        public string? FallbackTier { get; set; }

        /// <summary>
        /// Replaces the classification instructions that open the LLM classifier rubric, and nothing else. The per-tier bullets follow it, the calibration examples follow those, and the trust-boundary paragraph telling the classifier to ignore tier requests embedded in quoted caller text is always appended after them and cannot be overridden. Requires an LLM classifier and cannot be combined with classifier_llm_config.system_prompt. With built-in tiers the rubric preset still supplies the tier criteria and, unless classification_examples replaces them, the calibration examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_prompt")]
        public string? ClassificationPrompt { get; set; }

        /// <summary>
        /// Replaces the calibration examples of the LLM classifier rubric, and nothing else. Written as example lines only: the router renders the 'Calibration examples:' heading above them, after the per-tier bullets. Requires an LLM classifier and cannot be combined with classifier_llm_config.system_prompt. With built-in tiers the rubric preset still supplies the tier criteria and, unless classification_prompt replaces them, the classification instructions; a custom tier set ships no examples of its own, so the section renders only when this is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_examples")]
        public string? ClassificationExamples { get; set; }

        /// <summary>
        /// Display names for the complexity tiers, so a deployment can use its own vocabulary (e.g. Cheap/Standard/Premium/Deep) in the dashboard, spend logs, and the LLM classifier rubric. Purely operator-facing: config keys stay canonical (tiers, keyword_tier_rules[].tier, tier_boundaries), API callers never see these names, and the heuristic scorer never reads them. Unlisted tiers keep their canonical name. Partial maps are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? TierLabels { get; set; }

        /// <summary>
        /// Score boundaries between tiers. These keys (simple_medium, medium_complex, complex_reasoning) name the gaps between the default tier names and are not renameable by tier_labels; they are scorer knobs persisted by name on every routing decision
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_boundaries")]
        public global::System.Collections.Generic.Dictionary<string, double>? TierBoundaries { get; set; }

        /// <summary>
        /// Minimum weighted score a request must reach before 2+ reasoning markers may promote it to the reasoning tier. Unset tracks tier_boundaries.simple_medium, so the override never rescues a request the scorer placed in the cheapest tier; 0 restores the unconditional override
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_override_min_score")]
        public double? ReasoningOverrideMinScore { get; set; }

        /// <summary>
        /// Token count thresholds for simple/complex classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_thresholds")]
        public global::System.Collections.Generic.Dictionary<string, int>? TokenThresholds { get; set; }

        /// <summary>
        /// Weights for each scoring dimension
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension_weights")]
        public global::System.Collections.Generic.Dictionary<string, double>? DimensionWeights { get; set; }

        /// <summary>
        /// Named dimensions added to the heuristic-v1 score. Each contributes its inline weight once when any keyword matches the current ask or a case-insensitive regex matches its first 2048 characters; scoring_mode 'match_count' instead grades half weight for one distinct matcher and full for two or more. Regex quantifiers repeat one character or class at most 64 times. Unbounded quantifiers, repeated groups, backreferences and lookarounds are rejected. Conservative work limits include alternation paths, repeat lengths and subsequent matching: 2048 units per pattern, 8192 across the router. Only heuristic, heuristic_first and hybrid accept this field. Uses the existing heuristic tuning quota.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CustomDimension>? CustomDimensions { get; set; }

        /// <summary>
        /// Keywords indicating code-related content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_keywords")]
        public global::System.Collections.Generic.IList<string>? CodeKeywords { get; set; }

        /// <summary>
        /// Keywords indicating reasoning-required content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_keywords")]
        public global::System.Collections.Generic.IList<string>? ReasoningKeywords { get; set; }

        /// <summary>
        /// Keywords indicating technical content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("technical_keywords")]
        public global::System.Collections.Generic.IList<string>? TechnicalKeywords { get; set; }

        /// <summary>
        /// Domain-specific technical keywords appended to the effective base list (technical_keywords if set, otherwise DEFAULT_TECHNICAL_KEYWORDS). Order is preserved; duplicates are removed case-insensitively against the base list and within this list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_technical_keywords")]
        public global::System.Collections.Generic.IList<string>? CustomTechnicalKeywords { get; set; }

        /// <summary>
        /// Keywords indicating simple/basic queries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simple_keywords")]
        public global::System.Collections.Generic.IList<string>? SimpleKeywords { get; set; }

        /// <summary>
        /// Default model to use if tier cannot be determined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model")]
        public string? DefaultModel { get; set; }

        /// <summary>
        /// Return the resolved raw model name in the response model field instead of the client-requested complexity-router alias<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_raw_model_name")]
        public bool? ReturnRawModelName { get; set; }

        /// <summary>
        /// Classification strategy: local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call<br/>
        /// Default Value: heuristic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.RequestComplexityRouterConfigClassifierTypeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfigClassifierType? ClassifierType { get; set; }

        /// <summary>
        /// Experimental joint task-demand and solver-capability forecasting for classifier_type llm_v2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_v2_config")]
        public global::Loud.Technology.LiteLLM.Sdk.LLMV2Config? LlmV2Config { get; set; }

        /// <summary>
        /// Success-probability artifact used by classifier_type 'heuristic_v2'. The bundled UltraFeedback artifact is selected by default; an inline trained artifact may replace it<br/>
        /// Default Value: ultrafeedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heuristic_v2_artifact")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::Loud.Technology.LiteLLM.Sdk.TrainedTierArtifact, string>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.TrainedTierArtifact, string>? HeuristicV2Artifact { get; set; }

        /// <summary>
        /// Minimum predicted success probability for classifier_type 'heuristic_v2' to select a tier. The first tier meeting this threshold is selected, or REASONING if none meets it. When omitted or null, uses the artifact's routing_threshold (0.75 for the bundled artifact). Other classifier types ignore this setting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heuristic_v2_success_threshold")]
        public double? HeuristicV2SuccessThreshold { get; set; }

        /// <summary>
        /// Configuration for the LLM classifier; required when classifier_type is 'llm', 'capability', 'heuristic_first' or 'hybrid'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_llm_config")]
        public global::Loud.Technology.LiteLLM.Sdk.ClassifierLLMConfig? ClassifierLlmConfig { get; set; }

        /// <summary>
        /// Probability threshold policy required when classifier_type is 'capability'. The classifier forecasts p_solve for efficient_tier, adjusts base_threshold using the capability-card boundary, and otherwise routes to capable_tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_classifier_config")]
        public global::Loud.Technology.LiteLLM.Sdk.CapabilityClassifierConfig? CapabilityClassifierConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jev_classifier_config")]
        public global::Loud.Technology.LiteLLM.Sdk.JevClassifierConfig? JevClassifierConfig { get; set; }

        /// <summary>
        /// The highest tier the local scorer may decide on its own; required when classifier_type is 'heuristic_first' and rejected otherwise. A request whose heuristic tier is at or below this one skips the LLM classifier and routes straight to that heuristic tier, so the classifier call is only paid for on traffic the scorer could not place cheaply. The scorer must also have produced at least one signal: a prompt where no dimension fired scores 0.0 and would otherwise land SIMPLE by default rather than by evidence, which is how a chained router would silently send unclassified traffic to the cheapest model. Names a built-in tier, and may not name the highest one, since that would make the LLM classifier unreachable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heuristic_first_max_tier")]
        public string? HeuristicFirstMaxTier { get; set; }

        /// <summary>
        /// How close to a tier boundary a heuristic score has to land before the LLM classifier breaks the tie; required when classifier_type is 'hybrid' and rejected otherwise. Everything further than this from every active boundary routes on the scorer's own tier with no classifier call, at any tier, which is what separates 'hybrid' from 'heuristic_first' and its cheap-tier ceiling. A prompt where no dimension fired still goes to the classifier, since the scorer has no opinion to be near a boundary with. 0 escalates only scores sitting exactly on a boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hybrid_boundary_margin")]
        public double? HybridBoundaryMargin { get; set; }

        /// <summary>
        /// Not settable over HTTP; the classifier plugin is a runtime object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_plugin")]
        public object? ClassifierPlugin { get; set; }

        /// <summary>
        /// Timeout budget for the classifier plugin call, in milliseconds. On expiry the fallback path decides the tier. Only applies when classifier_type is 'custom'.<br/>
        /// Default Value: 3000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_plugin_timeout_ms")]
        public int? ClassifierPluginTimeoutMs { get; set; }

        /// <summary>
        /// What classifies the request when the LLM classifier errors, times out, or returns an unparseable response. 'heuristic' runs the local complexity scorer, which is right when the classifier grades complexity too. 'default_model' skips scoring and routes to default_model, which is what a classifier on some other taxonomy wants: a prompt that grades data sensitivity has no use for a complexity score, and scoring one produces a tier unrelated to what the operator configured. Requires default_model when set to 'default_model'. Only applies when classifier_type is 'llm', 'custom', or 'heuristic_first'.<br/>
        /// Default Value: heuristic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_fallback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.RequestComplexityRouterConfigClassifierFallbackJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfigClassifierFallback? ClassifierFallback { get; set; }

        /// <summary>
        /// Number of prior user turns (tool output and harness reminders excluded) to include as context in the LLM or JEV classifier input, so a follow-up like 'now do the same for the streaming path' is classified against what it refers to. Counts turns of both roles when classifier_context_include_assistant_turns is enabled. These turns are sent to the classifier model (the configured TypeSafe endpoint for JEV), which may be a different deployment or provider than the routed completion model; that call carries the current user ask and, except for Claude Code requests, the extracted system-role text in full. Claude Code system text is omitted to avoid classifying harness instructions; the routed completion still receives it. Set to 0 to omit prior turns and the conversation-depth summary; the current ask and selected system text are still sent. Applies to LLM and JEV classification.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_context_window_size")]
        public int? ClassifierContextWindowSize { get; set; }

        /// <summary>
        /// Maximum characters of prior-turn text quoted to the LLM or JEV classifier, across the whole context window, per classification call. Turns are taken newest first and quoted whole while they fit, so a conversation small enough to quote entirely is never cut; once the budget runs out the older turns are dropped whole and only the turn straddling the boundary is truncated, into whatever space is left. The current ask and, except for Claude Code requests, the extracted system-role text sit outside this budget and are sent in full, as does the numbering each quoted turn carries. A budget under 120 leaves no room to quote a turn and suppresses the block; set classifier_context_window_size to 0 to turn context off deliberately. Applies to LLM and JEV classification.<br/>
        /// Default Value: 8000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_context_budget_chars")]
        public int? ClassifierContextBudgetChars { get; set; }

        /// <summary>
        /// Optional cap on each individual prior turn's text, applied before classifier_context_budget_chars bounds the block. Unset by default, so one long turn may spend the whole budget, which is usually what a follow-up needs; set it when no single turn should dominate the context the classifier sees. A capped turn keeps its opening and its ending with the middle elided. Applies to LLM and JEV classification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_context_per_turn_chars")]
        public int? ClassifierContextPerTurnChars { get; set; }

        /// <summary>
        /// Include assistant turns in the classifier context window, so difficulty stated by the model rather than by the user stays visible: a plan the assistant calls complex, which the user approves with 'yes', is classified on the work being approved instead of on the word 'yes'. When enabled, classifier_context_window_size counts the last N turns of the conversation across both roles rather than the last N user turns, and assistant text is sent to the classifier model, which may be a different deployment or provider than the routed completion model. Assistant replies spend classifier_context_budget_chars alongside user turns, so raise it if the oldest turns stop being quoted once replies join the window. Off by default because enabling it shifts tier decisions, and therefore spend, for an already-deployed router. Applies to LLM and JEV classification.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_context_include_assistant_turns")]
        public bool? ClassifierContextIncludeAssistantTurns { get; set; }

        /// <summary>
        /// Enable adaptive bandit selection with soft complexity floors<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive")]
        public bool? Adaptive { get; set; }

        /// <summary>
        /// Quality vs cost weights for adaptive selection (used when adaptive=True)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive_weights")]
        public global::Loud.Technology.LiteLLM.Sdk.AdaptiveRouterWeights? AdaptiveWeights { get; set; }

        /// <summary>
        /// Score penalty per tier-step away from the classified tier when adaptive=True<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_distance_penalty")]
        public double? TierDistancePenalty { get; set; }

        /// <summary>
        /// When adaptive=True: 'all' scores every pool model with a tier-distance penalty (soft floors); 'classified_tier' Thompson-samples only inside the classified tier's pool<br/>
        /// Default Value: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive_eligible")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.RequestComplexityRouterConfigAdaptiveEligibleJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfigAdaptiveEligible? AdaptiveEligible { get; set; }

        /// <summary>
        /// Case-sensitive phrases a user can include to force a bump to the next-higher complexity tier when they aren't satisfied with results (they can force a stronger model, but not choose which one). Defaults to ['LITELLM ESCALATE'] when unset; set to an empty list to disable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("escalation_keywords")]
        public global::System.Collections.Generic.IList<string>? EscalationKeywords { get; set; }

        /// <summary>
        /// Rules that force a specific tier when their keywords match the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword_tier_rules")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeywordTierRule>? KeywordTierRules { get; set; }

        /// <summary>
        /// Escalate mid-task to the next-higher configured tier when the assistant's own recent tool calls look stuck: the newest tool call repeats, or errors, at least stall_escalation_repeat_threshold times across the last stall_escalation_window calls. Both tests are anchored on the newest call, so a task that tried the same thing a few times and then moved on is not escalated on the strength of those older calls alone, while a retry loop broken up by an unrelated lookup still counts. One tier at most, on the same ladder escalation_keywords bumps along, and never above the highest configured tier. Detection re-runs on every classified turn from the tool calls visible in that request, so it needs no state and nothing survives past the task. Mutually exclusive with session_affinity and classification_mode='user_turn', which both replay a held routing decision instead of classifying most turns, so this would never see the tool calls to look at. Off by default.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stall_escalation_enabled")]
        public bool? StallEscalationEnabled { get; set; }

        /// <summary>
        /// How many of the assistant's most recent tool calls stall detection looks at, oldest ones dropped as new calls happen. Counted across the whole visible conversation rather than reset at the newest human ask, so evidence from before a plain follow-up message like 'try again' is still visible on the turn after it.<br/>
        /// Default Value: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stall_escalation_window")]
        public int? StallEscalationWindow { get; set; }

        /// <summary>
        /// How many of the last stall_escalation_window tool calls must repeat the newest call, or must have errored alongside it, before the task counts as stalled. Must not exceed stall_escalation_window, or the condition could never be reached.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stall_escalation_repeat_threshold")]
        public int? StallEscalationRepeatThreshold { get; set; }

        /// <summary>
        /// When set, requests carrying a coding-agent plan-mode sentinel (Claude Code plan mode, VS Code Copilot Plan mode, Copilot CLI's exit_plan_mode tool) are routed to at least this tier: the classified tier still wins when it is higher, and the floor also overrides a session-affinity pin to a lower tier for exactly the turns carrying the sentinel, without rewriting the pin -- the first turn after plan mode exits routes as if plan mode had never happened. Names a built-in tier, or with tier_definitions set, one of the defined tier names (list order is ascending severity, same as keyword_tier_rules). Unset disables detection entirely. The sentinels ride in client-injected prompt text, so a caller who pastes one can spend up to this tier's models -- never down, and never outside the configured pools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_mode_min_tier")]
        public string? PlanModeMinTier { get; set; }

        /// <summary>
        /// Additional case-sensitive literal sentinels that mark a request as plan mode, on top of the built-in Claude Code and Copilot ones. For clients whose plan-mode wording the built-ins don't cover, or after a client release changes its strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_mode_patterns")]
        public global::System.Collections.Generic.IList<string>? PlanModePatterns { get; set; }

        /// <summary>
        /// Set max_tokens on every routed request to the output ceiling of the tier model it lands on, replacing whatever the caller sent. A caller behind an auto-router cannot pick one value that fits every tier: the smallest tier's ceiling starves a bigger tier's thinking budget, and a bigger tier's ceiling is rejected by the smallest. The ceiling is the smallest max_output_tokens across the tier model's deployments, read from each deployment's model_info and then the model cost map; a tier model with a deployment whose ceiling is unknown keeps the caller's value. A max_tokens, max_completion_tokens or max_output_tokens in the tier's own litellm_params still wins. Set false to forward the caller's value unchanged.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_from_tier_model")]
        public bool? MaxTokensFromTierModel { get; set; }

        /// <summary>
        /// Route a coding agent's own housekeeping calls to the cheapest configured tier without classifying them. A client names the conversation by quoting the whole session and asking for a title, so the ask reads as the session's engineering work and lands on the most expensive tier, which is the reverse of what the call is worth. Detection is a literal match against client-owned sentinels on the newest ask only, so it cannot fire on an earlier turn, and it never lowers what anyone else asked for: a keyword_tier_rule or a session pin still decides instead, and an escalation keyword or the plan-mode floor still raises the tier from here. Only the classifier is displaced, and its call is skipped, so a matched request costs nothing to route. Set false to classify these calls like any other.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_housekeeping_to_cheapest_tier")]
        public bool? RouteHousekeepingToCheapestTier { get; set; }

        /// <summary>
        /// Additional case-sensitive literal sentinels that mark a request as client housekeeping, on top of the built-in conversation-title ones. For clients whose wording the built-ins don't cover, or after a client release changes its strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("housekeeping_patterns")]
        public global::System.Collections.Generic.IList<string>? HousekeepingPatterns { get; set; }

        /// <summary>
        /// Compact full conversation history near the selected deployment's input limit for Chat, Responses and Messages. Uses a capable configured tier model unless model is specified. Set false or null to disable. Stored and client-managed native history keep their existing behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_compaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::Loud.Technology.LiteLLM.Sdk.ContextCompactionConfig, bool?>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ContextCompactionConfig, bool?>? ContextCompaction { get; set; }

        /// <summary>
        /// Escalate a request off a tier whose models provably cannot hold its prompt, before dispatch. The classifier scores complexity and never prompt size, so a long agentic session whose newest ask is trivial lands on a small-window tier and the provider rejects it with a context-window 400 that nothing retries. When every model of the decided tier has a declared window smaller than the estimated prompt, the request moves to the lowest configured tier with a model whose declared window fits; when only some of the tier's models fit, the pick is restricted to those and the tier keeps the request. Models with no resolvable window are never escalated away from and never escalated onto. Disabled by default: omit or set false to dispatch on complexity alone; set true to enable context-window escalation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_context_window_escalation")]
        public bool? EnableContextWindowEscalation { get; set; }

        /// <summary>
        /// Fraction of a model's declared context window the estimated prompt must fit within. The token count is an estimate, so fitting against the full window would dispatch prompts that the provider's own tokenizer then rejects; 0.95 leaves room for that drift plus the response tokens.<br/>
        /// Default Value: 0.95F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window_escalation_buffer")]
        public double? ContextWindowEscalationBuffer { get; set; }

        /// <summary>
        /// Route image-bearing requests only to models that can accept image input. The classifier reads text alone, so an image request whose text classifies cheap otherwise lands on a text-only model and fails with a provider 400. When enabled, a routed model explicitly declared supports_vision false (deployment model_info or the model cost map; unmapped names stay routable) is replaced by the nearest HIGHER tier holding a capable model, then default_model, else a clear 400. A kept session-affinity pin still wins even when an image arrives, unless modality_pin_override is also enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality_routing")]
        public bool? ModalityRouting { get; set; }

        /// <summary>
        /// Let modality_routing replace a kept session-affinity pin on the turns that carry an image. Without this, a session pinned to a text-only model fails every image turn with a provider 400, since the pin is exempt from the modality gate. When enabled, such a turn routes to a capable model for that request only and the stored pin is left untouched, so the next text turn replays the session's own model; the override is reported as cause modality_pin_override and is never itself pinned. Inert unless modality_routing is also enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality_pin_override")]
        public bool? ModalityPinOverride { get; set; }

        /// <summary>
        /// Match keyword_tier_rules by embedding similarity instead of literal text<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semantic_keyword_matching")]
        public bool? SemanticKeywordMatching { get; set; }

        /// <summary>
        /// Embedding model (LiteLLM model name) used when semantic_keyword_matching is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        public string? EmbeddingModel { get; set; }

        /// <summary>
        /// Minimum cosine similarity for a semantic keyword match<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_threshold")]
        public double? MatchThreshold { get; set; }

        /// <summary>
        /// When to run the complexity classifier. 'every_request' (the default) classifies every inference request, including the tool-result continuation turns of an agentic loop. 'user_turn' classifies only requests whose newest turn is a new human ask and replays the session's held routing decision on continuation turns, which cuts classifier spend and eliminates mid-loop model switches. Continuations with no held decision to replay (no resolvable session_id, expired pin, fresh restart) still classify. Unlike session_affinity, a new human ask always re-classifies, so a session can still move tiers between asks. Suppressed when plugins are configured, for the same reason session_affinity is: a replayed decision would bypass the plugin pipeline.<br/>
        /// Default Value: every_request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.RequestComplexityRouterConfigClassificationModeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfigClassificationMode? ClassificationMode { get; set; }

        /// <summary>
        /// When True and a session_id is resolvable on the request, pin the model chosen on the session's first turn and reuse it for every later turn, skipping re-classification. Off by default so every turn is classified on its own merits and routed to the cheapest adequate tier. Set True to keep a multi-turn session on one model, which preserves provider prompt caches and avoids cross-model conversation-history errors. Always implies the deployment pin regardless of deployment_affinity: the session sticks to one deployment of the pinned model, since freezing the model while re-shuffling its deployments would still go cache-cold.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_affinity")]
        public bool? SessionAffinity { get; set; }

        /// <summary>
        /// When True and a client session_id is resolvable, reuse the session's chosen model for each classified tier and its deployment within each model group. With session_affinity off, every turn is still classified: moving to another tier leaves the previous tier's model pin intact for a later return. Pins yield to current candidate, context, modality, and availability constraints. Adaptive selection chooses the initial model from its eligible pool, then reuses that choice per tier. This reduces avoidable provider prompt-cache misses; it does not guarantee cache hits. Set False to select models and load-balance deployments on every turn, unless session_affinity or user_turn classification requires a pin. Inert without a client session_id and suppressed when plugins are configured.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_affinity")]
        public bool? DeploymentAffinity { get; set; }

        /// <summary>
        /// TTL for the session affinity pin; refreshed on every cache hit. Bounds both the session_affinity model pin and the deployment_affinity per-tier model and deployment pins, so it measures idle time for the session's routing decisions rather than total session length<br/>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_affinity_ttl_seconds")]
        public int? SessionAffinityTtlSeconds { get; set; }

        /// <summary>
        /// Not settable over HTTP; routing plugins are runtime objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public object? Plugins { get; set; }

        /// <summary>
        /// Override the delimiter pairs used to recognize and strip harness-injected reminder blocks before classification. A harness that wraps injected context differently per agent type (main, subagent, cron) lists every pair it emits. Replaces, rather than adds to, the built-in system-reminder pair and the Codex envelope pairs enabled for Codex user agents, so list every built-in pair your harness also emits. Matching is case-insensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reminder_markers")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ReminderMarkerPair>? ReminderMarkers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestComplexityRouterConfig" /> class.
        /// </summary>
        /// <param name="tiers">
        /// Mapping of complexity tiers to a model or model pool. A list is randomly picked from when adaptive=False, and used as a soft-floor home pool when adaptive=True
        /// </param>
        /// <param name="tierModelConfigs"></param>
        /// <param name="enableNonReasoningTier">
        /// Add NON_REASONING as a fifth built-in tier below SIMPLE, for operational agent traffic that relays or reformats information rather than reasoning about it. Off by default: turning it on adds a rung to this router's ladder, a bullet to the LLM classifier's rubric, and a value the classifier may return, all of which move tier decisions and spend on an already-deployed router. Requires an LLM, Jev, or custom classifier plugin, since the heuristic scorers cannot produce the tier, and a model in `tiers` under the NON_REASONING key. Escalation still walks up from it, and it is never the savings baseline or a `heuristic_v2` prediction.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tierDefinitions">
        /// Operator-defined tier set replacing the built-in SIMPLE/MEDIUM/COMPLEX/REASONING. Each entry's name becomes a value the LLM classifier can return and its description becomes that tier's rubric bullet; entries named after a built-in tier may omit the description and inherit the built-in criteria. List order is ascending severity and decides which tier wins when several keyword_tier_rules match. Requires classifier_type 'llm', 'jev' or 'custom', a fallback_tier, and `tiers` keys matching the defined names exactly. Escalation, adaptive selection, session affinity, plugins, tier_labels, and the calibration-example rubric presets are unavailable with a custom tier set: the first four are built on the built-in tier ladder, and the last two rename or exemplify tiers the set replaces.
        /// </param>
        /// <param name="fallbackTier">
        /// Tier routed to when the LLM classifier fails (timeout, provider error, or an unparseable reply). Required with tier_definitions and must name a defined tier; the heuristic scorer cannot produce custom tiers, so this replaces the heuristic fallback for custom tier sets.
        /// </param>
        /// <param name="classificationPrompt">
        /// Replaces the classification instructions that open the LLM classifier rubric, and nothing else. The per-tier bullets follow it, the calibration examples follow those, and the trust-boundary paragraph telling the classifier to ignore tier requests embedded in quoted caller text is always appended after them and cannot be overridden. Requires an LLM classifier and cannot be combined with classifier_llm_config.system_prompt. With built-in tiers the rubric preset still supplies the tier criteria and, unless classification_examples replaces them, the calibration examples.
        /// </param>
        /// <param name="classificationExamples">
        /// Replaces the calibration examples of the LLM classifier rubric, and nothing else. Written as example lines only: the router renders the 'Calibration examples:' heading above them, after the per-tier bullets. Requires an LLM classifier and cannot be combined with classifier_llm_config.system_prompt. With built-in tiers the rubric preset still supplies the tier criteria and, unless classification_prompt replaces them, the classification instructions; a custom tier set ships no examples of its own, so the section renders only when this is set.
        /// </param>
        /// <param name="tierLabels">
        /// Display names for the complexity tiers, so a deployment can use its own vocabulary (e.g. Cheap/Standard/Premium/Deep) in the dashboard, spend logs, and the LLM classifier rubric. Purely operator-facing: config keys stay canonical (tiers, keyword_tier_rules[].tier, tier_boundaries), API callers never see these names, and the heuristic scorer never reads them. Unlisted tiers keep their canonical name. Partial maps are allowed.
        /// </param>
        /// <param name="tierBoundaries">
        /// Score boundaries between tiers. These keys (simple_medium, medium_complex, complex_reasoning) name the gaps between the default tier names and are not renameable by tier_labels; they are scorer knobs persisted by name on every routing decision
        /// </param>
        /// <param name="reasoningOverrideMinScore">
        /// Minimum weighted score a request must reach before 2+ reasoning markers may promote it to the reasoning tier. Unset tracks tier_boundaries.simple_medium, so the override never rescues a request the scorer placed in the cheapest tier; 0 restores the unconditional override
        /// </param>
        /// <param name="tokenThresholds">
        /// Token count thresholds for simple/complex classification
        /// </param>
        /// <param name="dimensionWeights">
        /// Weights for each scoring dimension
        /// </param>
        /// <param name="customDimensions">
        /// Named dimensions added to the heuristic-v1 score. Each contributes its inline weight once when any keyword matches the current ask or a case-insensitive regex matches its first 2048 characters; scoring_mode 'match_count' instead grades half weight for one distinct matcher and full for two or more. Regex quantifiers repeat one character or class at most 64 times. Unbounded quantifiers, repeated groups, backreferences and lookarounds are rejected. Conservative work limits include alternation paths, repeat lengths and subsequent matching: 2048 units per pattern, 8192 across the router. Only heuristic, heuristic_first and hybrid accept this field. Uses the existing heuristic tuning quota.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="codeKeywords">
        /// Keywords indicating code-related content
        /// </param>
        /// <param name="reasoningKeywords">
        /// Keywords indicating reasoning-required content
        /// </param>
        /// <param name="technicalKeywords">
        /// Keywords indicating technical content
        /// </param>
        /// <param name="customTechnicalKeywords">
        /// Domain-specific technical keywords appended to the effective base list (technical_keywords if set, otherwise DEFAULT_TECHNICAL_KEYWORDS). Order is preserved; duplicates are removed case-insensitively against the base list and within this list.
        /// </param>
        /// <param name="simpleKeywords">
        /// Keywords indicating simple/basic queries
        /// </param>
        /// <param name="defaultModel">
        /// Default model to use if tier cannot be determined
        /// </param>
        /// <param name="returnRawModelName">
        /// Return the resolved raw model name in the response model field instead of the client-requested complexity-router alias<br/>
        /// Default Value: false
        /// </param>
        /// <param name="classifierType">
        /// Classification strategy: local regex/keyword scoring, the bundled trained four-tier heuristic, an LLM tier-selection call, a Switchyard-compatible capability forecast, a joint Fuse V2 forecast, a custom classifier plugin, 'heuristic_first', which scores locally and only pays for the LLM classifier when the local scorer does not confidently land a cheap tier, or 'hybrid', which trusts the local scorer everywhere except when its score lands near a tier boundary, or 'jev', a TypeSafe AI Jev structured choice call<br/>
        /// Default Value: heuristic
        /// </param>
        /// <param name="llmV2Config">
        /// Experimental joint task-demand and solver-capability forecasting for classifier_type llm_v2.
        /// </param>
        /// <param name="heuristicV2Artifact">
        /// Success-probability artifact used by classifier_type 'heuristic_v2'. The bundled UltraFeedback artifact is selected by default; an inline trained artifact may replace it<br/>
        /// Default Value: ultrafeedback
        /// </param>
        /// <param name="heuristicV2SuccessThreshold">
        /// Minimum predicted success probability for classifier_type 'heuristic_v2' to select a tier. The first tier meeting this threshold is selected, or REASONING if none meets it. When omitted or null, uses the artifact's routing_threshold (0.75 for the bundled artifact). Other classifier types ignore this setting
        /// </param>
        /// <param name="classifierLlmConfig">
        /// Configuration for the LLM classifier; required when classifier_type is 'llm', 'capability', 'heuristic_first' or 'hybrid'
        /// </param>
        /// <param name="capabilityClassifierConfig">
        /// Probability threshold policy required when classifier_type is 'capability'. The classifier forecasts p_solve for efficient_tier, adjusts base_threshold using the capability-card boundary, and otherwise routes to capable_tier
        /// </param>
        /// <param name="jevClassifierConfig"></param>
        /// <param name="heuristicFirstMaxTier">
        /// The highest tier the local scorer may decide on its own; required when classifier_type is 'heuristic_first' and rejected otherwise. A request whose heuristic tier is at or below this one skips the LLM classifier and routes straight to that heuristic tier, so the classifier call is only paid for on traffic the scorer could not place cheaply. The scorer must also have produced at least one signal: a prompt where no dimension fired scores 0.0 and would otherwise land SIMPLE by default rather than by evidence, which is how a chained router would silently send unclassified traffic to the cheapest model. Names a built-in tier, and may not name the highest one, since that would make the LLM classifier unreachable.
        /// </param>
        /// <param name="hybridBoundaryMargin">
        /// How close to a tier boundary a heuristic score has to land before the LLM classifier breaks the tie; required when classifier_type is 'hybrid' and rejected otherwise. Everything further than this from every active boundary routes on the scorer's own tier with no classifier call, at any tier, which is what separates 'hybrid' from 'heuristic_first' and its cheap-tier ceiling. A prompt where no dimension fired still goes to the classifier, since the scorer has no opinion to be near a boundary with. 0 escalates only scores sitting exactly on a boundary.
        /// </param>
        /// <param name="classifierPlugin">
        /// Not settable over HTTP; the classifier plugin is a runtime object
        /// </param>
        /// <param name="classifierPluginTimeoutMs">
        /// Timeout budget for the classifier plugin call, in milliseconds. On expiry the fallback path decides the tier. Only applies when classifier_type is 'custom'.<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="classifierFallback">
        /// What classifies the request when the LLM classifier errors, times out, or returns an unparseable response. 'heuristic' runs the local complexity scorer, which is right when the classifier grades complexity too. 'default_model' skips scoring and routes to default_model, which is what a classifier on some other taxonomy wants: a prompt that grades data sensitivity has no use for a complexity score, and scoring one produces a tier unrelated to what the operator configured. Requires default_model when set to 'default_model'. Only applies when classifier_type is 'llm', 'custom', or 'heuristic_first'.<br/>
        /// Default Value: heuristic
        /// </param>
        /// <param name="classifierContextWindowSize">
        /// Number of prior user turns (tool output and harness reminders excluded) to include as context in the LLM or JEV classifier input, so a follow-up like 'now do the same for the streaming path' is classified against what it refers to. Counts turns of both roles when classifier_context_include_assistant_turns is enabled. These turns are sent to the classifier model (the configured TypeSafe endpoint for JEV), which may be a different deployment or provider than the routed completion model; that call carries the current user ask and, except for Claude Code requests, the extracted system-role text in full. Claude Code system text is omitted to avoid classifying harness instructions; the routed completion still receives it. Set to 0 to omit prior turns and the conversation-depth summary; the current ask and selected system text are still sent. Applies to LLM and JEV classification.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="classifierContextBudgetChars">
        /// Maximum characters of prior-turn text quoted to the LLM or JEV classifier, across the whole context window, per classification call. Turns are taken newest first and quoted whole while they fit, so a conversation small enough to quote entirely is never cut; once the budget runs out the older turns are dropped whole and only the turn straddling the boundary is truncated, into whatever space is left. The current ask and, except for Claude Code requests, the extracted system-role text sit outside this budget and are sent in full, as does the numbering each quoted turn carries. A budget under 120 leaves no room to quote a turn and suppresses the block; set classifier_context_window_size to 0 to turn context off deliberately. Applies to LLM and JEV classification.<br/>
        /// Default Value: 8000
        /// </param>
        /// <param name="classifierContextPerTurnChars">
        /// Optional cap on each individual prior turn's text, applied before classifier_context_budget_chars bounds the block. Unset by default, so one long turn may spend the whole budget, which is usually what a follow-up needs; set it when no single turn should dominate the context the classifier sees. A capped turn keeps its opening and its ending with the middle elided. Applies to LLM and JEV classification.
        /// </param>
        /// <param name="classifierContextIncludeAssistantTurns">
        /// Include assistant turns in the classifier context window, so difficulty stated by the model rather than by the user stays visible: a plan the assistant calls complex, which the user approves with 'yes', is classified on the work being approved instead of on the word 'yes'. When enabled, classifier_context_window_size counts the last N turns of the conversation across both roles rather than the last N user turns, and assistant text is sent to the classifier model, which may be a different deployment or provider than the routed completion model. Assistant replies spend classifier_context_budget_chars alongside user turns, so raise it if the oldest turns stop being quoted once replies join the window. Off by default because enabling it shifts tier decisions, and therefore spend, for an already-deployed router. Applies to LLM and JEV classification.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="adaptive">
        /// Enable adaptive bandit selection with soft complexity floors<br/>
        /// Default Value: false
        /// </param>
        /// <param name="adaptiveWeights">
        /// Quality vs cost weights for adaptive selection (used when adaptive=True)
        /// </param>
        /// <param name="tierDistancePenalty">
        /// Score penalty per tier-step away from the classified tier when adaptive=True<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="adaptiveEligible">
        /// When adaptive=True: 'all' scores every pool model with a tier-distance penalty (soft floors); 'classified_tier' Thompson-samples only inside the classified tier's pool<br/>
        /// Default Value: all
        /// </param>
        /// <param name="escalationKeywords">
        /// Case-sensitive phrases a user can include to force a bump to the next-higher complexity tier when they aren't satisfied with results (they can force a stronger model, but not choose which one). Defaults to ['LITELLM ESCALATE'] when unset; set to an empty list to disable.
        /// </param>
        /// <param name="keywordTierRules">
        /// Rules that force a specific tier when their keywords match the prompt
        /// </param>
        /// <param name="stallEscalationEnabled">
        /// Escalate mid-task to the next-higher configured tier when the assistant's own recent tool calls look stuck: the newest tool call repeats, or errors, at least stall_escalation_repeat_threshold times across the last stall_escalation_window calls. Both tests are anchored on the newest call, so a task that tried the same thing a few times and then moved on is not escalated on the strength of those older calls alone, while a retry loop broken up by an unrelated lookup still counts. One tier at most, on the same ladder escalation_keywords bumps along, and never above the highest configured tier. Detection re-runs on every classified turn from the tool calls visible in that request, so it needs no state and nothing survives past the task. Mutually exclusive with session_affinity and classification_mode='user_turn', which both replay a held routing decision instead of classifying most turns, so this would never see the tool calls to look at. Off by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stallEscalationWindow">
        /// How many of the assistant's most recent tool calls stall detection looks at, oldest ones dropped as new calls happen. Counted across the whole visible conversation rather than reset at the newest human ask, so evidence from before a plain follow-up message like 'try again' is still visible on the turn after it.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="stallEscalationRepeatThreshold">
        /// How many of the last stall_escalation_window tool calls must repeat the newest call, or must have errored alongside it, before the task counts as stalled. Must not exceed stall_escalation_window, or the condition could never be reached.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="planModeMinTier">
        /// When set, requests carrying a coding-agent plan-mode sentinel (Claude Code plan mode, VS Code Copilot Plan mode, Copilot CLI's exit_plan_mode tool) are routed to at least this tier: the classified tier still wins when it is higher, and the floor also overrides a session-affinity pin to a lower tier for exactly the turns carrying the sentinel, without rewriting the pin -- the first turn after plan mode exits routes as if plan mode had never happened. Names a built-in tier, or with tier_definitions set, one of the defined tier names (list order is ascending severity, same as keyword_tier_rules). Unset disables detection entirely. The sentinels ride in client-injected prompt text, so a caller who pastes one can spend up to this tier's models -- never down, and never outside the configured pools.
        /// </param>
        /// <param name="planModePatterns">
        /// Additional case-sensitive literal sentinels that mark a request as plan mode, on top of the built-in Claude Code and Copilot ones. For clients whose plan-mode wording the built-ins don't cover, or after a client release changes its strings.
        /// </param>
        /// <param name="maxTokensFromTierModel">
        /// Set max_tokens on every routed request to the output ceiling of the tier model it lands on, replacing whatever the caller sent. A caller behind an auto-router cannot pick one value that fits every tier: the smallest tier's ceiling starves a bigger tier's thinking budget, and a bigger tier's ceiling is rejected by the smallest. The ceiling is the smallest max_output_tokens across the tier model's deployments, read from each deployment's model_info and then the model cost map; a tier model with a deployment whose ceiling is unknown keeps the caller's value. A max_tokens, max_completion_tokens or max_output_tokens in the tier's own litellm_params still wins. Set false to forward the caller's value unchanged.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="routeHousekeepingToCheapestTier">
        /// Route a coding agent's own housekeeping calls to the cheapest configured tier without classifying them. A client names the conversation by quoting the whole session and asking for a title, so the ask reads as the session's engineering work and lands on the most expensive tier, which is the reverse of what the call is worth. Detection is a literal match against client-owned sentinels on the newest ask only, so it cannot fire on an earlier turn, and it never lowers what anyone else asked for: a keyword_tier_rule or a session pin still decides instead, and an escalation keyword or the plan-mode floor still raises the tier from here. Only the classifier is displaced, and its call is skipped, so a matched request costs nothing to route. Set false to classify these calls like any other.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="housekeepingPatterns">
        /// Additional case-sensitive literal sentinels that mark a request as client housekeeping, on top of the built-in conversation-title ones. For clients whose wording the built-ins don't cover, or after a client release changes its strings.
        /// </param>
        /// <param name="contextCompaction">
        /// Compact full conversation history near the selected deployment's input limit for Chat, Responses and Messages. Uses a capable configured tier model unless model is specified. Set false or null to disable. Stored and client-managed native history keep their existing behavior.
        /// </param>
        /// <param name="enableContextWindowEscalation">
        /// Escalate a request off a tier whose models provably cannot hold its prompt, before dispatch. The classifier scores complexity and never prompt size, so a long agentic session whose newest ask is trivial lands on a small-window tier and the provider rejects it with a context-window 400 that nothing retries. When every model of the decided tier has a declared window smaller than the estimated prompt, the request moves to the lowest configured tier with a model whose declared window fits; when only some of the tier's models fit, the pick is restricted to those and the tier keeps the request. Models with no resolvable window are never escalated away from and never escalated onto. Disabled by default: omit or set false to dispatch on complexity alone; set true to enable context-window escalation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="contextWindowEscalationBuffer">
        /// Fraction of a model's declared context window the estimated prompt must fit within. The token count is an estimate, so fitting against the full window would dispatch prompts that the provider's own tokenizer then rejects; 0.95 leaves room for that drift plus the response tokens.<br/>
        /// Default Value: 0.95F
        /// </param>
        /// <param name="modalityRouting">
        /// Route image-bearing requests only to models that can accept image input. The classifier reads text alone, so an image request whose text classifies cheap otherwise lands on a text-only model and fails with a provider 400. When enabled, a routed model explicitly declared supports_vision false (deployment model_info or the model cost map; unmapped names stay routable) is replaced by the nearest HIGHER tier holding a capable model, then default_model, else a clear 400. A kept session-affinity pin still wins even when an image arrives, unless modality_pin_override is also enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="modalityPinOverride">
        /// Let modality_routing replace a kept session-affinity pin on the turns that carry an image. Without this, a session pinned to a text-only model fails every image turn with a provider 400, since the pin is exempt from the modality gate. When enabled, such a turn routes to a capable model for that request only and the stored pin is left untouched, so the next text turn replays the session's own model; the override is reported as cause modality_pin_override and is never itself pinned. Inert unless modality_routing is also enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="semanticKeywordMatching">
        /// Match keyword_tier_rules by embedding similarity instead of literal text<br/>
        /// Default Value: false
        /// </param>
        /// <param name="embeddingModel">
        /// Embedding model (LiteLLM model name) used when semantic_keyword_matching is enabled
        /// </param>
        /// <param name="matchThreshold">
        /// Minimum cosine similarity for a semantic keyword match<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="classificationMode">
        /// When to run the complexity classifier. 'every_request' (the default) classifies every inference request, including the tool-result continuation turns of an agentic loop. 'user_turn' classifies only requests whose newest turn is a new human ask and replays the session's held routing decision on continuation turns, which cuts classifier spend and eliminates mid-loop model switches. Continuations with no held decision to replay (no resolvable session_id, expired pin, fresh restart) still classify. Unlike session_affinity, a new human ask always re-classifies, so a session can still move tiers between asks. Suppressed when plugins are configured, for the same reason session_affinity is: a replayed decision would bypass the plugin pipeline.<br/>
        /// Default Value: every_request
        /// </param>
        /// <param name="sessionAffinity">
        /// When True and a session_id is resolvable on the request, pin the model chosen on the session's first turn and reuse it for every later turn, skipping re-classification. Off by default so every turn is classified on its own merits and routed to the cheapest adequate tier. Set True to keep a multi-turn session on one model, which preserves provider prompt caches and avoids cross-model conversation-history errors. Always implies the deployment pin regardless of deployment_affinity: the session sticks to one deployment of the pinned model, since freezing the model while re-shuffling its deployments would still go cache-cold.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="deploymentAffinity">
        /// When True and a client session_id is resolvable, reuse the session's chosen model for each classified tier and its deployment within each model group. With session_affinity off, every turn is still classified: moving to another tier leaves the previous tier's model pin intact for a later return. Pins yield to current candidate, context, modality, and availability constraints. Adaptive selection chooses the initial model from its eligible pool, then reuses that choice per tier. This reduces avoidable provider prompt-cache misses; it does not guarantee cache hits. Set False to select models and load-balance deployments on every turn, unless session_affinity or user_turn classification requires a pin. Inert without a client session_id and suppressed when plugins are configured.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sessionAffinityTtlSeconds">
        /// TTL for the session affinity pin; refreshed on every cache hit. Bounds both the session_affinity model pin and the deployment_affinity per-tier model and deployment pins, so it measures idle time for the session's routing decisions rather than total session length<br/>
        /// Default Value: 3600
        /// </param>
        /// <param name="plugins">
        /// Not settable over HTTP; routing plugins are runtime objects
        /// </param>
        /// <param name="reminderMarkers">
        /// Override the delimiter pairs used to recognize and strip harness-injected reminder blocks before classification. A harness that wraps injected context differently per agent type (main, subagent, cron) lists every pair it emits. Replaces, rather than adds to, the built-in system-reminder pair and the Codex envelope pairs enabled for Codex user agents, so list every built-in pair your harness also emits. Matching is case-insensitive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestComplexityRouterConfig(
            object? tiers,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ComplexityTierModel>>? tierModelConfigs,
            bool? enableNonReasoningTier,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDefinition>? tierDefinitions,
            string? fallbackTier,
            string? classificationPrompt,
            string? classificationExamples,
            global::System.Collections.Generic.Dictionary<string, string>? tierLabels,
            global::System.Collections.Generic.Dictionary<string, double>? tierBoundaries,
            double? reasoningOverrideMinScore,
            global::System.Collections.Generic.Dictionary<string, int>? tokenThresholds,
            global::System.Collections.Generic.Dictionary<string, double>? dimensionWeights,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CustomDimension>? customDimensions,
            global::System.Collections.Generic.IList<string>? codeKeywords,
            global::System.Collections.Generic.IList<string>? reasoningKeywords,
            global::System.Collections.Generic.IList<string>? technicalKeywords,
            global::System.Collections.Generic.IList<string>? customTechnicalKeywords,
            global::System.Collections.Generic.IList<string>? simpleKeywords,
            string? defaultModel,
            bool? returnRawModelName,
            global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfigClassifierType? classifierType,
            global::Loud.Technology.LiteLLM.Sdk.LLMV2Config? llmV2Config,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.TrainedTierArtifact, string>? heuristicV2Artifact,
            double? heuristicV2SuccessThreshold,
            global::Loud.Technology.LiteLLM.Sdk.ClassifierLLMConfig? classifierLlmConfig,
            global::Loud.Technology.LiteLLM.Sdk.CapabilityClassifierConfig? capabilityClassifierConfig,
            global::Loud.Technology.LiteLLM.Sdk.JevClassifierConfig? jevClassifierConfig,
            string? heuristicFirstMaxTier,
            double? hybridBoundaryMargin,
            object? classifierPlugin,
            int? classifierPluginTimeoutMs,
            global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfigClassifierFallback? classifierFallback,
            int? classifierContextWindowSize,
            int? classifierContextBudgetChars,
            int? classifierContextPerTurnChars,
            bool? classifierContextIncludeAssistantTurns,
            bool? adaptive,
            global::Loud.Technology.LiteLLM.Sdk.AdaptiveRouterWeights? adaptiveWeights,
            double? tierDistancePenalty,
            global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfigAdaptiveEligible? adaptiveEligible,
            global::System.Collections.Generic.IList<string>? escalationKeywords,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeywordTierRule>? keywordTierRules,
            bool? stallEscalationEnabled,
            int? stallEscalationWindow,
            int? stallEscalationRepeatThreshold,
            string? planModeMinTier,
            global::System.Collections.Generic.IList<string>? planModePatterns,
            bool? maxTokensFromTierModel,
            bool? routeHousekeepingToCheapestTier,
            global::System.Collections.Generic.IList<string>? housekeepingPatterns,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ContextCompactionConfig, bool?>? contextCompaction,
            bool? enableContextWindowEscalation,
            double? contextWindowEscalationBuffer,
            bool? modalityRouting,
            bool? modalityPinOverride,
            bool? semanticKeywordMatching,
            string? embeddingModel,
            double? matchThreshold,
            global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfigClassificationMode? classificationMode,
            bool? sessionAffinity,
            bool? deploymentAffinity,
            int? sessionAffinityTtlSeconds,
            object? plugins,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ReminderMarkerPair>? reminderMarkers)
        {
            this.Tiers = tiers;
            this.TierModelConfigs = tierModelConfigs;
            this.EnableNonReasoningTier = enableNonReasoningTier;
            this.TierDefinitions = tierDefinitions;
            this.FallbackTier = fallbackTier;
            this.ClassificationPrompt = classificationPrompt;
            this.ClassificationExamples = classificationExamples;
            this.TierLabels = tierLabels;
            this.TierBoundaries = tierBoundaries;
            this.ReasoningOverrideMinScore = reasoningOverrideMinScore;
            this.TokenThresholds = tokenThresholds;
            this.DimensionWeights = dimensionWeights;
            this.CustomDimensions = customDimensions;
            this.CodeKeywords = codeKeywords;
            this.ReasoningKeywords = reasoningKeywords;
            this.TechnicalKeywords = technicalKeywords;
            this.CustomTechnicalKeywords = customTechnicalKeywords;
            this.SimpleKeywords = simpleKeywords;
            this.DefaultModel = defaultModel;
            this.ReturnRawModelName = returnRawModelName;
            this.ClassifierType = classifierType;
            this.LlmV2Config = llmV2Config;
            this.HeuristicV2Artifact = heuristicV2Artifact;
            this.HeuristicV2SuccessThreshold = heuristicV2SuccessThreshold;
            this.ClassifierLlmConfig = classifierLlmConfig;
            this.CapabilityClassifierConfig = capabilityClassifierConfig;
            this.JevClassifierConfig = jevClassifierConfig;
            this.HeuristicFirstMaxTier = heuristicFirstMaxTier;
            this.HybridBoundaryMargin = hybridBoundaryMargin;
            this.ClassifierPlugin = classifierPlugin;
            this.ClassifierPluginTimeoutMs = classifierPluginTimeoutMs;
            this.ClassifierFallback = classifierFallback;
            this.ClassifierContextWindowSize = classifierContextWindowSize;
            this.ClassifierContextBudgetChars = classifierContextBudgetChars;
            this.ClassifierContextPerTurnChars = classifierContextPerTurnChars;
            this.ClassifierContextIncludeAssistantTurns = classifierContextIncludeAssistantTurns;
            this.Adaptive = adaptive;
            this.AdaptiveWeights = adaptiveWeights;
            this.TierDistancePenalty = tierDistancePenalty;
            this.AdaptiveEligible = adaptiveEligible;
            this.EscalationKeywords = escalationKeywords;
            this.KeywordTierRules = keywordTierRules;
            this.StallEscalationEnabled = stallEscalationEnabled;
            this.StallEscalationWindow = stallEscalationWindow;
            this.StallEscalationRepeatThreshold = stallEscalationRepeatThreshold;
            this.PlanModeMinTier = planModeMinTier;
            this.PlanModePatterns = planModePatterns;
            this.MaxTokensFromTierModel = maxTokensFromTierModel;
            this.RouteHousekeepingToCheapestTier = routeHousekeepingToCheapestTier;
            this.HousekeepingPatterns = housekeepingPatterns;
            this.ContextCompaction = contextCompaction;
            this.EnableContextWindowEscalation = enableContextWindowEscalation;
            this.ContextWindowEscalationBuffer = contextWindowEscalationBuffer;
            this.ModalityRouting = modalityRouting;
            this.ModalityPinOverride = modalityPinOverride;
            this.SemanticKeywordMatching = semanticKeywordMatching;
            this.EmbeddingModel = embeddingModel;
            this.MatchThreshold = matchThreshold;
            this.ClassificationMode = classificationMode;
            this.SessionAffinity = sessionAffinity;
            this.DeploymentAffinity = deploymentAffinity;
            this.SessionAffinityTtlSeconds = sessionAffinityTtlSeconds;
            this.Plugins = plugins;
            this.ReminderMarkers = reminderMarkers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestComplexityRouterConfig" /> class.
        /// </summary>
        public RequestComplexityRouterConfig()
        {
        }

    }
}
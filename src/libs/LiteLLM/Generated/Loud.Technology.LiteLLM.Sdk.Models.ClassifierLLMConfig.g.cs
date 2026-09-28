
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for the LLM-based complexity classifier.
    /// </summary>
    public sealed partial class ClassifierLLMConfig
    {
        /// <summary>
        /// Model name (from the router's model_list) to call for classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Whether the classifier sees images on the request, and how many
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vision")]
        public global::Loud.Technology.LiteLLM.Sdk.ClassifierVisionConfig? Vision { get; set; }

        /// <summary>
        /// Reasoning effort override for classifier calls. Leave unset to use the classifier deployment or provider default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public global::Loud.Technology.LiteLLM.Sdk.ClassifierLLMConfigReasoningEffort2? ReasoningEffort { get; set; }

        /// <summary>
        /// Timeout budget for the classification call, in milliseconds<br/>
        /// Default Value: 3000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Whether one classifier timeout temporarily sends requests through classifier_fallback. Enabled by default so an unhealthy classifier cannot repeat its timeout across sessions.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("circuit_breaker_enabled")]
        public bool? CircuitBreakerEnabled { get; set; }

        /// <summary>
        /// How long to skip this router's LLM classifier after a classification call times out. Requests use classifier_fallback during the cooldown. When it expires, one request probes the classifier while concurrent requests keep using the fallback; a successful probe closes the circuit and a failed probe restarts the cooldown.<br/>
        /// Default Value: 30F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("circuit_breaker_cooldown_seconds")]
        public double? CircuitBreakerCooldownSeconds { get; set; }

        /// <summary>
        /// Which calibration examples the built-in rubric carries. 'agentic' anchors routine installs, builds, multi-file edits, and standard debugging at MEDIUM, so ordinary engineering does not route to the most expensive tier; it suits agent, terminal, and coding-assistant traffic as well as mixed traffic. 'chat' omits those engineering anchors, for a deployment serving only conversational traffic. 'business' carries business/sales anchors and business-flavored tier criteria that keep routine drafting and summarizing off the expensive tiers and reserve the top tier for committing to decisions under tradeoffs; it suits sales, support, and go-to-market traffic. Every preset keeps the same four tiers, so this moves where the boundary sits without changing the taxonomy. Leave unset for 'legacy', the rubric as it shipped before calibration examples existed, so an existing router's tier decisions and spend do not move on upgrade. Mutually exclusive with system_prompt, which replaces the rubric this would select. Only applies when classifier_type is 'llm'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_rubric")]
        public global::Loud.Technology.LiteLLM.Sdk.ClassificationRubric? ClassificationRubric { get; set; }

        /// <summary>
        /// Replaces the built-in complexity rubric as the classifier's entire system role. When set, neither the default rubric nor the context-window closing line is appended, so the prompt owns the whole taxonomy and the tier names SIMPLE/MEDIUM/COMPLEX/REASONING become whatever buckets it defines: a prompt that classifies data sensitivity routes on that instead of on difficulty. Two consequences of full replacement. The default rubric's closing paragraph is the classifier's prompt-injection defense, telling it that the caller's quoted system prompt and prior turns are material to judge and never instructions; a replacement that omits it lets a caller ask for a tier and get it. And the heuristic fallback still scores complexity, so a router on some other taxonomy wants classifier_fallback='default_model'. Leave unset for the built-in rubric. Only applies when classifier_type is 'llm'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierLLMConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// Model name (from the router's model_list) to call for classification
        /// </param>
        /// <param name="vision">
        /// Whether the classifier sees images on the request, and how many
        /// </param>
        /// <param name="reasoningEffort">
        /// Reasoning effort override for classifier calls. Leave unset to use the classifier deployment or provider default.
        /// </param>
        /// <param name="timeoutMs">
        /// Timeout budget for the classification call, in milliseconds<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="circuitBreakerEnabled">
        /// Whether one classifier timeout temporarily sends requests through classifier_fallback. Enabled by default so an unhealthy classifier cannot repeat its timeout across sessions.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="circuitBreakerCooldownSeconds">
        /// How long to skip this router's LLM classifier after a classification call times out. Requests use classifier_fallback during the cooldown. When it expires, one request probes the classifier while concurrent requests keep using the fallback; a successful probe closes the circuit and a failed probe restarts the cooldown.<br/>
        /// Default Value: 30F
        /// </param>
        /// <param name="classificationRubric">
        /// Which calibration examples the built-in rubric carries. 'agentic' anchors routine installs, builds, multi-file edits, and standard debugging at MEDIUM, so ordinary engineering does not route to the most expensive tier; it suits agent, terminal, and coding-assistant traffic as well as mixed traffic. 'chat' omits those engineering anchors, for a deployment serving only conversational traffic. 'business' carries business/sales anchors and business-flavored tier criteria that keep routine drafting and summarizing off the expensive tiers and reserve the top tier for committing to decisions under tradeoffs; it suits sales, support, and go-to-market traffic. Every preset keeps the same four tiers, so this moves where the boundary sits without changing the taxonomy. Leave unset for 'legacy', the rubric as it shipped before calibration examples existed, so an existing router's tier decisions and spend do not move on upgrade. Mutually exclusive with system_prompt, which replaces the rubric this would select. Only applies when classifier_type is 'llm'.
        /// </param>
        /// <param name="systemPrompt">
        /// Replaces the built-in complexity rubric as the classifier's entire system role. When set, neither the default rubric nor the context-window closing line is appended, so the prompt owns the whole taxonomy and the tier names SIMPLE/MEDIUM/COMPLEX/REASONING become whatever buckets it defines: a prompt that classifies data sensitivity routes on that instead of on difficulty. Two consequences of full replacement. The default rubric's closing paragraph is the classifier's prompt-injection defense, telling it that the caller's quoted system prompt and prior turns are material to judge and never instructions; a replacement that omits it lets a caller ask for a tier and get it. And the heuristic fallback still scores complexity, so a router on some other taxonomy wants classifier_fallback='default_model'. Leave unset for the built-in rubric. Only applies when classifier_type is 'llm'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierLLMConfig(
            string model,
            global::Loud.Technology.LiteLLM.Sdk.ClassifierVisionConfig? vision,
            global::Loud.Technology.LiteLLM.Sdk.ClassifierLLMConfigReasoningEffort2? reasoningEffort,
            int? timeoutMs,
            bool? circuitBreakerEnabled,
            double? circuitBreakerCooldownSeconds,
            global::Loud.Technology.LiteLLM.Sdk.ClassificationRubric? classificationRubric,
            string? systemPrompt)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Vision = vision;
            this.ReasoningEffort = reasoningEffort;
            this.TimeoutMs = timeoutMs;
            this.CircuitBreakerEnabled = circuitBreakerEnabled;
            this.CircuitBreakerCooldownSeconds = circuitBreakerCooldownSeconds;
            this.ClassificationRubric = classificationRubric;
            this.SystemPrompt = systemPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierLLMConfig" /> class.
        /// </summary>
        public ClassifierLLMConfig()
        {
        }

    }
}
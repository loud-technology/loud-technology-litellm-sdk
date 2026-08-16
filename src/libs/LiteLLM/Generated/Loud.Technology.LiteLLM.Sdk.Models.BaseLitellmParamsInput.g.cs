
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseLitellmParamsInput
    {
        /// <summary>
        /// Additional provider-specific parameters for generic guardrail APIs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_provider_specific_params")]
        public object? AdditionalProviderSpecificParams { get; set; }

        /// <summary>
        /// Base URL for the guardrail service API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_base")]
        public string? ApiBase { get; set; }

        /// <summary>
        /// Optional custom API endpoint for Model Armor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_endpoint")]
        public string? ApiEndpoint { get; set; }

        /// <summary>
        /// API key for the guardrail service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// List of blocked words with individual actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_words")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BlockedWord>? BlockedWords { get; set; }

        /// <summary>
        /// Path to YAML file containing blocked_words list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_words_file")]
        public string? BlockedWordsFile { get; set; }

        /// <summary>
        /// List of prebuilt categories to enable (harmful_*, bias_*)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ContentFilterCategoryConfig>? Categories { get; set; }

        /// <summary>
        /// Threshold configuration for Lakera guardrail categories
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_thresholds")]
        public global::Loud.Technology.LiteLLM.Sdk.LakeraCategoryThresholds? CategoryThresholds { get; set; }

        /// <summary>
        /// Path to Google Cloud credentials JSON file or JSON string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public string? Credentials { get; set; }

        /// <summary>
        /// Python-like code containing the apply_guardrail function for custom guardrail logic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_code")]
        public string? CustomCode { get; set; }

        /// <summary>
        /// Whether the guardrail is enabled by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_on")]
        public bool? DefaultOn { get; set; }

        /// <summary>
        /// Configuration for detect-secrets guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_secrets_config")]
        public object? DetectSecretsConfig { get; set; }

        /// <summary>
        /// For /v1/realtime sessions: automatically close the session after this many guardrail violations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_session_after_n_fails")]
        public int? EndSessionAfterNFails { get; set; }

        /// <summary>
        /// When True, guardrails only receive the latest message for the relevant role (e.g., newest user input pre-call, newest assistant output post-call)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental_use_latest_role_message_only")]
        public bool? ExperimentalUseLatestRoleMessageOnly { get; set; }

        /// <summary>
        /// Header names to forward from the client request to the guardrail (e.g. x-request-id). Only these headers' values are sent; others may be omitted or sent as [present]. Used by generic_guardrail_api (similar to MCP extra_headers).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_headers")]
        public global::System.Collections.Generic.IList<string>? ExtraHeaders { get; set; }

        /// <summary>
        /// Whether to fail the request if Model Armor encounters an error<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_on_error")]
        public bool? FailOnError { get; set; }

        /// <summary>
        /// Name of the guardrail in guardrails.ai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guard_name")]
        public string? GuardName { get; set; }

        /// <summary>
        /// Tag to use for keyword redaction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword_redaction_tag")]
        public string? KeywordRedactionTag { get; set; }

        /// <summary>
        /// Google Cloud location/region (e.g., us-central1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Will mask request content if guardrail makes any changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_request_content")]
        public bool? MaskRequestContent { get; set; }

        /// <summary>
        /// Will mask response content if guardrail makes any changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_response_content")]
        public bool? MaskResponseContent { get; set; }

        /// <summary>
        /// Optional field if guardrail requires a 'model' parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// For /v1/realtime sessions: 'warn' speaks the violation message and continues; 'end_session' speaks the message and closes the connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_violation")]
        public global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsInputOnViolation2? OnViolation { get; set; }

        /// <summary>
        /// Recipe for input (LLM request)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pangea_input_recipe")]
        public string? PangeaInputRecipe { get; set; }

        /// <summary>
        /// Recipe for output (LLM response)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pangea_output_recipe")]
        public string? PangeaOutputRecipe { get; set; }

        /// <summary>
        /// Format string for pattern redaction (use {pattern_name} placeholder)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_redaction_format")]
        public string? PatternRedactionFormat { get; set; }

        /// <summary>
        /// List of patterns (prebuilt or custom regex) to detect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patterns")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ContentFilterPattern>? Patterns { get; set; }

        /// <summary>
        /// The message the bot speaks aloud when a /v1/realtime guardrail fires. Falls back to violation_message_template if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realtime_violation_message")]
        public string? RealtimeViolationMessage { get; set; }

        /// <summary>
        /// Minimum severity to block (high, medium, low)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_threshold")]
        public string? SeverityThreshold { get; set; }

        /// <summary>
        /// When True, unified guardrails skip system-role messages when building evaluation inputs (texts and structured_messages). When False, system messages are included even if litellm_settings sets a global skip. When None, use the global litellm.skip_system_message_in_guardrail setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_system_message_in_guardrail")]
        public bool? SkipSystemMessageInGuardrail { get; set; }

        /// <summary>
        /// The ID of your Model Armor template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Behavior when a guardrail endpoint is unreachable due to network errors. NOTE: This is currently only implemented by guardrail='generic_guardrail_api'. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and allows the request to proceed.<br/>
        /// Default Value: fail_closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unreachable_fallback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.BaseLitellmParamsInputUnreachableFallbackJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsInputUnreachableFallback? UnreachableFallback { get; set; }

        /// <summary>
        /// Custom message when a guardrail blocks an action. Supports placeholders like {tool_name}, {rule_id}, and {default_message}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violation_message_template")]
        public string? ViolationMessageTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseLitellmParamsInput" /> class.
        /// </summary>
        /// <param name="additionalProviderSpecificParams">
        /// Additional provider-specific parameters for generic guardrail APIs
        /// </param>
        /// <param name="apiBase">
        /// Base URL for the guardrail service API
        /// </param>
        /// <param name="apiEndpoint">
        /// Optional custom API endpoint for Model Armor
        /// </param>
        /// <param name="apiKey">
        /// API key for the guardrail service
        /// </param>
        /// <param name="blockedWords">
        /// List of blocked words with individual actions
        /// </param>
        /// <param name="blockedWordsFile">
        /// Path to YAML file containing blocked_words list
        /// </param>
        /// <param name="categories">
        /// List of prebuilt categories to enable (harmful_*, bias_*)
        /// </param>
        /// <param name="categoryThresholds">
        /// Threshold configuration for Lakera guardrail categories
        /// </param>
        /// <param name="credentials">
        /// Path to Google Cloud credentials JSON file or JSON string
        /// </param>
        /// <param name="customCode">
        /// Python-like code containing the apply_guardrail function for custom guardrail logic
        /// </param>
        /// <param name="defaultOn">
        /// Whether the guardrail is enabled by default
        /// </param>
        /// <param name="detectSecretsConfig">
        /// Configuration for detect-secrets guardrail
        /// </param>
        /// <param name="endSessionAfterNFails">
        /// For /v1/realtime sessions: automatically close the session after this many guardrail violations.
        /// </param>
        /// <param name="experimentalUseLatestRoleMessageOnly">
        /// When True, guardrails only receive the latest message for the relevant role (e.g., newest user input pre-call, newest assistant output post-call)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="extraHeaders">
        /// Header names to forward from the client request to the guardrail (e.g. x-request-id). Only these headers' values are sent; others may be omitted or sent as [present]. Used by generic_guardrail_api (similar to MCP extra_headers).
        /// </param>
        /// <param name="failOnError">
        /// Whether to fail the request if Model Armor encounters an error<br/>
        /// Default Value: true
        /// </param>
        /// <param name="guardName">
        /// Name of the guardrail in guardrails.ai
        /// </param>
        /// <param name="keywordRedactionTag">
        /// Tag to use for keyword redaction
        /// </param>
        /// <param name="location">
        /// Google Cloud location/region (e.g., us-central1)
        /// </param>
        /// <param name="maskRequestContent">
        /// Will mask request content if guardrail makes any changes
        /// </param>
        /// <param name="maskResponseContent">
        /// Will mask response content if guardrail makes any changes
        /// </param>
        /// <param name="model">
        /// Optional field if guardrail requires a 'model' parameter
        /// </param>
        /// <param name="onViolation">
        /// For /v1/realtime sessions: 'warn' speaks the violation message and continues; 'end_session' speaks the message and closes the connection.
        /// </param>
        /// <param name="pangeaInputRecipe">
        /// Recipe for input (LLM request)
        /// </param>
        /// <param name="pangeaOutputRecipe">
        /// Recipe for output (LLM response)
        /// </param>
        /// <param name="patternRedactionFormat">
        /// Format string for pattern redaction (use {pattern_name} placeholder)
        /// </param>
        /// <param name="patterns">
        /// List of patterns (prebuilt or custom regex) to detect
        /// </param>
        /// <param name="realtimeViolationMessage">
        /// The message the bot speaks aloud when a /v1/realtime guardrail fires. Falls back to violation_message_template if not set.
        /// </param>
        /// <param name="severityThreshold">
        /// Minimum severity to block (high, medium, low)
        /// </param>
        /// <param name="skipSystemMessageInGuardrail">
        /// When True, unified guardrails skip system-role messages when building evaluation inputs (texts and structured_messages). When False, system messages are included even if litellm_settings sets a global skip. When None, use the global litellm.skip_system_message_in_guardrail setting.
        /// </param>
        /// <param name="templateId">
        /// The ID of your Model Armor template
        /// </param>
        /// <param name="unreachableFallback">
        /// Behavior when a guardrail endpoint is unreachable due to network errors. NOTE: This is currently only implemented by guardrail='generic_guardrail_api'. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and allows the request to proceed.<br/>
        /// Default Value: fail_closed
        /// </param>
        /// <param name="violationMessageTemplate">
        /// Custom message when a guardrail blocks an action. Supports placeholders like {tool_name}, {rule_id}, and {default_message}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseLitellmParamsInput(
            object? additionalProviderSpecificParams,
            string? apiBase,
            string? apiEndpoint,
            string? apiKey,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BlockedWord>? blockedWords,
            string? blockedWordsFile,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ContentFilterCategoryConfig>? categories,
            global::Loud.Technology.LiteLLM.Sdk.LakeraCategoryThresholds? categoryThresholds,
            string? credentials,
            string? customCode,
            bool? defaultOn,
            object? detectSecretsConfig,
            int? endSessionAfterNFails,
            bool? experimentalUseLatestRoleMessageOnly,
            global::System.Collections.Generic.IList<string>? extraHeaders,
            bool? failOnError,
            string? guardName,
            string? keywordRedactionTag,
            string? location,
            bool? maskRequestContent,
            bool? maskResponseContent,
            string? model,
            global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsInputOnViolation2? onViolation,
            string? pangeaInputRecipe,
            string? pangeaOutputRecipe,
            string? patternRedactionFormat,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ContentFilterPattern>? patterns,
            string? realtimeViolationMessage,
            string? severityThreshold,
            bool? skipSystemMessageInGuardrail,
            string? templateId,
            global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsInputUnreachableFallback? unreachableFallback,
            string? violationMessageTemplate)
        {
            this.AdditionalProviderSpecificParams = additionalProviderSpecificParams;
            this.ApiBase = apiBase;
            this.ApiEndpoint = apiEndpoint;
            this.ApiKey = apiKey;
            this.BlockedWords = blockedWords;
            this.BlockedWordsFile = blockedWordsFile;
            this.Categories = categories;
            this.CategoryThresholds = categoryThresholds;
            this.Credentials = credentials;
            this.CustomCode = customCode;
            this.DefaultOn = defaultOn;
            this.DetectSecretsConfig = detectSecretsConfig;
            this.EndSessionAfterNFails = endSessionAfterNFails;
            this.ExperimentalUseLatestRoleMessageOnly = experimentalUseLatestRoleMessageOnly;
            this.ExtraHeaders = extraHeaders;
            this.FailOnError = failOnError;
            this.GuardName = guardName;
            this.KeywordRedactionTag = keywordRedactionTag;
            this.Location = location;
            this.MaskRequestContent = maskRequestContent;
            this.MaskResponseContent = maskResponseContent;
            this.Model = model;
            this.OnViolation = onViolation;
            this.PangeaInputRecipe = pangeaInputRecipe;
            this.PangeaOutputRecipe = pangeaOutputRecipe;
            this.PatternRedactionFormat = patternRedactionFormat;
            this.Patterns = patterns;
            this.RealtimeViolationMessage = realtimeViolationMessage;
            this.SeverityThreshold = severityThreshold;
            this.SkipSystemMessageInGuardrail = skipSystemMessageInGuardrail;
            this.TemplateId = templateId;
            this.UnreachableFallback = unreachableFallback;
            this.ViolationMessageTemplate = violationMessageTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseLitellmParamsInput" /> class.
        /// </summary>
        public BaseLitellmParamsInput()
        {
        }

    }
}
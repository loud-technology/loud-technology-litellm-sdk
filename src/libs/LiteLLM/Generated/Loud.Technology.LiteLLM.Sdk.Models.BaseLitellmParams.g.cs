
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BaseLitellmParams
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
        /// Whether to fail the request if the guardrail encounters an error. Implemented by guardrail='model_armor', 'generic_guardrail_api' and 'crowdstrike_aidr'. True (default) raises the error. False logs a critical error and lets the request proceed, so only a valid guardrail response can block or modify it.<br/>
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
        /// When True, the Aim and Cato Networks guardrails send /embeddings `input` to the vendor as user messages. Off by default because embedding input is documents being indexed, not a conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspect_embeddings")]
        public bool? InspectEmbeddings { get; set; }

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
        /// Action to take when sensitive data is detected. 'block' raises an exception (default behavior). 'route' reroutes the request to the model specified in sensitive_data_route_to_model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_sensitive_data")]
        public global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsOnSensitiveData2? OnSensitiveData { get; set; }

        /// <summary>
        /// For /v1/realtime sessions: 'warn' speaks the violation message and continues; 'end_session' speaks the message and closes the connection. For guardrail='mcp_security': 'block' rejects the request; 'alert' only logs a warning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_violation")]
        public global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsOnViolation2? OnViolation { get; set; }

        /// <summary>
        /// When True, the guardrail only scans messages that have not already been scanned earlier in the same session (identified by litellm_session_id / session_id). Message content is hashed per session and cached; only the diff (new or edited messages) is sent to the guardrail provider on follow-up calls. Falls back to a full scan when the request has no session id or the cache is unavailable. Intended for blocking/detection guardrails; not applied when mask_request_content is set.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only_scan_new_messages")]
        public bool? OnlyScanNewMessages { get; set; }

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
        /// When True, this pre_call or post_call guardrail runs concurrently with other opted-in guardrails of the same hook, after the sequential guardrails have run. Use only for block-only guardrails that inspect and reject; do not enable it for guardrails that modify the request or response (e.g. PII masking or sensitive-data routing), since parallel runs share one snapshot and their mutations would race.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_in_parallel")]
        public bool? RunInParallel { get; set; }

        /// <summary>
        /// For guardrail='model_armor': omit the raw Model Armor response from caller-facing errors and logs by default. Set False to restore verbose output.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sanitize_error_detail")]
        public bool? SanitizeErrorDetail { get; set; }

        /// <summary>
        /// When True, unified guardrails only evaluate tool results, the untrusted data an agent feeds back into the model, and skip system, user, and assistant content. Intended for agent harnesses whose own prompt scaffolding is trusted but often trips prompt-attack detectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scan_only_tool_results")]
        public bool? ScanOnlyToolResults { get; set; }

        /// <summary>
        /// When True, this pre_call guardrail always evaluates the request as it was before any guardrail in this hook ran, regardless of its position in the guardrails list -- so the YAML order of guardrails can never change whether this one blocks. Use only for block-only guardrails: any data this guardrail returns is discarded, same contract as run_in_parallel, since an earlier guardrail's masking must not be undone by this one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scan_raw_request")]
        public bool? ScanRawRequest { get; set; }

        /// <summary>
        /// Model to route requests to when sensitive data is detected and on_sensitive_data='route'. This is typically an on-premise model for data privacy. The routing decision persists for the entire session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitive_data_route_to_model")]
        public string? SensitiveDataRouteToModel { get; set; }

        /// <summary>
        /// Minimum severity to block (high, medium, low)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_threshold")]
        public string? SeverityThreshold { get; set; }

        /// <summary>
        /// When True, unified guardrails skip system-role messages when building evaluation inputs (texts and structured_messages). When False, system messages are included even if litellm_settings sets a global skip. When None, use the global litellm.skip_system_message_in_guardrail setting. For Anthropic /v1/messages, the flag applies only to the trusted top-level system prompt. In-sequence system entries are untrusted client input and remain in texts and structured_messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_system_message_in_guardrail")]
        public bool? SkipSystemMessageInGuardrail { get; set; }

        /// <summary>
        /// When True, unified guardrails skip tool-role messages when building evaluation inputs (texts and structured_messages). When False, tool messages are included even if litellm_settings sets a global skip. When None, use the global litellm.skip_tool_message_in_guardrail setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_tool_message_in_guardrail")]
        public bool? SkipToolMessageInGuardrail { get; set; }

        /// <summary>
        /// Implemented by guardrail='model_armor'. When True, attachment references that carry no inline bytes (file_id, gs://, or http(s) URLs) pass through unscanned instead of blocking, while fail_on_error still governs real Model Armor API errors. Default False blocks them.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_unscannable_attachments")]
        public bool? SkipUnscannableAttachments { get; set; }

        /// <summary>
        /// When True (default), after sensitive data is detected and routed, all subsequent requests in the same session will continue routing to the same model.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sticky_session_routing")]
        public bool? StickySessionRouting { get; set; }

        /// <summary>
        /// The ID of your Model Armor template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Per-request timeout for the guardrail provider API call (seconds). Accepts int, float, or numeric string; coerced to float on load. Each guardrail handler chooses its own default when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Behavior when a guardrail endpoint is unreachable due to network errors. Implemented by guardrail='generic_guardrail_api', 'agent_365', 'akto', 'vigil_guard', 'repelloai', 'headroom', 'compresr', and 'typesafe'. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and allows the request to proceed.<br/>
        /// Default Value: fail_closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unreachable_fallback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.BaseLitellmParamsUnreachableFallbackJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsUnreachableFallback? UnreachableFallback { get; set; }

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
        /// Initializes a new instance of the <see cref="BaseLitellmParams" /> class.
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
        /// Whether to fail the request if the guardrail encounters an error. Implemented by guardrail='model_armor', 'generic_guardrail_api' and 'crowdstrike_aidr'. True (default) raises the error. False logs a critical error and lets the request proceed, so only a valid guardrail response can block or modify it.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="guardName">
        /// Name of the guardrail in guardrails.ai
        /// </param>
        /// <param name="inspectEmbeddings">
        /// When True, the Aim and Cato Networks guardrails send /embeddings `input` to the vendor as user messages. Off by default because embedding input is documents being indexed, not a conversation.
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
        /// <param name="onSensitiveData">
        /// Action to take when sensitive data is detected. 'block' raises an exception (default behavior). 'route' reroutes the request to the model specified in sensitive_data_route_to_model.
        /// </param>
        /// <param name="onViolation">
        /// For /v1/realtime sessions: 'warn' speaks the violation message and continues; 'end_session' speaks the message and closes the connection. For guardrail='mcp_security': 'block' rejects the request; 'alert' only logs a warning.
        /// </param>
        /// <param name="onlyScanNewMessages">
        /// When True, the guardrail only scans messages that have not already been scanned earlier in the same session (identified by litellm_session_id / session_id). Message content is hashed per session and cached; only the diff (new or edited messages) is sent to the guardrail provider on follow-up calls. Falls back to a full scan when the request has no session id or the cache is unavailable. Intended for blocking/detection guardrails; not applied when mask_request_content is set.<br/>
        /// Default Value: false
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
        /// <param name="runInParallel">
        /// When True, this pre_call or post_call guardrail runs concurrently with other opted-in guardrails of the same hook, after the sequential guardrails have run. Use only for block-only guardrails that inspect and reject; do not enable it for guardrails that modify the request or response (e.g. PII masking or sensitive-data routing), since parallel runs share one snapshot and their mutations would race.
        /// </param>
        /// <param name="sanitizeErrorDetail">
        /// For guardrail='model_armor': omit the raw Model Armor response from caller-facing errors and logs by default. Set False to restore verbose output.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="scanOnlyToolResults">
        /// When True, unified guardrails only evaluate tool results, the untrusted data an agent feeds back into the model, and skip system, user, and assistant content. Intended for agent harnesses whose own prompt scaffolding is trusted but often trips prompt-attack detectors.
        /// </param>
        /// <param name="scanRawRequest">
        /// When True, this pre_call guardrail always evaluates the request as it was before any guardrail in this hook ran, regardless of its position in the guardrails list -- so the YAML order of guardrails can never change whether this one blocks. Use only for block-only guardrails: any data this guardrail returns is discarded, same contract as run_in_parallel, since an earlier guardrail's masking must not be undone by this one.
        /// </param>
        /// <param name="sensitiveDataRouteToModel">
        /// Model to route requests to when sensitive data is detected and on_sensitive_data='route'. This is typically an on-premise model for data privacy. The routing decision persists for the entire session.
        /// </param>
        /// <param name="severityThreshold">
        /// Minimum severity to block (high, medium, low)
        /// </param>
        /// <param name="skipSystemMessageInGuardrail">
        /// When True, unified guardrails skip system-role messages when building evaluation inputs (texts and structured_messages). When False, system messages are included even if litellm_settings sets a global skip. When None, use the global litellm.skip_system_message_in_guardrail setting. For Anthropic /v1/messages, the flag applies only to the trusted top-level system prompt. In-sequence system entries are untrusted client input and remain in texts and structured_messages.
        /// </param>
        /// <param name="skipToolMessageInGuardrail">
        /// When True, unified guardrails skip tool-role messages when building evaluation inputs (texts and structured_messages). When False, tool messages are included even if litellm_settings sets a global skip. When None, use the global litellm.skip_tool_message_in_guardrail setting.
        /// </param>
        /// <param name="skipUnscannableAttachments">
        /// Implemented by guardrail='model_armor'. When True, attachment references that carry no inline bytes (file_id, gs://, or http(s) URLs) pass through unscanned instead of blocking, while fail_on_error still governs real Model Armor API errors. Default False blocks them.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stickySessionRouting">
        /// When True (default), after sensitive data is detected and routed, all subsequent requests in the same session will continue routing to the same model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="templateId">
        /// The ID of your Model Armor template
        /// </param>
        /// <param name="timeout">
        /// Per-request timeout for the guardrail provider API call (seconds). Accepts int, float, or numeric string; coerced to float on load. Each guardrail handler chooses its own default when unset.
        /// </param>
        /// <param name="unreachableFallback">
        /// Behavior when a guardrail endpoint is unreachable due to network errors. Implemented by guardrail='generic_guardrail_api', 'agent_365', 'akto', 'vigil_guard', 'repelloai', 'headroom', 'compresr', and 'typesafe'. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and allows the request to proceed.<br/>
        /// Default Value: fail_closed
        /// </param>
        /// <param name="violationMessageTemplate">
        /// Custom message when a guardrail blocks an action. Supports placeholders like {tool_name}, {rule_id}, and {default_message}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseLitellmParams(
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
            bool? inspectEmbeddings,
            string? keywordRedactionTag,
            string? location,
            bool? maskRequestContent,
            bool? maskResponseContent,
            string? model,
            global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsOnSensitiveData2? onSensitiveData,
            global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsOnViolation2? onViolation,
            bool? onlyScanNewMessages,
            string? pangeaInputRecipe,
            string? pangeaOutputRecipe,
            string? patternRedactionFormat,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ContentFilterPattern>? patterns,
            string? realtimeViolationMessage,
            bool? runInParallel,
            bool? sanitizeErrorDetail,
            bool? scanOnlyToolResults,
            bool? scanRawRequest,
            string? sensitiveDataRouteToModel,
            string? severityThreshold,
            bool? skipSystemMessageInGuardrail,
            bool? skipToolMessageInGuardrail,
            bool? skipUnscannableAttachments,
            bool? stickySessionRouting,
            string? templateId,
            double? timeout,
            global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsUnreachableFallback? unreachableFallback,
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
            this.InspectEmbeddings = inspectEmbeddings;
            this.KeywordRedactionTag = keywordRedactionTag;
            this.Location = location;
            this.MaskRequestContent = maskRequestContent;
            this.MaskResponseContent = maskResponseContent;
            this.Model = model;
            this.OnSensitiveData = onSensitiveData;
            this.OnViolation = onViolation;
            this.OnlyScanNewMessages = onlyScanNewMessages;
            this.PangeaInputRecipe = pangeaInputRecipe;
            this.PangeaOutputRecipe = pangeaOutputRecipe;
            this.PatternRedactionFormat = patternRedactionFormat;
            this.Patterns = patterns;
            this.RealtimeViolationMessage = realtimeViolationMessage;
            this.RunInParallel = runInParallel;
            this.SanitizeErrorDetail = sanitizeErrorDetail;
            this.ScanOnlyToolResults = scanOnlyToolResults;
            this.ScanRawRequest = scanRawRequest;
            this.SensitiveDataRouteToModel = sensitiveDataRouteToModel;
            this.SeverityThreshold = severityThreshold;
            this.SkipSystemMessageInGuardrail = skipSystemMessageInGuardrail;
            this.SkipToolMessageInGuardrail = skipToolMessageInGuardrail;
            this.SkipUnscannableAttachments = skipUnscannableAttachments;
            this.StickySessionRouting = stickySessionRouting;
            this.TemplateId = templateId;
            this.Timeout = timeout;
            this.UnreachableFallback = unreachableFallback;
            this.ViolationMessageTemplate = violationMessageTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseLitellmParams" /> class.
        /// </summary>
        public BaseLitellmParams()
        {
        }

    }
}
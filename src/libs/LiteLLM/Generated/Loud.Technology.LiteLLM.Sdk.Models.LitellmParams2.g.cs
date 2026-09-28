
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LitellmParams2
    {
        /// <summary>
        /// 'block' raises an error; 'mask' replaces the code block with a placeholder.<br/>
        /// Default Value: block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LitellmParamsActionJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsAction? Action { get; set; }

        /// <summary>
        /// Additional provider-specific parameters for generic guardrail APIs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_provider_specific_params")]
        public object? AdditionalProviderSpecificParams { get; set; }

        /// <summary>
        /// Custom advisory message template used when on_flagged='inject_system_message'. Must contain a {reason} placeholder. Defaults to a generic advisory message if unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_system_message")]
        public string? AdvisorySystemMessage { get; set; }

        /// <summary>
        /// Agent identity reported to Agent 365 with every tool evaluation. When unset, the caller's key alias is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Akto account ID for multi-tenant deployments. Env: AKTO_ACCOUNT_ID. Default: '1000000'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akto_account_id")]
        public string? AktoAccountId { get; set; }

        /// <summary>
        /// API key for Akto. Env: AKTO_API_KEY.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akto_api_key")]
        public string? AktoApiKey { get; set; }

        /// <summary>
        /// Akto Guardrail API Base URL. Env: AKTO_GUARDRAIL_API_BASE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akto_base_url")]
        public string? AktoBaseUrl { get; set; }

        /// <summary>
        /// Akto VXLAN ID. Env: AKTO_VXLAN_ID. Default: '0'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akto_vxlan_id")]
        public string? AktoVxlanId { get; set; }

        /// <summary>
        /// If True, replaces sensitive content with anonymized version when only PII/PCI/secrets are detected. Only applies in blocking mode. Defaults to False if not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anonymize_input")]
        public bool? AnonymizeInput { get; set; }

        /// <summary>
        /// Regional base URL for the Cisco AI Defense Inspection API. Defaults to https://us.api.inspect.aidefense.security.cisco.com. Supported regions: us (us-west-2), ap (ap-ne-1), eu (eu-central-1). The environment variable `CISCO_AI_DEFENSE_API_BASE` is consulted as a fallback. The endpoint path is derived from inspection_type (/api/v1/inspect/chat for 'chat', /api/v1/inspect/mcp for 'mcp').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_base")]
        public string? ApiBase { get; set; }

        /// <summary>
        /// Optional custom API endpoint for Model Armor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_endpoint")]
        public string? ApiEndpoint { get; set; }

        /// <summary>
        /// The Hiddenlayer API Id for the Hiddenlayer API. If not provided, the `HIDDENLAYER_CLIENT_ID` environment variable is checked or https://api.hiddenlayer.ai is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_id")]
        public string? ApiId { get; set; }

        /// <summary>
        /// API key for the Cisco AI Defense inspection endpoint. If not provided, the `CISCO_AI_DEFENSE_API_KEY` environment variable is used. Sent in the `X-Cisco-AI-Defense-API-Key` header. Both the chat and MCP endpoints use this key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// API version for Javelin service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Application name for Javelin service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application")]
        public string? Application { get; set; }

        /// <summary>
        /// Application ID for Noma Security. Defaults to 'litellm' if not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// Custom assertions to validate against the output. Each assertion is a string describing a condition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assertions")]
        public global::System.Collections.Generic.IList<string>? Assertions { get; set; }

        /// <summary>
        /// Repello asset ID whose dashboard policies are enforced. Required; the guardrail raises at init if it is missing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Set to True to request asynchronous analysis (sets `plr_async` header). Defaults to provider behaviour when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_mode")]
        public bool? AsyncMode { get; set; }

        /// <summary>
        /// Authorization bearer token for IBM Guardrails API. Reads from IBM_GUARDRAILS_AUTH_TOKEN env var if None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_token")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// AWS access key ID for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS Bedrock runtime endpoint URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_bedrock_runtime_endpoint")]
        public string? AwsBedrockRuntimeEndpoint { get; set; }

        /// <summary>
        /// External ID required by the target role's trust policy on sts:AssumeRole
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_external_id")]
        public string? AwsExternalId { get; set; }

        /// <summary>
        /// AWS profile name for credential retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_profile_name")]
        public string? AwsProfileName { get; set; }

        /// <summary>
        /// AWS region where your guardrail is deployed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region_name")]
        public string? AwsRegionName { get; set; }

        /// <summary>
        /// AWS role name for assuming roles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_name")]
        public string? AwsRoleName { get; set; }

        /// <summary>
        /// AWS secret access key for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        /// Name of the AWS session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_name")]
        public string? AwsSessionName { get; set; }

        /// <summary>
        /// AWS session token for temporary credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_token")]
        public string? AwsSessionToken { get; set; }

        /// <summary>
        /// AWS STS endpoint URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_sts_endpoint")]
        public string? AwsStsEndpoint { get; set; }

        /// <summary>
        /// Web identity token for AWS role assumption
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_web_identity_token")]
        public string? AwsWebIdentityToken { get; set; }

        /// <summary>
        /// Base URL for the IBM Guardrails server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// If True, blocks requests on API failures. Defaults to True if not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_failures")]
        public bool? BlockFailures { get; set; }

        /// <summary>
        /// Whether to block the request when the PromptGuard API is unreachable. Defaults to true (fail-closed). Set to false for fail-open behaviour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_on_error")]
        public bool? BlockOnError { get; set; }

        /// <summary>
        /// Whether to block requests when violations are detected. Defaults to True.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_on_violation")]
        public bool? BlockOnViolation { get; set; }

        /// <summary>
        /// Language tags to block (e.g. python, javascript, bash). Empty or None = block all fenced code blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_languages")]
        public global::System.Collections.Generic.IList<string>? BlockedLanguages { get; set; }

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
        /// Whether to include breakdown in the response<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public bool? Breakdown { get; set; }

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
        /// Inject the Headroom retrieval tool for hashes declared by the compression service.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ccr_retrieval")]
        public bool? CcrRetrieval { get; set; }

        /// <summary>
        /// Inline safeguards for the resource-less InvokeGuardrailChecks API (contentFilter / promptAttack / sensitiveInformation). When set, the guardrail calls InvokeGuardrailChecks instead of ApplyGuardrail and no guardrailIdentifier is required. Mutually exclusive with guardrailIdentifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::Loud.Technology.LiteLLM.Sdk.BedrockChecksConfigModel? Checks { get; set; }

        /// <summary>
        /// ApplyGuardrail: batch size, in characters, used to re-send content after AWS has rejected a request as too large. Requests AWS accepts are always sent in a single call, so this has no effect until a rejection happens. Defaults to 25,000; a batch AWS still rejects is bisected automatically, so this value only trades round trips against batch size and cannot fail a request on its own.<br/>
        /// Default Value: 25000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_budget_chars")]
        public int? ChunkBudgetChars { get; set; }

        /// <summary>
        /// Client id of the gateway's Entra app registration (a confidential client). Falls back to the AGENT365_CLIENT_ID environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Client secret of the gateway's Entra app registration, used to perform the On-Behalf-Of exchange. Falls back to the AGENT365_CLIENT_SECRET environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Only block or mask when detection confidence &gt;= this value; below threshold, allow or log_only.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_threshold")]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// Additional configuration for the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// InvokeGuardrailChecks: block when any contentFilter severityScore &gt;= this value (scores are in [0,1]). Set to null to make the content filter detect-only (logged, never blocks).<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filter_threshold")]
        public double? ContentFilterThreshold { get; set; }

        /// <summary>
        /// Enable content moderation to check for harmful content (harassment, hate speech, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_moderation_check")]
        public bool? ContentModerationCheck { get; set; }

        /// <summary>
        /// ApplyGuardrail: when True, post-call scans of a request with no grounding_source / query content parts send the system and developer messages as the grounding source and the latest user message as the query, so the guardrail's contextual grounding policy can score the response. Bedrock bills contextual grounding units for these scans and rejects queries, sources and responses over its contextual grounding length limits, so leave this off for guardrails without a contextual grounding policy. Default False: plain messages are never sent as grounding context.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextual_grounding_from_messages")]
        public bool? ContextualGroundingFromMessages { get; set; }

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
        /// The DeepKeep Firewall ID to use for guardrail evaluation. If not provided, the `DEEPKEEP_FIREWALL_ID` environment variable is checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepkeep_firewall_id")]
        public string? DeepkeepFirewallId { get; set; }

        /// <summary>
        /// Fallback decision when no rule matches<br/>
        /// Default Value: deny
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LitellmParamsDefaultActionJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsDefaultAction? DefaultAction { get; set; }

        /// <summary>
        /// Whether the guardrail is enabled by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_on")]
        public bool? DefaultOn { get; set; }

        /// <summary>
        /// The EnkryptAI deployment name to use. Sent via X-Enkrypt-Deployment header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// When True, block only when user intent is to run/execute; allow when intent is explain/refactor/don't run. Also block text-only execution requests (e.g. 'run `ls`', 'read /etc/passwd').<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_execution_intent")]
        public bool? DetectExecutionIntent { get; set; }

        /// <summary>
        /// Configuration for detect-secrets guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_secrets_config")]
        public object? DetectSecretsConfig { get; set; }

        /// <summary>
        /// Name of the detector inside the server (e.g., 'jailbreak-detector')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detector_id")]
        public string? DetectorId { get; set; }

        /// <summary>
        /// Dictionary of detector configurations (e.g., {'nsfw': {'enabled': True}, 'toxicity': {'enabled': True}}).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectors")]
        public object? Detectors { get; set; }

        /// <summary>
        /// Whether to include developer information in the response<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dev_info")]
        public bool? DevInfo { get; set; }

        /// <summary>
        /// If True, will not raise an exception when the guardrail is blocked. Useful for OpenWebUI where exceptions can end the chat flow.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_exception_on_block")]
        public bool? DisableExceptionOnBlock { get; set; }

        /// <summary>
        /// For /v1/realtime sessions: automatically close the session after this many guardrail violations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_session_after_n_fails")]
        public int? EndSessionAfterNFails { get; set; }

        /// <summary>
        /// Pre-configured evaluation ID from Qualifire dashboard. When provided, uses invoke_evaluation() instead of evaluate().
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_id")]
        public string? EvaluationId { get; set; }

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
        /// Enable grounding verification to ensure output is grounded in provided context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding_check")]
        public bool? GroundingCheck { get; set; }

        /// <summary>
        /// Strictness level for XecGuard context-grounding validation. 'BALANCED' (default) treats INCOMPLETE answers as SAFE; 'STRICT' flags them as UNSAFE. Grounding only runs in post_call when `metadata.xecguard_grounding_documents` is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding_strictness")]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsGroundingStrictness2? GroundingStrictness { get; set; }

        /// <summary>
        /// Name of the Javelin guard to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guard_name")]
        public string? GuardName { get; set; }

        /// <summary>
        /// The type of guardrail integration to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Guardrail { get; set; }

        /// <summary>
        /// The ID of your guardrail on Bedrock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrailIdentifier")]
        public string? GuardrailIdentifier { get; set; }

        /// <summary>
        /// The version of your Bedrock guardrail (e.g., DRAFT or version number)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrailVersion")]
        public string? GuardrailVersion { get; set; }

        /// <summary>
        /// HTTP timeout in seconds. Default: 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_timeout")]
        public int? GuardrailTimeout { get; set; }

        /// <summary>
        /// Enable hallucination detection to detect factual inaccuracies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hallucinations_check")]
        public bool? HallucinationsCheck { get; set; }

        /// <summary>
        /// Include detailed evidence payloads in responses (sets `plr_evidence` header).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_evidence")]
        public bool? IncludeEvidence { get; set; }

        /// <summary>
        /// Include scanner category summaries in responses (sets `plr_scanners` header).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_scanners")]
        public bool? IncludeScanners { get; set; }

        /// <summary>
        /// When True, the Aim and Cato Networks guardrails send /embeddings `input` to the vendor as user messages. Off by default because embedding input is documents being indexed, not a conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspect_embeddings")]
        public bool? InspectEmbeddings { get; set; }

        /// <summary>
        /// Boolean flag to determine if calling a detector server (True) or the FMS Orchestrator (False). Defaults to True.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_detector_server")]
        public bool? IsDetectorServer { get; set; }

        /// <summary>
        /// Tag to use for keyword redaction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword_redaction_tag")]
        public string? KeywordRedactionTag { get; set; }

        /// <summary>
        /// Conversation ID for the Lasso guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lasso_conversation_id")]
        public string? LassoConversationId { get; set; }

        /// <summary>
        /// User ID for the Lasso guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lasso_user_id")]
        public string? LassoUserId { get; set; }

        /// <summary>
        /// Google Cloud location/region (e.g., us-central1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Enable content masking using Lasso classifix API<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public bool? Mask { get; set; }

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
        /// Additional metadata to include in the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Mock redacted text for testing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mock_redacted_text")]
        public object? MockRedactedText { get; set; }

        /// <summary>
        /// When to apply the guardrail (pre_call, post_call, during_call, logging_only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::Loud.Technology.LiteLLM.Sdk.Mode3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Loud.Technology.LiteLLM.Sdk.Mode3> Mode { get; set; }

        /// <summary>
        /// Model name forwarded to the headroom /v1/compress endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// If True, logs violations without blocking. Defaults to False if not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitor_mode")]
        public bool? MonitorMode { get; set; }

        /// <summary>
        /// Choose whether disallowed tools block the request or get rewritten out of the payload<br/>
        /// Default Value: block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disallowed_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LitellmParamsOnDisallowedActionJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsOnDisallowedAction? OnDisallowedAction { get; set; }

        /// <summary>
        /// Action to take when content is flagged: 'block' (raise exception), 'monitor' (log only), or 'inject_system_message' (append an advisory system message and let the LLM decide)<br/>
        /// Default Value: block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_flagged")]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsOnFlagged2? OnFlagged { get; set; }

        /// <summary>
        /// Action to take when content is flagged: 'block' (raise exception) or 'monitor' (log only)<br/>
        /// Default Value: monitor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_flagged_action")]
        public string? OnFlaggedAction { get; set; }

        /// <summary>
        /// Action to take when sensitive data is detected. 'block' raises an exception (default behavior). 'route' reroutes the request to the model specified in sensitive_data_route_to_model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_sensitive_data")]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsOnSensitiveData2? OnSensitiveData { get; set; }

        /// <summary>
        /// For /v1/realtime sessions: 'warn' speaks the violation message and continues; 'end_session' speaks the message and closes the connection. For guardrail='mcp_security': 'block' rejects the request; 'alert' only logs a warning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_violation")]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsOnViolation2? OnViolation { get; set; }

        /// <summary>
        /// When True, the guardrail only scans messages that have not already been scanned earlier in the same session (identified by litellm_session_id / session_id). Message content is hashed per session and cached; only the diff (new or edited messages) is sent to the guardrail provider on follow-up calls. Falls back to a full scan when the request has no session id or the cache is unavailable. Intended for blocking/detection guardrails; not applied when mask_request_content is set.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only_scan_new_messages")]
        public bool? OnlyScanNewMessages { get; set; }

        /// <summary>
        /// Optional parameters for the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optional_params")]
        public global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParams? OptionalParams { get; set; }

        /// <summary>
        /// When True, LiteLLM will replace the masked text with the original text in the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_parse_pii")]
        public bool? OutputParsePii { get; set; }

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
        /// Whether to include payload in the response<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public bool? Payload { get; set; }

        /// <summary>
        /// Controls Pillar session persistence (sets `plr_persist` header). Set to False to disable persistence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist_session")]
        public bool? PersistSession { get; set; }

        /// <summary>
        /// Enable PII (Personally Identifiable Information) detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_check")]
        public bool? PiiCheck { get; set; }

        /// <summary>
        /// InvokeGuardrailChecks: block when any sensitiveInformation confidenceScore &gt;= this value (scores are in [0,1]). Set to null to make PII detection detect-only.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_confidence_threshold")]
        public double? PiiConfidenceThreshold { get; set; }

        /// <summary>
        /// Configuration for PII entity types and actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_entities_config")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.PiiAction>? PiiEntitiesConfig { get; set; }

        /// <summary>
        /// Policy ID for Zscaler AI Guard. Can also be set via ZSCALER_AI_GUARD_POLICY_ID environment variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_id")]
        public int? PolicyId { get; set; }

        /// <summary>
        /// The EnkryptAI policy name to use. Sent via x-enkrypt-policy header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_name")]
        public string? PolicyName { get; set; }

        /// <summary>
        /// XecGuard policies to apply on each scan. Select one or more of the built-in default policies; if none are selected, the guardrail defaults to System Prompt Enforcement + Harmful Content Protection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_names")]
        public global::System.Collections.Generic.IList<string>? PolicyNames { get; set; }

        /// <summary>
        /// Post-checkpoint ID for the Ovalix Tracker service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_checkpoint_id")]
        public string? PostCheckpointId { get; set; }

        /// <summary>
        /// Pre-checkpoint ID for the Ovalix Tracker service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_checkpoint_id")]
        public string? PreCheckpointId { get; set; }

        /// <summary>
        /// Path to a JSON file containing ad-hoc recognizers for Presidio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_ad_hoc_recognizers")]
        public string? PresidioAdHocRecognizers { get; set; }

        /// <summary>
        /// Maximum UTF-8 bytes of text sent in a single Presidio /analyze call. Longer texts are split into overlapping chunks of at most this size and the merged results are remapped onto the original text. Defaults to 500000; set it below your analyzer deployment's request body limit, leaving headroom for the rest of the analyze payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_analyze_chunk_size_bytes")]
        public long? PresidioAnalyzeChunkSizeBytes { get; set; }

        /// <summary>
        /// Base URL for the Presidio analyzer API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_analyzer_api_base")]
        public string? PresidioAnalyzerApiBase { get; set; }

        /// <summary>
        /// Base URL for the Presidio anonymizer API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_anonymizer_api_base")]
        public string? PresidioAnonymizerApiBase { get; set; }

        /// <summary>
        /// List of entity types to exclude from Presidio detection results. Detections of these types will be silently dropped. Useful for suppressing false positives (e.g., US_DRIVER_LICENSE on coding routes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_entities_deny_list")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.PiiEntityType?, string>>? PresidioEntitiesDenyList { get; set; }

        /// <summary>
        /// Where to apply Presidio checks: 'input' (user -&gt; model), 'output' (model -&gt; user), or 'both' (default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_filter_scope")]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsPresidioFilterScope2? PresidioFilterScope { get; set; }

        /// <summary>
        /// Language code for Presidio PII analysis (e.g., 'en', 'de', 'es', 'fr')<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_language")]
        public string? PresidioLanguage { get; set; }

        /// <summary>
        /// Where to apply Presidio checks: input, output, or both (default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_run_on")]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsPresidioRunOn2? PresidioRunOn { get; set; }

        /// <summary>
        /// Optional per-entity minimum confidence scores for Presidio detections. Entities below the threshold are ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presidio_score_thresholds")]
        public global::System.Collections.Generic.Dictionary<string, double>? PresidioScoreThresholds { get; set; }

        /// <summary>
        /// Project ID for the Lakera AI project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// InvokeGuardrailChecks: block when any promptAttack severityScore &gt;= this value (scores are in [0,1]). Set to null to make prompt-attack detection detect-only.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_attack_threshold")]
        public double? PromptAttackThreshold { get; set; }

        /// <summary>
        /// Enable prompt injection detection. Default check if no evaluation_id and no other checks are specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injections")]
        public bool? PromptInjections { get; set; }

        /// <summary>
        /// The message the bot speaks aloud when a /v1/realtime guardrail fires. Falls back to violation_message_template if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realtime_violation_message")]
        public string? RealtimeViolationMessage { get; set; }

        /// <summary>
        /// Application id of the Agent 365 resource the OBO token is minted for. Defaults to the production resource ea9ffc3e-8a23-4a7d-836d-234d7c7565c1; the Test and PreProd environments use a different id. Falls back to the AGENT365_RESOURCE_APP_ID environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_app_id")]
        public string? ResourceAppId { get; set; }

        /// <summary>
        /// Ordered allow/deny rules. Patterns use regex for tool names/types and optional regex constraints on tool arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolPermissionRule>? Rules { get; set; }

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
        /// Whether to send user_API_key_alias in headers<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_user_api_key_alias")]
        public bool? SendUserApiKeyAlias { get; set; }

        /// <summary>
        /// Whether to send user_API_key_team_id in headers<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_user_api_key_team_id")]
        public bool? SendUserApiKeyTeamId { get; set; }

        /// <summary>
        /// Whether to send user_API_key_user_id in headers<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_user_api_key_user_id")]
        public bool? SendUserApiKeyUserId { get; set; }

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
        /// The Singulr API base URL. Get base URL from Singulr Platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("singulr_api_base")]
        public string? SingulrApiBase { get; set; }

        /// <summary>
        /// The Singulr API key. Generate API key from Singulr Platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("singulr_api_key")]
        public string? SingulrApiKey { get; set; }

        /// <summary>
        /// The Singulr application ID. Get application ID from Singulr Platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("singulr_application_id")]
        public string? SingulrApplicationId { get; set; }

        /// <summary>
        /// The Singulr Guardrail ID. Get guardrail ID from Singulr Platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("singulr_guardrail_id")]
        public string? SingulrGuardrailId { get; set; }

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
        /// Entra tenant id used for the On-Behalf-Of token exchange. Falls back to the AGENT365_TENANT_ID environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// Per-request timeout for the guardrail provider API call (seconds). Accepts int, float, or numeric string; coerced to float on load. Each guardrail handler chooses its own default when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Enable tool selection quality check to evaluate quality of tool/function calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_selection_quality_check")]
        public bool? ToolSelectionQualityCheck { get; set; }

        /// <summary>
        /// Base URL for the Ovalix Tracker service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracker_api_base")]
        public string? TrackerApiBase { get; set; }

        /// <summary>
        /// API key for the Ovalix Tracker service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracker_api_key")]
        public string? TrackerApiKey { get; set; }

        /// <summary>
        /// Behavior when the headroom compression service is unreachable or errors. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and forwards the request uncompressed instead of blocking it.<br/>
        /// Default Value: fail_closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unreachable_fallback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LitellmParamsUnreachableFallbackJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmParamsUnreachableFallback? UnreachableFallback { get; set; }

        /// <summary>
        /// If True and guardrail='noma', route to the new Noma v2 implementation instead of the legacy implementation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_v2")]
        public bool? UseV2 { get; set; }

        /// <summary>
        /// Whether to verify SSL certificates. Defaults to True.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_ssl")]
        public bool? VerifySsl { get; set; }

        /// <summary>
        /// Hiddenlayer guardrail version to use.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Custom message when a guardrail blocks an action. Supports placeholders like {tool_name}, {rule_id}, and {default_message}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violation_message_template")]
        public string? ViolationMessageTemplate { get; set; }

        /// <summary>
        /// XecGuard scanning model identifier. Defaults to 'xecguard_v2'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xecguard_model")]
        public string? XecguardModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LitellmParams2" /> class.
        /// </summary>
        /// <param name="guardrail">
        /// The type of guardrail integration to use
        /// </param>
        /// <param name="mode">
        /// When to apply the guardrail (pre_call, post_call, during_call, logging_only)
        /// </param>
        /// <param name="action">
        /// 'block' raises an error; 'mask' replaces the code block with a placeholder.<br/>
        /// Default Value: block
        /// </param>
        /// <param name="additionalProviderSpecificParams">
        /// Additional provider-specific parameters for generic guardrail APIs
        /// </param>
        /// <param name="advisorySystemMessage">
        /// Custom advisory message template used when on_flagged='inject_system_message'. Must contain a {reason} placeholder. Defaults to a generic advisory message if unset.
        /// </param>
        /// <param name="agentId">
        /// Agent identity reported to Agent 365 with every tool evaluation. When unset, the caller's key alias is used.
        /// </param>
        /// <param name="aktoAccountId">
        /// Akto account ID for multi-tenant deployments. Env: AKTO_ACCOUNT_ID. Default: '1000000'.
        /// </param>
        /// <param name="aktoApiKey">
        /// API key for Akto. Env: AKTO_API_KEY.
        /// </param>
        /// <param name="aktoBaseUrl">
        /// Akto Guardrail API Base URL. Env: AKTO_GUARDRAIL_API_BASE.
        /// </param>
        /// <param name="aktoVxlanId">
        /// Akto VXLAN ID. Env: AKTO_VXLAN_ID. Default: '0'.
        /// </param>
        /// <param name="anonymizeInput">
        /// If True, replaces sensitive content with anonymized version when only PII/PCI/secrets are detected. Only applies in blocking mode. Defaults to False if not provided
        /// </param>
        /// <param name="apiBase">
        /// Regional base URL for the Cisco AI Defense Inspection API. Defaults to https://us.api.inspect.aidefense.security.cisco.com. Supported regions: us (us-west-2), ap (ap-ne-1), eu (eu-central-1). The environment variable `CISCO_AI_DEFENSE_API_BASE` is consulted as a fallback. The endpoint path is derived from inspection_type (/api/v1/inspect/chat for 'chat', /api/v1/inspect/mcp for 'mcp').
        /// </param>
        /// <param name="apiEndpoint">
        /// Optional custom API endpoint for Model Armor
        /// </param>
        /// <param name="apiId">
        /// The Hiddenlayer API Id for the Hiddenlayer API. If not provided, the `HIDDENLAYER_CLIENT_ID` environment variable is checked or https://api.hiddenlayer.ai is used.
        /// </param>
        /// <param name="apiKey">
        /// API key for the Cisco AI Defense inspection endpoint. If not provided, the `CISCO_AI_DEFENSE_API_KEY` environment variable is used. Sent in the `X-Cisco-AI-Defense-API-Key` header. Both the chat and MCP endpoints use this key.
        /// </param>
        /// <param name="apiVersion">
        /// API version for Javelin service
        /// </param>
        /// <param name="application">
        /// Application name for Javelin service
        /// </param>
        /// <param name="applicationId">
        /// Application ID for Noma Security. Defaults to 'litellm' if not provided
        /// </param>
        /// <param name="assertions">
        /// Custom assertions to validate against the output. Each assertion is a string describing a condition.
        /// </param>
        /// <param name="assetId">
        /// Repello asset ID whose dashboard policies are enforced. Required; the guardrail raises at init if it is missing.
        /// </param>
        /// <param name="asyncMode">
        /// Set to True to request asynchronous analysis (sets `plr_async` header). Defaults to provider behaviour when omitted.
        /// </param>
        /// <param name="authToken">
        /// Authorization bearer token for IBM Guardrails API. Reads from IBM_GUARDRAILS_AUTH_TOKEN env var if None.
        /// </param>
        /// <param name="awsAccessKeyId">
        /// AWS access key ID for authentication
        /// </param>
        /// <param name="awsBedrockRuntimeEndpoint">
        /// AWS Bedrock runtime endpoint URL
        /// </param>
        /// <param name="awsExternalId">
        /// External ID required by the target role's trust policy on sts:AssumeRole
        /// </param>
        /// <param name="awsProfileName">
        /// AWS profile name for credential retrieval
        /// </param>
        /// <param name="awsRegionName">
        /// AWS region where your guardrail is deployed
        /// </param>
        /// <param name="awsRoleName">
        /// AWS role name for assuming roles
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS secret access key for authentication
        /// </param>
        /// <param name="awsSessionName">
        /// Name of the AWS session
        /// </param>
        /// <param name="awsSessionToken">
        /// AWS session token for temporary credentials
        /// </param>
        /// <param name="awsStsEndpoint">
        /// AWS STS endpoint URL
        /// </param>
        /// <param name="awsWebIdentityToken">
        /// Web identity token for AWS role assumption
        /// </param>
        /// <param name="baseUrl">
        /// Base URL for the IBM Guardrails server
        /// </param>
        /// <param name="blockFailures">
        /// If True, blocks requests on API failures. Defaults to True if not provided
        /// </param>
        /// <param name="blockOnError">
        /// Whether to block the request when the PromptGuard API is unreachable. Defaults to true (fail-closed). Set to false for fail-open behaviour.
        /// </param>
        /// <param name="blockOnViolation">
        /// Whether to block requests when violations are detected. Defaults to True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="blockedLanguages">
        /// Language tags to block (e.g. python, javascript, bash). Empty or None = block all fenced code blocks.
        /// </param>
        /// <param name="blockedWords">
        /// List of blocked words with individual actions
        /// </param>
        /// <param name="blockedWordsFile">
        /// Path to YAML file containing blocked_words list
        /// </param>
        /// <param name="breakdown">
        /// Whether to include breakdown in the response<br/>
        /// Default Value: true
        /// </param>
        /// <param name="categories">
        /// List of prebuilt categories to enable (harmful_*, bias_*)
        /// </param>
        /// <param name="categoryThresholds">
        /// Threshold configuration for Lakera guardrail categories
        /// </param>
        /// <param name="ccrRetrieval">
        /// Inject the Headroom retrieval tool for hashes declared by the compression service.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="checks">
        /// Inline safeguards for the resource-less InvokeGuardrailChecks API (contentFilter / promptAttack / sensitiveInformation). When set, the guardrail calls InvokeGuardrailChecks instead of ApplyGuardrail and no guardrailIdentifier is required. Mutually exclusive with guardrailIdentifier.
        /// </param>
        /// <param name="chunkBudgetChars">
        /// ApplyGuardrail: batch size, in characters, used to re-send content after AWS has rejected a request as too large. Requests AWS accepts are always sent in a single call, so this has no effect until a rejection happens. Defaults to 25,000; a batch AWS still rejects is bisected automatically, so this value only trades round trips against batch size and cannot fail a request on its own.<br/>
        /// Default Value: 25000
        /// </param>
        /// <param name="clientId">
        /// Client id of the gateway's Entra app registration (a confidential client). Falls back to the AGENT365_CLIENT_ID environment variable.
        /// </param>
        /// <param name="clientSecret">
        /// Client secret of the gateway's Entra app registration, used to perform the On-Behalf-Of exchange. Falls back to the AGENT365_CLIENT_SECRET environment variable.
        /// </param>
        /// <param name="confidenceThreshold">
        /// Only block or mask when detection confidence &gt;= this value; below threshold, allow or log_only.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="config">
        /// Additional configuration for the guardrail
        /// </param>
        /// <param name="contentFilterThreshold">
        /// InvokeGuardrailChecks: block when any contentFilter severityScore &gt;= this value (scores are in [0,1]). Set to null to make the content filter detect-only (logged, never blocks).<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="contentModerationCheck">
        /// Enable content moderation to check for harmful content (harassment, hate speech, etc.).
        /// </param>
        /// <param name="contextualGroundingFromMessages">
        /// ApplyGuardrail: when True, post-call scans of a request with no grounding_source / query content parts send the system and developer messages as the grounding source and the latest user message as the query, so the guardrail's contextual grounding policy can score the response. Bedrock bills contextual grounding units for these scans and rejects queries, sources and responses over its contextual grounding length limits, so leave this off for guardrails without a contextual grounding policy. Default False: plain messages are never sent as grounding context.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="credentials">
        /// Path to Google Cloud credentials JSON file or JSON string
        /// </param>
        /// <param name="customCode">
        /// Python-like code containing the apply_guardrail function for custom guardrail logic
        /// </param>
        /// <param name="deepkeepFirewallId">
        /// The DeepKeep Firewall ID to use for guardrail evaluation. If not provided, the `DEEPKEEP_FIREWALL_ID` environment variable is checked.
        /// </param>
        /// <param name="defaultAction">
        /// Fallback decision when no rule matches<br/>
        /// Default Value: deny
        /// </param>
        /// <param name="defaultOn">
        /// Whether the guardrail is enabled by default
        /// </param>
        /// <param name="deploymentName">
        /// The EnkryptAI deployment name to use. Sent via X-Enkrypt-Deployment header.
        /// </param>
        /// <param name="detectExecutionIntent">
        /// When True, block only when user intent is to run/execute; allow when intent is explain/refactor/don't run. Also block text-only execution requests (e.g. 'run `ls`', 'read /etc/passwd').<br/>
        /// Default Value: true
        /// </param>
        /// <param name="detectSecretsConfig">
        /// Configuration for detect-secrets guardrail
        /// </param>
        /// <param name="detectorId">
        /// Name of the detector inside the server (e.g., 'jailbreak-detector')
        /// </param>
        /// <param name="detectors">
        /// Dictionary of detector configurations (e.g., {'nsfw': {'enabled': True}, 'toxicity': {'enabled': True}}).
        /// </param>
        /// <param name="devInfo">
        /// Whether to include developer information in the response<br/>
        /// Default Value: true
        /// </param>
        /// <param name="disableExceptionOnBlock">
        /// If True, will not raise an exception when the guardrail is blocked. Useful for OpenWebUI where exceptions can end the chat flow.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="endSessionAfterNFails">
        /// For /v1/realtime sessions: automatically close the session after this many guardrail violations.
        /// </param>
        /// <param name="evaluationId">
        /// Pre-configured evaluation ID from Qualifire dashboard. When provided, uses invoke_evaluation() instead of evaluate().
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
        /// <param name="groundingCheck">
        /// Enable grounding verification to ensure output is grounded in provided context.
        /// </param>
        /// <param name="groundingStrictness">
        /// Strictness level for XecGuard context-grounding validation. 'BALANCED' (default) treats INCOMPLETE answers as SAFE; 'STRICT' flags them as UNSAFE. Grounding only runs in post_call when `metadata.xecguard_grounding_documents` is provided.
        /// </param>
        /// <param name="guardName">
        /// Name of the Javelin guard to use
        /// </param>
        /// <param name="guardrailIdentifier">
        /// The ID of your guardrail on Bedrock
        /// </param>
        /// <param name="guardrailVersion">
        /// The version of your Bedrock guardrail (e.g., DRAFT or version number)
        /// </param>
        /// <param name="guardrailTimeout">
        /// HTTP timeout in seconds. Default: 5.
        /// </param>
        /// <param name="hallucinationsCheck">
        /// Enable hallucination detection to detect factual inaccuracies.
        /// </param>
        /// <param name="includeEvidence">
        /// Include detailed evidence payloads in responses (sets `plr_evidence` header).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeScanners">
        /// Include scanner category summaries in responses (sets `plr_scanners` header).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="inspectEmbeddings">
        /// When True, the Aim and Cato Networks guardrails send /embeddings `input` to the vendor as user messages. Off by default because embedding input is documents being indexed, not a conversation.
        /// </param>
        /// <param name="isDetectorServer">
        /// Boolean flag to determine if calling a detector server (True) or the FMS Orchestrator (False). Defaults to True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="keywordRedactionTag">
        /// Tag to use for keyword redaction
        /// </param>
        /// <param name="lassoConversationId">
        /// Conversation ID for the Lasso guardrail
        /// </param>
        /// <param name="lassoUserId">
        /// User ID for the Lasso guardrail
        /// </param>
        /// <param name="location">
        /// Google Cloud location/region (e.g., us-central1)
        /// </param>
        /// <param name="mask">
        /// Enable content masking using Lasso classifix API<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maskRequestContent">
        /// Will mask request content if guardrail makes any changes
        /// </param>
        /// <param name="maskResponseContent">
        /// Will mask response content if guardrail makes any changes
        /// </param>
        /// <param name="metadata">
        /// Additional metadata to include in the request
        /// </param>
        /// <param name="mockRedactedText">
        /// Mock redacted text for testing
        /// </param>
        /// <param name="model">
        /// Model name forwarded to the headroom /v1/compress endpoint.
        /// </param>
        /// <param name="monitorMode">
        /// If True, logs violations without blocking. Defaults to False if not provided
        /// </param>
        /// <param name="onDisallowedAction">
        /// Choose whether disallowed tools block the request or get rewritten out of the payload<br/>
        /// Default Value: block
        /// </param>
        /// <param name="onFlagged">
        /// Action to take when content is flagged: 'block' (raise exception), 'monitor' (log only), or 'inject_system_message' (append an advisory system message and let the LLM decide)<br/>
        /// Default Value: block
        /// </param>
        /// <param name="onFlaggedAction">
        /// Action to take when content is flagged: 'block' (raise exception) or 'monitor' (log only)<br/>
        /// Default Value: monitor
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
        /// <param name="optionalParams">
        /// Optional parameters for the guardrail
        /// </param>
        /// <param name="outputParsePii">
        /// When True, LiteLLM will replace the masked text with the original text in the response
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
        /// <param name="payload">
        /// Whether to include payload in the response<br/>
        /// Default Value: true
        /// </param>
        /// <param name="persistSession">
        /// Controls Pillar session persistence (sets `plr_persist` header). Set to False to disable persistence.
        /// </param>
        /// <param name="piiCheck">
        /// Enable PII (Personally Identifiable Information) detection.
        /// </param>
        /// <param name="piiConfidenceThreshold">
        /// InvokeGuardrailChecks: block when any sensitiveInformation confidenceScore &gt;= this value (scores are in [0,1]). Set to null to make PII detection detect-only.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="piiEntitiesConfig">
        /// Configuration for PII entity types and actions
        /// </param>
        /// <param name="policyId">
        /// Policy ID for Zscaler AI Guard. Can also be set via ZSCALER_AI_GUARD_POLICY_ID environment variable
        /// </param>
        /// <param name="policyName">
        /// The EnkryptAI policy name to use. Sent via x-enkrypt-policy header.
        /// </param>
        /// <param name="policyNames">
        /// XecGuard policies to apply on each scan. Select one or more of the built-in default policies; if none are selected, the guardrail defaults to System Prompt Enforcement + Harmful Content Protection.
        /// </param>
        /// <param name="postCheckpointId">
        /// Post-checkpoint ID for the Ovalix Tracker service.
        /// </param>
        /// <param name="preCheckpointId">
        /// Pre-checkpoint ID for the Ovalix Tracker service.
        /// </param>
        /// <param name="presidioAdHocRecognizers">
        /// Path to a JSON file containing ad-hoc recognizers for Presidio
        /// </param>
        /// <param name="presidioAnalyzeChunkSizeBytes">
        /// Maximum UTF-8 bytes of text sent in a single Presidio /analyze call. Longer texts are split into overlapping chunks of at most this size and the merged results are remapped onto the original text. Defaults to 500000; set it below your analyzer deployment's request body limit, leaving headroom for the rest of the analyze payload.
        /// </param>
        /// <param name="presidioAnalyzerApiBase">
        /// Base URL for the Presidio analyzer API
        /// </param>
        /// <param name="presidioAnonymizerApiBase">
        /// Base URL for the Presidio anonymizer API
        /// </param>
        /// <param name="presidioEntitiesDenyList">
        /// List of entity types to exclude from Presidio detection results. Detections of these types will be silently dropped. Useful for suppressing false positives (e.g., US_DRIVER_LICENSE on coding routes).
        /// </param>
        /// <param name="presidioFilterScope">
        /// Where to apply Presidio checks: 'input' (user -&gt; model), 'output' (model -&gt; user), or 'both' (default).
        /// </param>
        /// <param name="presidioLanguage">
        /// Language code for Presidio PII analysis (e.g., 'en', 'de', 'es', 'fr')<br/>
        /// Default Value: en
        /// </param>
        /// <param name="presidioRunOn">
        /// Where to apply Presidio checks: input, output, or both (default).
        /// </param>
        /// <param name="presidioScoreThresholds">
        /// Optional per-entity minimum confidence scores for Presidio detections. Entities below the threshold are ignored.
        /// </param>
        /// <param name="projectId">
        /// Project ID for the Lakera AI project
        /// </param>
        /// <param name="promptAttackThreshold">
        /// InvokeGuardrailChecks: block when any promptAttack severityScore &gt;= this value (scores are in [0,1]). Set to null to make prompt-attack detection detect-only.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="promptInjections">
        /// Enable prompt injection detection. Default check if no evaluation_id and no other checks are specified.
        /// </param>
        /// <param name="realtimeViolationMessage">
        /// The message the bot speaks aloud when a /v1/realtime guardrail fires. Falls back to violation_message_template if not set.
        /// </param>
        /// <param name="resourceAppId">
        /// Application id of the Agent 365 resource the OBO token is minted for. Defaults to the production resource ea9ffc3e-8a23-4a7d-836d-234d7c7565c1; the Test and PreProd environments use a different id. Falls back to the AGENT365_RESOURCE_APP_ID environment variable.
        /// </param>
        /// <param name="rules">
        /// Ordered allow/deny rules. Patterns use regex for tool names/types and optional regex constraints on tool arguments.
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
        /// <param name="sendUserApiKeyAlias">
        /// Whether to send user_API_key_alias in headers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sendUserApiKeyTeamId">
        /// Whether to send user_API_key_team_id in headers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sendUserApiKeyUserId">
        /// Whether to send user_API_key_user_id in headers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sensitiveDataRouteToModel">
        /// Model to route requests to when sensitive data is detected and on_sensitive_data='route'. This is typically an on-premise model for data privacy. The routing decision persists for the entire session.
        /// </param>
        /// <param name="severityThreshold">
        /// Minimum severity to block (high, medium, low)
        /// </param>
        /// <param name="singulrApiBase">
        /// The Singulr API base URL. Get base URL from Singulr Platform.
        /// </param>
        /// <param name="singulrApiKey">
        /// The Singulr API key. Generate API key from Singulr Platform.
        /// </param>
        /// <param name="singulrApplicationId">
        /// The Singulr application ID. Get application ID from Singulr Platform.
        /// </param>
        /// <param name="singulrGuardrailId">
        /// The Singulr Guardrail ID. Get guardrail ID from Singulr Platform.
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
        /// <param name="tenantId">
        /// Entra tenant id used for the On-Behalf-Of token exchange. Falls back to the AGENT365_TENANT_ID environment variable.
        /// </param>
        /// <param name="timeout">
        /// Per-request timeout for the guardrail provider API call (seconds). Accepts int, float, or numeric string; coerced to float on load. Each guardrail handler chooses its own default when unset.
        /// </param>
        /// <param name="toolSelectionQualityCheck">
        /// Enable tool selection quality check to evaluate quality of tool/function calls.
        /// </param>
        /// <param name="trackerApiBase">
        /// Base URL for the Ovalix Tracker service.
        /// </param>
        /// <param name="trackerApiKey">
        /// API key for the Ovalix Tracker service.
        /// </param>
        /// <param name="unreachableFallback">
        /// Behavior when the headroom compression service is unreachable or errors. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and forwards the request uncompressed instead of blocking it.<br/>
        /// Default Value: fail_closed
        /// </param>
        /// <param name="useV2">
        /// If True and guardrail='noma', route to the new Noma v2 implementation instead of the legacy implementation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="verifySsl">
        /// Whether to verify SSL certificates. Defaults to True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="version">
        /// Hiddenlayer guardrail version to use.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="violationMessageTemplate">
        /// Custom message when a guardrail blocks an action. Supports placeholders like {tool_name}, {rule_id}, and {default_message}.
        /// </param>
        /// <param name="xecguardModel">
        /// XecGuard scanning model identifier. Defaults to 'xecguard_v2'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LitellmParams2(
            string guardrail,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<string>, global::Loud.Technology.LiteLLM.Sdk.Mode3> mode,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsAction? action,
            object? additionalProviderSpecificParams,
            string? advisorySystemMessage,
            string? agentId,
            string? aktoAccountId,
            string? aktoApiKey,
            string? aktoBaseUrl,
            string? aktoVxlanId,
            bool? anonymizeInput,
            string? apiBase,
            string? apiEndpoint,
            string? apiId,
            string? apiKey,
            string? apiVersion,
            string? application,
            string? applicationId,
            global::System.Collections.Generic.IList<string>? assertions,
            string? assetId,
            bool? asyncMode,
            string? authToken,
            string? awsAccessKeyId,
            string? awsBedrockRuntimeEndpoint,
            string? awsExternalId,
            string? awsProfileName,
            string? awsRegionName,
            string? awsRoleName,
            string? awsSecretAccessKey,
            string? awsSessionName,
            string? awsSessionToken,
            string? awsStsEndpoint,
            string? awsWebIdentityToken,
            string? baseUrl,
            bool? blockFailures,
            bool? blockOnError,
            bool? blockOnViolation,
            global::System.Collections.Generic.IList<string>? blockedLanguages,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BlockedWord>? blockedWords,
            string? blockedWordsFile,
            bool? breakdown,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ContentFilterCategoryConfig>? categories,
            global::Loud.Technology.LiteLLM.Sdk.LakeraCategoryThresholds? categoryThresholds,
            bool? ccrRetrieval,
            global::Loud.Technology.LiteLLM.Sdk.BedrockChecksConfigModel? checks,
            int? chunkBudgetChars,
            string? clientId,
            string? clientSecret,
            double? confidenceThreshold,
            object? config,
            double? contentFilterThreshold,
            bool? contentModerationCheck,
            bool? contextualGroundingFromMessages,
            string? credentials,
            string? customCode,
            string? deepkeepFirewallId,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsDefaultAction? defaultAction,
            bool? defaultOn,
            string? deploymentName,
            bool? detectExecutionIntent,
            object? detectSecretsConfig,
            string? detectorId,
            object? detectors,
            bool? devInfo,
            bool? disableExceptionOnBlock,
            int? endSessionAfterNFails,
            string? evaluationId,
            bool? experimentalUseLatestRoleMessageOnly,
            global::System.Collections.Generic.IList<string>? extraHeaders,
            bool? failOnError,
            bool? groundingCheck,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsGroundingStrictness2? groundingStrictness,
            string? guardName,
            string? guardrailIdentifier,
            string? guardrailVersion,
            int? guardrailTimeout,
            bool? hallucinationsCheck,
            bool? includeEvidence,
            bool? includeScanners,
            bool? inspectEmbeddings,
            bool? isDetectorServer,
            string? keywordRedactionTag,
            string? lassoConversationId,
            string? lassoUserId,
            string? location,
            bool? mask,
            bool? maskRequestContent,
            bool? maskResponseContent,
            object? metadata,
            object? mockRedactedText,
            string? model,
            bool? monitorMode,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsOnDisallowedAction? onDisallowedAction,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsOnFlagged2? onFlagged,
            string? onFlaggedAction,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsOnSensitiveData2? onSensitiveData,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsOnViolation2? onViolation,
            bool? onlyScanNewMessages,
            global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParams? optionalParams,
            bool? outputParsePii,
            string? pangeaInputRecipe,
            string? pangeaOutputRecipe,
            string? patternRedactionFormat,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ContentFilterPattern>? patterns,
            bool? payload,
            bool? persistSession,
            bool? piiCheck,
            double? piiConfidenceThreshold,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.PiiAction>? piiEntitiesConfig,
            int? policyId,
            string? policyName,
            global::System.Collections.Generic.IList<string>? policyNames,
            string? postCheckpointId,
            string? preCheckpointId,
            string? presidioAdHocRecognizers,
            long? presidioAnalyzeChunkSizeBytes,
            string? presidioAnalyzerApiBase,
            string? presidioAnonymizerApiBase,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.PiiEntityType?, string>>? presidioEntitiesDenyList,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsPresidioFilterScope2? presidioFilterScope,
            string? presidioLanguage,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsPresidioRunOn2? presidioRunOn,
            global::System.Collections.Generic.Dictionary<string, double>? presidioScoreThresholds,
            string? projectId,
            double? promptAttackThreshold,
            bool? promptInjections,
            string? realtimeViolationMessage,
            string? resourceAppId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolPermissionRule>? rules,
            bool? runInParallel,
            bool? sanitizeErrorDetail,
            bool? scanOnlyToolResults,
            bool? scanRawRequest,
            bool? sendUserApiKeyAlias,
            bool? sendUserApiKeyTeamId,
            bool? sendUserApiKeyUserId,
            string? sensitiveDataRouteToModel,
            string? severityThreshold,
            string? singulrApiBase,
            string? singulrApiKey,
            string? singulrApplicationId,
            string? singulrGuardrailId,
            bool? skipSystemMessageInGuardrail,
            bool? skipToolMessageInGuardrail,
            bool? skipUnscannableAttachments,
            bool? stickySessionRouting,
            string? templateId,
            string? tenantId,
            double? timeout,
            bool? toolSelectionQualityCheck,
            string? trackerApiBase,
            string? trackerApiKey,
            global::Loud.Technology.LiteLLM.Sdk.LitellmParamsUnreachableFallback? unreachableFallback,
            bool? useV2,
            bool? verifySsl,
            int? version,
            string? violationMessageTemplate,
            string? xecguardModel)
        {
            this.Action = action;
            this.AdditionalProviderSpecificParams = additionalProviderSpecificParams;
            this.AdvisorySystemMessage = advisorySystemMessage;
            this.AgentId = agentId;
            this.AktoAccountId = aktoAccountId;
            this.AktoApiKey = aktoApiKey;
            this.AktoBaseUrl = aktoBaseUrl;
            this.AktoVxlanId = aktoVxlanId;
            this.AnonymizeInput = anonymizeInput;
            this.ApiBase = apiBase;
            this.ApiEndpoint = apiEndpoint;
            this.ApiId = apiId;
            this.ApiKey = apiKey;
            this.ApiVersion = apiVersion;
            this.Application = application;
            this.ApplicationId = applicationId;
            this.Assertions = assertions;
            this.AssetId = assetId;
            this.AsyncMode = asyncMode;
            this.AuthToken = authToken;
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsBedrockRuntimeEndpoint = awsBedrockRuntimeEndpoint;
            this.AwsExternalId = awsExternalId;
            this.AwsProfileName = awsProfileName;
            this.AwsRegionName = awsRegionName;
            this.AwsRoleName = awsRoleName;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.AwsSessionName = awsSessionName;
            this.AwsSessionToken = awsSessionToken;
            this.AwsStsEndpoint = awsStsEndpoint;
            this.AwsWebIdentityToken = awsWebIdentityToken;
            this.BaseUrl = baseUrl;
            this.BlockFailures = blockFailures;
            this.BlockOnError = blockOnError;
            this.BlockOnViolation = blockOnViolation;
            this.BlockedLanguages = blockedLanguages;
            this.BlockedWords = blockedWords;
            this.BlockedWordsFile = blockedWordsFile;
            this.Breakdown = breakdown;
            this.Categories = categories;
            this.CategoryThresholds = categoryThresholds;
            this.CcrRetrieval = ccrRetrieval;
            this.Checks = checks;
            this.ChunkBudgetChars = chunkBudgetChars;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.ConfidenceThreshold = confidenceThreshold;
            this.Config = config;
            this.ContentFilterThreshold = contentFilterThreshold;
            this.ContentModerationCheck = contentModerationCheck;
            this.ContextualGroundingFromMessages = contextualGroundingFromMessages;
            this.Credentials = credentials;
            this.CustomCode = customCode;
            this.DeepkeepFirewallId = deepkeepFirewallId;
            this.DefaultAction = defaultAction;
            this.DefaultOn = defaultOn;
            this.DeploymentName = deploymentName;
            this.DetectExecutionIntent = detectExecutionIntent;
            this.DetectSecretsConfig = detectSecretsConfig;
            this.DetectorId = detectorId;
            this.Detectors = detectors;
            this.DevInfo = devInfo;
            this.DisableExceptionOnBlock = disableExceptionOnBlock;
            this.EndSessionAfterNFails = endSessionAfterNFails;
            this.EvaluationId = evaluationId;
            this.ExperimentalUseLatestRoleMessageOnly = experimentalUseLatestRoleMessageOnly;
            this.ExtraHeaders = extraHeaders;
            this.FailOnError = failOnError;
            this.GroundingCheck = groundingCheck;
            this.GroundingStrictness = groundingStrictness;
            this.GuardName = guardName;
            this.Guardrail = guardrail ?? throw new global::System.ArgumentNullException(nameof(guardrail));
            this.GuardrailIdentifier = guardrailIdentifier;
            this.GuardrailVersion = guardrailVersion;
            this.GuardrailTimeout = guardrailTimeout;
            this.HallucinationsCheck = hallucinationsCheck;
            this.IncludeEvidence = includeEvidence;
            this.IncludeScanners = includeScanners;
            this.InspectEmbeddings = inspectEmbeddings;
            this.IsDetectorServer = isDetectorServer;
            this.KeywordRedactionTag = keywordRedactionTag;
            this.LassoConversationId = lassoConversationId;
            this.LassoUserId = lassoUserId;
            this.Location = location;
            this.Mask = mask;
            this.MaskRequestContent = maskRequestContent;
            this.MaskResponseContent = maskResponseContent;
            this.Metadata = metadata;
            this.MockRedactedText = mockRedactedText;
            this.Mode = mode;
            this.Model = model;
            this.MonitorMode = monitorMode;
            this.OnDisallowedAction = onDisallowedAction;
            this.OnFlagged = onFlagged;
            this.OnFlaggedAction = onFlaggedAction;
            this.OnSensitiveData = onSensitiveData;
            this.OnViolation = onViolation;
            this.OnlyScanNewMessages = onlyScanNewMessages;
            this.OptionalParams = optionalParams;
            this.OutputParsePii = outputParsePii;
            this.PangeaInputRecipe = pangeaInputRecipe;
            this.PangeaOutputRecipe = pangeaOutputRecipe;
            this.PatternRedactionFormat = patternRedactionFormat;
            this.Patterns = patterns;
            this.Payload = payload;
            this.PersistSession = persistSession;
            this.PiiCheck = piiCheck;
            this.PiiConfidenceThreshold = piiConfidenceThreshold;
            this.PiiEntitiesConfig = piiEntitiesConfig;
            this.PolicyId = policyId;
            this.PolicyName = policyName;
            this.PolicyNames = policyNames;
            this.PostCheckpointId = postCheckpointId;
            this.PreCheckpointId = preCheckpointId;
            this.PresidioAdHocRecognizers = presidioAdHocRecognizers;
            this.PresidioAnalyzeChunkSizeBytes = presidioAnalyzeChunkSizeBytes;
            this.PresidioAnalyzerApiBase = presidioAnalyzerApiBase;
            this.PresidioAnonymizerApiBase = presidioAnonymizerApiBase;
            this.PresidioEntitiesDenyList = presidioEntitiesDenyList;
            this.PresidioFilterScope = presidioFilterScope;
            this.PresidioLanguage = presidioLanguage;
            this.PresidioRunOn = presidioRunOn;
            this.PresidioScoreThresholds = presidioScoreThresholds;
            this.ProjectId = projectId;
            this.PromptAttackThreshold = promptAttackThreshold;
            this.PromptInjections = promptInjections;
            this.RealtimeViolationMessage = realtimeViolationMessage;
            this.ResourceAppId = resourceAppId;
            this.Rules = rules;
            this.RunInParallel = runInParallel;
            this.SanitizeErrorDetail = sanitizeErrorDetail;
            this.ScanOnlyToolResults = scanOnlyToolResults;
            this.ScanRawRequest = scanRawRequest;
            this.SendUserApiKeyAlias = sendUserApiKeyAlias;
            this.SendUserApiKeyTeamId = sendUserApiKeyTeamId;
            this.SendUserApiKeyUserId = sendUserApiKeyUserId;
            this.SensitiveDataRouteToModel = sensitiveDataRouteToModel;
            this.SeverityThreshold = severityThreshold;
            this.SingulrApiBase = singulrApiBase;
            this.SingulrApiKey = singulrApiKey;
            this.SingulrApplicationId = singulrApplicationId;
            this.SingulrGuardrailId = singulrGuardrailId;
            this.SkipSystemMessageInGuardrail = skipSystemMessageInGuardrail;
            this.SkipToolMessageInGuardrail = skipToolMessageInGuardrail;
            this.SkipUnscannableAttachments = skipUnscannableAttachments;
            this.StickySessionRouting = stickySessionRouting;
            this.TemplateId = templateId;
            this.TenantId = tenantId;
            this.Timeout = timeout;
            this.ToolSelectionQualityCheck = toolSelectionQualityCheck;
            this.TrackerApiBase = trackerApiBase;
            this.TrackerApiKey = trackerApiKey;
            this.UnreachableFallback = unreachableFallback;
            this.UseV2 = useV2;
            this.VerifySsl = verifySsl;
            this.Version = version;
            this.ViolationMessageTemplate = violationMessageTemplate;
            this.XecguardModel = xecguardModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LitellmParams2" /> class.
        /// </summary>
        public LitellmParams2()
        {
        }

    }
}
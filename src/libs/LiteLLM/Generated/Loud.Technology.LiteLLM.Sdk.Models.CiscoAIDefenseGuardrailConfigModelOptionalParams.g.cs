
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Optional parameters for the Cisco AI Defense guardrail.
    /// </summary>
    public sealed partial class CiscoAIDefenseGuardrailConfigModelOptionalParams
    {
        /// <summary>
        /// Explicit list of Cisco AI Defense rules to evaluate. If omitted, the policies configured for the API key in the Cisco AI Defense UI are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_rules")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseRule>? EnabledRules { get; set; }

        /// <summary>
        /// Behaviour when the Cisco AI Defense API is unavailable: 'allow' proceeds without scanning (high availability), 'block' rejects the request (maximum security).<br/>
        /// Default Value: block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_on_error")]
        public global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2? FallbackOnError { get; set; }

        /// <summary>
        /// Override for the inspection endpoint path. Defaults to /api/v1/inspect/chat when inspection_type='chat' and /api/v1/inspect/mcp when inspection_type='mcp'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspect_path")]
        public string? InspectPath { get; set; }

        /// <summary>
        /// Which Cisco AI Defense inspection surface to use. 'chat' scans LLM model conversations via /api/v1/inspect/chat. 'mcp' scans MCP tool calls via /api/v1/inspect/mcp. Each guardrail instance targets exactly one surface; configure two guardrails to scan both chat and MCP traffic.<br/>
        /// Default Value: chat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspection_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionTypeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType? InspectionType { get; set; }

        /// <summary>
        /// Integration profile id to apply (advanced).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_profile_id")]
        public string? IntegrationProfileId { get; set; }

        /// <summary>
        /// Integration profile version to apply (advanced).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_profile_version")]
        public string? IntegrationProfileVersion { get; set; }

        /// <summary>
        /// Integration tenant id to apply (advanced).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_tenant_id")]
        public string? IntegrationTenantId { get; set; }

        /// <summary>
        /// Integration type to apply (advanced).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        public string? IntegrationType { get; set; }

        /// <summary>
        /// Action to take when Cisco AI Defense flags content. 'block' raises an HTTPException; 'monitor' logs the detection and lets the request continue.<br/>
        /// Default Value: block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_flagged_action")]
        public string? OnFlaggedAction { get; set; }

        /// <summary>
        /// Timeout (seconds) for Cisco AI Defense API calls (1-60).<br/>
        /// Default Value: 10F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiscoAIDefenseGuardrailConfigModelOptionalParams" /> class.
        /// </summary>
        /// <param name="enabledRules">
        /// Explicit list of Cisco AI Defense rules to evaluate. If omitted, the policies configured for the API key in the Cisco AI Defense UI are used.
        /// </param>
        /// <param name="fallbackOnError">
        /// Behaviour when the Cisco AI Defense API is unavailable: 'allow' proceeds without scanning (high availability), 'block' rejects the request (maximum security).<br/>
        /// Default Value: block
        /// </param>
        /// <param name="inspectPath">
        /// Override for the inspection endpoint path. Defaults to /api/v1/inspect/chat when inspection_type='chat' and /api/v1/inspect/mcp when inspection_type='mcp'.
        /// </param>
        /// <param name="inspectionType">
        /// Which Cisco AI Defense inspection surface to use. 'chat' scans LLM model conversations via /api/v1/inspect/chat. 'mcp' scans MCP tool calls via /api/v1/inspect/mcp. Each guardrail instance targets exactly one surface; configure two guardrails to scan both chat and MCP traffic.<br/>
        /// Default Value: chat
        /// </param>
        /// <param name="integrationProfileId">
        /// Integration profile id to apply (advanced).
        /// </param>
        /// <param name="integrationProfileVersion">
        /// Integration profile version to apply (advanced).
        /// </param>
        /// <param name="integrationTenantId">
        /// Integration tenant id to apply (advanced).
        /// </param>
        /// <param name="integrationType">
        /// Integration type to apply (advanced).
        /// </param>
        /// <param name="onFlaggedAction">
        /// Action to take when Cisco AI Defense flags content. 'block' raises an HTTPException; 'monitor' logs the detection and lets the request continue.<br/>
        /// Default Value: block
        /// </param>
        /// <param name="timeout">
        /// Timeout (seconds) for Cisco AI Defense API calls (1-60).<br/>
        /// Default Value: 10F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiscoAIDefenseGuardrailConfigModelOptionalParams(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseRule>? enabledRules,
            global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError2? fallbackOnError,
            string? inspectPath,
            global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseGuardrailConfigModelOptionalParamsInspectionType? inspectionType,
            string? integrationProfileId,
            string? integrationProfileVersion,
            string? integrationTenantId,
            string? integrationType,
            string? onFlaggedAction,
            double? timeout)
        {
            this.EnabledRules = enabledRules;
            this.FallbackOnError = fallbackOnError;
            this.InspectPath = inspectPath;
            this.InspectionType = inspectionType;
            this.IntegrationProfileId = integrationProfileId;
            this.IntegrationProfileVersion = integrationProfileVersion;
            this.IntegrationTenantId = integrationTenantId;
            this.IntegrationType = integrationType;
            this.OnFlaggedAction = onFlaggedAction;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiscoAIDefenseGuardrailConfigModelOptionalParams" /> class.
        /// </summary>
        public CiscoAIDefenseGuardrailConfigModelOptionalParams()
        {
        }

    }
}
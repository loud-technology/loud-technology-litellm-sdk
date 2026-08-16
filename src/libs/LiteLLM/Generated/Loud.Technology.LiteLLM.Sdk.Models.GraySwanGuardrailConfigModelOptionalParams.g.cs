
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Optional parameters for the Gray Swan guardrail.
    /// </summary>
    public sealed partial class GraySwanGuardrailConfigModelOptionalParams
    {
        /// <summary>
        /// Default Gray Swan category definitions to send with each request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.Dictionary<string, string>? Categories { get; set; }

        /// <summary>
        /// If true (default), errors contacting Gray Swan are logged and the request proceeds. If false, errors propagate and block the request.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_open")]
        public bool? FailOpen { get; set; }

        /// <summary>
        /// Timeout in seconds for calling the Gray Swan guardrail service.<br/>
        /// Default Value: 30F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_timeout")]
        public double? GuardrailTimeout { get; set; }

        /// <summary>
        /// Action when a violation is detected: 'block' rejects the call (400 error), 'monitor' logs only, 'passthrough' replaces response content with violation message (200 status).<br/>
        /// Default Value: passthrough
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_flagged_action")]
        public string? OnFlaggedAction { get; set; }

        /// <summary>
        /// Gray Swan policy identifier to apply during monitoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }

        /// <summary>
        /// Gray Swan reasoning mode override. Accepted values: 'off', 'hybrid', 'thinking'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_mode")]
        public string? ReasoningMode { get; set; }

        /// <summary>
        /// Threshold between 0 and 1 at which Gray Swan violations trigger the configured action.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violation_threshold")]
        public double? ViolationThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraySwanGuardrailConfigModelOptionalParams" /> class.
        /// </summary>
        /// <param name="categories">
        /// Default Gray Swan category definitions to send with each request.
        /// </param>
        /// <param name="failOpen">
        /// If true (default), errors contacting Gray Swan are logged and the request proceeds. If false, errors propagate and block the request.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="guardrailTimeout">
        /// Timeout in seconds for calling the Gray Swan guardrail service.<br/>
        /// Default Value: 30F
        /// </param>
        /// <param name="onFlaggedAction">
        /// Action when a violation is detected: 'block' rejects the call (400 error), 'monitor' logs only, 'passthrough' replaces response content with violation message (200 status).<br/>
        /// Default Value: passthrough
        /// </param>
        /// <param name="policyId">
        /// Gray Swan policy identifier to apply during monitoring.
        /// </param>
        /// <param name="reasoningMode">
        /// Gray Swan reasoning mode override. Accepted values: 'off', 'hybrid', 'thinking'.
        /// </param>
        /// <param name="violationThreshold">
        /// Threshold between 0 and 1 at which Gray Swan violations trigger the configured action.<br/>
        /// Default Value: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraySwanGuardrailConfigModelOptionalParams(
            global::System.Collections.Generic.Dictionary<string, string>? categories,
            bool? failOpen,
            double? guardrailTimeout,
            string? onFlaggedAction,
            string? policyId,
            string? reasoningMode,
            double? violationThreshold)
        {
            this.Categories = categories;
            this.FailOpen = failOpen;
            this.GuardrailTimeout = guardrailTimeout;
            this.OnFlaggedAction = onFlaggedAction;
            this.PolicyId = policyId;
            this.ReasoningMode = reasoningMode;
            this.ViolationThreshold = violationThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraySwanGuardrailConfigModelOptionalParams" /> class.
        /// </summary>
        public GraySwanGuardrailConfigModelOptionalParams()
        {
        }

    }
}
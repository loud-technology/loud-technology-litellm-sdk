
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for updating a policy.
    /// </summary>
    public sealed partial class PolicyUpdateRequest
    {
        /// <summary>
        /// Condition for when this policy applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Loud.Technology.LiteLLM.Sdk.PolicyConditionRequest? Condition { get; set; }

        /// <summary>
        /// Human-readable description of the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of guardrail names to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_add")]
        public global::System.Collections.Generic.IList<string>? GuardrailsAdd { get; set; }

        /// <summary>
        /// List of guardrail names to remove (from inherited).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_remove")]
        public global::System.Collections.Generic.IList<string>? GuardrailsRemove { get; set; }

        /// <summary>
        /// Name of parent policy to inherit from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherit")]
        public string? Inherit { get; set; }

        /// <summary>
        /// Optional guardrail pipeline for ordered execution. Contains 'mode' and 'steps'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public object? Pipeline { get; set; }

        /// <summary>
        /// New name for the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_name")]
        public string? PolicyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyUpdateRequest" /> class.
        /// </summary>
        /// <param name="condition">
        /// Condition for when this policy applies.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the policy.
        /// </param>
        /// <param name="guardrailsAdd">
        /// List of guardrail names to add.
        /// </param>
        /// <param name="guardrailsRemove">
        /// List of guardrail names to remove (from inherited).
        /// </param>
        /// <param name="inherit">
        /// Name of parent policy to inherit from.
        /// </param>
        /// <param name="pipeline">
        /// Optional guardrail pipeline for ordered execution. Contains 'mode' and 'steps'.
        /// </param>
        /// <param name="policyName">
        /// New name for the policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyUpdateRequest(
            global::Loud.Technology.LiteLLM.Sdk.PolicyConditionRequest? condition,
            string? description,
            global::System.Collections.Generic.IList<string>? guardrailsAdd,
            global::System.Collections.Generic.IList<string>? guardrailsRemove,
            string? inherit,
            object? pipeline,
            string? policyName)
        {
            this.Condition = condition;
            this.Description = description;
            this.GuardrailsAdd = guardrailsAdd;
            this.GuardrailsRemove = guardrailsRemove;
            this.Inherit = inherit;
            this.Pipeline = pipeline;
            this.PolicyName = policyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyUpdateRequest" /> class.
        /// </summary>
        public PolicyUpdateRequest()
        {
        }

    }
}
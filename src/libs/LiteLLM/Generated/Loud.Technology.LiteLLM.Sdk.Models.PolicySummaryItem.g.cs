
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Summary of a single policy for list endpoint.
    /// </summary>
    public sealed partial class PolicySummaryItem
    {
        /// <summary>
        /// Guardrails configuration for a policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PolicyGuardrailsResponse Guardrails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherit")]
        public string? Inherit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inheritance_chain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InheritanceChain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_guardrails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ResolvedGuardrails { get; set; }

        /// <summary>
        /// Scope configuration for a policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PolicyScopeResponse Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicySummaryItem" /> class.
        /// </summary>
        /// <param name="guardrails">
        /// Guardrails configuration for a policy.
        /// </param>
        /// <param name="inheritanceChain"></param>
        /// <param name="resolvedGuardrails"></param>
        /// <param name="scope">
        /// Scope configuration for a policy.
        /// </param>
        /// <param name="inherit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicySummaryItem(
            global::Loud.Technology.LiteLLM.Sdk.PolicyGuardrailsResponse guardrails,
            global::System.Collections.Generic.IList<string> inheritanceChain,
            global::System.Collections.Generic.IList<string> resolvedGuardrails,
            global::Loud.Technology.LiteLLM.Sdk.PolicyScopeResponse scope,
            string? inherit)
        {
            this.Guardrails = guardrails ?? throw new global::System.ArgumentNullException(nameof(guardrails));
            this.Inherit = inherit;
            this.InheritanceChain = inheritanceChain ?? throw new global::System.ArgumentNullException(nameof(inheritanceChain));
            this.ResolvedGuardrails = resolvedGuardrails ?? throw new global::System.ArgumentNullException(nameof(resolvedGuardrails));
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicySummaryItem" /> class.
        /// </summary>
        public PolicySummaryItem()
        {
        }

    }
}
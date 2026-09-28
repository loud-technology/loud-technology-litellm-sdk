
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for resolving effective policies/guardrails for a context.
    /// </summary>
    public sealed partial class PolicyResolveResponse
    {
        /// <summary>
        /// Final list of guardrails that would be applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_guardrails")]
        public global::System.Collections.Generic.IList<string>? EffectiveGuardrails { get; set; }

        /// <summary>
        /// Details about each matched policy and why it matched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matched_policies")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyMatchDetail>? MatchedPolicies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResolveResponse" /> class.
        /// </summary>
        /// <param name="effectiveGuardrails">
        /// Final list of guardrails that would be applied.
        /// </param>
        /// <param name="matchedPolicies">
        /// Details about each matched policy and why it matched.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyResolveResponse(
            global::System.Collections.Generic.IList<string>? effectiveGuardrails,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyMatchDetail>? matchedPolicies)
        {
            this.EffectiveGuardrails = effectiveGuardrails;
            this.MatchedPolicies = matchedPolicies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResolveResponse" /> class.
        /// </summary>
        public PolicyResolveResponse()
        {
        }

    }
}
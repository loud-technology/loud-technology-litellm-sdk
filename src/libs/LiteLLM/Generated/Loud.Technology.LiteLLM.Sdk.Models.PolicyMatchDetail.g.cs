
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Details about why a specific policy matched.
    /// </summary>
    public sealed partial class PolicyMatchDetail
    {
        /// <summary>
        /// Guardrails this policy contributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_added")]
        public global::System.Collections.Generic.IList<string>? GuardrailsAdded { get; set; }

        /// <summary>
        /// How the policy was matched (e.g., 'tag:healthcare', 'team:health-team', 'scope:*').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matched_via")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MatchedVia { get; set; }

        /// <summary>
        /// Name of the matched policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PolicyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyMatchDetail" /> class.
        /// </summary>
        /// <param name="matchedVia">
        /// How the policy was matched (e.g., 'tag:healthcare', 'team:health-team', 'scope:*').
        /// </param>
        /// <param name="policyName">
        /// Name of the matched policy.
        /// </param>
        /// <param name="guardrailsAdded">
        /// Guardrails this policy contributes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyMatchDetail(
            string matchedVia,
            string policyName,
            global::System.Collections.Generic.IList<string>? guardrailsAdded)
        {
            this.GuardrailsAdded = guardrailsAdded;
            this.MatchedVia = matchedVia ?? throw new global::System.ArgumentNullException(nameof(matchedVia));
            this.PolicyName = policyName ?? throw new global::System.ArgumentNullException(nameof(policyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyMatchDetail" /> class.
        /// </summary>
        public PolicyMatchDetail()
        {
        }

    }
}
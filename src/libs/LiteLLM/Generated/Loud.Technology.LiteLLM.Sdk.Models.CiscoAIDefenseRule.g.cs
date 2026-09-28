
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A single rule to enable for Cisco AI Defense inspection.
    /// </summary>
    public sealed partial class CiscoAIDefenseRule
    {
        /// <summary>
        /// Optional list of entity types for the rule (e.g. 'Email Address', 'Phone Number'). Applies to rules such as PII, PCI, and PHI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_types")]
        public global::System.Collections.Generic.IList<string>? EntityTypes { get; set; }

        /// <summary>
        /// The canonical Cisco AI Defense rule name to evaluate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.CiscoAIDefenseRuleRuleNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseRuleRuleName RuleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiscoAIDefenseRule" /> class.
        /// </summary>
        /// <param name="ruleName">
        /// The canonical Cisco AI Defense rule name to evaluate.
        /// </param>
        /// <param name="entityTypes">
        /// Optional list of entity types for the rule (e.g. 'Email Address', 'Phone Number'). Applies to rules such as PII, PCI, and PHI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiscoAIDefenseRule(
            global::Loud.Technology.LiteLLM.Sdk.CiscoAIDefenseRuleRuleName ruleName,
            global::System.Collections.Generic.IList<string>? entityTypes)
        {
            this.EntityTypes = entityTypes;
            this.RuleName = ruleName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiscoAIDefenseRule" /> class.
        /// </summary>
        public CiscoAIDefenseRule()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A deterministic override: if any keyword matches, route to this tier.
    /// </summary>
    public sealed partial class KeywordTierRule
    {
        /// <summary>
        /// Keywords/phrases that trigger this rule (lexical or semantic match)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keywords { get; set; }

        /// <summary>
        /// Tier to route to when this rule matches: a built-in tier name, or with tier_definitions set, one of the defined tier names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeywordTierRule" /> class.
        /// </summary>
        /// <param name="keywords">
        /// Keywords/phrases that trigger this rule (lexical or semantic match)
        /// </param>
        /// <param name="tier">
        /// Tier to route to when this rule matches: a built-in tier name, or with tier_definitions set, one of the defined tier names
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeywordTierRule(
            global::System.Collections.Generic.IList<string> keywords,
            string tier)
        {
            this.Keywords = keywords ?? throw new global::System.ArgumentNullException(nameof(keywords));
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeywordTierRule" /> class.
        /// </summary>
        public KeywordTierRule()
        {
        }

    }
}
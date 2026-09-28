
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// An operator-defined tier: the name the LLM classifier must return and its rubric description.
    /// </summary>
    public sealed partial class TierDefinition
    {
        /// <summary>
        /// Tier name; becomes a value the LLM classifier can return and a key of `tiers`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// What belongs in this tier; rendered as this tier's bullet in the classifier rubric. Required unless the name is a built-in tier (NON_REASONING, SIMPLE, MEDIUM, COMPLEX, REASONING), which inherits the built-in criteria when omitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TierDefinition" /> class.
        /// </summary>
        /// <param name="name">
        /// Tier name; becomes a value the LLM classifier can return and a key of `tiers`
        /// </param>
        /// <param name="description">
        /// What belongs in this tier; rendered as this tier's bullet in the classifier rubric. Required unless the name is a built-in tier (NON_REASONING, SIMPLE, MEDIUM, COMPLEX, REASONING), which inherits the built-in criteria when omitted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TierDefinition(
            string name,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TierDefinition" /> class.
        /// </summary>
        public TierDefinition()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Exactly the four built-in tiers the dashboard's preset prefill can apply.<br/>
    /// extra="forbid" on purpose: a tier name this dashboard cannot apply would grey out or crash the<br/>
    /// picker, so such a catalog is rejected wholesale and the bundled one serves instead.
    /// </summary>
    public sealed partial class AutoRouterPresetTiers
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SIMPLE")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Simple { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MEDIUM")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Medium { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("COMPLEX")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Complex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REASONING")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPresetTiers" /> class.
        /// </summary>
        /// <param name="simple"></param>
        /// <param name="medium"></param>
        /// <param name="complex"></param>
        /// <param name="reasoning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterPresetTiers(
            global::System.Collections.Generic.IList<string> simple,
            global::System.Collections.Generic.IList<string> medium,
            global::System.Collections.Generic.IList<string> complex,
            global::System.Collections.Generic.IList<string> reasoning)
        {
            this.Simple = simple ?? throw new global::System.ArgumentNullException(nameof(simple));
            this.Medium = medium ?? throw new global::System.ArgumentNullException(nameof(medium));
            this.Complex = complex ?? throw new global::System.ArgumentNullException(nameof(complex));
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterPresetTiers" /> class.
        /// </summary>
        public AutoRouterPresetTiers()
        {
        }

    }
}
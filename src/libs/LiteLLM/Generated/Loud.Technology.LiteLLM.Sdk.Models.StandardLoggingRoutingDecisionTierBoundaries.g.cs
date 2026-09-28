
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Snapshot of the complexity scorer's tier boundaries at decision time, so a<br/>
    /// historical spend log row stays explainable after the router config changes.
    /// </summary>
    public sealed partial class StandardLoggingRoutingDecisionTierBoundaries
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simple_medium")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SimpleMedium { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium_complex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MediumComplex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complex_reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ComplexReasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardLoggingRoutingDecisionTierBoundaries" /> class.
        /// </summary>
        /// <param name="simpleMedium"></param>
        /// <param name="mediumComplex"></param>
        /// <param name="complexReasoning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StandardLoggingRoutingDecisionTierBoundaries(
            double simpleMedium,
            double mediumComplex,
            double complexReasoning)
        {
            this.SimpleMedium = simpleMedium;
            this.MediumComplex = mediumComplex;
            this.ComplexReasoning = complexReasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardLoggingRoutingDecisionTierBoundaries" /> class.
        /// </summary>
        public StandardLoggingRoutingDecisionTierBoundaries()
        {
        }

    }
}
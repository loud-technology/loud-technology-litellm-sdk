
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The complexity router's shipped heuristic scorer defaults.<br/>
    /// The dashboard prefills its Advanced scoring controls from these rather than keeping its own copy, so<br/>
    /// a recalibration of the defaults cannot leave the form reporting numbers the router no longer uses.
    /// </summary>
    public sealed partial class ComplexityScorerDefaults
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_boundaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> TierBoundaries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_thresholds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> TokenThresholds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension_weights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> DimensionWeights { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexityScorerDefaults" /> class.
        /// </summary>
        /// <param name="tierBoundaries"></param>
        /// <param name="tokenThresholds"></param>
        /// <param name="dimensionWeights"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComplexityScorerDefaults(
            global::System.Collections.Generic.Dictionary<string, double> tierBoundaries,
            global::System.Collections.Generic.Dictionary<string, int> tokenThresholds,
            global::System.Collections.Generic.Dictionary<string, double> dimensionWeights)
        {
            this.TierBoundaries = tierBoundaries ?? throw new global::System.ArgumentNullException(nameof(tierBoundaries));
            this.TokenThresholds = tokenThresholds ?? throw new global::System.ArgumentNullException(nameof(tokenThresholds));
            this.DimensionWeights = dimensionWeights ?? throw new global::System.ArgumentNullException(nameof(dimensionWeights));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexityScorerDefaults" /> class.
        /// </summary>
        public ComplexityScorerDefaults()
        {
        }

    }
}
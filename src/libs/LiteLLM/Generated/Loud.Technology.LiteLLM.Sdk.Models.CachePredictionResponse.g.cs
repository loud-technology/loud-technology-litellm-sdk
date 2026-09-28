
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CachePredictionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.CachePredictionArm Stay { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.CachePredictionArm Switch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switch_delta")]
        public double? SwitchDelta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_rebuild_penalty")]
        public double? CacheRebuildPenalty { get; set; }

        /// <summary>
        /// Default Value: input_before_discounts_and_margins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_basis")]
        public string? PricingBasis { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_guarantee")]
        public bool? CacheGuarantee { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CachePredictionResponse" /> class.
        /// </summary>
        /// <param name="stay"></param>
        /// <param name="switch"></param>
        /// <param name="switchDelta"></param>
        /// <param name="cacheRebuildPenalty"></param>
        /// <param name="pricingBasis">
        /// Default Value: input_before_discounts_and_margins
        /// </param>
        /// <param name="cacheGuarantee">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CachePredictionResponse(
            global::Loud.Technology.LiteLLM.Sdk.CachePredictionArm stay,
            global::Loud.Technology.LiteLLM.Sdk.CachePredictionArm @switch,
            double? switchDelta,
            double? cacheRebuildPenalty,
            string? pricingBasis,
            bool? cacheGuarantee)
        {
            this.Stay = stay ?? throw new global::System.ArgumentNullException(nameof(stay));
            this.Switch = @switch ?? throw new global::System.ArgumentNullException(nameof(@switch));
            this.SwitchDelta = switchDelta;
            this.CacheRebuildPenalty = cacheRebuildPenalty;
            this.PricingBasis = pricingBasis;
            this.CacheGuarantee = cacheGuarantee;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CachePredictionResponse" /> class.
        /// </summary>
        public CachePredictionResponse()
        {
        }

    }
}
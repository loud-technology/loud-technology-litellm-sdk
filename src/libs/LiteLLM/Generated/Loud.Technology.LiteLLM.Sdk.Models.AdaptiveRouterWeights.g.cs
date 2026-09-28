
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdaptiveRouterWeights
    {
        /// <summary>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public double? Quality { get; set; }

        /// <summary>
        /// Default Value: 0.3F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdaptiveRouterWeights" /> class.
        /// </summary>
        /// <param name="quality">
        /// Default Value: 0.7F
        /// </param>
        /// <param name="cost">
        /// Default Value: 0.3F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdaptiveRouterWeights(
            double? quality,
            double? cost)
        {
            this.Quality = quality;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdaptiveRouterWeights" /> class.
        /// </summary>
        public AdaptiveRouterWeights()
        {
        }

    }
}
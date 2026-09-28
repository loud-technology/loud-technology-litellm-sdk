
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TierGlobalStatistic
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Tier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Successes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Observations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TierGlobalStatistic" /> class.
        /// </summary>
        /// <param name="tier"></param>
        /// <param name="successes"></param>
        /// <param name="observations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TierGlobalStatistic(
            int tier,
            double successes,
            double observations)
        {
            this.Tier = tier;
            this.Successes = successes;
            this.Observations = observations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TierGlobalStatistic" /> class.
        /// </summary>
        public TierGlobalStatistic()
        {
        }

    }
}
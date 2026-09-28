
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TierDomainStatistic
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
        /// Fixed v0 taxonomy. User-extensible types come in v1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.RequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.RequestType RequestType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TierDomainStatistic" /> class.
        /// </summary>
        /// <param name="tier"></param>
        /// <param name="successes"></param>
        /// <param name="observations"></param>
        /// <param name="requestType">
        /// Fixed v0 taxonomy. User-extensible types come in v1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TierDomainStatistic(
            int tier,
            double successes,
            double observations,
            global::Loud.Technology.LiteLLM.Sdk.RequestType requestType)
        {
            this.Tier = tier;
            this.Successes = successes;
            this.Observations = observations;
            this.RequestType = requestType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TierDomainStatistic" /> class.
        /// </summary>
        public TierDomainStatistic()
        {
        }

    }
}
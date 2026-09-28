
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StandardLoggingHeuristicV2Forecast
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Probabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predicted_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PredictedTier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardLoggingHeuristicV2Forecast" /> class.
        /// </summary>
        /// <param name="probabilities"></param>
        /// <param name="threshold"></param>
        /// <param name="predictedTier"></param>
        /// <param name="requestType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StandardLoggingHeuristicV2Forecast(
            global::System.Collections.Generic.Dictionary<string, double> probabilities,
            double threshold,
            string predictedTier,
            string requestType)
        {
            this.Probabilities = probabilities ?? throw new global::System.ArgumentNullException(nameof(probabilities));
            this.Threshold = threshold;
            this.PredictedTier = predictedTier ?? throw new global::System.ArgumentNullException(nameof(predictedTier));
            this.RequestType = requestType ?? throw new global::System.ArgumentNullException(nameof(requestType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardLoggingHeuristicV2Forecast" /> class.
        /// </summary>
        public StandardLoggingHeuristicV2Forecast()
        {
        }

    }
}
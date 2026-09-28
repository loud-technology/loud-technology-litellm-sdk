
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Switchyard-compatible probability threshold policy for two model tiers.
    /// </summary>
    public sealed partial class CapabilityClassifierConfig
    {
        /// <summary>
        /// Tier used when the efficient model's forecasted solve probability meets the adjusted threshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficient_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EfficientTier { get; set; }

        /// <summary>
        /// Higher, fail-closed tier used below the adjusted threshold or when the classifier verdict is unavailable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capable_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CapableTier { get; set; }

        /// <summary>
        /// Lowest p_solve that routes a supported task to efficient_tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BaseThreshold { get; set; }

        /// <summary>
        /// Amount added once for uncertain or unmatched verdicts and twice for unsupported verdicts<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_step")]
        public double? ThresholdStep { get; set; }

        /// <summary>
        /// Maximum completion tokens available to the capability classifier verdict<br/>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Optional versioned sigmoid calibration fitted for this judge, capability card, efficient model, and execution setup. Applies sigmoid(slope * logit(clip(p_solve, 1e-6, 1-1e-6)) + intercept) before the threshold policy. Omit to route on the raw forecast.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibration")]
        public global::Loud.Technology.LiteLLM.Sdk.CapabilityCalibrationConfig? Calibration { get; set; }

        /// <summary>
        /// Use json_object for judges without strict JSON Schema support. This appends the verdict schema to the packaged system prompt; both modes validate the returned verdict identically.<br/>
        /// Default Value: json_schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.CapabilityClassifierConfigResponseFormatJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.CapabilityClassifierConfigResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityClassifierConfig" /> class.
        /// </summary>
        /// <param name="efficientTier">
        /// Tier used when the efficient model's forecasted solve probability meets the adjusted threshold
        /// </param>
        /// <param name="capableTier">
        /// Higher, fail-closed tier used below the adjusted threshold or when the classifier verdict is unavailable
        /// </param>
        /// <param name="baseThreshold">
        /// Lowest p_solve that routes a supported task to efficient_tier
        /// </param>
        /// <param name="thresholdStep">
        /// Amount added once for uncertain or unmatched verdicts and twice for unsupported verdicts<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum completion tokens available to the capability classifier verdict<br/>
        /// Default Value: 4096
        /// </param>
        /// <param name="calibration">
        /// Optional versioned sigmoid calibration fitted for this judge, capability card, efficient model, and execution setup. Applies sigmoid(slope * logit(clip(p_solve, 1e-6, 1-1e-6)) + intercept) before the threshold policy. Omit to route on the raw forecast.
        /// </param>
        /// <param name="responseFormat">
        /// Use json_object for judges without strict JSON Schema support. This appends the verdict schema to the packaged system prompt; both modes validate the returned verdict identically.<br/>
        /// Default Value: json_schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CapabilityClassifierConfig(
            string efficientTier,
            string capableTier,
            double baseThreshold,
            double? thresholdStep,
            int? maxOutputTokens,
            global::Loud.Technology.LiteLLM.Sdk.CapabilityCalibrationConfig? calibration,
            global::Loud.Technology.LiteLLM.Sdk.CapabilityClassifierConfigResponseFormat? responseFormat)
        {
            this.EfficientTier = efficientTier ?? throw new global::System.ArgumentNullException(nameof(efficientTier));
            this.CapableTier = capableTier ?? throw new global::System.ArgumentNullException(nameof(capableTier));
            this.BaseThreshold = baseThreshold;
            this.ThresholdStep = thresholdStep;
            this.MaxOutputTokens = maxOutputTokens;
            this.Calibration = calibration;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityClassifierConfig" /> class.
        /// </summary>
        public CapabilityClassifierConfig()
        {
        }

    }
}
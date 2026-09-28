
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMV2Config
    {
        /// <summary>
        /// Default Value: SIMPLE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficient_tier")]
        public string? EfficientTier { get; set; }

        /// <summary>
        /// Default Value: REASONING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capable_tier")]
        public string? CapableTier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficient_profile")]
        public string? EfficientProfile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capable_profile")]
        public string? CapableProfile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness")]
        public string? Harness { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficient_profile_preset")]
        public string? EfficientProfilePreset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capable_profile_preset")]
        public string? CapableProfilePreset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness_preset")]
        public string? HarnessPreset { get; set; }

        /// <summary>
        /// Maximum estimated success loss allowed for efficient.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_quality_gap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxQualityGap { get; set; }

        /// <summary>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Default Value: json_schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LLMV2ConfigResponseFormatJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.LLMV2ConfigResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibration")]
        public global::Loud.Technology.LiteLLM.Sdk.LLMV2Calibration? Calibration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMV2Config" /> class.
        /// </summary>
        /// <param name="maxQualityGap">
        /// Maximum estimated success loss allowed for efficient.
        /// </param>
        /// <param name="efficientTier">
        /// Default Value: SIMPLE
        /// </param>
        /// <param name="capableTier">
        /// Default Value: REASONING
        /// </param>
        /// <param name="efficientProfile"></param>
        /// <param name="capableProfile"></param>
        /// <param name="harness"></param>
        /// <param name="efficientProfilePreset"></param>
        /// <param name="capableProfilePreset"></param>
        /// <param name="harnessPreset"></param>
        /// <param name="maxOutputTokens">
        /// Default Value: 1024
        /// </param>
        /// <param name="responseFormat">
        /// Default Value: json_schema
        /// </param>
        /// <param name="calibration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMV2Config(
            double maxQualityGap,
            string? efficientTier,
            string? capableTier,
            string? efficientProfile,
            string? capableProfile,
            string? harness,
            string? efficientProfilePreset,
            string? capableProfilePreset,
            string? harnessPreset,
            int? maxOutputTokens,
            global::Loud.Technology.LiteLLM.Sdk.LLMV2ConfigResponseFormat? responseFormat,
            global::Loud.Technology.LiteLLM.Sdk.LLMV2Calibration? calibration)
        {
            this.EfficientTier = efficientTier;
            this.CapableTier = capableTier;
            this.EfficientProfile = efficientProfile;
            this.CapableProfile = capableProfile;
            this.Harness = harness;
            this.EfficientProfilePreset = efficientProfilePreset;
            this.CapableProfilePreset = capableProfilePreset;
            this.HarnessPreset = harnessPreset;
            this.MaxQualityGap = maxQualityGap;
            this.MaxOutputTokens = maxOutputTokens;
            this.ResponseFormat = responseFormat;
            this.Calibration = calibration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMV2Config" /> class.
        /// </summary>
        public LLMV2Config()
        {
        }

    }
}
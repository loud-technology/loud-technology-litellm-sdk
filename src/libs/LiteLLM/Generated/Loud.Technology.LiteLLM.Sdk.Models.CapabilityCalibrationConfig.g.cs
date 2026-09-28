
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CapabilityCalibrationConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Slope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intercept")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Intercept { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityCalibrationConfig" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="slope"></param>
        /// <param name="intercept"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CapabilityCalibrationConfig(
            string version,
            double slope,
            double intercept)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Slope = slope;
            this.Intercept = intercept;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityCalibrationConfig" /> class.
        /// </summary>
        public CapabilityCalibrationConfig()
        {
        }

    }
}
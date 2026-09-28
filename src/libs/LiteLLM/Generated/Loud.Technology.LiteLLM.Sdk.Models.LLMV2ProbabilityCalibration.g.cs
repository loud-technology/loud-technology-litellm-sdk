
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMV2ProbabilityCalibration
    {
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
        /// Initializes a new instance of the <see cref="LLMV2ProbabilityCalibration" /> class.
        /// </summary>
        /// <param name="slope"></param>
        /// <param name="intercept"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMV2ProbabilityCalibration(
            double slope,
            double intercept)
        {
            this.Slope = slope;
            this.Intercept = intercept;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMV2ProbabilityCalibration" /> class.
        /// </summary>
        public LLMV2ProbabilityCalibration()
        {
        }

    }
}
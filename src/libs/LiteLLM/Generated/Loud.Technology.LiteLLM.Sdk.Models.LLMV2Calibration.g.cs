
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMV2Calibration
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
        /// <default>"llm-v2-1"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        public string PromptVersion { get; set; } = "llm-v2-1";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.LLMV2ProbabilityCalibration Efficient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.LLMV2ProbabilityCalibration Capable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMV2Calibration" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="efficient"></param>
        /// <param name="capable"></param>
        /// <param name="promptVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMV2Calibration(
            string version,
            global::Loud.Technology.LiteLLM.Sdk.LLMV2ProbabilityCalibration efficient,
            global::Loud.Technology.LiteLLM.Sdk.LLMV2ProbabilityCalibration capable,
            string promptVersion = "llm-v2-1")
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.PromptVersion = promptVersion;
            this.Efficient = efficient ?? throw new global::System.ArgumentNullException(nameof(efficient));
            this.Capable = capable ?? throw new global::System.ArgumentNullException(nameof(capable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMV2Calibration" /> class.
        /// </summary>
        public LLMV2Calibration()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContextCompactionConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: 0.9F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_ratio")]
        public double? TriggerRatio { get; set; }

        /// <summary>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Default Value: 120
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextCompactionConfig" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="triggerRatio">
        /// Default Value: 0.9F
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 4096
        /// </param>
        /// <param name="timeoutSeconds">
        /// Default Value: 120
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextCompactionConfig(
            string? model,
            double? triggerRatio,
            int? maxTokens,
            double? timeoutSeconds)
        {
            this.Model = model;
            this.TriggerRatio = triggerRatio;
            this.MaxTokens = maxTokens;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextCompactionConfig" /> class.
        /// </summary>
        public ContextCompactionConfig()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Base class for metrics with additional metadata
    /// </summary>
    public sealed partial class KeyMetricWithMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.SpendMetrics Metrics { get; set; }

        /// <summary>
        /// Metadata for a key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Loud.Technology.LiteLLM.Sdk.KeyMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyMetricWithMetadata" /> class.
        /// </summary>
        /// <param name="metrics"></param>
        /// <param name="metadata">
        /// Metadata for a key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyMetricWithMetadata(
            global::Loud.Technology.LiteLLM.Sdk.SpendMetrics metrics,
            global::Loud.Technology.LiteLLM.Sdk.KeyMetadata? metadata)
        {
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyMetricWithMetadata" /> class.
        /// </summary>
        public KeyMetricWithMetadata()
        {
        }

    }
}
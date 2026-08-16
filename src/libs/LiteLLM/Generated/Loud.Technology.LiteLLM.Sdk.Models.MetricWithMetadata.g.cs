
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricWithMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.SpendMetrics Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_breakdown")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.KeyMetricWithMetadata>? ApiKeyBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricWithMetadata" /> class.
        /// </summary>
        /// <param name="metrics"></param>
        /// <param name="metadata"></param>
        /// <param name="apiKeyBreakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricWithMetadata(
            global::Loud.Technology.LiteLLM.Sdk.SpendMetrics metrics,
            object? metadata,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.KeyMetricWithMetadata>? apiKeyBreakdown)
        {
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Metadata = metadata;
            this.ApiKeyBreakdown = apiKeyBreakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricWithMetadata" /> class.
        /// </summary>
        public MetricWithMetadata()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CacheEvidence
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ObservedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        /// Default Value: provider_usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Default Value: observed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public string? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheEvidence" /> class.
        /// </summary>
        /// <param name="observedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="source">
        /// Default Value: provider_usage
        /// </param>
        /// <param name="confidence">
        /// Default Value: observed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheEvidence(
            double observedAt,
            double expiresAt,
            string? source,
            string? confidence)
        {
            this.ObservedAt = observedAt;
            this.ExpiresAt = expiresAt;
            this.Source = source;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheEvidence" /> class.
        /// </summary>
        public CacheEvidence()
        {
        }

    }
}
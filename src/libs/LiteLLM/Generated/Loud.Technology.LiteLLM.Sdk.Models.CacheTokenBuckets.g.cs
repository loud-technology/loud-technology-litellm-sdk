
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CacheTokenBuckets
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncached_input_tokens")]
        public int? UncachedInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_5m_input_tokens")]
        public int? CacheCreation5mInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_1h_input_tokens")]
        public int? CacheCreation1hInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheTokenBuckets" /> class.
        /// </summary>
        /// <param name="uncachedInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheCreation5mInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheCreation1hInputTokens">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheTokenBuckets(
            int? uncachedInputTokens,
            int? cacheReadInputTokens,
            int? cacheCreation5mInputTokens,
            int? cacheCreation1hInputTokens)
        {
            this.UncachedInputTokens = uncachedInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreation5mInputTokens = cacheCreation5mInputTokens;
            this.CacheCreation1hInputTokens = cacheCreation1hInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheTokenBuckets" /> class.
        /// </summary>
        public CacheTokenBuckets()
        {
        }

    }
}
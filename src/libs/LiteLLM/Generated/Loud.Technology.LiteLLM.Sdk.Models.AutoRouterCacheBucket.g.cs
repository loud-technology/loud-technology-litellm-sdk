
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One prompt-caching bucket of turns, with how often those turns hit the cache.
    /// </summary>
    public sealed partial class AutoRouterCacheBucket
    {
        /// <summary>
        /// Turns classified into this bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Turns { get; set; }

        /// <summary>
        /// Turns in this bucket whose response reported cache-read tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Hits { get; set; }

        /// <summary>
        /// hits over this bucket's turns, as a percentage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hit_rate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HitRatePct { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterCacheBucket" /> class.
        /// </summary>
        /// <param name="turns">
        /// Turns classified into this bucket
        /// </param>
        /// <param name="hits">
        /// Turns in this bucket whose response reported cache-read tokens
        /// </param>
        /// <param name="hitRatePct">
        /// hits over this bucket's turns, as a percentage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterCacheBucket(
            int turns,
            int hits,
            double hitRatePct)
        {
            this.Turns = turns;
            this.Hits = hits;
            this.HitRatePct = hitRatePct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterCacheBucket" /> class.
        /// </summary>
        public AutoRouterCacheBucket()
        {
        }

    }
}
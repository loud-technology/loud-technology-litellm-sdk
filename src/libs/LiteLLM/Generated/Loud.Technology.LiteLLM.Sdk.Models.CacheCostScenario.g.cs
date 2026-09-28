
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CacheCostScenario
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.CacheTokenBuckets Tokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InputCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheCostScenario" /> class.
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="inputCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheCostScenario(
            global::Loud.Technology.LiteLLM.Sdk.CacheTokenBuckets tokens,
            double inputCost)
        {
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.InputCost = inputCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheCostScenario" /> class.
        /// </summary>
        public CacheCostScenario()
        {
        }

    }
}
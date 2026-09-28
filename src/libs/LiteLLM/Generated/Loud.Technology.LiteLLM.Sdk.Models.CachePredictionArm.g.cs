
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CachePredictionArm
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.CachePredictionArmCacheStateJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.CachePredictionArmCacheState? CacheState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimate")]
        public global::Loud.Technology.LiteLLM.Sdk.CacheCostScenario? Estimate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cold")]
        public global::Loud.Technology.LiteLLM.Sdk.CacheCostScenario? Cold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warm")]
        public global::Loud.Technology.LiteLLM.Sdk.CacheCostScenario? Warm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evidence")]
        public global::Loud.Technology.LiteLLM.Sdk.CacheEvidence? Evidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_count_source")]
        public string? TokenCountSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CachePredictionArm" /> class.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="model"></param>
        /// <param name="cacheState">
        /// Default Value: unknown
        /// </param>
        /// <param name="reason"></param>
        /// <param name="estimate"></param>
        /// <param name="cold"></param>
        /// <param name="warm"></param>
        /// <param name="evidence"></param>
        /// <param name="tokenCountSource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CachePredictionArm(
            string deploymentId,
            string? model,
            global::Loud.Technology.LiteLLM.Sdk.CachePredictionArmCacheState? cacheState,
            string? reason,
            global::Loud.Technology.LiteLLM.Sdk.CacheCostScenario? estimate,
            global::Loud.Technology.LiteLLM.Sdk.CacheCostScenario? cold,
            global::Loud.Technology.LiteLLM.Sdk.CacheCostScenario? warm,
            global::Loud.Technology.LiteLLM.Sdk.CacheEvidence? evidence,
            string? tokenCountSource)
        {
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Model = model;
            this.CacheState = cacheState;
            this.Reason = reason;
            this.Estimate = estimate;
            this.Cold = cold;
            this.Warm = warm;
            this.Evidence = evidence;
            this.TokenCountSource = tokenCountSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CachePredictionArm" /> class.
        /// </summary>
        public CachePredictionArm()
        {
        }

    }
}
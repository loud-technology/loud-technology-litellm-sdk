
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrainedTierArtifact
    {
        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        public int? SchemaVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_statistics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierGlobalStatistic> GlobalStatistics { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_statistics")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDomainStatistic>? DomainStatistics { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_statistics")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierCohortStatistic>? CohortStatistics { get; set; }

        /// <summary>
        /// Default Value: 200F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_prior_mass")]
        public double? DomainPriorMass { get; set; }

        /// <summary>
        /// Default Value: 20F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_prior_mass")]
        public double? CohortPriorMass { get; set; }

        /// <summary>
        /// Default Value: 0.75F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_threshold")]
        public double? RoutingThreshold { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDataset>? Datasets { get; set; }

        /// <summary>
        /// Default Value: quality score meets the dataset success threshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_definition")]
        public string? SuccessDefinition { get; set; }

        /// <summary>
        /// Default Value: sha256(prompt): 70% train, 15% validation, 15% test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_method")]
        public string? SplitMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainedTierArtifact" /> class.
        /// </summary>
        /// <param name="globalStatistics"></param>
        /// <param name="schemaVersion">
        /// Default Value: 1
        /// </param>
        /// <param name="domainStatistics">
        /// Default Value: []
        /// </param>
        /// <param name="cohortStatistics">
        /// Default Value: []
        /// </param>
        /// <param name="domainPriorMass">
        /// Default Value: 200F
        /// </param>
        /// <param name="cohortPriorMass">
        /// Default Value: 20F
        /// </param>
        /// <param name="routingThreshold">
        /// Default Value: 0.75F
        /// </param>
        /// <param name="datasets">
        /// Default Value: []
        /// </param>
        /// <param name="successDefinition">
        /// Default Value: quality score meets the dataset success threshold
        /// </param>
        /// <param name="splitMethod">
        /// Default Value: sha256(prompt): 70% train, 15% validation, 15% test
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainedTierArtifact(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierGlobalStatistic> globalStatistics,
            int? schemaVersion,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDomainStatistic>? domainStatistics,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierCohortStatistic>? cohortStatistics,
            double? domainPriorMass,
            double? cohortPriorMass,
            double? routingThreshold,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDataset>? datasets,
            string? successDefinition,
            string? splitMethod)
        {
            this.SchemaVersion = schemaVersion;
            this.GlobalStatistics = globalStatistics ?? throw new global::System.ArgumentNullException(nameof(globalStatistics));
            this.DomainStatistics = domainStatistics;
            this.CohortStatistics = cohortStatistics;
            this.DomainPriorMass = domainPriorMass;
            this.CohortPriorMass = cohortPriorMass;
            this.RoutingThreshold = routingThreshold;
            this.Datasets = datasets;
            this.SuccessDefinition = successDefinition;
            this.SplitMethod = splitMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainedTierArtifact" /> class.
        /// </summary>
        public TrainedTierArtifact()
        {
        }

    }
}
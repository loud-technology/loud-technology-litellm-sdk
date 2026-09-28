
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for a policy from the database.
    /// </summary>
    public sealed partial class PolicyDBResponse
    {
        /// <summary>
        /// Policy condition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public object? Condition { get; set; }

        /// <summary>
        /// When the policy was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Who created the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Where this policy is defined: 'db' (database) or 'config' (config.yaml).<br/>
        /// Default Value: db
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.PolicyDBResponseDefinitionLocationJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponseDefinitionLocation? DefinitionLocation { get; set; }

        /// <summary>
        /// Policy description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Guardrails to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_add")]
        public global::System.Collections.Generic.IList<string>? GuardrailsAdd { get; set; }

        /// <summary>
        /// Guardrails to remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_remove")]
        public global::System.Collections.Generic.IList<string>? GuardrailsRemove { get; set; }

        /// <summary>
        /// Parent policy name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherit")]
        public string? Inherit { get; set; }

        /// <summary>
        /// True if this is the latest version by version_number.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_latest")]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// Policy ID this version was cloned from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_version_id")]
        public string? ParentVersionId { get; set; }

        /// <summary>
        /// Optional guardrail pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public object? Pipeline { get; set; }

        /// <summary>
        /// Unique ID of the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PolicyId { get; set; }

        /// <summary>
        /// Name of the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PolicyName { get; set; }

        /// <summary>
        /// When this version was promoted to production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("production_at")]
        public global::System.DateTime? ProductionAt { get; set; }

        /// <summary>
        /// When this version was published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// When the policy was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Who last updated the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Version number of this policy.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// One of: draft, published, production.<br/>
        /// Default Value: production
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_status")]
        public string? VersionStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyDBResponse" /> class.
        /// </summary>
        /// <param name="policyId">
        /// Unique ID of the policy.
        /// </param>
        /// <param name="policyName">
        /// Name of the policy.
        /// </param>
        /// <param name="condition">
        /// Policy condition.
        /// </param>
        /// <param name="createdAt">
        /// When the policy was created.
        /// </param>
        /// <param name="createdBy">
        /// Who created the policy.
        /// </param>
        /// <param name="definitionLocation">
        /// Where this policy is defined: 'db' (database) or 'config' (config.yaml).<br/>
        /// Default Value: db
        /// </param>
        /// <param name="description">
        /// Policy description.
        /// </param>
        /// <param name="guardrailsAdd">
        /// Guardrails to add.
        /// </param>
        /// <param name="guardrailsRemove">
        /// Guardrails to remove.
        /// </param>
        /// <param name="inherit">
        /// Parent policy name.
        /// </param>
        /// <param name="isLatest">
        /// True if this is the latest version by version_number.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="parentVersionId">
        /// Policy ID this version was cloned from.
        /// </param>
        /// <param name="pipeline">
        /// Optional guardrail pipeline.
        /// </param>
        /// <param name="productionAt">
        /// When this version was promoted to production.
        /// </param>
        /// <param name="publishedAt">
        /// When this version was published.
        /// </param>
        /// <param name="updatedAt">
        /// When the policy was last updated.
        /// </param>
        /// <param name="updatedBy">
        /// Who last updated the policy.
        /// </param>
        /// <param name="versionNumber">
        /// Version number of this policy.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="versionStatus">
        /// One of: draft, published, production.<br/>
        /// Default Value: production
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyDBResponse(
            string policyId,
            string policyName,
            object? condition,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponseDefinitionLocation? definitionLocation,
            string? description,
            global::System.Collections.Generic.IList<string>? guardrailsAdd,
            global::System.Collections.Generic.IList<string>? guardrailsRemove,
            string? inherit,
            bool? isLatest,
            string? parentVersionId,
            object? pipeline,
            global::System.DateTime? productionAt,
            global::System.DateTime? publishedAt,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            int? versionNumber,
            string? versionStatus)
        {
            this.Condition = condition;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DefinitionLocation = definitionLocation;
            this.Description = description;
            this.GuardrailsAdd = guardrailsAdd;
            this.GuardrailsRemove = guardrailsRemove;
            this.Inherit = inherit;
            this.IsLatest = isLatest;
            this.ParentVersionId = parentVersionId;
            this.Pipeline = pipeline;
            this.PolicyId = policyId ?? throw new global::System.ArgumentNullException(nameof(policyId));
            this.PolicyName = policyName ?? throw new global::System.ArgumentNullException(nameof(policyName));
            this.ProductionAt = productionAt;
            this.PublishedAt = publishedAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.VersionNumber = versionNumber;
            this.VersionStatus = versionStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyDBResponse" /> class.
        /// </summary>
        public PolicyDBResponse()
        {
        }

    }
}
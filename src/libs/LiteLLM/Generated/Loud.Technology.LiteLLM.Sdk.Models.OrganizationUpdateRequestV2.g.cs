
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Typed PATCH body for ``/v2/organization/{organization_id}`` (RFC 7396 merge-patch).<br/>
    /// Presence is read from ``model_fields_set``, so a sent field is written and an omitted one is<br/>
    /// left untouched. ``extra="forbid"`` makes an unknown key a 422 rather than a silent no-op, since<br/>
    /// the contract hinges on which keys are present. See the endpoint for the per-field clear tokens.
    /// </summary>
    public sealed partial class OrganizationUpdateRequestV2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_alias")]
        public string? OrganizationAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit")]
        public int? TpmLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit")]
        public int? RpmLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_budget")]
        public double? SoftBudget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_requests")]
        public int? MaxParallelRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_max_budget")]
        public object? ModelMaxBudget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? ObjectPermission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdateRequestV2" /> class.
        /// </summary>
        /// <param name="organizationAlias"></param>
        /// <param name="models"></param>
        /// <param name="metadata"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="modelMaxBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="objectPermission"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationUpdateRequestV2(
            string? organizationAlias,
            global::System.Collections.Generic.IList<string>? models,
            object? metadata,
            int? tpmLimit,
            int? rpmLimit,
            double? maxBudget,
            double? softBudget,
            int? maxParallelRequests,
            object? modelMaxBudget,
            string? budgetDuration,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission)
        {
            this.OrganizationAlias = organizationAlias;
            this.Models = models;
            this.Metadata = metadata;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.MaxBudget = maxBudget;
            this.SoftBudget = softBudget;
            this.MaxParallelRequests = maxParallelRequests;
            this.ModelMaxBudget = modelMaxBudget;
            this.BudgetDuration = budgetDuration;
            this.ObjectPermission = objectPermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdateRequestV2" /> class.
        /// </summary>
        public OrganizationUpdateRequestV2()
        {
        }

    }
}
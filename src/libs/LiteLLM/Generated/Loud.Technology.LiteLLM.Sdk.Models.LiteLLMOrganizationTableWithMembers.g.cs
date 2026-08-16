
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Returned by the /organization/info endpoint and /organization/list endpoint
    /// </summary>
    public sealed partial class LiteLLMOrganizationTableWithMembers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_alias")]
        public string? OrganizationAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BudgetId { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_spend")]
        public object? ModelSpend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMUserTable>? Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_budget_table")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTable? LitellmBudgetTable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? ObjectPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission_id")]
        public string? ObjectPermissionId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable>? Members { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable>? Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMOrganizationTableWithMembers" /> class.
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="createdBy"></param>
        /// <param name="updatedBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="organizationId"></param>
        /// <param name="organizationAlias"></param>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="modelSpend">
        /// Default Value: {}
        /// </param>
        /// <param name="users"></param>
        /// <param name="litellmBudgetTable"></param>
        /// <param name="objectPermission"></param>
        /// <param name="objectPermissionId"></param>
        /// <param name="members">
        /// Default Value: []
        /// </param>
        /// <param name="teams">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMOrganizationTableWithMembers(
            string budgetId,
            string createdBy,
            string updatedBy,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? organizationId,
            string? organizationAlias,
            double? spend,
            object? metadata,
            global::System.Collections.Generic.IList<string>? models,
            object? modelSpend,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMUserTable>? users,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTable? litellmBudgetTable,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? objectPermission,
            string? objectPermissionId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable>? members,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable>? teams)
        {
            this.OrganizationId = organizationId;
            this.OrganizationAlias = organizationAlias;
            this.BudgetId = budgetId ?? throw new global::System.ArgumentNullException(nameof(budgetId));
            this.Spend = spend;
            this.Metadata = metadata;
            this.Models = models;
            this.ModelSpend = modelSpend;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.UpdatedBy = updatedBy ?? throw new global::System.ArgumentNullException(nameof(updatedBy));
            this.Users = users;
            this.LitellmBudgetTable = litellmBudgetTable;
            this.ObjectPermission = objectPermission;
            this.ObjectPermissionId = objectPermissionId;
            this.Members = members;
            this.Teams = teams;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMOrganizationTableWithMembers" /> class.
        /// </summary>
        public LiteLLMOrganizationTableWithMembers()
        {
        }

    }
}
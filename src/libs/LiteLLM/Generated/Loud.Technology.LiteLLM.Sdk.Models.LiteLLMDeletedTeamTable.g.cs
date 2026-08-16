
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Audit record for deleted teams; mirrors the team plus deletion metadata.
    /// </summary>
    public sealed partial class LiteLLMDeletedTeamTable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_alias")]
        public string? TeamAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admins")]
        public global::System.Collections.Generic.IList<object>? Admins { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<object>? Members { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_with_roles")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>? MembersWithRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_permissions")]
        public global::System.Collections.Generic.IList<string>? TeamMemberPermissions { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_limits")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? BudgetLimits { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<object>? Models { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_settings")]
        public object? RouterSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_group_ids")]
        public global::System.Collections.Generic.IList<string>? AccessGroupIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_team_member_models")]
        public global::System.Collections.Generic.IList<string>? DefaultTeamMemberModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_requests")]
        public int? MaxParallelRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_reset_at")]
        public global::System.DateTime? BudgetResetAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public int? ModelId { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_spend")]
        public object? ModelSpend { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_max_budget")]
        public object? ModelMaxBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<string>? Policies { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_team_guardrail_config")]
        public bool? AllowTeamGuardrailConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_model_table")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMModelTable? LitellmModelTable { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_by")]
        public string? DeletedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_by_api_key")]
        public string? DeletedByApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_changed_by")]
        public string? LitellmChangedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMDeletedTeamTable" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="teamAlias"></param>
        /// <param name="organizationId"></param>
        /// <param name="admins">
        /// Default Value: []
        /// </param>
        /// <param name="members">
        /// Default Value: []
        /// </param>
        /// <param name="membersWithRoles">
        /// Default Value: []
        /// </param>
        /// <param name="teamMemberPermissions"></param>
        /// <param name="metadata"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetLimits"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="blocked">
        /// Default Value: false
        /// </param>
        /// <param name="routerSettings"></param>
        /// <param name="accessGroupIds"></param>
        /// <param name="defaultTeamMemberModels"></param>
        /// <param name="spend"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="budgetResetAt"></param>
        /// <param name="modelId"></param>
        /// <param name="modelSpend">
        /// Default Value: {}
        /// </param>
        /// <param name="modelMaxBudget">
        /// Default Value: {}
        /// </param>
        /// <param name="policies"></param>
        /// <param name="allowTeamGuardrailConfig">
        /// Default Value: false
        /// </param>
        /// <param name="litellmModelTable"></param>
        /// <param name="objectPermission"></param>
        /// <param name="objectPermissionId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="deletedAt"></param>
        /// <param name="deletedBy"></param>
        /// <param name="deletedByApiKey"></param>
        /// <param name="litellmChangedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMDeletedTeamTable(
            string teamId,
            string? teamAlias,
            string? organizationId,
            global::System.Collections.Generic.IList<object>? admins,
            global::System.Collections.Generic.IList<object>? members,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>? membersWithRoles,
            global::System.Collections.Generic.IList<string>? teamMemberPermissions,
            object? metadata,
            int? tpmLimit,
            int? rpmLimit,
            double? maxBudget,
            double? softBudget,
            string? budgetDuration,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? budgetLimits,
            global::System.Collections.Generic.IList<object>? models,
            bool? blocked,
            object? routerSettings,
            global::System.Collections.Generic.IList<string>? accessGroupIds,
            global::System.Collections.Generic.IList<string>? defaultTeamMemberModels,
            double? spend,
            int? maxParallelRequests,
            global::System.DateTime? budgetResetAt,
            int? modelId,
            object? modelSpend,
            object? modelMaxBudget,
            global::System.Collections.Generic.IList<string>? policies,
            bool? allowTeamGuardrailConfig,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMModelTable? litellmModelTable,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? objectPermission,
            string? objectPermissionId,
            global::System.DateTime? updatedAt,
            global::System.DateTime? createdAt,
            string? id,
            global::System.DateTime? deletedAt,
            string? deletedBy,
            string? deletedByApiKey,
            string? litellmChangedBy)
        {
            this.TeamAlias = teamAlias;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.OrganizationId = organizationId;
            this.Admins = admins;
            this.Members = members;
            this.MembersWithRoles = membersWithRoles;
            this.TeamMemberPermissions = teamMemberPermissions;
            this.Metadata = metadata;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.MaxBudget = maxBudget;
            this.SoftBudget = softBudget;
            this.BudgetDuration = budgetDuration;
            this.BudgetLimits = budgetLimits;
            this.Models = models;
            this.Blocked = blocked;
            this.RouterSettings = routerSettings;
            this.AccessGroupIds = accessGroupIds;
            this.DefaultTeamMemberModels = defaultTeamMemberModels;
            this.Spend = spend;
            this.MaxParallelRequests = maxParallelRequests;
            this.BudgetResetAt = budgetResetAt;
            this.ModelId = modelId;
            this.ModelSpend = modelSpend;
            this.ModelMaxBudget = modelMaxBudget;
            this.Policies = policies;
            this.AllowTeamGuardrailConfig = allowTeamGuardrailConfig;
            this.LitellmModelTable = litellmModelTable;
            this.ObjectPermission = objectPermission;
            this.ObjectPermissionId = objectPermissionId;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
            this.DeletedByApiKey = deletedByApiKey;
            this.LitellmChangedBy = litellmChangedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMDeletedTeamTable" /> class.
        /// </summary>
        public LiteLLMDeletedTeamTable()
        {
        }

    }
}
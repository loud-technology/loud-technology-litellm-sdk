
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewTeamRequest
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
        public string? TeamId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_aliases")]
        public object? ModelAliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<object>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        public global::System.Collections.Generic.IList<string>? Guardrails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<string>? Policies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::System.Collections.Generic.IList<string>? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? ObjectPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_passthrough_routes")]
        public global::System.Collections.Generic.IList<object>? AllowedPassthroughRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_global_guardrails")]
        public bool? DisableGlobalGuardrails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_manager_settings")]
        public object? SecretManagerSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_rpm_limit")]
        public global::System.Collections.Generic.Dictionary<string, int>? ModelRpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit_type")]
        public global::Loud.Technology.LiteLLM.Sdk.NewTeamRequestRpmLimitType2? RpmLimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit_type")]
        public global::Loud.Technology.LiteLLM.Sdk.NewTeamRequestTpmLimitType2? TpmLimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_tpm_limit")]
        public global::System.Collections.Generic.Dictionary<string, int>? ModelTpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_rpm_limit")]
        public global::System.Collections.Generic.Dictionary<string, int>? McpRpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_budget")]
        public double? TeamMemberBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_rpm_limit")]
        public int? TeamMemberRpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_tpm_limit")]
        public int? TeamMemberTpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_key_duration")]
        public string? TeamMemberKeyDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_budget_duration")]
        public string? TeamMemberBudgetDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_vector_store_indexes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? AllowedVectorStoreIndexes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced_batch_output_expires_after")]
        public object? EnforcedBatchOutputExpiresAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced_file_expires_after")]
        public object? EnforcedFileExpiresAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewTeamRequest" /> class.
        /// </summary>
        /// <param name="teamAlias"></param>
        /// <param name="teamId"></param>
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
        /// <param name="modelAliases"></param>
        /// <param name="tags"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="prompts"></param>
        /// <param name="objectPermission"></param>
        /// <param name="allowedPassthroughRoutes"></param>
        /// <param name="disableGlobalGuardrails"></param>
        /// <param name="secretManagerSettings"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="rpmLimitType"></param>
        /// <param name="tpmLimitType"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="mcpRpmLimit"></param>
        /// <param name="teamMemberBudget"></param>
        /// <param name="teamMemberRpmLimit"></param>
        /// <param name="teamMemberTpmLimit"></param>
        /// <param name="teamMemberKeyDuration"></param>
        /// <param name="teamMemberBudgetDuration"></param>
        /// <param name="allowedVectorStoreIndexes"></param>
        /// <param name="enforcedBatchOutputExpiresAfter"></param>
        /// <param name="enforcedFileExpiresAfter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewTeamRequest(
            string? teamAlias,
            string? teamId,
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
            object? modelAliases,
            global::System.Collections.Generic.IList<object>? tags,
            global::System.Collections.Generic.IList<string>? guardrails,
            global::System.Collections.Generic.IList<string>? policies,
            global::System.Collections.Generic.IList<string>? prompts,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission,
            global::System.Collections.Generic.IList<object>? allowedPassthroughRoutes,
            bool? disableGlobalGuardrails,
            object? secretManagerSettings,
            global::System.Collections.Generic.Dictionary<string, int>? modelRpmLimit,
            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequestRpmLimitType2? rpmLimitType,
            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequestTpmLimitType2? tpmLimitType,
            global::System.Collections.Generic.Dictionary<string, int>? modelTpmLimit,
            global::System.Collections.Generic.Dictionary<string, int>? mcpRpmLimit,
            double? teamMemberBudget,
            int? teamMemberRpmLimit,
            int? teamMemberTpmLimit,
            string? teamMemberKeyDuration,
            string? teamMemberBudgetDuration,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? allowedVectorStoreIndexes,
            object? enforcedBatchOutputExpiresAfter,
            object? enforcedFileExpiresAfter)
        {
            this.TeamAlias = teamAlias;
            this.TeamId = teamId;
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
            this.ModelAliases = modelAliases;
            this.Tags = tags;
            this.Guardrails = guardrails;
            this.Policies = policies;
            this.Prompts = prompts;
            this.ObjectPermission = objectPermission;
            this.AllowedPassthroughRoutes = allowedPassthroughRoutes;
            this.DisableGlobalGuardrails = disableGlobalGuardrails;
            this.SecretManagerSettings = secretManagerSettings;
            this.ModelRpmLimit = modelRpmLimit;
            this.RpmLimitType = rpmLimitType;
            this.TpmLimitType = tpmLimitType;
            this.ModelTpmLimit = modelTpmLimit;
            this.McpRpmLimit = mcpRpmLimit;
            this.TeamMemberBudget = teamMemberBudget;
            this.TeamMemberRpmLimit = teamMemberRpmLimit;
            this.TeamMemberTpmLimit = teamMemberTpmLimit;
            this.TeamMemberKeyDuration = teamMemberKeyDuration;
            this.TeamMemberBudgetDuration = teamMemberBudgetDuration;
            this.AllowedVectorStoreIndexes = allowedVectorStoreIndexes;
            this.EnforcedBatchOutputExpiresAfter = enforcedBatchOutputExpiresAfter;
            this.EnforcedFileExpiresAfter = enforcedFileExpiresAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewTeamRequest" /> class.
        /// </summary>
        public NewTeamRequest()
        {
        }

    }
}
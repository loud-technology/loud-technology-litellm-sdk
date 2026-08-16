
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Body of PATCH /team/{team_id}.<br/>
    /// Identical to UpdateTeamRequest except team_id is optional, because PATCH takes it<br/>
    /// from the path. A team_id in the body is still accepted when it matches the path.
    /// </summary>
    public sealed partial class PatchTeamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_alias")]
        public string? TeamAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<object>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<object>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_aliases")]
        public object? ModelAliases { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? ObjectPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_global_guardrails")]
        public bool? DisableGlobalGuardrails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_budget")]
        public double? TeamMemberBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_budget_duration")]
        public string? TeamMemberBudgetDuration { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_passthrough_routes")]
        public global::System.Collections.Generic.IList<object>? AllowedPassthroughRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_manager_settings")]
        public object? SecretManagerSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::System.Collections.Generic.IList<string>? Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_rpm_limit")]
        public global::System.Collections.Generic.Dictionary<string, int>? ModelRpmLimit { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_limits")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? BudgetLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_team_member_models")]
        public global::System.Collections.Generic.IList<string>? DefaultTeamMemberModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequest" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="teamAlias"></param>
        /// <param name="organizationId"></param>
        /// <param name="metadata"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="models"></param>
        /// <param name="blocked"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="tags"></param>
        /// <param name="modelAliases"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="objectPermission"></param>
        /// <param name="disableGlobalGuardrails"></param>
        /// <param name="teamMemberBudget"></param>
        /// <param name="teamMemberBudgetDuration"></param>
        /// <param name="teamMemberRpmLimit"></param>
        /// <param name="teamMemberTpmLimit"></param>
        /// <param name="teamMemberKeyDuration"></param>
        /// <param name="allowedPassthroughRoutes"></param>
        /// <param name="secretManagerSettings"></param>
        /// <param name="prompts"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="mcpRpmLimit"></param>
        /// <param name="allowedVectorStoreIndexes"></param>
        /// <param name="enforcedBatchOutputExpiresAfter"></param>
        /// <param name="enforcedFileExpiresAfter"></param>
        /// <param name="routerSettings"></param>
        /// <param name="accessGroupIds"></param>
        /// <param name="budgetLimits"></param>
        /// <param name="defaultTeamMemberModels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequest(
            string? teamId,
            string? teamAlias,
            string? organizationId,
            object? metadata,
            int? tpmLimit,
            int? rpmLimit,
            double? maxBudget,
            double? softBudget,
            global::System.Collections.Generic.IList<object>? models,
            bool? blocked,
            string? budgetDuration,
            global::System.Collections.Generic.IList<object>? tags,
            object? modelAliases,
            global::System.Collections.Generic.IList<string>? guardrails,
            global::System.Collections.Generic.IList<string>? policies,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission,
            bool? disableGlobalGuardrails,
            double? teamMemberBudget,
            string? teamMemberBudgetDuration,
            int? teamMemberRpmLimit,
            int? teamMemberTpmLimit,
            string? teamMemberKeyDuration,
            global::System.Collections.Generic.IList<object>? allowedPassthroughRoutes,
            object? secretManagerSettings,
            global::System.Collections.Generic.IList<string>? prompts,
            global::System.Collections.Generic.Dictionary<string, int>? modelRpmLimit,
            global::System.Collections.Generic.Dictionary<string, int>? modelTpmLimit,
            global::System.Collections.Generic.Dictionary<string, int>? mcpRpmLimit,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? allowedVectorStoreIndexes,
            object? enforcedBatchOutputExpiresAfter,
            object? enforcedFileExpiresAfter,
            object? routerSettings,
            global::System.Collections.Generic.IList<string>? accessGroupIds,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? budgetLimits,
            global::System.Collections.Generic.IList<string>? defaultTeamMemberModels)
        {
            this.TeamId = teamId;
            this.TeamAlias = teamAlias;
            this.OrganizationId = organizationId;
            this.Metadata = metadata;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.MaxBudget = maxBudget;
            this.SoftBudget = softBudget;
            this.Models = models;
            this.Blocked = blocked;
            this.BudgetDuration = budgetDuration;
            this.Tags = tags;
            this.ModelAliases = modelAliases;
            this.Guardrails = guardrails;
            this.Policies = policies;
            this.ObjectPermission = objectPermission;
            this.DisableGlobalGuardrails = disableGlobalGuardrails;
            this.TeamMemberBudget = teamMemberBudget;
            this.TeamMemberBudgetDuration = teamMemberBudgetDuration;
            this.TeamMemberRpmLimit = teamMemberRpmLimit;
            this.TeamMemberTpmLimit = teamMemberTpmLimit;
            this.TeamMemberKeyDuration = teamMemberKeyDuration;
            this.AllowedPassthroughRoutes = allowedPassthroughRoutes;
            this.SecretManagerSettings = secretManagerSettings;
            this.Prompts = prompts;
            this.ModelRpmLimit = modelRpmLimit;
            this.ModelTpmLimit = modelTpmLimit;
            this.McpRpmLimit = mcpRpmLimit;
            this.AllowedVectorStoreIndexes = allowedVectorStoreIndexes;
            this.EnforcedBatchOutputExpiresAfter = enforcedBatchOutputExpiresAfter;
            this.EnforcedFileExpiresAfter = enforcedFileExpiresAfter;
            this.RouterSettings = routerSettings;
            this.AccessGroupIds = accessGroupIds;
            this.BudgetLimits = budgetLimits;
            this.DefaultTeamMemberModels = defaultTeamMemberModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequest" /> class.
        /// </summary>
        public PatchTeamRequest()
        {
        }

    }
}
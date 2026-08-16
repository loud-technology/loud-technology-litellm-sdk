
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiteLLMVerificationToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        public string? KeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_alias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.DateTime?, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.DateTime?, object>? Expires { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<object>? Models { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public object? Aliases { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_requests")]
        public int? MaxParallelRequests { get; set; }

        /// <summary>
        /// Default Value: {}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_reset_at")]
        public global::System.DateTime? BudgetResetAt { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_cache_controls")]
        public global::System.Collections.Generic.IList<object>? AllowedCacheControls { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_routes")]
        public global::System.Collections.Generic.IList<object>? AllowedRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_type")]
        public string? KeyType { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public object? Permissions { get; set; }

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
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_fallbacks")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? BudgetFallbacks { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_budget_cooldown")]
        public bool? SoftBudgetCooldown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_budget_table")]
        public object? LitellmBudgetTable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active")]
        public global::System.DateTime? LastActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission_id")]
        public string? ObjectPermissionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? ObjectPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_group_ids")]
        public global::System.Collections.Generic.IList<string>? AccessGroupIds { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation_count")]
        public int? RotationCount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_rotate")]
        public bool? AutoRotate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation_interval")]
        public string? RotationInterval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_rotation_at")]
        public global::System.DateTime? LastRotationAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_rotation_at")]
        public global::System.DateTime? KeyRotationAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_settings")]
        public object? RouterSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_limits")]
        public global::System.Collections.Generic.IList<object>? BudgetLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMVerificationToken" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="keyName"></param>
        /// <param name="keyAlias"></param>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
        /// <param name="maxBudget"></param>
        /// <param name="expires"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="aliases">
        /// Default Value: {}
        /// </param>
        /// <param name="config">
        /// Default Value: {}
        /// </param>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="agentId"></param>
        /// <param name="projectId"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="metadata">
        /// Default Value: {}
        /// </param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetResetAt"></param>
        /// <param name="allowedCacheControls">
        /// Default Value: []
        /// </param>
        /// <param name="allowedRoutes">
        /// Default Value: []
        /// </param>
        /// <param name="keyType"></param>
        /// <param name="permissions">
        /// Default Value: {}
        /// </param>
        /// <param name="modelSpend">
        /// Default Value: {}
        /// </param>
        /// <param name="modelMaxBudget">
        /// Default Value: {}
        /// </param>
        /// <param name="budgetFallbacks">
        /// Default Value: {}
        /// </param>
        /// <param name="softBudgetCooldown">
        /// Default Value: false
        /// </param>
        /// <param name="blocked"></param>
        /// <param name="litellmBudgetTable"></param>
        /// <param name="budgetId"></param>
        /// <param name="orgId"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="lastActive"></param>
        /// <param name="objectPermissionId"></param>
        /// <param name="objectPermission"></param>
        /// <param name="accessGroupIds"></param>
        /// <param name="rotationCount">
        /// Default Value: 0
        /// </param>
        /// <param name="autoRotate">
        /// Default Value: false
        /// </param>
        /// <param name="rotationInterval"></param>
        /// <param name="lastRotationAt"></param>
        /// <param name="keyRotationAt"></param>
        /// <param name="routerSettings"></param>
        /// <param name="budgetLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMVerificationToken(
            string? token,
            string? keyName,
            string? keyAlias,
            double? spend,
            double? maxBudget,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.DateTime?, object>? expires,
            global::System.Collections.Generic.IList<object>? models,
            object? aliases,
            object? config,
            string? userId,
            string? teamId,
            string? agentId,
            string? projectId,
            int? maxParallelRequests,
            object? metadata,
            int? tpmLimit,
            int? rpmLimit,
            string? budgetDuration,
            global::System.DateTime? budgetResetAt,
            global::System.Collections.Generic.IList<object>? allowedCacheControls,
            global::System.Collections.Generic.IList<object>? allowedRoutes,
            string? keyType,
            object? permissions,
            object? modelSpend,
            object? modelMaxBudget,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? budgetFallbacks,
            bool? softBudgetCooldown,
            bool? blocked,
            object? litellmBudgetTable,
            string? budgetId,
            string? orgId,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            global::System.DateTime? lastActive,
            string? objectPermissionId,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? objectPermission,
            global::System.Collections.Generic.IList<string>? accessGroupIds,
            int? rotationCount,
            bool? autoRotate,
            string? rotationInterval,
            global::System.DateTime? lastRotationAt,
            global::System.DateTime? keyRotationAt,
            object? routerSettings,
            global::System.Collections.Generic.IList<object>? budgetLimits)
        {
            this.Token = token;
            this.KeyName = keyName;
            this.KeyAlias = keyAlias;
            this.Spend = spend;
            this.MaxBudget = maxBudget;
            this.Expires = expires;
            this.Models = models;
            this.Aliases = aliases;
            this.Config = config;
            this.UserId = userId;
            this.TeamId = teamId;
            this.AgentId = agentId;
            this.ProjectId = projectId;
            this.MaxParallelRequests = maxParallelRequests;
            this.Metadata = metadata;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.BudgetDuration = budgetDuration;
            this.BudgetResetAt = budgetResetAt;
            this.AllowedCacheControls = allowedCacheControls;
            this.AllowedRoutes = allowedRoutes;
            this.KeyType = keyType;
            this.Permissions = permissions;
            this.ModelSpend = modelSpend;
            this.ModelMaxBudget = modelMaxBudget;
            this.BudgetFallbacks = budgetFallbacks;
            this.SoftBudgetCooldown = softBudgetCooldown;
            this.Blocked = blocked;
            this.LitellmBudgetTable = litellmBudgetTable;
            this.BudgetId = budgetId;
            this.OrgId = orgId;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.LastActive = lastActive;
            this.ObjectPermissionId = objectPermissionId;
            this.ObjectPermission = objectPermission;
            this.AccessGroupIds = accessGroupIds;
            this.RotationCount = rotationCount;
            this.AutoRotate = autoRotate;
            this.RotationInterval = rotationInterval;
            this.LastRotationAt = lastRotationAt;
            this.KeyRotationAt = keyRotationAt;
            this.RouterSettings = routerSettings;
            this.BudgetLimits = budgetLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMVerificationToken" /> class.
        /// </summary>
        public LiteLLMVerificationToken()
        {
        }

    }
}
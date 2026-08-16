
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_alias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<object>? Models { get; set; }

        /// <summary>
        /// Default Value: 0
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
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_limits")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? BudgetLimits { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_cache_controls")]
        public global::System.Collections.Generic.IList<object>? AllowedCacheControls { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public object? Permissions { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_max_budget")]
        public object? ModelMaxBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_fallbacks")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? BudgetFallbacks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_rpm_limit")]
        public object? ModelRpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_tpm_limit")]
        public object? ModelTpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_rpm_limit")]
        public global::System.Collections.Generic.Dictionary<string, int>? McpRpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_rpm_limit")]
        public global::System.Collections.Generic.Dictionary<string, int>? TagRpmLimit { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public object? Aliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? ObjectPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_global_guardrails")]
        public bool? DisableGlobalGuardrails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttle_on_budget_exceeded")]
        public bool? ThrottleOnBudgetExceeded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced_params")]
        public global::System.Collections.Generic.IList<string>? EnforcedParams { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_routes")]
        public global::System.Collections.Generic.IList<object>? AllowedRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_passthrough_routes")]
        public global::System.Collections.Generic.IList<object>? AllowedPassthroughRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_vector_store_indexes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? AllowedVectorStoreIndexes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit_type")]
        public global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponseRpmLimitType2? RpmLimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit_type")]
        public global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponseTpmLimitType2? TpmLimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_settings")]
        public global::Loud.Technology.LiteLLM.Sdk.UpdateRouterConfig? RouterSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_group_ids")]
        public global::System.Collections.Generic.IList<string>? AccessGroupIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        public string? KeyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_type")]
        public string? KeyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires")]
        public global::System.DateTime? Expires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        public string? TokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_budget_table")]
        public object? LitellmBudgetTable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateKeyResponse" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="keyAlias"></param>
        /// <param name="duration"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="spend">
        /// Default Value: 0
        /// </param>
        /// <param name="maxBudget"></param>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="agentId"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="metadata">
        /// Default Value: {}
        /// </param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetLimits"></param>
        /// <param name="allowedCacheControls">
        /// Default Value: []
        /// </param>
        /// <param name="config">
        /// Default Value: {}
        /// </param>
        /// <param name="permissions">
        /// Default Value: {}
        /// </param>
        /// <param name="modelMaxBudget">
        /// Default Value: {}
        /// </param>
        /// <param name="budgetFallbacks"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="mcpRpmLimit"></param>
        /// <param name="tagRpmLimit"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="prompts"></param>
        /// <param name="blocked"></param>
        /// <param name="aliases">
        /// Default Value: {}
        /// </param>
        /// <param name="objectPermission"></param>
        /// <param name="budgetId"></param>
        /// <param name="tags"></param>
        /// <param name="disableGlobalGuardrails"></param>
        /// <param name="throttleOnBudgetExceeded"></param>
        /// <param name="enforcedParams"></param>
        /// <param name="allowedRoutes">
        /// Default Value: []
        /// </param>
        /// <param name="allowedPassthroughRoutes"></param>
        /// <param name="allowedVectorStoreIndexes"></param>
        /// <param name="rpmLimitType"></param>
        /// <param name="tpmLimitType"></param>
        /// <param name="routerSettings"></param>
        /// <param name="accessGroupIds"></param>
        /// <param name="keyName"></param>
        /// <param name="keyType"></param>
        /// <param name="expires"></param>
        /// <param name="tokenId"></param>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="litellmBudgetTable"></param>
        /// <param name="token"></param>
        /// <param name="createdBy"></param>
        /// <param name="updatedBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateKeyResponse(
            string key,
            string? keyAlias,
            string? duration,
            global::System.Collections.Generic.IList<object>? models,
            double? spend,
            double? maxBudget,
            string? userId,
            string? teamId,
            string? agentId,
            int? maxParallelRequests,
            object? metadata,
            int? tpmLimit,
            int? rpmLimit,
            string? budgetDuration,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? budgetLimits,
            global::System.Collections.Generic.IList<object>? allowedCacheControls,
            object? config,
            object? permissions,
            object? modelMaxBudget,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? budgetFallbacks,
            object? modelRpmLimit,
            object? modelTpmLimit,
            global::System.Collections.Generic.Dictionary<string, int>? mcpRpmLimit,
            global::System.Collections.Generic.Dictionary<string, int>? tagRpmLimit,
            global::System.Collections.Generic.IList<string>? guardrails,
            global::System.Collections.Generic.IList<string>? policies,
            global::System.Collections.Generic.IList<string>? prompts,
            bool? blocked,
            object? aliases,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission,
            string? budgetId,
            global::System.Collections.Generic.IList<string>? tags,
            bool? disableGlobalGuardrails,
            bool? throttleOnBudgetExceeded,
            global::System.Collections.Generic.IList<string>? enforcedParams,
            global::System.Collections.Generic.IList<object>? allowedRoutes,
            global::System.Collections.Generic.IList<object>? allowedPassthroughRoutes,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? allowedVectorStoreIndexes,
            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponseRpmLimitType2? rpmLimitType,
            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponseTpmLimitType2? tpmLimitType,
            global::Loud.Technology.LiteLLM.Sdk.UpdateRouterConfig? routerSettings,
            global::System.Collections.Generic.IList<string>? accessGroupIds,
            string? keyName,
            string? keyType,
            global::System.DateTime? expires,
            string? tokenId,
            string? organizationId,
            string? projectId,
            object? litellmBudgetTable,
            string? token,
            string? createdBy,
            string? updatedBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.KeyAlias = keyAlias;
            this.Duration = duration;
            this.Models = models;
            this.Spend = spend;
            this.MaxBudget = maxBudget;
            this.UserId = userId;
            this.TeamId = teamId;
            this.AgentId = agentId;
            this.MaxParallelRequests = maxParallelRequests;
            this.Metadata = metadata;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.BudgetDuration = budgetDuration;
            this.BudgetLimits = budgetLimits;
            this.AllowedCacheControls = allowedCacheControls;
            this.Config = config;
            this.Permissions = permissions;
            this.ModelMaxBudget = modelMaxBudget;
            this.BudgetFallbacks = budgetFallbacks;
            this.ModelRpmLimit = modelRpmLimit;
            this.ModelTpmLimit = modelTpmLimit;
            this.McpRpmLimit = mcpRpmLimit;
            this.TagRpmLimit = tagRpmLimit;
            this.Guardrails = guardrails;
            this.Policies = policies;
            this.Prompts = prompts;
            this.Blocked = blocked;
            this.Aliases = aliases;
            this.ObjectPermission = objectPermission;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.BudgetId = budgetId;
            this.Tags = tags;
            this.DisableGlobalGuardrails = disableGlobalGuardrails;
            this.ThrottleOnBudgetExceeded = throttleOnBudgetExceeded;
            this.EnforcedParams = enforcedParams;
            this.AllowedRoutes = allowedRoutes;
            this.AllowedPassthroughRoutes = allowedPassthroughRoutes;
            this.AllowedVectorStoreIndexes = allowedVectorStoreIndexes;
            this.RpmLimitType = rpmLimitType;
            this.TpmLimitType = tpmLimitType;
            this.RouterSettings = routerSettings;
            this.AccessGroupIds = accessGroupIds;
            this.KeyName = keyName;
            this.KeyType = keyType;
            this.Expires = expires;
            this.TokenId = tokenId;
            this.OrganizationId = organizationId;
            this.ProjectId = projectId;
            this.LitellmBudgetTable = litellmBudgetTable;
            this.Token = token;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateKeyResponse" /> class.
        /// </summary>
        public GenerateKeyResponse()
        {
        }

    }
}
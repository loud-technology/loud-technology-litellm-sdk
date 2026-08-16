
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewUserRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_alias")]
        public string? UserAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_role")]
        public global::Loud.Technology.LiteLLM.Sdk.NewUserRequestUserRole2? UserRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.NewUserRequestTeam>, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.NewUserRequestTeam>, object>? Teams { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_create_key")]
        public bool? AutoCreateKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_invite_email")]
        public bool? SendInviteEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_user_id")]
        public string? SsoUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        public global::System.Collections.Generic.IList<string>? Organizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserRequest" /> class.
        /// </summary>
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
        /// <param name="userEmail"></param>
        /// <param name="userAlias"></param>
        /// <param name="userRole"></param>
        /// <param name="teams"></param>
        /// <param name="autoCreateKey">
        /// Default Value: true
        /// </param>
        /// <param name="sendInviteEmail"></param>
        /// <param name="ssoUserId"></param>
        /// <param name="organizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewUserRequest(
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
            string? userEmail,
            string? userAlias,
            global::Loud.Technology.LiteLLM.Sdk.NewUserRequestUserRole2? userRole,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.NewUserRequestTeam>, object>? teams,
            bool? autoCreateKey,
            bool? sendInviteEmail,
            string? ssoUserId,
            global::System.Collections.Generic.IList<string>? organizations)
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
            this.UserEmail = userEmail;
            this.UserAlias = userAlias;
            this.UserRole = userRole;
            this.Teams = teams;
            this.AutoCreateKey = autoCreateKey;
            this.SendInviteEmail = sendInviteEmail;
            this.SsoUserId = ssoUserId;
            this.Organizations = organizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserRequest" /> class.
        /// </summary>
        public NewUserRequest()
        {
        }

    }
}
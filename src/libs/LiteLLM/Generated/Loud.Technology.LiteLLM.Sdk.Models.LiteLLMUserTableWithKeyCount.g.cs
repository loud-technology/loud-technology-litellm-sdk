
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiteLLMUserTableWithKeyCount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_alias")]
        public string? UserAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_user_id")]
        public string? SsoUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission_id")]
        public string? ObjectPermissionId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_role")]
        public string? UserRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<object>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_requests")]
        public int? MaxParallelRequests { get; set; }

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
        public global::System.Collections.Generic.IList<string>? AllowedCacheControls { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<string>? Policies { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_memberships")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable>? OrganizationMemberships { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? ObjectPermission { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_count")]
        public int? KeyCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMUserTableWithKeyCount" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userAlias"></param>
        /// <param name="teamId"></param>
        /// <param name="ssoUserId"></param>
        /// <param name="organizationId"></param>
        /// <param name="objectPermissionId"></param>
        /// <param name="teams">
        /// Default Value: []
        /// </param>
        /// <param name="userRole"></param>
        /// <param name="maxBudget"></param>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
        /// <param name="userEmail"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetResetAt"></param>
        /// <param name="allowedCacheControls">
        /// Default Value: []
        /// </param>
        /// <param name="policies">
        /// Default Value: []
        /// </param>
        /// <param name="modelSpend">
        /// Default Value: {}
        /// </param>
        /// <param name="modelMaxBudget">
        /// Default Value: {}
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="organizationMemberships"></param>
        /// <param name="objectPermission"></param>
        /// <param name="keyCount">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMUserTableWithKeyCount(
            string userId,
            string? userAlias,
            string? teamId,
            string? ssoUserId,
            string? organizationId,
            string? objectPermissionId,
            global::System.Collections.Generic.IList<string>? teams,
            string? userRole,
            double? maxBudget,
            double? spend,
            string? userEmail,
            global::System.Collections.Generic.IList<object>? models,
            object? metadata,
            int? maxParallelRequests,
            int? tpmLimit,
            int? rpmLimit,
            string? budgetDuration,
            global::System.DateTime? budgetResetAt,
            global::System.Collections.Generic.IList<string>? allowedCacheControls,
            global::System.Collections.Generic.IList<string>? policies,
            object? modelSpend,
            object? modelMaxBudget,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable>? organizationMemberships,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? objectPermission,
            int? keyCount)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserAlias = userAlias;
            this.TeamId = teamId;
            this.SsoUserId = ssoUserId;
            this.OrganizationId = organizationId;
            this.ObjectPermissionId = objectPermissionId;
            this.Teams = teams;
            this.UserRole = userRole;
            this.MaxBudget = maxBudget;
            this.Spend = spend;
            this.UserEmail = userEmail;
            this.Models = models;
            this.Metadata = metadata;
            this.MaxParallelRequests = maxParallelRequests;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.BudgetDuration = budgetDuration;
            this.BudgetResetAt = budgetResetAt;
            this.AllowedCacheControls = allowedCacheControls;
            this.Policies = policies;
            this.ModelSpend = modelSpend;
            this.ModelMaxBudget = modelMaxBudget;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OrganizationMemberships = organizationMemberships;
            this.ObjectPermission = objectPermission;
            this.KeyCount = keyCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMUserTableWithKeyCount" /> class.
        /// </summary>
        public LiteLLMUserTableWithKeyCount()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for GET /v2/user/info<br/>
    /// Returns ONLY the user object - no keys, no teams objects.<br/>
    /// This is a lightweight alternative to UserInfoResponse.
    /// </summary>
    public sealed partial class UserInfoV2Response
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
        public string? UserRole { get; set; }

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
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_user_id")]
        public string? SsoUserId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? ObjectPermission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoV2Response" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="userAlias"></param>
        /// <param name="userRole"></param>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
        /// <param name="maxBudget"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetResetAt"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="ssoUserId"></param>
        /// <param name="teams">
        /// Default Value: []
        /// </param>
        /// <param name="objectPermission"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInfoV2Response(
            string userId,
            string? userEmail,
            string? userAlias,
            string? userRole,
            double? spend,
            double? maxBudget,
            global::System.Collections.Generic.IList<string>? models,
            string? budgetDuration,
            global::System.DateTime? budgetResetAt,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? ssoUserId,
            global::System.Collections.Generic.IList<string>? teams,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? objectPermission)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserEmail = userEmail;
            this.UserAlias = userAlias;
            this.UserRole = userRole;
            this.Spend = spend;
            this.MaxBudget = maxBudget;
            this.Models = models;
            this.BudgetDuration = budgetDuration;
            this.BudgetResetAt = budgetResetAt;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SsoUserId = ssoUserId;
            this.Teams = teams;
            this.ObjectPermission = objectPermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoV2Response" /> class.
        /// </summary>
        public UserInfoV2Response()
        {
        }

    }
}
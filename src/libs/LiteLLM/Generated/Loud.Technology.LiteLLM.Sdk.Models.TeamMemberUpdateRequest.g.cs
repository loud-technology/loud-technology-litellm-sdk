
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamMemberUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget_in_team")]
        public double? MaxBudgetInTeam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Loud.Technology.LiteLLM.Sdk.TeamMemberUpdateRequestRole2? Role { get; set; }

        /// <summary>
        /// Tokens per minute limit for this team member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit")]
        public int? TpmLimit { get; set; }

        /// <summary>
        /// Requests per minute limit for this team member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit")]
        public int? RpmLimit { get; set; }

        /// <summary>
        /// Duration after which this team member's budget resets (e.g. '1h', '24h', '7d', '30d'). If not set, the budget never resets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// List of models this team member can access. Pass an empty list to remove per-member model restrictions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberUpdateRequest" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="maxBudgetInTeam"></param>
        /// <param name="role"></param>
        /// <param name="tpmLimit">
        /// Tokens per minute limit for this team member
        /// </param>
        /// <param name="rpmLimit">
        /// Requests per minute limit for this team member
        /// </param>
        /// <param name="budgetDuration">
        /// Duration after which this team member's budget resets (e.g. '1h', '24h', '7d', '30d'). If not set, the budget never resets.
        /// </param>
        /// <param name="allowedModels">
        /// List of models this team member can access. Pass an empty list to remove per-member model restrictions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberUpdateRequest(
            string teamId,
            string? userId,
            string? userEmail,
            double? maxBudgetInTeam,
            global::Loud.Technology.LiteLLM.Sdk.TeamMemberUpdateRequestRole2? role,
            int? tpmLimit,
            int? rpmLimit,
            string? budgetDuration,
            global::System.Collections.Generic.IList<string>? allowedModels)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.MaxBudgetInTeam = maxBudgetInTeam;
            this.Role = role;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.BudgetDuration = budgetDuration;
            this.AllowedModels = allowedModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberUpdateRequest" /> class.
        /// </summary>
        public TeamMemberUpdateRequest()
        {
        }

    }
}
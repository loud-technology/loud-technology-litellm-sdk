
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One member's per-member limits, merge-patch style: a field left out of the row is<br/>
    /// untouched, a field sent as null is cleared, and clearing the last limit drops the<br/>
    /// member back to the team default.
    /// </summary>
    public sealed partial class TeamMemberBudgetPatch
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
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget_in_team")]
        public double? MaxBudgetInTeam { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberBudgetPatch" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="maxBudgetInTeam"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="allowedModels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberBudgetPatch(
            string? userId,
            string? userEmail,
            double? maxBudgetInTeam,
            int? tpmLimit,
            int? rpmLimit,
            string? budgetDuration,
            global::System.Collections.Generic.IList<string>? allowedModels)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.MaxBudgetInTeam = maxBudgetInTeam;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.BudgetDuration = budgetDuration;
            this.AllowedModels = allowedModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberBudgetPatch" /> class.
        /// </summary>
        public TeamMemberBudgetPatch()
        {
        }

    }
}
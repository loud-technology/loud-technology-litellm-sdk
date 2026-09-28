
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Outcome for one requested member, in request order, carrying the limits in force<br/>
    /// after the write rather than the ones that were asked for.
    /// </summary>
    public sealed partial class TeamMemberBudgetUpdateResult
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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget_source")]
        public global::Loud.Technology.LiteLLM.Sdk.TeamMemberBudgetUpdateResultMaxBudgetSource2? MaxBudgetSource { get; set; }

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
        /// Initializes a new instance of the <see cref="TeamMemberBudgetUpdateResult" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="error"></param>
        /// <param name="budgetId"></param>
        /// <param name="maxBudget"></param>
        /// <param name="maxBudgetSource"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="allowedModels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberBudgetUpdateResult(
            bool success,
            string? userId,
            string? userEmail,
            string? error,
            string? budgetId,
            double? maxBudget,
            global::Loud.Technology.LiteLLM.Sdk.TeamMemberBudgetUpdateResultMaxBudgetSource2? maxBudgetSource,
            int? tpmLimit,
            int? rpmLimit,
            string? budgetDuration,
            global::System.Collections.Generic.IList<string>? allowedModels)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.Success = success;
            this.Error = error;
            this.BudgetId = budgetId;
            this.MaxBudget = maxBudget;
            this.MaxBudgetSource = maxBudgetSource;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.BudgetDuration = budgetDuration;
            this.AllowedModels = allowedModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberBudgetUpdateResult" /> class.
        /// </summary>
        public TeamMemberBudgetUpdateResult()
        {
        }

    }
}
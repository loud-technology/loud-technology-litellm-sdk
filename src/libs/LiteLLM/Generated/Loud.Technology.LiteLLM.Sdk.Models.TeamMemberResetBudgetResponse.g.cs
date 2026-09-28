
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamMemberResetBudgetResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_budget_id")]
        public string? PreviousBudgetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.TeamMemberResetBudgetResponseBudgetSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.TeamMemberResetBudgetResponseBudgetSource BudgetSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberResetBudgetResponse" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="budgetSource"></param>
        /// <param name="budgetId"></param>
        /// <param name="previousBudgetId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberResetBudgetResponse(
            string teamId,
            string userId,
            global::Loud.Technology.LiteLLM.Sdk.TeamMemberResetBudgetResponseBudgetSource budgetSource,
            string? budgetId,
            string? previousBudgetId)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.BudgetId = budgetId;
            this.PreviousBudgetId = previousBudgetId;
            this.BudgetSource = budgetSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberResetBudgetResponse" /> class.
        /// </summary>
        public TeamMemberResetBudgetResponse()
        {
        }

    }
}
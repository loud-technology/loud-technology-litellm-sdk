
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for GET /team/{team_id}/members/me — caller's own membership row.
    /// </summary>
    public sealed partial class TeamMemberInfoResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend")]
        public double? TotalSpend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_budget_table")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTableFull, global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTable, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTableFull, global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTable, object>? LitellmBudgetTable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_alias")]
        public string? TeamAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberInfoResponse" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="budgetId"></param>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
        /// <param name="totalSpend">
        /// Default Value: 0F
        /// </param>
        /// <param name="litellmBudgetTable"></param>
        /// <param name="role"></param>
        /// <param name="userEmail"></param>
        /// <param name="teamAlias"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberInfoResponse(
            string userId,
            string teamId,
            string? budgetId,
            double? spend,
            double? totalSpend,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTableFull, global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTable, object>? litellmBudgetTable,
            string? role,
            string? userEmail,
            string? teamAlias)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.BudgetId = budgetId;
            this.Spend = spend;
            this.TotalSpend = totalSpend;
            this.LitellmBudgetTable = litellmBudgetTable;
            this.Role = role;
            this.UserEmail = userEmail;
            this.TeamAlias = teamAlias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberInfoResponse" /> class.
        /// </summary>
        public TeamMemberInfoResponse()
        {
        }

    }
}
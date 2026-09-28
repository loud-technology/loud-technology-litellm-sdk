
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for adding members to a team.<br/>
    /// Example:<br/>
    /// ```json<br/>
    /// {<br/>
    ///     "team_id": "45e3e396-ee08-4a61-a88e-16b3ce7e0849",<br/>
    ///     "member": {<br/>
    ///         "role": "user",<br/>
    ///         "user_id": "user123"<br/>
    ///     },<br/>
    ///     "max_budget_in_team": 100.0<br/>
    /// }<br/>
    /// ```
    /// </summary>
    public sealed partial class TeamMemberAddRequest
    {
        /// <summary>
        /// Member object or list of member objects to add. Each member must include either user_id or user_email, and a role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>, global::Loud.Technology.LiteLLM.Sdk.Member>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>, global::Loud.Technology.LiteLLM.Sdk.Member> Member { get; set; }

        /// <summary>
        /// The ID of the team to add the member to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Maximum budget allocated to this user within the team. If not set, user has unlimited budget within team limits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget_in_team")]
        public double? MaxBudgetInTeam { get; set; }

        /// <summary>
        /// Duration after which this team member's budget resets (e.g. '1h', '24h', '7d', '30d'). If not set, the budget never resets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// List of models this team member can access. If not set, inherits the team's default_team_member_models or all team models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberAddRequest" /> class.
        /// </summary>
        /// <param name="member">
        /// Member object or list of member objects to add. Each member must include either user_id or user_email, and a role
        /// </param>
        /// <param name="teamId">
        /// The ID of the team to add the member to
        /// </param>
        /// <param name="maxBudgetInTeam">
        /// Maximum budget allocated to this user within the team. If not set, user has unlimited budget within team limits
        /// </param>
        /// <param name="budgetDuration">
        /// Duration after which this team member's budget resets (e.g. '1h', '24h', '7d', '30d'). If not set, the budget never resets.
        /// </param>
        /// <param name="allowedModels">
        /// List of models this team member can access. If not set, inherits the team's default_team_member_models or all team models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberAddRequest(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>, global::Loud.Technology.LiteLLM.Sdk.Member> member,
            string teamId,
            double? maxBudgetInTeam,
            string? budgetDuration,
            global::System.Collections.Generic.IList<string>? allowedModels)
        {
            this.Member = member;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.MaxBudgetInTeam = maxBudgetInTeam;
            this.BudgetDuration = budgetDuration;
            this.AllowedModels = allowedModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberAddRequest" /> class.
        /// </summary>
        public TeamMemberAddRequest()
        {
        }

    }
}
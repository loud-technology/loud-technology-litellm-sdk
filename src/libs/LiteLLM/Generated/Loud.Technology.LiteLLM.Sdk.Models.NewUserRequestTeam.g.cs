
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewUserRequestTeam
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
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget_in_team")]
        public double? MaxBudgetInTeam { get; set; }

        /// <summary>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.NewUserRequestTeamUserRoleJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.NewUserRequestTeamUserRole? UserRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserRequestTeam" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="maxBudgetInTeam"></param>
        /// <param name="userRole">
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewUserRequestTeam(
            string teamId,
            double? maxBudgetInTeam,
            global::Loud.Technology.LiteLLM.Sdk.NewUserRequestTeamUserRole? userRole)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.MaxBudgetInTeam = maxBudgetInTeam;
            this.UserRole = userRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewUserRequestTeam" /> class.
        /// </summary>
        public NewUserRequestTeam()
        {
        }

    }
}
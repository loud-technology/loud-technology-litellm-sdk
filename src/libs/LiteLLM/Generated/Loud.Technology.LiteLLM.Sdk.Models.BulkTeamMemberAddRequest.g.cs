
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request for bulk team member addition
    /// </summary>
    public sealed partial class BulkTeamMemberAddRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>? Members { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_users")]
        public bool? AllUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget_in_team")]
        public double? MaxBudgetInTeam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTeamMemberAddRequest" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="members"></param>
        /// <param name="allUsers">
        /// Default Value: false
        /// </param>
        /// <param name="maxBudgetInTeam"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkTeamMemberAddRequest(
            string teamId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>? members,
            bool? allUsers,
            double? maxBudgetInTeam)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Members = members;
            this.AllUsers = allUsers;
            this.MaxBudgetInTeam = maxBudgetInTeam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTeamMemberAddRequest" /> class.
        /// </summary>
        public BulkTeamMemberAddRequest()
        {
        }

    }
}
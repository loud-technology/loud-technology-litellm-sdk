
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request to update the team member permissions for a team
    /// </summary>
    public sealed partial class UpdateTeamMemberPermissionsRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TeamMemberPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamMemberPermissionsRequest" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="teamMemberPermissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTeamMemberPermissionsRequest(
            string teamId,
            global::System.Collections.Generic.IList<string> teamMemberPermissions)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamMemberPermissions = teamMemberPermissions ?? throw new global::System.ArgumentNullException(nameof(teamMemberPermissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamMemberPermissionsRequest" /> class.
        /// </summary>
        public UpdateTeamMemberPermissionsRequest()
        {
        }

    }
}
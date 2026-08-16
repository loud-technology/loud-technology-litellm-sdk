
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response to get the team member permissions for a team
    /// </summary>
    public sealed partial class GetTeamMemberPermissionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_permissions")]
        public global::System.Collections.Generic.IList<string>? TeamMemberPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_available_permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllAvailablePermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMemberPermissionsResponse" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="allAvailablePermissions"></param>
        /// <param name="teamMemberPermissions">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamMemberPermissionsResponse(
            string teamId,
            global::System.Collections.Generic.IList<string> allAvailablePermissions,
            global::System.Collections.Generic.IList<string>? teamMemberPermissions)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamMemberPermissions = teamMemberPermissions;
            this.AllAvailablePermissions = allAvailablePermissions ?? throw new global::System.ArgumentNullException(nameof(allAvailablePermissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamMemberPermissionsResponse" /> class.
        /// </summary>
        public GetTeamMemberPermissionsResponse()
        {
        }

    }
}
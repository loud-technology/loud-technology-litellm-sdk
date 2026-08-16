
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request to bulk-update team member permissions across teams.
    /// </summary>
    public sealed partial class BulkUpdateTeamMemberPermissionsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeyManagementRoutes> Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<string>? TeamIds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_to_all_teams")]
        public bool? ApplyToAllTeams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateTeamMemberPermissionsRequest" /> class.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="teamIds"></param>
        /// <param name="applyToAllTeams">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateTeamMemberPermissionsRequest(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeyManagementRoutes> permissions,
            global::System.Collections.Generic.IList<string>? teamIds,
            bool? applyToAllTeams)
        {
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.TeamIds = teamIds;
            this.ApplyToAllTeams = applyToAllTeams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateTeamMemberPermissionsRequest" /> class.
        /// </summary>
        public BulkUpdateTeamMemberPermissionsRequest()
        {
        }

    }
}
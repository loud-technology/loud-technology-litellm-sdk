
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for bulk team member permissions update.
    /// </summary>
    public sealed partial class BulkUpdateTeamMemberPermissionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TeamsUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_appended")]
        public global::System.Collections.Generic.IList<string>? PermissionsAppended { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateTeamMemberPermissionsResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="teamsUpdated"></param>
        /// <param name="permissionsAppended"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateTeamMemberPermissionsResponse(
            string message,
            int teamsUpdated,
            global::System.Collections.Generic.IList<string>? permissionsAppended)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.TeamsUpdated = teamsUpdated;
            this.PermissionsAppended = permissionsAppended;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateTeamMemberPermissionsResponse" /> class.
        /// </summary>
        public BulkUpdateTeamMemberPermissionsResponse()
        {
        }

    }
}
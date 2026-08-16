
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for mapping SSO JWT fields to team IDs.<br/>
    /// This allows configuring team_ids_jwt_field via the database instead of<br/>
    /// requiring config file changes and restarts.
    /// </summary>
    public sealed partial class TeamMappings
    {
        /// <summary>
        /// The field name in the SSO/JWT token that contains the team IDs array (e.g., 'groups', 'teams'). Supports dot notation for nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids_jwt_field")]
        public string? TeamIdsJwtField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMappings" /> class.
        /// </summary>
        /// <param name="teamIdsJwtField">
        /// The field name in the SSO/JWT token that contains the team IDs array (e.g., 'groups', 'teams'). Supports dot notation for nested fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMappings(
            string? teamIdsJwtField)
        {
            this.TeamIdsJwtField = teamIdsJwtField;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMappings" /> class.
        /// </summary>
        public TeamMappings()
        {
        }

    }
}
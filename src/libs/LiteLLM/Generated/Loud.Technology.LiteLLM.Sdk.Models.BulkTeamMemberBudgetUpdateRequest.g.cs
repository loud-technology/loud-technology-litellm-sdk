
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Body of `POST /management/v1/teams/{team_id}/members/bulk_update`.
    /// </summary>
    public sealed partial class BulkTeamMemberBudgetUpdateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TeamMemberBudgetPatch> Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTeamMemberBudgetUpdateRequest" /> class.
        /// </summary>
        /// <param name="members"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkTeamMemberBudgetUpdateRequest(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TeamMemberBudgetPatch> members)
        {
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTeamMemberBudgetUpdateRequest" /> class.
        /// </summary>
        public BulkTeamMemberBudgetUpdateRequest()
        {
        }

    }
}
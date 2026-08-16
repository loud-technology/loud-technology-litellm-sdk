
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Apply one update payload to many keys inside a team; provide either `key_ids` or `all_keys_in_team=True`.
    /// </summary>
    public sealed partial class BulkUpdateTeamKeysRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("key_ids")]
        public global::System.Collections.Generic.IList<string>? KeyIds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_keys_in_team")]
        public bool? AllKeysInTeam { get; set; }

        /// <summary>
        /// Allowlist of bulk-broadcastable fields for /team/key/bulk_update; `extra="forbid"` blocks RBAC/ownership/scope mutations even by team admins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.KeyUpdateFields UpdateFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateTeamKeysRequest" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="updateFields">
        /// Allowlist of bulk-broadcastable fields for /team/key/bulk_update; `extra="forbid"` blocks RBAC/ownership/scope mutations even by team admins.
        /// </param>
        /// <param name="keyIds"></param>
        /// <param name="allKeysInTeam">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateTeamKeysRequest(
            string teamId,
            global::Loud.Technology.LiteLLM.Sdk.KeyUpdateFields updateFields,
            global::System.Collections.Generic.IList<string>? keyIds,
            bool? allKeysInTeam)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.KeyIds = keyIds;
            this.AllKeysInTeam = allKeysInTeam;
            this.UpdateFields = updateFields ?? throw new global::System.ArgumentNullException(nameof(updateFields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateTeamKeysRequest" /> class.
        /// </summary>
        public BulkUpdateTeamKeysRequest()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for bulk team member add operations
    /// </summary>
    public sealed partial class BulkTeamMemberAddResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TeamMemberAddResult> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRequested { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_additions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SuccessfulAdditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_additions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedAdditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_team")]
        public object? UpdatedTeam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTeamMemberAddResponse" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="results"></param>
        /// <param name="totalRequested"></param>
        /// <param name="successfulAdditions"></param>
        /// <param name="failedAdditions"></param>
        /// <param name="updatedTeam"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkTeamMemberAddResponse(
            string teamId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TeamMemberAddResult> results,
            int totalRequested,
            int successfulAdditions,
            int failedAdditions,
            object? updatedTeam)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TotalRequested = totalRequested;
            this.SuccessfulAdditions = successfulAdditions;
            this.FailedAdditions = failedAdditions;
            this.UpdatedTeam = updatedTeam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTeamMemberAddResponse" /> class.
        /// </summary>
        public BulkTeamMemberAddResponse()
        {
        }

    }
}
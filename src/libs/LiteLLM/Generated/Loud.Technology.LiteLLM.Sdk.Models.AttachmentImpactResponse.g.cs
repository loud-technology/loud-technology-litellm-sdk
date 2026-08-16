
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for estimating the impact of a policy attachment.
    /// </summary>
    public sealed partial class AttachmentImpactResponse
    {
        /// <summary>
        /// Number of keys that would be affected (named + unnamed).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affected_keys_count")]
        public int? AffectedKeysCount { get; set; }

        /// <summary>
        /// Number of teams that would be affected (named + unnamed).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affected_teams_count")]
        public int? AffectedTeamsCount { get; set; }

        /// <summary>
        /// Sample of affected key aliases (up to 10).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_keys")]
        public global::System.Collections.Generic.IList<string>? SampleKeys { get; set; }

        /// <summary>
        /// Sample of affected team aliases (up to 10).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_teams")]
        public global::System.Collections.Generic.IList<string>? SampleTeams { get; set; }

        /// <summary>
        /// Number of affected keys without an alias.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unnamed_keys_count")]
        public int? UnnamedKeysCount { get; set; }

        /// <summary>
        /// Number of affected teams without an alias.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unnamed_teams_count")]
        public int? UnnamedTeamsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentImpactResponse" /> class.
        /// </summary>
        /// <param name="affectedKeysCount">
        /// Number of keys that would be affected (named + unnamed).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="affectedTeamsCount">
        /// Number of teams that would be affected (named + unnamed).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="sampleKeys">
        /// Sample of affected key aliases (up to 10).
        /// </param>
        /// <param name="sampleTeams">
        /// Sample of affected team aliases (up to 10).
        /// </param>
        /// <param name="unnamedKeysCount">
        /// Number of affected keys without an alias.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="unnamedTeamsCount">
        /// Number of affected teams without an alias.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachmentImpactResponse(
            int? affectedKeysCount,
            int? affectedTeamsCount,
            global::System.Collections.Generic.IList<string>? sampleKeys,
            global::System.Collections.Generic.IList<string>? sampleTeams,
            int? unnamedKeysCount,
            int? unnamedTeamsCount)
        {
            this.AffectedKeysCount = affectedKeysCount;
            this.AffectedTeamsCount = affectedTeamsCount;
            this.SampleKeys = sampleKeys;
            this.SampleTeams = sampleTeams;
            this.UnnamedKeysCount = unnamedKeysCount;
            this.UnnamedTeamsCount = unnamedTeamsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentImpactResponse" /> class.
        /// </summary>
        public AttachmentImpactResponse()
        {
        }

    }
}
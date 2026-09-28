
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SCIMPlaceholderMergeResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_into_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MergedIntoUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaceholderUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMPlaceholderMergeResult" /> class.
        /// </summary>
        /// <param name="mergedIntoUserId"></param>
        /// <param name="placeholderUserId"></param>
        /// <param name="teamIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMPlaceholderMergeResult(
            string mergedIntoUserId,
            string placeholderUserId,
            global::System.Collections.Generic.IList<string> teamIds)
        {
            this.MergedIntoUserId = mergedIntoUserId ?? throw new global::System.ArgumentNullException(nameof(mergedIntoUserId));
            this.PlaceholderUserId = placeholderUserId ?? throw new global::System.ArgumentNullException(nameof(placeholderUserId));
            this.TeamIds = teamIds ?? throw new global::System.ArgumentNullException(nameof(teamIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMPlaceholderMergeResult" /> class.
        /// </summary>
        public SCIMPlaceholderMergeResult()
        {
        }

    }
}
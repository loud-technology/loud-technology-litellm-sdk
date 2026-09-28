
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A user row keyed by a value that names another account by SSO identity or email.
    /// </summary>
    public sealed partial class SCIMPlaceholder
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaceholderUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ResolvedUserIds { get; set; }

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
        /// Initializes a new instance of the <see cref="SCIMPlaceholder" /> class.
        /// </summary>
        /// <param name="placeholderUserId"></param>
        /// <param name="resolvedUserIds"></param>
        /// <param name="teamIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMPlaceholder(
            string placeholderUserId,
            global::System.Collections.Generic.IList<string> resolvedUserIds,
            global::System.Collections.Generic.IList<string> teamIds)
        {
            this.PlaceholderUserId = placeholderUserId ?? throw new global::System.ArgumentNullException(nameof(placeholderUserId));
            this.ResolvedUserIds = resolvedUserIds ?? throw new global::System.ArgumentNullException(nameof(resolvedUserIds));
            this.TeamIds = teamIds ?? throw new global::System.ArgumentNullException(nameof(teamIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMPlaceholder" /> class.
        /// </summary>
        public SCIMPlaceholder()
        {
        }

    }
}
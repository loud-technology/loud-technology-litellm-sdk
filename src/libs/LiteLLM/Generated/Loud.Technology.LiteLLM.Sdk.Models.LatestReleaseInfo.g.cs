
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LatestReleaseInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NewFeatures { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bug_fixes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BugFixes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other_updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OtherUpdates { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LatestReleaseInfo" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="newFeatures"></param>
        /// <param name="bugFixes"></param>
        /// <param name="otherUpdates"></param>
        /// <param name="releaseUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LatestReleaseInfo(
            string version,
            int newFeatures,
            int bugFixes,
            int otherUpdates,
            string releaseUrl)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.NewFeatures = newFeatures;
            this.BugFixes = bugFixes;
            this.OtherUpdates = otherUpdates;
            this.ReleaseUrl = releaseUrl ?? throw new global::System.ArgumentNullException(nameof(releaseUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatestReleaseInfo" /> class.
        /// </summary>
        public LatestReleaseInfo()
        {
        }

    }
}
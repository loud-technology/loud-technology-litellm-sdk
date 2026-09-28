
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for comparing two policy versions.
    /// </summary>
    public sealed partial class PolicyVersionCompareResponse
    {
        /// <summary>
        /// Field name -&gt; {version_a: val, version_b: val} for differing fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_diffs")]
        public global::System.Collections.Generic.Dictionary<string, object>? FieldDiffs { get; set; }

        /// <summary>
        /// First version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_a")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse VersionA { get; set; }

        /// <summary>
        /// Second version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_b")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse VersionB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyVersionCompareResponse" /> class.
        /// </summary>
        /// <param name="versionA">
        /// First version.
        /// </param>
        /// <param name="versionB">
        /// Second version.
        /// </param>
        /// <param name="fieldDiffs">
        /// Field name -&gt; {version_a: val, version_b: val} for differing fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyVersionCompareResponse(
            global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse versionA,
            global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse versionB,
            global::System.Collections.Generic.Dictionary<string, object>? fieldDiffs)
        {
            this.FieldDiffs = fieldDiffs;
            this.VersionA = versionA ?? throw new global::System.ArgumentNullException(nameof(versionA));
            this.VersionB = versionB ?? throw new global::System.ArgumentNullException(nameof(versionB));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyVersionCompareResponse" /> class.
        /// </summary>
        public PolicyVersionCompareResponse()
        {
        }

    }
}
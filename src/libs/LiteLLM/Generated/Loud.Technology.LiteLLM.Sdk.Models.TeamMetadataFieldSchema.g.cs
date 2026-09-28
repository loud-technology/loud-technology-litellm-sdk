
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One declared team metadata field from ``general_settings.team_metadata_schema``.<br/>
    /// Advisory only: the UI uses it to prepopulate the team metadata form.<br/>
    /// Enforcement stays with ``custom_team_metadata_validate``.
    /// </summary>
    public sealed partial class TeamMetadataFieldSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMetadataFieldSchema" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMetadataFieldSchema(
            string key,
            string? label)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMetadataFieldSchema" /> class.
        /// </summary>
        public TeamMetadataFieldSchema()
        {
        }

    }
}
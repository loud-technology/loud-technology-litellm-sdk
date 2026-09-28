
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for GET /team/metadata_schema; ``fields`` is empty when no schema is configured.
    /// </summary>
    public sealed partial class TeamMetadataSchemaResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TeamMetadataFieldSchema> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMetadataSchemaResponse" /> class.
        /// </summary>
        /// <param name="fields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMetadataSchemaResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TeamMetadataFieldSchema> fields)
        {
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMetadataSchemaResponse" /> class.
        /// </summary>
        public TeamMetadataSchemaResponse()
        {
        }

    }
}
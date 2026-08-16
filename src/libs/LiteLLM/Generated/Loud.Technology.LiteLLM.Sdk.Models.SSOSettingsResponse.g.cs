
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for SSO settings
    /// </summary>
    public sealed partial class SSOSettingsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Values { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object FieldSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provenance")]
        public global::System.Collections.Generic.Dictionary<string, string>? Provenance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOSettingsResponse" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="fieldSchema"></param>
        /// <param name="provenance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSOSettingsResponse(
            object values,
            object fieldSchema,
            global::System.Collections.Generic.Dictionary<string, string>? provenance)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.FieldSchema = fieldSchema ?? throw new global::System.ArgumentNullException(nameof(fieldSchema));
            this.Provenance = provenance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOSettingsResponse" /> class.
        /// </summary>
        public SSOSettingsResponse()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for UI settings
    /// </summary>
    public sealed partial class UISettingsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.UISettingsResponseSource2> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UISettingsResponse" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="fieldSchema"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UISettingsResponse(
            object values,
            object fieldSchema,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.UISettingsResponseSource2> source)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.FieldSchema = fieldSchema ?? throw new global::System.ArgumentNullException(nameof(fieldSchema));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UISettingsResponse" /> class.
        /// </summary>
        public UISettingsResponse()
        {
        }

    }
}
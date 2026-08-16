
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for UI theme settings
    /// </summary>
    public sealed partial class UIThemeSettingsResponse
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UIThemeSettingsResponse" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="fieldSchema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UIThemeSettingsResponse(
            object values,
            object fieldSchema)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.FieldSchema = fieldSchema ?? throw new global::System.ArgumentNullException(nameof(fieldSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIThemeSettingsResponse" /> class.
        /// </summary>
        public UIThemeSettingsResponse()
        {
        }

    }
}
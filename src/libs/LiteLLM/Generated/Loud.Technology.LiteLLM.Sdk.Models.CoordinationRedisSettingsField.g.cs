
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CoordinationRedisSettingsField
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_value")]
        public object? FieldValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_default")]
        public object? FieldDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_field_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UiFieldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.CoordinationRedisSettingsFieldSectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsFieldSection Section { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinationRedisSettingsField" /> class.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="fieldType"></param>
        /// <param name="fieldDescription"></param>
        /// <param name="uiFieldName"></param>
        /// <param name="section"></param>
        /// <param name="fieldValue"></param>
        /// <param name="fieldDefault"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoordinationRedisSettingsField(
            string fieldName,
            string fieldType,
            string fieldDescription,
            string uiFieldName,
            global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsFieldSection section,
            object? fieldValue,
            object? fieldDefault)
        {
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.FieldType = fieldType ?? throw new global::System.ArgumentNullException(nameof(fieldType));
            this.FieldValue = fieldValue;
            this.FieldDescription = fieldDescription ?? throw new global::System.ArgumentNullException(nameof(fieldDescription));
            this.FieldDefault = fieldDefault;
            this.UiFieldName = uiFieldName ?? throw new global::System.ArgumentNullException(nameof(uiFieldName));
            this.Section = section;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinationRedisSettingsField" /> class.
        /// </summary>
        public CoordinationRedisSettingsField()
        {
        }

    }
}
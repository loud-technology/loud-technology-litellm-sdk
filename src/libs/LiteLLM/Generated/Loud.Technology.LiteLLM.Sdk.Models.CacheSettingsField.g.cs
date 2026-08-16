
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CacheSettingsField
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object FieldValue { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_field_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UiFieldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redis_type")]
        public string? RedisType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheSettingsField" /> class.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="fieldType"></param>
        /// <param name="fieldValue"></param>
        /// <param name="fieldDescription"></param>
        /// <param name="uiFieldName"></param>
        /// <param name="fieldDefault"></param>
        /// <param name="options"></param>
        /// <param name="link"></param>
        /// <param name="redisType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheSettingsField(
            string fieldName,
            string fieldType,
            object fieldValue,
            string fieldDescription,
            string uiFieldName,
            object? fieldDefault,
            global::System.Collections.Generic.IList<string>? options,
            string? link,
            string? redisType)
        {
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.FieldType = fieldType ?? throw new global::System.ArgumentNullException(nameof(fieldType));
            this.FieldValue = fieldValue ?? throw new global::System.ArgumentNullException(nameof(fieldValue));
            this.FieldDescription = fieldDescription ?? throw new global::System.ArgumentNullException(nameof(fieldDescription));
            this.FieldDefault = fieldDefault;
            this.Options = options;
            this.UiFieldName = uiFieldName ?? throw new global::System.ArgumentNullException(nameof(uiFieldName));
            this.Link = link;
            this.RedisType = redisType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheSettingsField" /> class.
        /// </summary>
        public CacheSettingsField()
        {
        }

    }
}
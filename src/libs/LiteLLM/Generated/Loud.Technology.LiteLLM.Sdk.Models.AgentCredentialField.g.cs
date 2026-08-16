
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCredentialField
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder")]
        public string? Placeholder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tooltip")]
        public string? Tooltip { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AgentCredentialFieldFieldTypeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.AgentCredentialFieldFieldType? FieldType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<string>? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_in_litellm_params")]
        public bool? IncludeInLitellmParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCredentialField" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="label"></param>
        /// <param name="placeholder"></param>
        /// <param name="tooltip"></param>
        /// <param name="required">
        /// Default Value: false
        /// </param>
        /// <param name="fieldType">
        /// Default Value: text
        /// </param>
        /// <param name="options"></param>
        /// <param name="defaultValue"></param>
        /// <param name="includeInLitellmParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCredentialField(
            string key,
            string label,
            string? placeholder,
            string? tooltip,
            bool? required,
            global::Loud.Technology.LiteLLM.Sdk.AgentCredentialFieldFieldType? fieldType,
            global::System.Collections.Generic.IList<string>? options,
            string? defaultValue,
            bool? includeInLitellmParams)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Placeholder = placeholder;
            this.Tooltip = tooltip;
            this.Required = required;
            this.FieldType = fieldType;
            this.Options = options;
            this.DefaultValue = defaultValue;
            this.IncludeInLitellmParams = includeInLitellmParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCredentialField" /> class.
        /// </summary>
        public AgentCredentialField()
        {
        }

    }
}
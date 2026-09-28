
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for config override settings GET endpoints.
    /// </summary>
    public sealed partial class ConfigOverrideSettingsResponse
    {
        /// <summary>
        /// The type of config override
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigType { get; set; }

        /// <summary>
        /// Schema information for UI rendering
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object FieldSchema { get; set; }

        /// <summary>
        /// Current configuration values (sensitive fields decrypted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigOverrideSettingsResponse" /> class.
        /// </summary>
        /// <param name="configType">
        /// The type of config override
        /// </param>
        /// <param name="fieldSchema">
        /// Schema information for UI rendering
        /// </param>
        /// <param name="values">
        /// Current configuration values (sensitive fields decrypted)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigOverrideSettingsResponse(
            string configType,
            object fieldSchema,
            object values)
        {
            this.ConfigType = configType ?? throw new global::System.ArgumentNullException(nameof(configType));
            this.FieldSchema = fieldSchema ?? throw new global::System.ArgumentNullException(nameof(fieldSchema));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigOverrideSettingsResponse" /> class.
        /// </summary>
        public ConfigOverrideSettingsResponse()
        {
        }

    }
}
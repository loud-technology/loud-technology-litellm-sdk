
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CacheSettingsResponse
    {
        /// <summary>
        /// List of all configurable cache settings with metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CacheSettingsField> Fields { get; set; }

        /// <summary>
        /// Current values of cache settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CurrentValues { get; set; }

        /// <summary>
        /// Descriptions for each Redis type option
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redis_type_descriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> RedisTypeDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheSettingsResponse" /> class.
        /// </summary>
        /// <param name="fields">
        /// List of all configurable cache settings with metadata
        /// </param>
        /// <param name="currentValues">
        /// Current values of cache settings
        /// </param>
        /// <param name="redisTypeDescriptions">
        /// Descriptions for each Redis type option
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheSettingsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CacheSettingsField> fields,
            object currentValues,
            global::System.Collections.Generic.Dictionary<string, string> redisTypeDescriptions)
        {
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.CurrentValues = currentValues ?? throw new global::System.ArgumentNullException(nameof(currentValues));
            this.RedisTypeDescriptions = redisTypeDescriptions ?? throw new global::System.ArgumentNullException(nameof(redisTypeDescriptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheSettingsResponse" /> class.
        /// </summary>
        public CacheSettingsResponse()
        {
        }

    }
}
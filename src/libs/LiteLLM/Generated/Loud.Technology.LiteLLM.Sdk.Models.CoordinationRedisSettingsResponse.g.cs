
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CoordinationRedisSettingsResponse
    {
        /// <summary>
        /// Current coordination Redis settings, with credentials redacted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Values { get; set; }

        /// <summary>
        /// List of all configurable coordination Redis settings with metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsField> Fields { get; set; }

        /// <summary>
        /// Where the proxy's coordination Redis comes from; null when it has none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsResponseSource2? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinationRedisSettingsResponse" /> class.
        /// </summary>
        /// <param name="values">
        /// Current coordination Redis settings, with credentials redacted
        /// </param>
        /// <param name="fields">
        /// List of all configurable coordination Redis settings with metadata
        /// </param>
        /// <param name="source">
        /// Where the proxy's coordination Redis comes from; null when it has none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoordinationRedisSettingsResponse(
            object values,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsField> fields,
            global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsResponseSource2? source)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinationRedisSettingsResponse" /> class.
        /// </summary>
        public CoordinationRedisSettingsResponse()
        {
        }

    }
}
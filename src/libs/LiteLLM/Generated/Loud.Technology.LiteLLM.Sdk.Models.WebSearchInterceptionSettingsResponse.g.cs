
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for web search interception settings
    /// </summary>
    public sealed partial class WebSearchInterceptionSettingsResponse
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
        /// Whether the process answering this request has the interception callback registered. Read-only: it reports what is running here, while values.enabled is the cluster-wide setting, and the two disagree while a pod is still applying a change or failed to apply it.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_on_this_pod")]
        public bool? ActiveOnThisPod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchInterceptionSettingsResponse" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="fieldSchema"></param>
        /// <param name="activeOnThisPod">
        /// Whether the process answering this request has the interception callback registered. Read-only: it reports what is running here, while values.enabled is the cluster-wide setting, and the two disagree while a pod is still applying a change or failed to apply it.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchInterceptionSettingsResponse(
            object values,
            object fieldSchema,
            bool? activeOnThisPod)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.FieldSchema = fieldSchema ?? throw new global::System.ArgumentNullException(nameof(fieldSchema));
            this.ActiveOnThisPod = activeOnThisPod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchInterceptionSettingsResponse" /> class.
        /// </summary>
        public WebSearchInterceptionSettingsResponse()
        {
        }

    }
}
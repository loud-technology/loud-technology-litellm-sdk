
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RouterSettingsResponse
    {
        /// <summary>
        /// List of all configurable router settings with metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.RouterSettingsField> Fields { get; set; }

        /// <summary>
        /// Current values of router settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CurrentValues { get; set; }

        /// <summary>
        /// Descriptions for each routing strategy option
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_strategy_descriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> RoutingStrategyDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterSettingsResponse" /> class.
        /// </summary>
        /// <param name="fields">
        /// List of all configurable router settings with metadata
        /// </param>
        /// <param name="currentValues">
        /// Current values of router settings
        /// </param>
        /// <param name="routingStrategyDescriptions">
        /// Descriptions for each routing strategy option
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouterSettingsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.RouterSettingsField> fields,
            object currentValues,
            global::System.Collections.Generic.Dictionary<string, string> routingStrategyDescriptions)
        {
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.CurrentValues = currentValues ?? throw new global::System.ArgumentNullException(nameof(currentValues));
            this.RoutingStrategyDescriptions = routingStrategyDescriptions ?? throw new global::System.ArgumentNullException(nameof(routingStrategyDescriptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterSettingsResponse" /> class.
        /// </summary>
        public RouterSettingsResponse()
        {
        }

    }
}
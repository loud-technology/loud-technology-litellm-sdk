
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RouterFieldsResponse
    {
        /// <summary>
        /// List of all configurable router settings with metadata (without field values)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.RouterSettingsField> Fields { get; set; }

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
        /// Initializes a new instance of the <see cref="RouterFieldsResponse" /> class.
        /// </summary>
        /// <param name="fields">
        /// List of all configurable router settings with metadata (without field values)
        /// </param>
        /// <param name="routingStrategyDescriptions">
        /// Descriptions for each routing strategy option
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouterFieldsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.RouterSettingsField> fields,
            global::System.Collections.Generic.Dictionary<string, string> routingStrategyDescriptions)
        {
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.RoutingStrategyDescriptions = routingStrategyDescriptions ?? throw new global::System.ArgumentNullException(nameof(routingStrategyDescriptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterFieldsResponse" /> class.
        /// </summary>
        public RouterFieldsResponse()
        {
        }

    }
}
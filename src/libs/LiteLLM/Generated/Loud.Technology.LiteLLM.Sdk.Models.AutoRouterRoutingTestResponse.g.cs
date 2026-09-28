
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Where one prompt would have been routed, and why.
    /// </summary>
    public sealed partial class AutoRouterRoutingTestResponse
    {
        /// <summary>
        /// The model group the router picked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routed_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoutedModel { get; set; }

        /// <summary>
        /// Whether routed_model is a model group available to the caller, scoped to team_id when given. Never confirms models the caller could not use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routed_model_configured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RoutedModelConfigured { get; set; }

        /// <summary>
        /// The decision record this request would have written to its log row
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_decision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.StandardLoggingRoutingDecision RoutingDecision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterRoutingTestResponse" /> class.
        /// </summary>
        /// <param name="routedModel">
        /// The model group the router picked
        /// </param>
        /// <param name="routedModelConfigured">
        /// Whether routed_model is a model group available to the caller, scoped to team_id when given. Never confirms models the caller could not use
        /// </param>
        /// <param name="routingDecision">
        /// The decision record this request would have written to its log row
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterRoutingTestResponse(
            string routedModel,
            bool routedModelConfigured,
            global::Loud.Technology.LiteLLM.Sdk.StandardLoggingRoutingDecision routingDecision)
        {
            this.RoutedModel = routedModel ?? throw new global::System.ArgumentNullException(nameof(routedModel));
            this.RoutedModelConfigured = routedModelConfigured;
            this.RoutingDecision = routingDecision ?? throw new global::System.ArgumentNullException(nameof(routingDecision));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterRoutingTestResponse" /> class.
        /// </summary>
        public AutoRouterRoutingTestResponse()
        {
        }

    }
}
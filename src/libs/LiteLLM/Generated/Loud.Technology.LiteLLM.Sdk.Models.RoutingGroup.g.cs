
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A group of models that share a routing strategy.
    /// </summary>
    public sealed partial class RoutingGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_strategy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoutingStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_strategy_args")]
        public object? RoutingStrategyArgs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingGroup" /> class.
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="models"></param>
        /// <param name="routingStrategy"></param>
        /// <param name="routingStrategyArgs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutingGroup(
            string groupName,
            global::System.Collections.Generic.IList<string> models,
            string routingStrategy,
            object? routingStrategyArgs)
        {
            this.GroupName = groupName ?? throw new global::System.ArgumentNullException(nameof(groupName));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.RoutingStrategy = routingStrategy ?? throw new global::System.ArgumentNullException(nameof(routingStrategy));
            this.RoutingStrategyArgs = routingStrategyArgs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingGroup" /> class.
        /// </summary>
        public RoutingGroup()
        {
        }

    }
}
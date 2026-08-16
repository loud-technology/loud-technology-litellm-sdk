
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Breakdown of spend by different dimensions
    /// </summary>
    public sealed partial class BreakdownMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? McpServers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_groups")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? ModelGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? Providers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? Endpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.KeyMetricWithMetadata>? ApiKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownMetrics" /> class.
        /// </summary>
        /// <param name="mcpServers"></param>
        /// <param name="models"></param>
        /// <param name="modelGroups"></param>
        /// <param name="providers"></param>
        /// <param name="endpoints"></param>
        /// <param name="apiKeys"></param>
        /// <param name="entities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BreakdownMetrics(
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? mcpServers,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? models,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? modelGroups,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? providers,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? endpoints,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.KeyMetricWithMetadata>? apiKeys,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.MetricWithMetadata>? entities)
        {
            this.McpServers = mcpServers;
            this.Models = models;
            this.ModelGroups = modelGroups;
            this.Providers = providers;
            this.Endpoints = endpoints;
            this.ApiKeys = apiKeys;
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownMetrics" /> class.
        /// </summary>
        public BreakdownMetrics()
        {
        }

    }
}
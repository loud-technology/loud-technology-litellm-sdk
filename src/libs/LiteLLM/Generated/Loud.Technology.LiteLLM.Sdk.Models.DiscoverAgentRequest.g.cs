
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiscoverAgentRequest
    {
        /// <summary>
        /// How to locate the upstream card. ``well_known_fallback`` for pure A2A agents (try standard paths); ``langgraph_platform`` for LangGraph Platform deployments where the card is shared across assistants and disambiguated by a query parameter.<br/>
        /// Default Value: well_known_fallback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discovery_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.DiscoveryModeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.DiscoveryMode? DiscoveryMode { get; set; }

        /// <summary>
        /// Mode-specific parameters. ``langgraph_platform`` requires ``{'assistant_id': &lt;id&gt;}``. ``well_known_fallback`` ignores this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Base URL of the upstream agent. Behavior depends on ``discovery_mode``: ``well_known_fallback`` (default) tries /.well-known/agent-card.json, /.well-known/agent.json, /agent.json under this URL in order; ``langgraph_platform`` hits ``/.well-known/agent-card.json?assistant_id=&lt;id&gt;`` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverAgentRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// Base URL of the upstream agent. Behavior depends on ``discovery_mode``: ``well_known_fallback`` (default) tries /.well-known/agent-card.json, /.well-known/agent.json, /agent.json under this URL in order; ``langgraph_platform`` hits ``/.well-known/agent-card.json?assistant_id=&lt;id&gt;`` instead.
        /// </param>
        /// <param name="discoveryMode">
        /// How to locate the upstream card. ``well_known_fallback`` for pure A2A agents (try standard paths); ``langgraph_platform`` for LangGraph Platform deployments where the card is shared across assistants and disambiguated by a query parameter.<br/>
        /// Default Value: well_known_fallback
        /// </param>
        /// <param name="params">
        /// Mode-specific parameters. ``langgraph_platform`` requires ``{'assistant_id': &lt;id&gt;}``. ``well_known_fallback`` ignores this.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscoverAgentRequest(
            string url,
            global::Loud.Technology.LiteLLM.Sdk.DiscoveryMode? discoveryMode,
            object? @params)
        {
            this.DiscoveryMode = discoveryMode;
            this.Params = @params;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverAgentRequest" /> class.
        /// </summary>
        public DiscoverAgentRequest()
        {
        }

    }
}

#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A single request to classify against a complexity-router config that need not be saved yet.<br/>
    /// Carries the same fields the serving path carries, so a dry run classifies what a real turn<br/>
    /// would classify. `messages`, `system` and `tools` are forwarded to the routing hook untranslated,<br/>
    /// which is why they are typed loosely: the hook reads whatever dialect the surface produced, and<br/>
    /// validating them against one surface's schema would reject the others.
    /// </summary>
    public sealed partial class AutoRouterRoutingTestRequest
    {
        /// <summary>
        /// A single ask to route, as an end user would send it. Mutually exclusive with messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The full message list to route, exactly as the serving path would receive it. Mutually exclusive with prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// The top-level system prompt an Anthropic /v1/messages body carries beside its messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<object>, object>? System { get; set; }

        /// <summary>
        /// The tool definitions the request advertises, which decide whether the plan-mode floor applies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// The complexity router config to route against, in the shape /model/new accepts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complexity_router_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfig ComplexityRouterConfig { get; set; }

        /// <summary>
        /// Test this saved deployment's server-side configuration instead of the supplied config and default model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_model_id")]
        public string? SavedModelId { get; set; }

        /// <summary>
        /// Model to route to when no tier resolves, i.e. complexity_router_default_model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model")]
        public string? DefaultModel { get; set; }

        /// <summary>
        /// Name reported as the router in the routing decision. Display only<br/>
        /// Default Value: auto_router_routing_test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_name")]
        public string? RouterName { get; set; }

        /// <summary>
        /// Team the router is being created for. Required for a team admin, who may only test their own team's routers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterRoutingTestRequest" /> class.
        /// </summary>
        /// <param name="complexityRouterConfig">
        /// The complexity router config to route against, in the shape /model/new accepts
        /// </param>
        /// <param name="prompt">
        /// A single ask to route, as an end user would send it. Mutually exclusive with messages
        /// </param>
        /// <param name="messages">
        /// The full message list to route, exactly as the serving path would receive it. Mutually exclusive with prompt
        /// </param>
        /// <param name="system">
        /// The top-level system prompt an Anthropic /v1/messages body carries beside its messages
        /// </param>
        /// <param name="tools">
        /// The tool definitions the request advertises, which decide whether the plan-mode floor applies
        /// </param>
        /// <param name="savedModelId">
        /// Test this saved deployment's server-side configuration instead of the supplied config and default model
        /// </param>
        /// <param name="defaultModel">
        /// Model to route to when no tier resolves, i.e. complexity_router_default_model
        /// </param>
        /// <param name="routerName">
        /// Name reported as the router in the routing decision. Display only<br/>
        /// Default Value: auto_router_routing_test
        /// </param>
        /// <param name="teamId">
        /// Team the router is being created for. Required for a team admin, who may only test their own team's routers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRouterRoutingTestRequest(
            global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfig complexityRouterConfig,
            string? prompt,
            global::System.Collections.Generic.IList<object>? messages,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<object>, object>? system,
            global::System.Collections.Generic.IList<object>? tools,
            string? savedModelId,
            string? defaultModel,
            string? routerName,
            string? teamId)
        {
            this.Prompt = prompt;
            this.Messages = messages;
            this.System = system;
            this.Tools = tools;
            this.ComplexityRouterConfig = complexityRouterConfig ?? throw new global::System.ArgumentNullException(nameof(complexityRouterConfig));
            this.SavedModelId = savedModelId;
            this.DefaultModel = defaultModel;
            this.RouterName = routerName;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRouterRoutingTestRequest" /> class.
        /// </summary>
        public AutoRouterRoutingTestRequest()
        {
        }

    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Preview Auto Router Routing<br/>
        /// Route a single request through a complexity-router config and report where it landed.<br/>
        /// Answers "which model would this request get?" for a config that only exists in a form,<br/>
        /// so an auto router can be checked before it is created. The request is classified by the<br/>
        /// same pre-routing hook a live request runs, over the same messages, system prompt and tool<br/>
        /// definitions, then dropped: nothing is sent to the model it routed to, and no auto router is<br/>
        /// created. A heuristic config therefore spends nothing, while an `llm` classifier or semantic<br/>
        /// keyword matching bills its classifier/embedding call to the calling key, like Test Connection<br/>
        /// does.<br/>
        /// Send `messages` to classify a real turn, with `system` and `tools` beside it when the surface<br/>
        /// carries them top level, as Anthropic /v1/messages does. `prompt` is the single-ask shorthand and<br/>
        /// routes as one user turn with nothing around it.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "messages": [<br/>
        ///         {"role": "system", "content": "You are a database migration assistant"},<br/>
        ///         {"role": "user", "content": "the index is not unique"},<br/>
        ///         {"role": "assistant", "content": "Then two workers can both insert. Add a unique index"},<br/>
        ///         {"role": "user", "content": "ok do it"}<br/>
        ///     ],<br/>
        ///     "tools": [{"type": "function", "function": {"name": "Bash", "description": "Run a command"}}],<br/>
        ///     "complexity_router_config": {<br/>
        ///         "tiers": {"SIMPLE": ["gpt-4o-mini"], "REASONING": ["o3"]},<br/>
        ///         "classifier_type": "heuristic"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse> PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Auto Router Routing<br/>
        /// Route a single request through a complexity-router config and report where it landed.<br/>
        /// Answers "which model would this request get?" for a config that only exists in a form,<br/>
        /// so an auto router can be checked before it is created. The request is classified by the<br/>
        /// same pre-routing hook a live request runs, over the same messages, system prompt and tool<br/>
        /// definitions, then dropped: nothing is sent to the model it routed to, and no auto router is<br/>
        /// created. A heuristic config therefore spends nothing, while an `llm` classifier or semantic<br/>
        /// keyword matching bills its classifier/embedding call to the calling key, like Test Connection<br/>
        /// does.<br/>
        /// Send `messages` to classify a real turn, with `system` and `tools` beside it when the surface<br/>
        /// carries them top level, as Anthropic /v1/messages does. `prompt` is the single-ask shorthand and<br/>
        /// routes as one user turn with nothing around it.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "messages": [<br/>
        ///         {"role": "system", "content": "You are a database migration assistant"},<br/>
        ///         {"role": "user", "content": "the index is not unique"},<br/>
        ///         {"role": "assistant", "content": "Then two workers can both insert. Add a unique index"},<br/>
        ///         {"role": "user", "content": "ok do it"}<br/>
        ///     ],<br/>
        ///     "tools": [{"type": "function", "function": {"name": "Bash", "description": "Run a command"}}],<br/>
        ///     "complexity_router_config": {<br/>
        ///         "tiers": {"SIMPLE": ["gpt-4o-mini"], "REASONING": ["o3"]},<br/>
        ///         "classifier_type": "heuristic"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse>> PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Auto Router Routing<br/>
        /// Route a single request through a complexity-router config and report where it landed.<br/>
        /// Answers "which model would this request get?" for a config that only exists in a form,<br/>
        /// so an auto router can be checked before it is created. The request is classified by the<br/>
        /// same pre-routing hook a live request runs, over the same messages, system prompt and tool<br/>
        /// definitions, then dropped: nothing is sent to the model it routed to, and no auto router is<br/>
        /// created. A heuristic config therefore spends nothing, while an `llm` classifier or semantic<br/>
        /// keyword matching bills its classifier/embedding call to the calling key, like Test Connection<br/>
        /// does.<br/>
        /// Send `messages` to classify a real turn, with `system` and `tools` beside it when the surface<br/>
        /// carries them top level, as Anthropic /v1/messages does. `prompt` is the single-ask shorthand and<br/>
        /// routes as one user turn with nothing around it.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "messages": [<br/>
        ///         {"role": "system", "content": "You are a database migration assistant"},<br/>
        ///         {"role": "user", "content": "the index is not unique"},<br/>
        ///         {"role": "assistant", "content": "Then two workers can both insert. Add a unique index"},<br/>
        ///         {"role": "user", "content": "ok do it"}<br/>
        ///     ],<br/>
        ///     "tools": [{"type": "function", "function": {"name": "Bash", "description": "Run a command"}}],<br/>
        ///     "complexity_router_config": {<br/>
        ///         "tiers": {"SIMPLE": ["gpt-4o-mini"], "REASONING": ["o3"]},<br/>
        ///         "classifier_type": "heuristic"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
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
        /// <param name="complexityRouterConfig">
        /// The complexity router config to route against, in the shape /model/new accepts
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse> PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfig complexityRouterConfig,
            string? prompt = default,
            global::System.Collections.Generic.IList<object>? messages = default,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<object>, object>? system = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            string? savedModelId = default,
            string? defaultModel = default,
            string? routerName = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IA2aRegistrationClient
    {
        /// <summary>
        /// Discover Agent Card<br/>
        /// Fetch the upstream agent's well-known card so the UI can show the admin<br/>
        /// which skills/capabilities the agent exposes.<br/>
        /// Only proxy admins can call this — the UI uses it during agent registration,<br/>
        /// and we don't want arbitrary keys probing internal URLs.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/a2a/discover" \<br/>
        ///     -H "Authorization: Bearer &lt;admin_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{"url": "https://upstream-agent.example.com"}'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse> DiscoverAgentCardV1A2aDiscoverPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Discover Agent Card<br/>
        /// Fetch the upstream agent's well-known card so the UI can show the admin<br/>
        /// which skills/capabilities the agent exposes.<br/>
        /// Only proxy admins can call this — the UI uses it during agent registration,<br/>
        /// and we don't want arbitrary keys probing internal URLs.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/a2a/discover" \<br/>
        ///     -H "Authorization: Bearer &lt;admin_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{"url": "https://upstream-agent.example.com"}'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse>> DiscoverAgentCardV1A2aDiscoverPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Discover Agent Card<br/>
        /// Fetch the upstream agent's well-known card so the UI can show the admin<br/>
        /// which skills/capabilities the agent exposes.<br/>
        /// Only proxy admins can call this — the UI uses it during agent registration,<br/>
        /// and we don't want arbitrary keys probing internal URLs.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/a2a/discover" \<br/>
        ///     -H "Authorization: Bearer &lt;admin_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{"url": "https://upstream-agent.example.com"}'<br/>
        /// ```
        /// </summary>
        /// <param name="discoveryMode">
        /// How to locate the upstream card. ``well_known_fallback`` for pure A2A agents (try standard paths); ``langgraph_platform`` for LangGraph Platform deployments where the card is shared across assistants and disambiguated by a query parameter.<br/>
        /// Default Value: well_known_fallback
        /// </param>
        /// <param name="params">
        /// Mode-specific parameters. ``langgraph_platform`` requires ``{'assistant_id': &lt;id&gt;}``. ``well_known_fallback`` ignores this.
        /// </param>
        /// <param name="url">
        /// Base URL of the upstream agent. Behavior depends on ``discovery_mode``: ``well_known_fallback`` (default) tries /.well-known/agent-card.json, /.well-known/agent.json, /agent.json under this URL in order; ``langgraph_platform`` hits ``/.well-known/agent-card.json?assistant_id=&lt;id&gt;`` instead.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse> DiscoverAgentCardV1A2aDiscoverPostAsync(
            string url,
            global::Loud.Technology.LiteLLM.Sdk.DiscoveryMode? discoveryMode = default,
            object? @params = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
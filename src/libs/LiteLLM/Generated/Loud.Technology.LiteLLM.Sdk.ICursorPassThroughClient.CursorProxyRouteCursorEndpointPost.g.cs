#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICursorPassThroughClient
    {
        /// <summary>
        /// Cursor Proxy Route<br/>
        /// Pass-through endpoint for the Cursor Cloud Agents API.<br/>
        /// Supports all Cursor Cloud Agents endpoints:<br/>
        /// - GET    /v0/agents         — List agents<br/>
        /// - POST   /v0/agents         — Launch an agent<br/>
        /// - GET    /v0/agents/{id}    — Agent status<br/>
        /// - GET    /v0/agents/{id}/conversation — Agent conversation<br/>
        /// - POST   /v0/agents/{id}/followup    — Add follow-up<br/>
        /// - POST   /v0/agents/{id}/stop        — Stop an agent<br/>
        /// - DELETE /v0/agents/{id}    — Delete an agent<br/>
        /// - GET    /v0/me             — API key info<br/>
        /// - GET    /v0/models         — List models<br/>
        /// - GET    /v0/repositories   — List GitHub repositories<br/>
        /// Uses Basic Authentication (base64-encoded `API_KEY:`).<br/>
        /// Credential lookup order:<br/>
        /// 1. passthrough_endpoint_router (config.yaml deployments with use_in_pass_through)<br/>
        /// 2. litellm.credential_list (credentials added via UI)<br/>
        /// 3. CURSOR_API_KEY environment variable
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CursorProxyRouteCursorEndpointPostAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cursor Proxy Route<br/>
        /// Pass-through endpoint for the Cursor Cloud Agents API.<br/>
        /// Supports all Cursor Cloud Agents endpoints:<br/>
        /// - GET    /v0/agents         — List agents<br/>
        /// - POST   /v0/agents         — Launch an agent<br/>
        /// - GET    /v0/agents/{id}    — Agent status<br/>
        /// - GET    /v0/agents/{id}/conversation — Agent conversation<br/>
        /// - POST   /v0/agents/{id}/followup    — Add follow-up<br/>
        /// - POST   /v0/agents/{id}/stop        — Stop an agent<br/>
        /// - DELETE /v0/agents/{id}    — Delete an agent<br/>
        /// - GET    /v0/me             — API key info<br/>
        /// - GET    /v0/models         — List models<br/>
        /// - GET    /v0/repositories   — List GitHub repositories<br/>
        /// Uses Basic Authentication (base64-encoded `API_KEY:`).<br/>
        /// Credential lookup order:<br/>
        /// 1. passthrough_endpoint_router (config.yaml deployments with use_in_pass_through)<br/>
        /// 2. litellm.credential_list (credentials added via UI)<br/>
        /// 3. CURSOR_API_KEY environment variable
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CursorProxyRouteCursorEndpointPostAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
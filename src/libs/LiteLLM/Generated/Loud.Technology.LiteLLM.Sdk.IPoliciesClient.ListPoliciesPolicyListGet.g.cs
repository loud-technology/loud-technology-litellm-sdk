#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// List Policies<br/>
        /// List all loaded policies with their resolved guardrails.<br/>
        /// Returns information about each policy including:<br/>
        /// - Inheritance configuration<br/>
        /// - Scope (teams, keys, models)<br/>
        /// - Guardrails to add/remove<br/>
        /// - Resolved guardrails (after inheritance)<br/>
        /// - Inheritance chain
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyListResponse> ListPoliciesPolicyListGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Policies<br/>
        /// List all loaded policies with their resolved guardrails.<br/>
        /// Returns information about each policy including:<br/>
        /// - Inheritance configuration<br/>
        /// - Scope (teams, keys, models)<br/>
        /// - Guardrails to add/remove<br/>
        /// - Resolved guardrails (after inheritance)<br/>
        /// - Inheritance chain
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyListResponse>> ListPoliciesPolicyListGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
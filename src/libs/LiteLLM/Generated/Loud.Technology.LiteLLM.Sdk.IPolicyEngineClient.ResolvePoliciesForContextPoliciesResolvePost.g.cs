#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Resolve Policies For Context<br/>
        /// Resolve which policies and guardrails apply for a given context.<br/>
        /// Use this endpoint to debug "what guardrails would apply to a request<br/>
        /// with this team/key/model/tags combination?"<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/resolve" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "tags": ["healthcare"],<br/>
        ///         "model": "gpt-4"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="forceSync">
        /// Force a DB sync before resolving. Default uses in-memory cache.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyResolveResponse> ResolvePoliciesForContextPoliciesResolvePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyResolveRequest request,
            bool? forceSync = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve Policies For Context<br/>
        /// Resolve which policies and guardrails apply for a given context.<br/>
        /// Use this endpoint to debug "what guardrails would apply to a request<br/>
        /// with this team/key/model/tags combination?"<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/resolve" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "tags": ["healthcare"],<br/>
        ///         "model": "gpt-4"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="forceSync">
        /// Force a DB sync before resolving. Default uses in-memory cache.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyResolveResponse>> ResolvePoliciesForContextPoliciesResolvePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyResolveRequest request,
            bool? forceSync = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve Policies For Context<br/>
        /// Resolve which policies and guardrails apply for a given context.<br/>
        /// Use this endpoint to debug "what guardrails would apply to a request<br/>
        /// with this team/key/model/tags combination?"<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/resolve" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "tags": ["healthcare"],<br/>
        ///         "model": "gpt-4"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="forceSync">
        /// Force a DB sync before resolving. Default uses in-memory cache.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keyAlias">
        /// Key alias to resolve for.
        /// </param>
        /// <param name="model">
        /// Model name to resolve for.
        /// </param>
        /// <param name="tags">
        /// Tags to resolve for.
        /// </param>
        /// <param name="teamAlias">
        /// Team alias to resolve for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyResolveResponse> ResolvePoliciesForContextPoliciesResolvePostAsync(
            bool? forceSync = default,
            string? keyAlias = default,
            string? model = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? teamAlias = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
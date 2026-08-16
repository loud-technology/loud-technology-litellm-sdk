#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// List Policies<br/>
        /// List all policies from the database and config.yaml. Optionally filter by version_status.<br/>
        /// Config-defined policies are returned with definition_location "config" and are treated<br/>
        /// as production versions. On a name conflict with a DB policy, only the DB policy is returned.<br/>
        /// Query params:<br/>
        /// - version_status: Optional. One of "draft", "published", "production".<br/>
        ///   If omitted, all versions are returned.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/list" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// curl -X GET "http://localhost:4000/policies/list?version_status=production" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policies": [<br/>
        ///         {<br/>
        ///             "policy_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///             "policy_name": "global-baseline",<br/>
        ///             "version_number": 1,<br/>
        ///             "version_status": "production",<br/>
        ///             "inherit": null,<br/>
        ///             "description": "Base guardrails for all requests",<br/>
        ///             "guardrails_add": ["pii_masking"],<br/>
        ///             "guardrails_remove": [],<br/>
        ///             "condition": null,<br/>
        ///             "created_at": "2024-01-01T00:00:00Z",<br/>
        ///             "updated_at": "2024-01-01T00:00:00Z"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "total_count": 1<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="versionStatus"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyListDBResponse> ListPoliciesPoliciesListGetAsync(
            string? versionStatus = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Policies<br/>
        /// List all policies from the database and config.yaml. Optionally filter by version_status.<br/>
        /// Config-defined policies are returned with definition_location "config" and are treated<br/>
        /// as production versions. On a name conflict with a DB policy, only the DB policy is returned.<br/>
        /// Query params:<br/>
        /// - version_status: Optional. One of "draft", "published", "production".<br/>
        ///   If omitted, all versions are returned.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/list" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// curl -X GET "http://localhost:4000/policies/list?version_status=production" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policies": [<br/>
        ///         {<br/>
        ///             "policy_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///             "policy_name": "global-baseline",<br/>
        ///             "version_number": 1,<br/>
        ///             "version_status": "production",<br/>
        ///             "inherit": null,<br/>
        ///             "description": "Base guardrails for all requests",<br/>
        ///             "guardrails_add": ["pii_masking"],<br/>
        ///             "guardrails_remove": [],<br/>
        ///             "condition": null,<br/>
        ///             "created_at": "2024-01-01T00:00:00Z",<br/>
        ///             "updated_at": "2024-01-01T00:00:00Z"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "total_count": 1<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="versionStatus"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyListDBResponse>> ListPoliciesPoliciesListGetAsResponseAsync(
            string? versionStatus = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
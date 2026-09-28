#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Create Policy<br/>
        /// Create a new policy.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "global-baseline",<br/>
        ///         "description": "Base guardrails for all requests",<br/>
        ///         "guardrails_add": ["pii_masking", "prompt_injection"],<br/>
        ///         "guardrails_remove": []<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policy_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "policy_name": "global-baseline",<br/>
        ///     "inherit": null,<br/>
        ///     "description": "Base guardrails for all requests",<br/>
        ///     "guardrails_add": ["pii_masking", "prompt_injection"],<br/>
        ///     "guardrails_remove": [],<br/>
        ///     "condition": null,<br/>
        ///     "created_at": "2024-01-01T00:00:00Z",<br/>
        ///     "updated_at": "2024-01-01T00:00:00Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse> CreatePolicyPoliciesPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Policy<br/>
        /// Create a new policy.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "global-baseline",<br/>
        ///         "description": "Base guardrails for all requests",<br/>
        ///         "guardrails_add": ["pii_masking", "prompt_injection"],<br/>
        ///         "guardrails_remove": []<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policy_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "policy_name": "global-baseline",<br/>
        ///     "inherit": null,<br/>
        ///     "description": "Base guardrails for all requests",<br/>
        ///     "guardrails_add": ["pii_masking", "prompt_injection"],<br/>
        ///     "guardrails_remove": [],<br/>
        ///     "condition": null,<br/>
        ///     "created_at": "2024-01-01T00:00:00Z",<br/>
        ///     "updated_at": "2024-01-01T00:00:00Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse>> CreatePolicyPoliciesPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Policy<br/>
        /// Create a new policy.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "global-baseline",<br/>
        ///         "description": "Base guardrails for all requests",<br/>
        ///         "guardrails_add": ["pii_masking", "prompt_injection"],<br/>
        ///         "guardrails_remove": []<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policy_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "policy_name": "global-baseline",<br/>
        ///     "inherit": null,<br/>
        ///     "description": "Base guardrails for all requests",<br/>
        ///     "guardrails_add": ["pii_masking", "prompt_injection"],<br/>
        ///     "guardrails_remove": [],<br/>
        ///     "condition": null,<br/>
        ///     "created_at": "2024-01-01T00:00:00Z",<br/>
        ///     "updated_at": "2024-01-01T00:00:00Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="condition">
        /// Condition for when this policy applies.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the policy.
        /// </param>
        /// <param name="guardrailsAdd">
        /// List of guardrail names to add.
        /// </param>
        /// <param name="guardrailsRemove">
        /// List of guardrail names to remove (from inherited).
        /// </param>
        /// <param name="inherit">
        /// Name of parent policy to inherit from.
        /// </param>
        /// <param name="pipeline">
        /// Optional guardrail pipeline for ordered execution. Contains 'mode' and 'steps'.
        /// </param>
        /// <param name="policyName">
        /// Unique name for the policy.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse> CreatePolicyPoliciesPostAsync(
            string policyName,
            global::Loud.Technology.LiteLLM.Sdk.PolicyConditionRequest? condition = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? guardrailsAdd = default,
            global::System.Collections.Generic.IList<string>? guardrailsRemove = default,
            string? inherit = default,
            object? pipeline = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
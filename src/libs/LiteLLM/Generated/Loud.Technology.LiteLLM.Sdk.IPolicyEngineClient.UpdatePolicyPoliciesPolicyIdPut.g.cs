#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Update Policy<br/>
        /// Update an existing policy.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/policies/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "description": "Updated description",<br/>
        ///         "guardrails_add": ["pii_masking", "toxicity_filter"]<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse> UpdatePolicyPoliciesPolicyIdPutAsync(
            string policyId,

            global::Loud.Technology.LiteLLM.Sdk.PolicyUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Policy<br/>
        /// Update an existing policy.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/policies/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "description": "Updated description",<br/>
        ///         "guardrails_add": ["pii_masking", "toxicity_filter"]<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse>> UpdatePolicyPoliciesPolicyIdPutAsResponseAsync(
            string policyId,

            global::Loud.Technology.LiteLLM.Sdk.PolicyUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Policy<br/>
        /// Update an existing policy.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/policies/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "description": "Updated description",<br/>
        ///         "guardrails_add": ["pii_masking", "toxicity_filter"]<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="policyId"></param>
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
        /// New name for the policy.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse> UpdatePolicyPoliciesPolicyIdPutAsync(
            string policyId,
            global::Loud.Technology.LiteLLM.Sdk.PolicyConditionRequest? condition = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? guardrailsAdd = default,
            global::System.Collections.Generic.IList<string>? guardrailsRemove = default,
            string? inherit = default,
            object? pipeline = default,
            string? policyName = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
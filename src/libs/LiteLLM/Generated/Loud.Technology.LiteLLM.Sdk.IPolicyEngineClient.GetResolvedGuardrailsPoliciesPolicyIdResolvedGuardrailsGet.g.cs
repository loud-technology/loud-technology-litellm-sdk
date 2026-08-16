#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Get Resolved Guardrails<br/>
        /// Get the resolved guardrails for a policy (including inherited guardrails).<br/>
        /// This endpoint resolves the full inheritance chain and returns the final<br/>
        /// set of guardrails that would be applied for this policy.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/123e4567-e89b-12d3-a456-426614174000/resolved-guardrails" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policy_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "policy_name": "healthcare-compliance",<br/>
        ///     "resolved_guardrails": ["pii_masking", "prompt_injection", "toxicity_filter"]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetResolvedGuardrailsPoliciesPolicyIdResolvedGuardrailsGetAsync(
            string policyId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Resolved Guardrails<br/>
        /// Get the resolved guardrails for a policy (including inherited guardrails).<br/>
        /// This endpoint resolves the full inheritance chain and returns the final<br/>
        /// set of guardrails that would be applied for this policy.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/123e4567-e89b-12d3-a456-426614174000/resolved-guardrails" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policy_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "policy_name": "healthcare-compliance",<br/>
        ///     "resolved_guardrails": ["pii_masking", "prompt_injection", "toxicity_filter"]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="policyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetResolvedGuardrailsPoliciesPolicyIdResolvedGuardrailsGetAsResponseAsync(
            string policyId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
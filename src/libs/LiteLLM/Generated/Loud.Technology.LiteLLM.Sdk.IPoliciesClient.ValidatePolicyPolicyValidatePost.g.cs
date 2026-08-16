#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Validate Policy<br/>
        /// Validate a policy configuration before applying it.<br/>
        /// Checks:<br/>
        /// - All referenced guardrails exist in the guardrail registry<br/>
        /// - All non-wildcard team aliases exist in the database<br/>
        /// - All non-wildcard key aliases exist in the database<br/>
        /// - Inheritance chains are valid (no cycles, parents exist)<br/>
        /// - Scope patterns are syntactically valid<br/>
        /// Returns:<br/>
        /// - valid: True if the policy configuration is valid (no blocking errors)<br/>
        /// - errors: List of blocking validation errors<br/>
        /// - warnings: List of non-blocking validation warnings<br/>
        /// Example request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policies": {<br/>
        ///         "global-baseline": {<br/>
        ///             "guardrails": {<br/>
        ///                 "add": ["pii_blocker", "phi_blocker"]<br/>
        ///             },<br/>
        ///             "scope": {<br/>
        ///                 "teams": ["*"],<br/>
        ///                 "keys": ["*"],<br/>
        ///                 "models": ["*"]<br/>
        ///             }<br/>
        ///         },<br/>
        ///         "healthcare-compliance": {<br/>
        ///             "inherit": "global-baseline",<br/>
        ///             "guardrails": {<br/>
        ///                 "add": ["hipaa_audit"]<br/>
        ///             },<br/>
        ///             "scope": {<br/>
        ///                 "teams": ["healthcare-team"]<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyValidationResponse> ValidatePolicyPolicyValidatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyValidateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Policy<br/>
        /// Validate a policy configuration before applying it.<br/>
        /// Checks:<br/>
        /// - All referenced guardrails exist in the guardrail registry<br/>
        /// - All non-wildcard team aliases exist in the database<br/>
        /// - All non-wildcard key aliases exist in the database<br/>
        /// - Inheritance chains are valid (no cycles, parents exist)<br/>
        /// - Scope patterns are syntactically valid<br/>
        /// Returns:<br/>
        /// - valid: True if the policy configuration is valid (no blocking errors)<br/>
        /// - errors: List of blocking validation errors<br/>
        /// - warnings: List of non-blocking validation warnings<br/>
        /// Example request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policies": {<br/>
        ///         "global-baseline": {<br/>
        ///             "guardrails": {<br/>
        ///                 "add": ["pii_blocker", "phi_blocker"]<br/>
        ///             },<br/>
        ///             "scope": {<br/>
        ///                 "teams": ["*"],<br/>
        ///                 "keys": ["*"],<br/>
        ///                 "models": ["*"]<br/>
        ///             }<br/>
        ///         },<br/>
        ///         "healthcare-compliance": {<br/>
        ///             "inherit": "global-baseline",<br/>
        ///             "guardrails": {<br/>
        ///                 "add": ["hipaa_audit"]<br/>
        ///             },<br/>
        ///             "scope": {<br/>
        ///                 "teams": ["healthcare-team"]<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyValidationResponse>> ValidatePolicyPolicyValidatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyValidateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Policy<br/>
        /// Validate a policy configuration before applying it.<br/>
        /// Checks:<br/>
        /// - All referenced guardrails exist in the guardrail registry<br/>
        /// - All non-wildcard team aliases exist in the database<br/>
        /// - All non-wildcard key aliases exist in the database<br/>
        /// - Inheritance chains are valid (no cycles, parents exist)<br/>
        /// - Scope patterns are syntactically valid<br/>
        /// Returns:<br/>
        /// - valid: True if the policy configuration is valid (no blocking errors)<br/>
        /// - errors: List of blocking validation errors<br/>
        /// - warnings: List of non-blocking validation warnings<br/>
        /// Example request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "policies": {<br/>
        ///         "global-baseline": {<br/>
        ///             "guardrails": {<br/>
        ///                 "add": ["pii_blocker", "phi_blocker"]<br/>
        ///             },<br/>
        ///             "scope": {<br/>
        ///                 "teams": ["*"],<br/>
        ///                 "keys": ["*"],<br/>
        ///                 "models": ["*"]<br/>
        ///             }<br/>
        ///         },<br/>
        ///         "healthcare-compliance": {<br/>
        ///             "inherit": "global-baseline",<br/>
        ///             "guardrails": {<br/>
        ///                 "add": ["hipaa_audit"]<br/>
        ///             },<br/>
        ///             "scope": {<br/>
        ///                 "teams": ["healthcare-team"]<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="policies">
        /// Policy configuration to validate. Map of policy names to policy definitions.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyValidationResponse> ValidatePolicyPolicyValidatePostAsync(
            object policies,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
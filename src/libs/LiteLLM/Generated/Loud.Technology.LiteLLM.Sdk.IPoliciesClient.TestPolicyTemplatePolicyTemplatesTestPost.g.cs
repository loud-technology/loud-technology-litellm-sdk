#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Test Policy Template<br/>
        /// Test a policy template's guardrails against a text input without creating them.<br/>
        /// Instantiates temporary guardrails from the template definitions, runs them<br/>
        /// against the provided text, and returns per-guardrail results so users can<br/>
        /// verify the template solves their problem before creating it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TestPolicyTemplateResponse> TestPolicyTemplatePolicyTemplatesTestPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TestPolicyTemplateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Policy Template<br/>
        /// Test a policy template's guardrails against a text input without creating them.<br/>
        /// Instantiates temporary guardrails from the template definitions, runs them<br/>
        /// against the provided text, and returns per-guardrail results so users can<br/>
        /// verify the template solves their problem before creating it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TestPolicyTemplateResponse>> TestPolicyTemplatePolicyTemplatesTestPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TestPolicyTemplateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Policy Template<br/>
        /// Test a policy template's guardrails against a text input without creating them.<br/>
        /// Instantiates temporary guardrails from the template definitions, runs them<br/>
        /// against the provided text, and returns per-guardrail results so users can<br/>
        /// verify the template solves their problem before creating it.
        /// </summary>
        /// <param name="guardrailDefinitions">
        /// All guardrailDefinitions from the policy template
        /// </param>
        /// <param name="text">
        /// Test input text to run guardrails against
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TestPolicyTemplateResponse> TestPolicyTemplatePolicyTemplatesTestPostAsync(
            global::System.Collections.Generic.IList<object> guardrailDefinitions,
            string text,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
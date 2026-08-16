#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IComplianceClient
    {
        /// <summary>
        /// Check Gdpr Compliance<br/>
        /// Check GDPR compliance for a spend log entry.<br/>
        /// Checks:<br/>
        /// - Art. 32: Data protection applied (pre-call guardrails)<br/>
        /// - Art. 5(1)(c): Sensitive data protected (masked/blocked or no issues)<br/>
        /// - Art. 30: Audit record complete (user_id, model, timestamp, guardrail_results)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ComplianceResponse> CheckGdprComplianceComplianceGdprPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.ComplianceCheckRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Gdpr Compliance<br/>
        /// Check GDPR compliance for a spend log entry.<br/>
        /// Checks:<br/>
        /// - Art. 32: Data protection applied (pre-call guardrails)<br/>
        /// - Art. 5(1)(c): Sensitive data protected (masked/blocked or no issues)<br/>
        /// - Art. 30: Audit record complete (user_id, model, timestamp, guardrail_results)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ComplianceResponse>> CheckGdprComplianceComplianceGdprPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.ComplianceCheckRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Gdpr Compliance<br/>
        /// Check GDPR compliance for a spend log entry.<br/>
        /// Checks:<br/>
        /// - Art. 32: Data protection applied (pre-call guardrails)<br/>
        /// - Art. 5(1)(c): Sensitive data protected (masked/blocked or no issues)<br/>
        /// - Art. 30: Audit record complete (user_id, model, timestamp, guardrail_results)
        /// </summary>
        /// <param name="guardrailInformation"></param>
        /// <param name="model"></param>
        /// <param name="requestId"></param>
        /// <param name="timestamp"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ComplianceResponse> CheckGdprComplianceComplianceGdprPostAsync(
            string requestId,
            global::System.Collections.Generic.IList<object>? guardrailInformation = default,
            string? model = default,
            string? timestamp = default,
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Guardrails Usage Overview<br/>
        /// Return guardrail performance overview for the dashboard.
        /// </summary>
        /// <param name="startDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.UsageOverviewResponse> GuardrailsUsageOverviewGuardrailsUsageOverviewGetAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Guardrails Usage Overview<br/>
        /// Return guardrail performance overview for the dashboard.
        /// </summary>
        /// <param name="startDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="endDate">
        /// YYYY-MM-DD
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.UsageOverviewResponse>> GuardrailsUsageOverviewGuardrailsUsageOverviewGetAsResponseAsync(
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Enrich Policy Template<br/>
        /// Enrich a policy template with LLM-discovered data (e.g. competitor names).<br/>
        /// Calls an onboarded LLM to discover competitors for the given brand name,<br/>
        /// then returns enriched guardrailDefinitions with the discovered data populated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EnrichPolicyTemplatePolicyTemplatesEnrichPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.EnrichTemplateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enrich Policy Template<br/>
        /// Enrich a policy template with LLM-discovered data (e.g. competitor names).<br/>
        /// Calls an onboarded LLM to discover competitors for the given brand name,<br/>
        /// then returns enriched guardrailDefinitions with the discovered data populated.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> EnrichPolicyTemplatePolicyTemplatesEnrichPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.EnrichTemplateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enrich Policy Template<br/>
        /// Enrich a policy template with LLM-discovered data (e.g. competitor names).<br/>
        /// Calls an onboarded LLM to discover competitors for the given brand name,<br/>
        /// then returns enriched guardrailDefinitions with the discovered data populated.
        /// </summary>
        /// <param name="competitors">
        /// Optional list of competitor names
        /// </param>
        /// <param name="instruction">
        /// Refinement instruction for modifying the competitor list (e.g. 'add 10 more from Asia')
        /// </param>
        /// <param name="model"></param>
        /// <param name="parameters"></param>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> EnrichPolicyTemplatePolicyTemplatesEnrichPostAsync(
            object parameters,
            string templateId,
            global::System.Collections.Generic.IList<string>? competitors = default,
            string? instruction = default,
            string? model = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
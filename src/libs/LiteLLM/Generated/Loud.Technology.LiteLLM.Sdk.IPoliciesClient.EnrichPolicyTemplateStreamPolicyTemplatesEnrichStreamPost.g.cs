#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Enrich Policy Template Stream<br/>
        /// Stream competitor names as SSE events as the LLM generates them.<br/>
        /// Events:<br/>
        /// - data: {"type": "competitor", "name": "..."}  — each competitor as discovered<br/>
        /// - data: {"type": "done", "competitors": [...], "competitor_variations": {...}, "guardrailDefinitions": [...]}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EnrichPolicyTemplateStreamPolicyTemplatesEnrichStreamPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.EnrichTemplateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enrich Policy Template Stream<br/>
        /// Stream competitor names as SSE events as the LLM generates them.<br/>
        /// Events:<br/>
        /// - data: {"type": "competitor", "name": "..."}  — each competitor as discovered<br/>
        /// - data: {"type": "done", "competitors": [...], "competitor_variations": {...}, "guardrailDefinitions": [...]}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> EnrichPolicyTemplateStreamPolicyTemplatesEnrichStreamPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.EnrichTemplateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enrich Policy Template Stream<br/>
        /// Stream competitor names as SSE events as the LLM generates them.<br/>
        /// Events:<br/>
        /// - data: {"type": "competitor", "name": "..."}  — each competitor as discovered<br/>
        /// - data: {"type": "done", "competitors": [...], "competitor_variations": {...}, "guardrailDefinitions": [...]}
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
        global::System.Threading.Tasks.Task<string> EnrichPolicyTemplateStreamPolicyTemplatesEnrichStreamPostAsync(
            object parameters,
            string templateId,
            global::System.Collections.Generic.IList<string>? competitors = default,
            string? instruction = default,
            string? model = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
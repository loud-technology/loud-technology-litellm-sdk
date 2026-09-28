#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPoliciesClient
    {
        /// <summary>
        /// Suggest Policy Templates<br/>
        /// Use AI to suggest policy templates based on attack examples and descriptions.<br/>
        /// Calls an LLM with tool calling to match user requirements to available templates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SuggestPolicyTemplatesPolicyTemplatesSuggestPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.SuggestTemplatesRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Suggest Policy Templates<br/>
        /// Use AI to suggest policy templates based on attack examples and descriptions.<br/>
        /// Calls an LLM with tool calling to match user requirements to available templates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> SuggestPolicyTemplatesPolicyTemplatesSuggestPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.SuggestTemplatesRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Suggest Policy Templates<br/>
        /// Use AI to suggest policy templates based on attack examples and descriptions.<br/>
        /// Calls an LLM with tool calling to match user requirements to available templates.
        /// </summary>
        /// <param name="attackExamples"></param>
        /// <param name="description"></param>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SuggestPolicyTemplatesPolicyTemplatesSuggestPostAsync(
            global::System.Collections.Generic.IList<string>? attackExamples = default,
            string? description = default,
            string? model = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
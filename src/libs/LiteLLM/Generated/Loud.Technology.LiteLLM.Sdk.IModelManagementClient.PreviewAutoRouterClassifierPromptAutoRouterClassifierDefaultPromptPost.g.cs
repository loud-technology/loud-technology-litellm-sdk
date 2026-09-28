#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Preview Auto Router Classifier Prompt<br/>
        /// Get the system prompt an auto-router's LLM classifier sends for an edited tier set
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoRouterClassifierDefaultPromptResponse> PreviewAutoRouterClassifierPromptAutoRouterClassifierDefaultPromptPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.AutoRouterClassifierPromptPreviewRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Auto Router Classifier Prompt<br/>
        /// Get the system prompt an auto-router's LLM classifier sends for an edited tier set
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AutoRouterClassifierDefaultPromptResponse>> PreviewAutoRouterClassifierPromptAutoRouterClassifierDefaultPromptPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.AutoRouterClassifierPromptPreviewRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Auto Router Classifier Prompt<br/>
        /// Get the system prompt an auto-router's LLM classifier sends for an edited tier set
        /// </summary>
        /// <param name="tierDefinitions"></param>
        /// <param name="tierLabels"></param>
        /// <param name="classificationRubric"></param>
        /// <param name="contextWindowSize">
        /// Default Value: 3
        /// </param>
        /// <param name="classificationPrompt"></param>
        /// <param name="classificationExamples"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoRouterClassifierDefaultPromptResponse> PreviewAutoRouterClassifierPromptAutoRouterClassifierDefaultPromptPostAsync(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.TierDefinition>? tierDefinitions = default,
            global::System.Collections.Generic.Dictionary<string, string>? tierLabels = default,
            global::Loud.Technology.LiteLLM.Sdk.ClassificationRubric? classificationRubric = default,
            int? contextWindowSize = default,
            string? classificationPrompt = default,
            string? classificationExamples = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
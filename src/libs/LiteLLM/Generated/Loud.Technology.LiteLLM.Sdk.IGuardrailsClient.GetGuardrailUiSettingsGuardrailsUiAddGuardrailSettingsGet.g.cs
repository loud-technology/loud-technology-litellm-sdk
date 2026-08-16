#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Get Guardrail Ui Settings<br/>
        /// Get the UI settings for the guardrails<br/>
        /// Returns:<br/>
        /// - Supported entities for guardrails<br/>
        /// - Supported modes for guardrails<br/>
        /// - PII entity categories for UI organization<br/>
        /// - Content filter settings (patterns and categories)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetGuardrailUiSettingsGuardrailsUiAddGuardrailSettingsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Guardrail Ui Settings<br/>
        /// Get the UI settings for the guardrails<br/>
        /// Returns:<br/>
        /// - Supported entities for guardrails<br/>
        /// - Supported modes for guardrails<br/>
        /// - PII entity categories for UI organization<br/>
        /// - Content filter settings (patterns and categories)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetGuardrailUiSettingsGuardrailsUiAddGuardrailSettingsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
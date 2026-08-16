#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Get Provider Specific Params<br/>
        /// Get provider-specific parameters for different guardrail types.<br/>
        /// Returns a dictionary mapping guardrail providers to their specific parameters,<br/>
        /// including parameter names, descriptions, and whether they are required.<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "bedrock": {<br/>
        ///         "guardrailIdentifier": {<br/>
        ///             "description": "The ID of your guardrail on Bedrock",<br/>
        ///             "required": true,<br/>
        ///             "type": null<br/>
        ///         },<br/>
        ///         "guardrailVersion": {<br/>
        ///             "description": "The version of your Bedrock guardrail (e.g., DRAFT or version number)",<br/>
        ///             "required": true,<br/>
        ///             "type": null<br/>
        ///         }<br/>
        ///     },<br/>
        ///     "azure_content_safety_text_moderation": {<br/>
        ///         "api_key": {<br/>
        ///             "description": "API key for the Azure Content Safety Text Moderation guardrail",<br/>
        ///             "required": false,<br/>
        ///             "type": null<br/>
        ///         },<br/>
        ///         "optional_params": {<br/>
        ///             "description": "Optional parameters for the Azure Content Safety Text Moderation guardrail",<br/>
        ///             "required": true,<br/>
        ///             "type": "nested",<br/>
        ///             "fields": {<br/>
        ///                 "severity_threshold": {<br/>
        ///                     "description": "Severity threshold for the Azure Content Safety Text Moderation guardrail across all categories",<br/>
        ///                     "required": false,<br/>
        ///                     "type": null<br/>
        ///                 },<br/>
        ///                 "categories": {<br/>
        ///                     "description": "Categories to scan for the Azure Content Safety Text Moderation guardrail",<br/>
        ///                     "required": false,<br/>
        ///                     "type": "multiselect",<br/>
        ///                     "options": ["Hate", "SelfHarm", "Sexual", "Violence"],<br/>
        ///                     "default_value": None<br/>
        ///                 }<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetProviderSpecificParamsGuardrailsUiProviderSpecificParamsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Provider Specific Params<br/>
        /// Get provider-specific parameters for different guardrail types.<br/>
        /// Returns a dictionary mapping guardrail providers to their specific parameters,<br/>
        /// including parameter names, descriptions, and whether they are required.<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "bedrock": {<br/>
        ///         "guardrailIdentifier": {<br/>
        ///             "description": "The ID of your guardrail on Bedrock",<br/>
        ///             "required": true,<br/>
        ///             "type": null<br/>
        ///         },<br/>
        ///         "guardrailVersion": {<br/>
        ///             "description": "The version of your Bedrock guardrail (e.g., DRAFT or version number)",<br/>
        ///             "required": true,<br/>
        ///             "type": null<br/>
        ///         }<br/>
        ///     },<br/>
        ///     "azure_content_safety_text_moderation": {<br/>
        ///         "api_key": {<br/>
        ///             "description": "API key for the Azure Content Safety Text Moderation guardrail",<br/>
        ///             "required": false,<br/>
        ///             "type": null<br/>
        ///         },<br/>
        ///         "optional_params": {<br/>
        ///             "description": "Optional parameters for the Azure Content Safety Text Moderation guardrail",<br/>
        ///             "required": true,<br/>
        ///             "type": "nested",<br/>
        ///             "fields": {<br/>
        ///                 "severity_threshold": {<br/>
        ///                     "description": "Severity threshold for the Azure Content Safety Text Moderation guardrail across all categories",<br/>
        ///                     "required": false,<br/>
        ///                     "type": null<br/>
        ///                 },<br/>
        ///                 "categories": {<br/>
        ///                     "description": "Categories to scan for the Azure Content Safety Text Moderation guardrail",<br/>
        ///                     "required": false,<br/>
        ///                     "type": "multiselect",<br/>
        ///                     "options": ["Hate", "SelfHarm", "Sexual", "Violence"],<br/>
        ///                     "default_value": None<br/>
        ///                 }<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetProviderSpecificParamsGuardrailsUiProviderSpecificParamsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
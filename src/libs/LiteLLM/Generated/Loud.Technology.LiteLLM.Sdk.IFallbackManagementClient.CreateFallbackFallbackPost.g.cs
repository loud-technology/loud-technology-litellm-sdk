#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IFallbackManagementClient
    {
        /// <summary>
        /// Create Fallback<br/>
        /// Create or update fallbacks for a specific model.<br/>
        /// This endpoint allows you to configure fallback models separately from the general config.<br/>
        /// Fallbacks are triggered when a model call fails after retries.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "model": "gpt-3.5-turbo",<br/>
        ///     "fallback_models": ["gpt-4", "claude-3-haiku"],<br/>
        ///     "fallback_type": "general"<br/>
        /// }<br/>
        /// ```<br/>
        /// **Fallback Types:**<br/>
        /// - `general`: Standard fallbacks for any error (default)<br/>
        /// - `context_window`: Fallbacks specifically for context window exceeded errors<br/>
        /// - `content_policy`: Fallbacks specifically for content policy violations
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.FallbackResponse> CreateFallbackFallbackPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.FallbackCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Fallback<br/>
        /// Create or update fallbacks for a specific model.<br/>
        /// This endpoint allows you to configure fallback models separately from the general config.<br/>
        /// Fallbacks are triggered when a model call fails after retries.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "model": "gpt-3.5-turbo",<br/>
        ///     "fallback_models": ["gpt-4", "claude-3-haiku"],<br/>
        ///     "fallback_type": "general"<br/>
        /// }<br/>
        /// ```<br/>
        /// **Fallback Types:**<br/>
        /// - `general`: Standard fallbacks for any error (default)<br/>
        /// - `context_window`: Fallbacks specifically for context window exceeded errors<br/>
        /// - `content_policy`: Fallbacks specifically for content policy violations
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.FallbackResponse>> CreateFallbackFallbackPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.FallbackCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Fallback<br/>
        /// Create or update fallbacks for a specific model.<br/>
        /// This endpoint allows you to configure fallback models separately from the general config.<br/>
        /// Fallbacks are triggered when a model call fails after retries.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "model": "gpt-3.5-turbo",<br/>
        ///     "fallback_models": ["gpt-4", "claude-3-haiku"],<br/>
        ///     "fallback_type": "general"<br/>
        /// }<br/>
        /// ```<br/>
        /// **Fallback Types:**<br/>
        /// - `general`: Standard fallbacks for any error (default)<br/>
        /// - `context_window`: Fallbacks specifically for context window exceeded errors<br/>
        /// - `content_policy`: Fallbacks specifically for content policy violations
        /// </summary>
        /// <param name="model">
        /// The model name to configure fallbacks for (e.g., 'gpt-3.5-turbo')
        /// </param>
        /// <param name="fallbackModels">
        /// List of fallback model names in order of priority
        /// </param>
        /// <param name="fallbackType">
        /// Type of fallback: 'general' (default), 'context_window', or 'content_policy'<br/>
        /// Default Value: general
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.FallbackResponse> CreateFallbackFallbackPostAsync(
            string model,
            global::System.Collections.Generic.IList<string> fallbackModels,
            global::Loud.Technology.LiteLLM.Sdk.FallbackCreateRequestFallbackType? fallbackType = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
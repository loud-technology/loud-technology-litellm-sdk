#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IOpenAIPassThroughClient
    {
        /// <summary>
        /// Openai Proxy Route<br/>
        /// Pass-through endpoint for OpenAI API calls.<br/>
        /// Available on both routes:<br/>
        /// - /openai/{endpoint:path} - Standard OpenAI passthrough route<br/>
        /// - /openai_passthrough/{endpoint:path} - Dedicated passthrough route (recommended for Responses API)<br/>
        /// Use /openai_passthrough/* when you need guaranteed passthrough to OpenAI without conflicts<br/>
        /// with LiteLLM's native implementations (e.g., for the Responses API at /v1/responses).<br/>
        /// Examples:<br/>
        ///     Standard route:<br/>
        ///     - /openai/v1/chat/completions<br/>
        ///     - /openai/v1/assistants<br/>
        ///     - /openai/v1/threads<br/>
        ///     Dedicated passthrough (for Responses API):<br/>
        ///     - /openai_passthrough/v1/responses<br/>
        ///     - /openai_passthrough/v1/responses/{response_id}<br/>
        ///     - /openai_passthrough/v1/responses/{response_id}/input_items<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/openai_passthrough)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiProxyRouteOpenaiEndpointDeleteAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openai Proxy Route<br/>
        /// Pass-through endpoint for OpenAI API calls.<br/>
        /// Available on both routes:<br/>
        /// - /openai/{endpoint:path} - Standard OpenAI passthrough route<br/>
        /// - /openai_passthrough/{endpoint:path} - Dedicated passthrough route (recommended for Responses API)<br/>
        /// Use /openai_passthrough/* when you need guaranteed passthrough to OpenAI without conflicts<br/>
        /// with LiteLLM's native implementations (e.g., for the Responses API at /v1/responses).<br/>
        /// Examples:<br/>
        ///     Standard route:<br/>
        ///     - /openai/v1/chat/completions<br/>
        ///     - /openai/v1/assistants<br/>
        ///     - /openai/v1/threads<br/>
        ///     Dedicated passthrough (for Responses API):<br/>
        ///     - /openai_passthrough/v1/responses<br/>
        ///     - /openai_passthrough/v1/responses/{response_id}<br/>
        ///     - /openai_passthrough/v1/responses/{response_id}/input_items<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/openai_passthrough)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OpenaiProxyRouteOpenaiEndpointDeleteAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IOpenAIPassThroughClient
    {
        /// <summary>
        /// Openai Passthrough Route<br/>
        /// Dedicated pass-through to the OpenAI API with no overlap with LiteLLM's native<br/>
        /// implementations (e.g. the Responses API at /v1/responses).<br/>
        /// Examples:<br/>
        ///     - /openai_passthrough/v1/responses<br/>
        ///     - /openai_passthrough/v1/responses/{response_id}<br/>
        ///     - /openai_passthrough/v1/responses/{response_id}/input_items<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/openai_passthrough)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiPassthroughRouteOpenaiPassthroughEndpointPatchAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Openai Passthrough Route<br/>
        /// Dedicated pass-through to the OpenAI API with no overlap with LiteLLM's native<br/>
        /// implementations (e.g. the Responses API at /v1/responses).<br/>
        /// Examples:<br/>
        ///     - /openai_passthrough/v1/responses<br/>
        ///     - /openai_passthrough/v1/responses/{response_id}<br/>
        ///     - /openai_passthrough/v1/responses/{response_id}/input_items<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/openai_passthrough)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OpenaiPassthroughRouteOpenaiPassthroughEndpointPatchAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILlmUtilsClient
    {
        /// <summary>
        /// Token Counter<br/>
        /// Args:<br/>
        ///     request: TokenCountRequest<br/>
        ///     call_endpoint: bool - When set to "True" it will call the token counting endpoint - e.g Anthropic or Google AI Studio Token Counting APIs.<br/>
        /// Returns:<br/>
        ///     TokenCountResponse
        /// </summary>
        /// <param name="callEndpoint">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TokenCountResponse> TokenCounterUtilsTokenCounterPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.TokenCountRequest request,
            bool? callEndpoint = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Token Counter<br/>
        /// Args:<br/>
        ///     request: TokenCountRequest<br/>
        ///     call_endpoint: bool - When set to "True" it will call the token counting endpoint - e.g Anthropic or Google AI Studio Token Counting APIs.<br/>
        /// Returns:<br/>
        ///     TokenCountResponse
        /// </summary>
        /// <param name="callEndpoint">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TokenCountResponse>> TokenCounterUtilsTokenCounterPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.TokenCountRequest request,
            bool? callEndpoint = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Token Counter<br/>
        /// Args:<br/>
        ///     request: TokenCountRequest<br/>
        ///     call_endpoint: bool - When set to "True" it will call the token counting endpoint - e.g Anthropic or Google AI Studio Token Counting APIs.<br/>
        /// Returns:<br/>
        ///     TokenCountResponse
        /// </summary>
        /// <param name="callEndpoint">
        /// Default Value: false
        /// </param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="messages"></param>
        /// <param name="contents"></param>
        /// <param name="tools"></param>
        /// <param name="system"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TokenCountResponse> TokenCounterUtilsTokenCounterPostAsync(
            string model,
            bool? callEndpoint = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<object>? messages = default,
            global::System.Collections.Generic.IList<object>? contents = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            object? system = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
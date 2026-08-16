#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAnthropicPassThrough2Client
    {
        /// <summary>
        /// Count Tokens<br/>
        /// Count tokens for Anthropic Messages API format.<br/>
        /// This endpoint follows the Anthropic Messages API token counting specification.<br/>
        /// It accepts the same parameters as the /v1/messages endpoint but returns<br/>
        /// token counts instead of generating a response.<br/>
        /// Example usage:<br/>
        /// ```<br/>
        /// curl -X POST "http://localhost:4000/v1/messages/count_tokens?beta=true"       -H "Content-Type: application/json"       -H "Authorization: Bearer your-key"       -d '{<br/>
        ///     "model": "claude-3-sonnet-20240229",<br/>
        ///     "messages": [{"role": "user", "content": "Hello Claude!"}]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Returns: {"input_tokens": &lt;number&gt;}
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CountTokensV1MessagesCountTokensPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Count Tokens<br/>
        /// Count tokens for Anthropic Messages API format.<br/>
        /// This endpoint follows the Anthropic Messages API token counting specification.<br/>
        /// It accepts the same parameters as the /v1/messages endpoint but returns<br/>
        /// token counts instead of generating a response.<br/>
        /// Example usage:<br/>
        /// ```<br/>
        /// curl -X POST "http://localhost:4000/v1/messages/count_tokens?beta=true"       -H "Content-Type: application/json"       -H "Authorization: Bearer your-key"       -d '{<br/>
        ///     "model": "claude-3-sonnet-20240229",<br/>
        ///     "messages": [{"role": "user", "content": "Hello Claude!"}]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Returns: {"input_tokens": &lt;number&gt;}
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CountTokensV1MessagesCountTokensPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
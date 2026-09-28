#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Tools<br/>
        /// List all auto-discovered tools and their policies.<br/>
        /// Parameters:<br/>
        /// - input_policy: Optional filter — one of "trusted", "untrusted", "blocked"
        /// </summary>
        /// <param name="inputPolicy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ToolListResponse> ListToolsV1ToolListGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.ListToolsV1ToolListGetInputPolicy2? inputPolicy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tools<br/>
        /// List all auto-discovered tools and their policies.<br/>
        /// Parameters:<br/>
        /// - input_policy: Optional filter — one of "trusted", "untrusted", "blocked"
        /// </summary>
        /// <param name="inputPolicy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ToolListResponse>> ListToolsV1ToolListGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.ListToolsV1ToolListGetInputPolicy2? inputPolicy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
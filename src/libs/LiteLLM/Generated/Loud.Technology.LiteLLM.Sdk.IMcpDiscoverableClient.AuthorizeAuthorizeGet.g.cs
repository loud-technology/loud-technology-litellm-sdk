#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpDiscoverableClient
    {
        /// <summary>
        /// Authorize
        /// </summary>
        /// <param name="redirectUri"></param>
        /// <param name="clientId"></param>
        /// <param name="state"></param>
        /// <param name="mcpServerName"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="responseType"></param>
        /// <param name="scope"></param>
        /// <param name="resource"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AuthorizeAuthorizeGetAsync(
            string redirectUri,
            string? clientId = default,
            string? state = default,
            string? mcpServerName = default,
            string? codeChallenge = default,
            string? codeChallengeMethod = default,
            string? responseType = default,
            string? scope = default,
            string? resource = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize
        /// </summary>
        /// <param name="redirectUri"></param>
        /// <param name="clientId"></param>
        /// <param name="state"></param>
        /// <param name="mcpServerName"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="responseType"></param>
        /// <param name="scope"></param>
        /// <param name="resource"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AuthorizeAuthorizeGetAsResponseAsync(
            string redirectUri,
            string? clientId = default,
            string? state = default,
            string? mcpServerName = default,
            string? codeChallenge = default,
            string? codeChallengeMethod = default,
            string? responseType = default,
            string? scope = default,
            string? resource = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
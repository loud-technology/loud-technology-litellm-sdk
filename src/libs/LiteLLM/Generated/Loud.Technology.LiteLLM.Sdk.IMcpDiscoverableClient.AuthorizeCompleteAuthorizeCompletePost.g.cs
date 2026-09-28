#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpDiscoverableClient
    {
        /// <summary>
        /// Authorize Complete<br/>
        /// Finish an aggregate connect flow: mint the gateway authorization code for the<br/>
        /// signed-in user and hand it back to the DCR client, by 303 redirect (default) or, for<br/>
        /// a loopback client on a different machine, as a copyable callback URL<br/>
        /// (``delivery=manual``). POST plus the per-flow HttpOnly cookie set at /authorize; an<br/>
        /// anonymous or bad-flow request just 400s. The native-client consent page adds<br/>
        /// ``decision`` (approve or deny) and the ``team_id`` the credential is attributed to.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AuthorizeCompleteAuthorizeCompletePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyAuthorizeCompleteAuthorizeCompletePost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize Complete<br/>
        /// Finish an aggregate connect flow: mint the gateway authorization code for the<br/>
        /// signed-in user and hand it back to the DCR client, by 303 redirect (default) or, for<br/>
        /// a loopback client on a different machine, as a copyable callback URL<br/>
        /// (``delivery=manual``). POST plus the per-flow HttpOnly cookie set at /authorize; an<br/>
        /// anonymous or bad-flow request just 400s. The native-client consent page adds<br/>
        /// ``decision`` (approve or deny) and the ``team_id`` the credential is attributed to.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AuthorizeCompleteAuthorizeCompletePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyAuthorizeCompleteAuthorizeCompletePost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize Complete<br/>
        /// Finish an aggregate connect flow: mint the gateway authorization code for the<br/>
        /// signed-in user and hand it back to the DCR client, by 303 redirect (default) or, for<br/>
        /// a loopback client on a different machine, as a copyable callback URL<br/>
        /// (``delivery=manual``). POST plus the per-flow HttpOnly cookie set at /authorize; an<br/>
        /// anonymous or bad-flow request just 400s. The native-client consent page adds<br/>
        /// ``decision`` (approve or deny) and the ``team_id`` the credential is attributed to.
        /// </summary>
        /// <param name="decision"></param>
        /// <param name="delivery"></param>
        /// <param name="flow"></param>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AuthorizeCompleteAuthorizeCompletePostAsync(
            string flow,
            string? decision = default,
            string? delivery = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
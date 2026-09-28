#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMcpDiscoverableClient
    {
        /// <summary>
        /// Native Client Auth Discovery<br/>
        /// The versioned contract a native client (``lite login --pkce``, or a CLI in any other<br/>
        /// language) reads to sign a user in through the browser and obtain a proxy credential.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> NativeClientAuthDiscoveryWellKnownLitellmCliAuthGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Native Client Auth Discovery<br/>
        /// The versioned contract a native client (``lite login --pkce``, or a CLI in any other<br/>
        /// language) reads to sign a user in through the browser and obtain a proxy credential.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> NativeClientAuthDiscoveryWellKnownLitellmCliAuthGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
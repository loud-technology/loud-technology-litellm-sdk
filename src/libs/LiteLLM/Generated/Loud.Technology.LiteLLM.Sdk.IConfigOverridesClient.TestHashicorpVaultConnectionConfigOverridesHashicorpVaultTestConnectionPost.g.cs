#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IConfigOverridesClient
    {
        /// <summary>
        /// Test Hashicorp Vault Connection<br/>
        /// Test the connection to the currently configured Hashicorp Vault.<br/>
        /// Uses the already-initialized secret manager client. Does not modify any state.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestHashicorpVaultConnectionConfigOverridesHashicorpVaultTestConnectionPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Hashicorp Vault Connection<br/>
        /// Test the connection to the currently configured Hashicorp Vault.<br/>
        /// Uses the already-initialized secret manager client. Does not modify any state.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestHashicorpVaultConnectionConfigOverridesHashicorpVaultTestConnectionPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
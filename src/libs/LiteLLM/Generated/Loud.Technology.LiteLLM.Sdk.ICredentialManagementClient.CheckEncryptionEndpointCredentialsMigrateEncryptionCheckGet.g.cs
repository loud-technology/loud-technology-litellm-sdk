#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICredentialManagementClient
    {
        /// <summary>
        /// Check Encryption Endpoint<br/>
        /// Read-only residual scan for compliance attestation. Reports how many at-rest<br/>
        /// values are still in the legacy format. ``residual_legacy == 0`` attests no<br/>
        /// legacy ciphertext remains. Admin only; performs no writes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CheckEncryptionEndpointCredentialsMigrateEncryptionCheckGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Encryption Endpoint<br/>
        /// Read-only residual scan for compliance attestation. Reports how many at-rest<br/>
        /// values are still in the legacy format. ``residual_legacy == 0`` attests no<br/>
        /// legacy ciphertext remains. Admin only; performs no writes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CheckEncryptionEndpointCredentialsMigrateEncryptionCheckGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
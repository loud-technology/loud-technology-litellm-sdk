#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICredentialManagementClient
    {
        /// <summary>
        /// Update Credential<br/>
        /// [BETA] endpoint. This might change unexpectedly.
        /// </summary>
        /// <param name="credentialName">
        /// The credential name, percent-decoded; may contain slashes
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCredentialCredentialsCredentialNamePatchAsync(
            string credentialName,

            global::Loud.Technology.LiteLLM.Sdk.CredentialItem request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Credential<br/>
        /// [BETA] endpoint. This might change unexpectedly.
        /// </summary>
        /// <param name="credentialName">
        /// The credential name, percent-decoded; may contain slashes
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateCredentialCredentialsCredentialNamePatchAsResponseAsync(
            string credentialName,

            global::Loud.Technology.LiteLLM.Sdk.CredentialItem request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Credential<br/>
        /// [BETA] endpoint. This might change unexpectedly.
        /// </summary>
        /// <param name="credentialName">
        /// The credential name, percent-decoded; may contain slashes
        /// </param>
        /// <param name="requestCredentialName"></param>
        /// <param name="credentialInfo"></param>
        /// <param name="credentialValues"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCredentialCredentialsCredentialNamePatchAsync(
            string credentialName,
            string requestCredentialName,
            object credentialInfo,
            object credentialValues,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
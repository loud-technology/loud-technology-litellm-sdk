#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICredentialManagementClient
    {
        /// <summary>
        /// Create Credential<br/>
        /// [BETA] endpoint. This might change unexpectedly.<br/>
        /// Stores credential in DB.<br/>
        /// Reloads credentials in memory.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateCredentialCredentialsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CreateCredentialItem request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Credential<br/>
        /// [BETA] endpoint. This might change unexpectedly.<br/>
        /// Stores credential in DB.<br/>
        /// Reloads credentials in memory.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateCredentialCredentialsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CreateCredentialItem request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Credential<br/>
        /// [BETA] endpoint. This might change unexpectedly.<br/>
        /// Stores credential in DB.<br/>
        /// Reloads credentials in memory.
        /// </summary>
        /// <param name="credentialName"></param>
        /// <param name="credentialInfo"></param>
        /// <param name="credentialValues"></param>
        /// <param name="modelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateCredentialCredentialsPostAsync(
            string credentialName,
            object credentialInfo,
            object? credentialValues = default,
            string? modelId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
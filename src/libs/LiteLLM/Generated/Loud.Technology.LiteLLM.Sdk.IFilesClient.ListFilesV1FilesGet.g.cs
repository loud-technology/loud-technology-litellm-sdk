#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files<br/>
        /// Returns information about a specific file. that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of GET https://api.openai.com/v1/files/<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/list<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files        -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="targetModelNames"></param>
        /// <param name="purpose"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListFilesV1FilesGetAsync(
            string? provider = default,
            string? targetModelNames = default,
            string? purpose = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Files<br/>
        /// Returns information about a specific file. that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of GET https://api.openai.com/v1/files/<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/list<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files        -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="targetModelNames"></param>
        /// <param name="purpose"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListFilesV1FilesGetAsResponseAsync(
            string? provider = default,
            string? targetModelNames = default,
            string? purpose = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
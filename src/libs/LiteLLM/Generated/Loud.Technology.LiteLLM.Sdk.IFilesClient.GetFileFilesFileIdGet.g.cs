#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get File<br/>
        /// Returns information about a specific file. that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of GET https://api.openai.com/v1/files/{file_id}<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/retrieve<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files/file-abc123         -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFileFilesFileIdGetAsync(
            string fileId,
            string? provider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get File<br/>
        /// Returns information about a specific file. that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of GET https://api.openai.com/v1/files/{file_id}<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/retrieve<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files/file-abc123         -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetFileFilesFileIdGetAsResponseAsync(
            string fileId,
            string? provider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
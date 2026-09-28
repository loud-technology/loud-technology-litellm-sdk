#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Create File<br/>
        /// Upload a file that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of POST https://api.openai.com/v1/files<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/create<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files         -H "Authorization: Bearer sk-1234"         -F purpose="batch"         -F file="@mydata.jsonl"<br/>
        ///     -F expires_after[anchor]="created_at"         -F expires_after[seconds]=2592000<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateFileFilesPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyCreateFileFilesPost request,
            string? provider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create File<br/>
        /// Upload a file that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of POST https://api.openai.com/v1/files<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/create<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files         -H "Authorization: Bearer sk-1234"         -F purpose="batch"         -F file="@mydata.jsonl"<br/>
        ///     -F expires_after[anchor]="created_at"         -F expires_after[seconds]=2592000<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateFileFilesPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyCreateFileFilesPost request,
            string? provider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create File<br/>
        /// Upload a file that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of POST https://api.openai.com/v1/files<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/create<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files         -H "Authorization: Bearer sk-1234"         -F purpose="batch"         -F file="@mydata.jsonl"<br/>
        ///     -F expires_after[anchor]="created_at"         -F expires_after[seconds]=2592000<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="purpose"></param>
        /// <param name="targetModelNames"></param>
        /// <param name="targetStorage">
        /// Default Value: default
        /// </param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="litellmMetadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateFileFilesPostAsync(
            string purpose,
            byte[] file,
            string filename,
            string? provider = default,
            string? targetModelNames = default,
            string? targetStorage = default,
            string? customLlmProvider = default,
            string? litellmMetadata = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create File<br/>
        /// Upload a file that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of POST https://api.openai.com/v1/files<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/create<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files         -H "Authorization: Bearer sk-1234"         -F purpose="batch"         -F file="@mydata.jsonl"<br/>
        ///     -F expires_after[anchor]="created_at"         -F expires_after[seconds]=2592000<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="purpose"></param>
        /// <param name="targetModelNames"></param>
        /// <param name="targetStorage">
        /// Default Value: default
        /// </param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="litellmMetadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateFileFilesPostAsync(
            string purpose,
            global::System.IO.Stream file,
            string filename,
            string? provider = default,
            string? targetModelNames = default,
            string? targetStorage = default,
            string? customLlmProvider = default,
            string? litellmMetadata = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create File<br/>
        /// Upload a file that can be used across - Assistants API, Batch API <br/>
        /// This is the equivalent of POST https://api.openai.com/v1/files<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/files/create<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/files         -H "Authorization: Bearer sk-1234"         -F purpose="batch"         -F file="@mydata.jsonl"<br/>
        ///     -F expires_after[anchor]="created_at"         -F expires_after[seconds]=2592000<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="purpose"></param>
        /// <param name="targetModelNames"></param>
        /// <param name="targetStorage">
        /// Default Value: default
        /// </param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="litellmMetadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateFileFilesPostAsResponseAsync(
            string purpose,
            global::System.IO.Stream file,
            string filename,
            string? provider = default,
            string? targetModelNames = default,
            string? targetStorage = default,
            string? customLlmProvider = default,
            string? litellmMetadata = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
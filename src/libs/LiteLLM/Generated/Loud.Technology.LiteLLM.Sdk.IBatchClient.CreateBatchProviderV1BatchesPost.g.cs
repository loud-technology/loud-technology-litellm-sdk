#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create Batch<br/>
        /// Create large batches of API requests for asynchronous processing.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/batch<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/batch<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/batches         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "input_file_id": "file-abc123",<br/>
        ///         "endpoint": "/v1/chat/completions",<br/>
        ///         "completion_window": "24h"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateBatchProviderV1BatchesPostAsync(
            string? provider,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Create large batches of API requests for asynchronous processing.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/batch<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/batch<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/batches         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "input_file_id": "file-abc123",<br/>
        ///         "endpoint": "/v1/chat/completions",<br/>
        ///         "completion_window": "24h"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateBatchProviderV1BatchesPostAsResponseAsync(
            string? provider,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
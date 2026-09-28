#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Retrieve Batch<br/>
        /// Retrieves a batch.<br/>
        /// This is the equivalent of GET https://api.openai.com/v1/batches/{batch_id}<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/batch/retrieve<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/batches/batch_abc123     -H "Authorization: Bearer sk-1234"     -H "Content-Type: application/json" <br/>
        /// ```
        /// </summary>
        /// <param name="batchId">
        /// The ID of the batch to retrieve
        /// </param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveBatchBatchesBatchIdGetAsync(
            string batchId,
            string? provider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Batch<br/>
        /// Retrieves a batch.<br/>
        /// This is the equivalent of GET https://api.openai.com/v1/batches/{batch_id}<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/batch/retrieve<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/batches/batch_abc123     -H "Authorization: Bearer sk-1234"     -H "Content-Type: application/json" <br/>
        /// ```
        /// </summary>
        /// <param name="batchId">
        /// The ID of the batch to retrieve
        /// </param>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> RetrieveBatchBatchesBatchIdGetAsResponseAsync(
            string batchId,
            string? provider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
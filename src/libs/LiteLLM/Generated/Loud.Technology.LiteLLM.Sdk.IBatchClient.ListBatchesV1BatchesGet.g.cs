#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// List Batches<br/>
        /// Lists <br/>
        /// This is the equivalent of GET https://api.openai.com/v1/batches/<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/batch/list<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/batches?limit=2     -H "Authorization: Bearer sk-1234"     -H "Content-Type: application/json" <br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="targetModelNames"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListBatchesV1BatchesGetAsync(
            string? provider = default,
            int? limit = default,
            string? after = default,
            string? targetModelNames = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Batches<br/>
        /// Lists <br/>
        /// This is the equivalent of GET https://api.openai.com/v1/batches/<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/batch/list<br/>
        /// Example Curl<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/batches?limit=2     -H "Authorization: Bearer sk-1234"     -H "Content-Type: application/json" <br/>
        /// ```
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="targetModelNames"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListBatchesV1BatchesGetAsResponseAsync(
            string? provider = default,
            int? limit = default,
            string? after = default,
            string? targetModelNames = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}